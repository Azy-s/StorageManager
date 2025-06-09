
namespace StorageManager
{
    public partial class MainForm : Form
    {
        private List<Pallet> _pallets = new List<Pallet>();
        private List<List<Pallet>> _groupedPallets = new List<List<Pallet>>();
        List<Pallet> mostFreshPallets = new List<Pallet>();
        private Pallet _selectedPallet;
        public MainForm()
        {
            InitializeComponent();
        }

        private void PrintPalletInfo(Pallet plt)
        {
            PalletIDLabel.Text = plt.ID.ToString();
            PalletBoxCountLabel.Text = plt.Boxes.Count.ToString();
            PalletVolumeLabel.Text = plt.Volume.ToString();
            PalletWeightLabel.Text = plt.Weight.ToString();
            PalletExpirationDateLabel.Text = plt.ExpirationDate.ToString();
        }

        private void PrintBoxInfo(StorageBox box)
        {
            BoxIDLabel.Text = box.ID.ToString();
            BoxWeightLabel.Text = box.Weight.ToString();
            BoxVolumeLabel.Text = box.Volume.ToString();
            BoxExpirationDateLabel.Text = box.ExpirationDate.ToString();
            BoxProductionDateLabel.Text = box.ProductionDate.ToString();
        }

        private void UpdateTreeView()
        {
            treeView1.BeginUpdate();
            try
            {
                treeView1.Nodes.Clear();

                foreach (var group in _groupedPallets)
                {
                    if (group == null || group.Count == 0)
                        continue;

                    var date = group[0].ExpirationDate;
                    var dateText = date.ToString();

                    // Создание групп по датам
                    var parentNode = new TreeNode(dateText + $" ({group.Count})")
                    {
                        Name = dateText
                    };

                    // Добавление дочерних узлов - ID паллет
                    foreach (var pallet in group)
                    {
                        var childNode = new TreeNode(pallet.ID.ToString())
                        {
                            Name = pallet.ID.ToString()
                        };
                        parentNode.Nodes.Add(childNode);
                    }

                    treeView1.Nodes.Add(parentNode);
                }
            }
            finally
            {
                treeView1.EndUpdate();
            }
        }

        // Группировка паллет по сроку годности
        private async void GroupPallets_Click(object sender, EventArgs e)
        {
            if (_pallets is null)
                return;

            _groupedPallets = _pallets.
                Where(p => p.ExpirationDate.HasValue)
                .GroupBy(p => p.ExpirationDate.Value)
                .OrderByDescending(g => g.Key)
                .Select(g => g.OrderBy(p => p.Weight).ToList())
                .ToList();

            UpdateTreeView();
        }

        // Получить (3) паллеты с самым низким сроком годности, отсортированные по объёму коробок (+ объём палеты)
        private void MostFreshPallets_Click(object sender, EventArgs e)
        {
            int takeNum = (int)numericUpDown1.Value;
            if (numericUpDown1.Value >= _pallets.Count)
                takeNum = _pallets.Count;

            mostFreshPallets = _pallets
                .Where(p => p.ExpirationDate.HasValue)
                .OrderByDescending(p => p.ExpirationDate.Value)
                .Take(takeNum)
                .OrderBy(p => p.Volume)
                .ToList();

            listBox1.Items.Clear();
            foreach (var pallet in mostFreshPallets)
            {
                listBox1.Items.Add($"{pallet.ExpirationDate} | {pallet.Volume}");
            }
        }

        // генерация паллет
        private void PalletGenerator_Click(object sender, EventArgs e)
        {
            var generator = new StorageGenerator();

            _pallets = generator.GeneratePallets((int)numericUpDown2.Value);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Parent is not null)
            {
                _selectedPallet = _groupedPallets[treeView1.SelectedNode.Parent.Index][treeView1.SelectedNode.Index];
                PrintPalletInfo(_selectedPallet);
                numericUpDown3.Maximum = _selectedPallet.Boxes.Count - 1;
                numericUpDown3.Value = 0;
                numericUpDown3_ValueChanged(numericUpDown3, new EventArgs());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < mostFreshPallets.Count)
            {
                _selectedPallet = mostFreshPallets[listBox1.SelectedIndex];
                PrintPalletInfo(_selectedPallet);
                numericUpDown3.Maximum = _selectedPallet.Boxes.Count - 1;
                numericUpDown3.Value = 0;
                numericUpDown3_ValueChanged(numericUpDown3, new EventArgs());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value <= numericUpDown3.Minimum)
                return;

            numericUpDown3.Value--;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (numericUpDown3.Value >= numericUpDown3.Maximum)
                return;

            numericUpDown3.Value++;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedPallet is null)
                return;
            if (_selectedPallet.Boxes is null)
                return;
            if (_selectedPallet.Boxes.Count == 0)
                return;

            PrintBoxInfo(_selectedPallet.Boxes.ToArray()[(int)numericUpDown3.Value]);
        }
    }
}

namespace StorageManager
{
    public class Pallet : StorageItem
    {
        private const double SelfWeight = 30.0; // вес самой паллеты (кг)
        private readonly List<StorageBox> _boxes = new List<StorageBox>();

        public IReadOnlyCollection<StorageBox> Boxes => _boxes.AsReadOnly();

        public override double Weight => _boxes.Sum(b => b.Weight) + SelfWeight;

        public DateOnly? ExpirationDate
            => _boxes.Count == 0 
            ? null 
            : _boxes.Min(b => b.ExpirationDate);

        public Pallet(double width, double height, double depth)
            : base(width, height, depth, SelfWeight)
        {

        }

        public void AddBox(StorageBox box)
        {
            if (box.Width > Width)
                throw new InvalidOperationException($"Ширина коробки ({box.Width} м) превышает ширину паллеты ({Width} м).");
            if (box.Depth > Depth)
                throw new InvalidOperationException($"Глубина коробки ({box.Depth} м) превышает глубину паллеты ({Depth} м).");

            _boxes.Add(box);
        }

        public void RemoveBox(Guid id)
        {
            var box = _boxes.FirstOrDefault(b => b.ID == id);
            if (box is null)
                throw new InvalidOperationException($"Коробка с ID {id} не найдена на паллете.");

            _boxes.Remove(box);
        }

        public void RemoveBox(StorageBox deleteBox)
        {
            var box = _boxes.FirstOrDefault(b => b == deleteBox);
            if (box is null)
                throw new InvalidOperationException($"Коробка не найдена на паллете.");

            _boxes.Remove(box);
        }

        public override double Volume => base.Volume + _boxes.Sum(b => b.Volume);
    }
}

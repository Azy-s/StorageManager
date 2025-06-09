namespace StorageManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            PalletExpirationDateLabel = new Label();
            label6 = new Label();
            PalletVolumeLabel = new Label();
            label5 = new Label();
            PalletWeightLabel = new Label();
            label4 = new Label();
            PalletBoxCountLabel = new Label();
            PalletIDLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            BoxProductionDateLabel = new Label();
            label8 = new Label();
            BoxExpirationDateLabel = new Label();
            label15 = new Label();
            label7 = new Label();
            BoxVolumeLabel = new Label();
            label13 = new Label();
            BoxIDLabel = new Label();
            BoxWeightLabel = new Label();
            label11 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            button3 = new Button();
            numericUpDown2 = new NumericUpDown();
            button4 = new Button();
            button5 = new Button();
            numericUpDown3 = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 27);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(354, 204);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 15);
            label1.TabIndex = 1;
            label1.Text = "Сгруппировать паллеты по сроку годности";
            // 
            // button1
            // 
            button1.Location = new Point(12, 237);
            button1.Name = "button1";
            button1.Size = new Size(354, 31);
            button1.TabIndex = 2;
            button1.Text = "Групировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GroupPallets_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PalletExpirationDateLabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(PalletVolumeLabel);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(PalletWeightLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(PalletBoxCountLabel);
            groupBox1.Controls.Add(PalletIDLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 274);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 139);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация о паллете";
            // 
            // PalletExpirationDateLabel
            // 
            PalletExpirationDateLabel.AutoSize = true;
            PalletExpirationDateLabel.Location = new Point(104, 108);
            PalletExpirationDateLabel.Name = "PalletExpirationDateLabel";
            PalletExpirationDateLabel.Size = new Size(88, 15);
            PalletExpirationDateLabel.TabIndex = 0;
            PalletExpirationDateLabel.Text = "Срок годности";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 108);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 0;
            label6.Text = "Срок годности";
            // 
            // PalletVolumeLabel
            // 
            PalletVolumeLabel.AutoSize = true;
            PalletVolumeLabel.Location = new Point(104, 89);
            PalletVolumeLabel.Name = "PalletVolumeLabel";
            PalletVolumeLabel.Size = new Size(45, 15);
            PalletVolumeLabel.TabIndex = 0;
            PalletVolumeLabel.Text = "Объём";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 89);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Объём";
            // 
            // PalletWeightLabel
            // 
            PalletWeightLabel.AutoSize = true;
            PalletWeightLabel.Location = new Point(104, 70);
            PalletWeightLabel.Name = "PalletWeightLabel";
            PalletWeightLabel.Size = new Size(26, 15);
            PalletWeightLabel.TabIndex = 0;
            PalletWeightLabel.Text = "Вес";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 70);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 0;
            label4.Text = "Вес";
            // 
            // PalletBoxCountLabel
            // 
            PalletBoxCountLabel.AutoSize = true;
            PalletBoxCountLabel.Location = new Point(104, 50);
            PalletBoxCountLabel.Name = "PalletBoxCountLabel";
            PalletBoxCountLabel.Size = new Size(92, 15);
            PalletBoxCountLabel.TabIndex = 0;
            PalletBoxCountLabel.Text = "Кол-во ящиков";
            // 
            // PalletIDLabel
            // 
            PalletIDLabel.AutoSize = true;
            PalletIDLabel.Location = new Point(104, 31);
            PalletIDLabel.Name = "PalletIDLabel";
            PalletIDLabel.Size = new Size(18, 15);
            PalletIDLabel.TabIndex = 0;
            PalletIDLabel.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 50);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 0;
            label3.Text = "Кол-во ящиков";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BoxProductionDateLabel);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(BoxExpirationDateLabel);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(BoxVolumeLabel);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(BoxIDLabel);
            groupBox2.Controls.Add(BoxWeightLabel);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(372, 274);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 139);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Информация о ящике";
            // 
            // BoxProductionDateLabel
            // 
            BoxProductionDateLabel.AutoSize = true;
            BoxProductionDateLabel.Location = new Point(109, 108);
            BoxProductionDateLabel.Name = "BoxProductionDateLabel";
            BoxProductionDateLabel.Size = new Size(91, 15);
            BoxProductionDateLabel.TabIndex = 0;
            BoxProductionDateLabel.Text = "Дата произв-ва";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 108);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 0;
            label8.Text = "Дата произв-ва";
            // 
            // BoxExpirationDateLabel
            // 
            BoxExpirationDateLabel.AutoSize = true;
            BoxExpirationDateLabel.Location = new Point(109, 88);
            BoxExpirationDateLabel.Name = "BoxExpirationDateLabel";
            BoxExpirationDateLabel.Size = new Size(88, 15);
            BoxExpirationDateLabel.TabIndex = 0;
            BoxExpirationDateLabel.Text = "Срок годности";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 88);
            label15.Name = "label15";
            label15.Size = new Size(88, 15);
            label15.TabIndex = 0;
            label15.Text = "Срок годности";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 31);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 0;
            label7.Text = "ID";
            // 
            // BoxVolumeLabel
            // 
            BoxVolumeLabel.AutoSize = true;
            BoxVolumeLabel.Location = new Point(109, 69);
            BoxVolumeLabel.Name = "BoxVolumeLabel";
            BoxVolumeLabel.Size = new Size(45, 15);
            BoxVolumeLabel.TabIndex = 0;
            BoxVolumeLabel.Text = "Объём";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 69);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 0;
            label13.Text = "Объём";
            // 
            // BoxIDLabel
            // 
            BoxIDLabel.AutoSize = true;
            BoxIDLabel.Location = new Point(109, 31);
            BoxIDLabel.Name = "BoxIDLabel";
            BoxIDLabel.Size = new Size(18, 15);
            BoxIDLabel.TabIndex = 0;
            BoxIDLabel.Text = "ID";
            // 
            // BoxWeightLabel
            // 
            BoxWeightLabel.AutoSize = true;
            BoxWeightLabel.Location = new Point(109, 50);
            BoxWeightLabel.Name = "BoxWeightLabel";
            BoxWeightLabel.Size = new Size(26, 15);
            BoxWeightLabel.TabIndex = 0;
            BoxWeightLabel.Text = "Вес";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 50);
            label11.Name = "label11";
            label11.Size = new Size(26, 15);
            label11.TabIndex = 0;
            label11.Text = "Вес";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(372, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(365, 199);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(372, 237);
            button2.Name = "button2";
            button2.Size = new Size(305, 31);
            button2.TabIndex = 2;
            button2.Text = "Найти палеты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += MostFreshPallets_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(683, 241);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(54, 25);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 9);
            label9.Name = "label9";
            label9.Size = new Size(268, 15);
            label9.TabIndex = 1;
            label9.Text = "Найти паллеты с набольшим сроком годности";
            // 
            // button3
            // 
            button3.Location = new Point(12, 420);
            button3.Name = "button3";
            button3.Size = new Size(98, 31);
            button3.TabIndex = 7;
            button3.Text = "Генерировать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PalletGenerator_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown2.Location = new Point(116, 422);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(45, 27);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            numericUpDown2.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // button4
            // 
            button4.Location = new Point(465, 419);
            button4.Name = "button4";
            button4.Size = new Size(42, 23);
            button4.TabIndex = 9;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(561, 419);
            button5.Name = "button5";
            button5.Size = new Size(42, 23);
            button5.TabIndex = 9;
            button5.Text = ">";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numericUpDown3
            // 
            numericUpDown3.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown3.Location = new Point(511, 419);
            numericUpDown3.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(46, 23);
            numericUpDown3.TabIndex = 10;
            numericUpDown3.TextAlign = HorizontalAlignment.Center;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 455);
            Controls.Add(numericUpDown3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(numericUpDown2);
            Controls.Add(button3);
            Controls.Add(numericUpDown1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(treeView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Storage Manager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label PalletVolumeLabel;
        private Label PalletWeightLabel;
        private Label PalletBoxCountLabel;
        private Label PalletIDLabel;
        private Label PalletExpirationDateLabel;
        private Label label6;
        private Label BoxExpirationDateLabel;
        private Label label15;
        private Label label7;
        private Label BoxVolumeLabel;
        private Label label13;
        private Label BoxIDLabel;
        private Label BoxWeightLabel;
        private Label label11;
        private Label BoxProductionDateLabel;
        private Label label8;
        private ListBox listBox1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private Button button3;
        private NumericUpDown numericUpDown2;
        private Button button4;
        private Button button5;
        private NumericUpDown numericUpDown3;
    }
}

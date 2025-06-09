namespace StorageManager
{
    public abstract class StorageItem
    {
        public Guid ID { get; }
        public double Width { get; protected set; }     // Ширина
        public double Height { get; protected set; }    // Высота
        public double Depth { get; protected set; }     // Глубина

        public virtual double Weight { get; protected set; }    // Вес
        public virtual double Volume => Width * Height * Depth; // Объём

        protected StorageItem(double width, double height, double depth, double weight)
        {
            if (width <= 0 || height <= 0 || depth <= 0)
                throw new ArgumentException("Размеры должны быть положительными.");
            if (weight < 0)
                throw new ArgumentException("Вес должен быть положительным");

            ID = Guid.NewGuid();
            Width = width;
            Height = height;
            Depth = depth;
            Weight = weight;
        }
    }
}

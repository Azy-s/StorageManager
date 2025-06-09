namespace StorageManager
{
    public class StorageGenerator
    {
        private readonly Random _random;

        public StorageGenerator(int? seed = null)
        {
            _random = seed.HasValue ? new Random(seed.Value) : new Random();
        }

        public List<Pallet> GeneratePallets(int count)
        {
            if (count < 1)
                throw new ArgumentOutOfRangeException(nameof(count), "Количество паллет должно быть не меньше 1");

            var pallets = new List<Pallet>(count);
            for (int i = 0; i < count; i++)
            {
                // Генерим габариты паллеты (См)
                double palletWidth = NextDouble(100, 300);
                double palletHeight = NextDouble(10, 20);
                double palletDepth = NextDouble(100, 300);

                var pallet = new Pallet(palletWidth, palletHeight, palletDepth);

                // Случайное число коробок на паллете
                int boxCount = _random.Next(1, 11); // от 1 до 10
                for (int j = 0; j < boxCount; j++)
                {
                    var box = GenerateRandomBox(palletWidth, palletDepth);
                    pallet.AddBox(box);
                }

                pallets.Add(pallet);
            }

            return pallets;
        }

        private StorageBox GenerateRandomBox(double maxWidth, double maxDepth)
        {
            // Размеры коробки не больше 80% внутренних размеров паллеты
            double width = NextDouble(10, maxWidth * 0.8);
            double height = NextDouble(5, 100);
            double depth = NextDouble(10, maxDepth * 0.8);
            double weight = NextDouble(1.0, 50.0);

            // Дата производства за последние 10 дней
            DateOnly productionDate = DateOnly.FromDateTime(
                DateTime.Now.AddDays(-_random.Next(0, 10))
            );

            // Задаём либо срок годности, либо дату производства
            if (_random.NextDouble() < 0.5)
            {
                // Истечение через 30–40 дней после производства
                var expiration = productionDate.AddDays(_random.Next(30, 41));
                return new StorageBox(width, height, depth, weight, expirationDate: expiration);
            }
            else
            {
                return new StorageBox(width, height, depth, weight, productionDate: productionDate);
            }
        }

        private double NextDouble(double min, double max)
        {
            return _random.NextDouble() * (max - min) + min;
        }
    }
}

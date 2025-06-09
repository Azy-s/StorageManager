
namespace StorageManager
{
    public class StorageBox : StorageItem
    {

        public DateOnly? ProductionDate { get; private set; }

        public DateOnly? ExpirationDate { get; private set; }

        public StorageBox(double width, double height, double depth, double weight, DateOnly productionDate, DateOnly? expirationDate = null)
            : base(width, height, depth, weight)
        {
            ProductionDate = productionDate;

            // Если срок годности не указан, то он расчитывается от даты производства + 100 дней
            ExpirationDate = ((expirationDate is null) ? productionDate.AddDays(100) : expirationDate);
        }

        public StorageBox(double width, double height, double depth, double weight, DateOnly expirationDate)
            : base(width, height, depth, weight)
        {
            ExpirationDate = expirationDate;
        }
    }
}

namespace StorageManager.Tests
{
    public class StorageTests
    {
        [Fact]
        public void StorageBox_WithExplicitExpirationDate_ShouldSetExpirationDate()
        {
            // Arrange
            DateOnly expiration = DateOnly.FromDateTime(new DateTime(2025, 12, 31));
            StorageBox box = new StorageBox(width: 1.0, height: 2.0, depth: 3.0, weight: 5.0, expirationDate: expiration);

            // Act & Assert
            Assert.Equal(expiration, box.ExpirationDate);
        }

        [Fact]
        public void StorageBox_WithProductionDate_ShouldCalculateExpirationDatePlus100Days()
        {
            // Arrange
            DateOnly productionDate = DateOnly.FromDateTime(new DateTime(2025, 1, 1));
            var expectedExpiration = productionDate.AddDays(100);
            StorageBox box = new StorageBox(width: 1.0, height: 1.0, depth: 1.0, weight: 2.0, productionDate: productionDate);

            // Act & Assert
            Assert.Equal(expectedExpiration, box.ExpirationDate);
        }

        [Fact]
        public void StorageBox_Volume_ShouldBeWidthTimesHeightTimesDepth()
        {
            // Arrange
            StorageBox box = new StorageBox(width: 2.0, height: 3.0, depth: 4.0, weight: 1.0, expirationDate: DateOnly.FromDateTime(DateTime.Now));

            // Act
            var volume = box.Volume;

            // Assert
            Assert.Equal(2.0 * 3.0 * 4.0, volume);
        }

        [Fact]
        public void Pallet_NewPallet_ShouldHaveZeroBoxesAndNullExpiration()
        {
            // Arrange
            Pallet pallet = new Pallet(width: 5.0, height: 0.5, depth: 5.0);

            // Act & Assert
            Assert.Empty(pallet.Boxes);
            Assert.Null(pallet.ExpirationDate);
            Assert.Equal(5.0 * 0.5 * 5.0, pallet.Volume);
        }

        [Fact]
        public void Pallet_AddBox_ShouldUpdatePropertiesCorrectly()
        {
            // Arrange
            Pallet pallet = new Pallet(width: 5.0, height: 1.0, depth: 5.0);
            StorageBox box1 = new StorageBox(1.0, 1.0, 1.0, 2.0, DateOnly.FromDateTime(DateTime.Today.AddDays(50)));
            StorageBox box2 = new StorageBox(2.0, 2.0, 2.0, 3.0, DateOnly.FromDateTime(DateTime.Today.AddDays(30)));

            // Act
            pallet.AddBox(box1);
            pallet.AddBox(box2);

            // Assert
            Assert.Equal(2, pallet.Boxes.Count);
            var expectedWeight = 2.0 + 3.0 + 30.0;
            Assert.Equal(expectedWeight, pallet.Weight);

            var expectedVolume = (5.0 * 1.0 * 5.0) + (1.0 * 1.0 * 1.0) + (2.0 * 2.0 * 2.0);
            Assert.Equal(expectedVolume, pallet.Volume);

            // Expiration should be the earliest of box expirations
            DateOnly expectedExpiration = DateOnly.FromDateTime(DateTime.Today.AddDays(30));
            Assert.Equal(expectedExpiration, pallet.ExpirationDate);
        }

        [Fact]
        public void Pallet_AddBox_OversizedBox_ShouldThrow()
        {
            // Arrange
            var pallet = new Pallet(width: 2.0, height: 0.5, depth: 2.0);
            var oversizedBox = new StorageBox(3.0, 1.0, 1.0, 1.0, DateOnly.FromDateTime(DateTime.Today));

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => pallet.AddBox(oversizedBox));
        }

        [Fact]
        public void Pallet_RemoveBox_ExistingBox_ShouldRemove()
        {
            // Arrange
            var pallet = new Pallet(5.0, 0.5, 5.0);
            var box = new StorageBox(1.0, 1.0, 1.0, 2.0, DateOnly.FromDateTime(DateTime.Today));
            pallet.AddBox(box);

            // Act
            pallet.RemoveBox(box.ID);

            // Assert
            Assert.Empty(pallet.Boxes);
            Assert.Null(pallet.ExpirationDate);
            Assert.Equal(30.0, pallet.Weight);
        }

        [Fact]
        public void Pallet_RemoveBox_NonExistingBox_ShouldThrow()
        {
            // Arrange
            var pallet = new Pallet(5.0, 0.5, 5.0);
            var nonExistingId = Guid.NewGuid();

            // Act & Assert
            var ex = Assert.Throws<InvalidOperationException>(() => pallet.RemoveBox(nonExistingId));
            Assert.Contains("не найдена", ex.Message);
        }
    }
}
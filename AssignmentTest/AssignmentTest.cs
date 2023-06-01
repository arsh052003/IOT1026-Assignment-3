using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            const int PackMaxItems = 10;
            const float PackMaxVolume = 20;
            const float PackMaxWeight = 30;
            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);

            Assert.AreEqual(pack.Get_maxCount(), PackMaxItems);
            Assert.AreEqual(pack.Get_maxVolume(), PackMaxVolume);
            Assert.AreEqual(pack.Get_maxWeight(), PackMaxWeight);
        }

        //This method is testing add method when user add more volume than pack volume limit.
        [TestMethod]
        public void VolumeOverflowTest()
        {
            const int PackMaxItems = 1000;
            const float PackMaxVolume = 5;
            const float PackMaxWeight = 3000;

            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);

            Assert.AreEqual(pack.Add(new Bow()), true);
            Assert.AreEqual(pack.Add(new Bow()), false);
        }

        //This method is testing add method when user add more weight than pack weight limit.
        [TestMethod]
        public void WeightOverflowTest()
        {
            const int PackMaxItems = 1000;
            const float PackMaxVolume = 1000;
            const float PackMaxWeight = 8;

            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);

            Assert.AreEqual(pack.Add(new Sword()), true);
            Assert.AreEqual(pack.Add(new Sword()), false);
        }

        //This method is testing add method when user add item more pack size.
        [TestMethod]
        public void ItemOverflowTest()
        {
            const int PackMaxItems = 2;
            const float PackMaxVolume = 1000;
            const float PackMaxWeight = 800;

            Pack pack = new(PackMaxItems, PackMaxVolume, PackMaxWeight);

            Assert.AreEqual(pack.Add(new Sword()), true);
            Assert.AreEqual(pack.Add(new Sword()), true);
            Assert.AreEqual(pack.Add(new Sword()), false);

        }

        //This test is to check error when user set pack size to zero.
        [TestMethod]
        public void ItemZeroTest()
        {
            const int PackMaxItems = 0;
            const float PackMaxVolume = 1000;
            const float PackMaxWeight = 800;

            //Pack pack = 
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Pack(PackMaxItems, PackMaxVolume, PackMaxWeight));
        }

        //This test is to check error when user provides negative volume.
        [TestMethod]
        public void VolumeNegativeTest()
        {
            const int PackMaxItems = 19;
            const float PackMaxVolume = -19;
            const float PackMaxWeight = 800;

            //Pack pack = 
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Pack(PackMaxItems, PackMaxVolume, PackMaxWeight));
        }

        //This test is to check error when user provides negative weight.
        [TestMethod]
        public void WeightNegativeTest()
        {
            const int PackMaxItems = 10;
            const float PackMaxVolume = 500;
            const float PackMaxWeight = -40;

            //Pack pack = 
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Pack(PackMaxItems, PackMaxVolume, PackMaxWeight));
        }

        //This test for addingitem in pack.
        [TestMethod]
        public void AddItemsTest()
        {
            Pack pack = new Pack(40, 80, 90);
            Assert.AreEqual(pack.Add(new Arrow()), true);
            Assert.AreEqual(pack.Add(new Bow()), true);
            Assert.AreEqual(pack.Add(new Rope()), true);
            Assert.AreEqual(pack.Add(new Water()), true);

        }



    }

}

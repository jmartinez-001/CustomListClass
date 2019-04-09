using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddToEmptyList_AddedItemAtIndexZero()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;
            int actual;

            //Act
            myList.Add(5);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_AddToEmptyList_CountIncreasesByOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expected = 1;
            int actual;

            //Act
            myList.Add(5);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_AddTwoValues_FirstValueEqualsIndexAtZero()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;

            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);

            //Assert
            Assert.AreEqual(5, myList[0]);

        }
        [TestMethod]
        public void Add_AddTwoValues_SecondValueEqualsIndexAtOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;

            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);

            //Assert
            Assert.AreEqual(10, myList[1]);

        }
        [TestMethod]
        public void Remove_RemoveValue_ValueRemoved()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;
            

            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Remove(valueOne);

            //Assert
            Assert.AreEqual(10, myList[0]);
        }
        [TestMethod]
        public void Remove_RemoveValue_CountDecreasesByOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            int expected = 2;
            int actual;

            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Remove(valueOne);
            actual = myList.count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();


            //Act


            //Assert
        }
        [TestMethod]
        public void Test()
        {
            //Arrange


            //Act


            //Assert

        }
        [TestMethod]
        public void Test()
        {
            //Arrange


            //Act


            //Assert

        }
        [TestMethod]
        public void Test()
        {
            //Arrange


            //Act


            //Assert

        }
        [TestMethod]
        public void Test()
        {
            //Arrange


            //Act


            //Assert

        }
        [TestMethod]
        public void Test()
        {
            //Arrange


            //Act


            //Assert

        }
        [TestMethod]
        public void Test()
        {
            //Arrange


            //Act


            //Assert

        }
        [TestMethod]
        public void Test()
        {
            //Arrange


            //Act


            //Assert

        }
        [TestMethod]
        public void Test()
        {
            //Arrange


            //Act


            //Assert

        }
        [TestMethod]
        public void Test()
        {
            //Arrange


            //Act


            //Assert

        }

    }
}

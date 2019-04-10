﻿using System;
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
            // PrivateObject po = new PrivateObject(myList, "IncreaseCapacity");
            

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
            myList.Remove(10);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveValue_RemoveOnlyFirstOccurance()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;

            //Act            
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Add(valueTwo);
            myList.Add(valueTwo);
            myList.Remove(10);

            //Assert
            Assert.AreEqual(10, myList[2]);
        }
        [TestMethod]
        public void Remove_RemoveOnlyFirstOccurance_CountDecreasesByOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            int actual;

            //Act     
            
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            myList.Add(valueTwo);
            myList.Add(valueTwo);
            myList.Remove(10);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(4, actual);
        }
        [TestMethod]
        public void Remove_RemoveValue_ReturnBoolTrue()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            bool actual;


            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            actual = myList.Remove(10);


            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void Remove_RemoveNonExistentValue_ReturnBoolFalse()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            bool actual;


            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            actual = myList.Remove(20);


            //Assert 
            Assert.IsFalse(actual);

        }
        //[TestMethod]
        //public void Test()
        //{
        //    //Arrange


        //    //Act


        //    //Assert

        //}
        //[TestMethod]
        //public void Test()
        //{
        //    //Arrange


        //    //Act


        //    //Assert

        //}
        //[TestMethod]
        //public void Test()
        //{
        //    //Arrange


        //    //Act


        //    //Assert

        //}
        //[TestMethod]
        //public void Test()
        //{
        //    //Arrange


        //    //Act


        //    //Assert

        //}
        //[TestMethod]
        //public void Test()
        //{
        //    //Arrange


        //    //Act


        //    //Assert

        //}
        //[TestMethod]
        //public void Test()
        //{
        //    //Arrange


        //    //Act


        //    //Assert

        //}
        //[TestMethod]
        //public void Test()
        //{
        //    //Arrange


        //    //Act


        //    //Assert

        //}

    }
}

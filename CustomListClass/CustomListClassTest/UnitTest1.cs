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
        [TestMethod]
        public void ToString_TakeListOfInt_ReturnStringOfContents()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            string actual;
            string expected;

            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            expected = "Contents : 5 10 15 ";
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_TakeListOfDouble_ReturnStringOfContents()
        {
            //Arrange
            CustomList<double> myList = new CustomList<double>();
            double valueOne = 5;
            double valueTwo = 10;
            double valueThree = 15;
            string actual;
            string expected;

            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            expected = "Contents : 5 10 15 ";
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_TakeListOfBool_ReturnStringOfContents()
        {
            //Arrange
            CustomList<bool> myList = new CustomList<bool>();
            bool valueOne = true;
            bool valueTwo = false;
            bool valueThree = true;
            string actual;
            string expected;

            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            expected = "Contents : True False True ";
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_TakeListOfFloat_ReturnStringOfContents()
        {
            //Arrange
            CustomList<float> myList = new CustomList<float>();
            float valueOne = 5000;
            float valueTwo = 1000;
            float valueThree = 1500;
            string actual;
            string expected;

            //Act
            myList.Add(valueOne);
            myList.Add(valueTwo);
            myList.Add(valueThree);
            expected = "Contents : 5000 1000 1500 ";
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ListOnePlusListTwo_ReturnNewListWithContentsOfBoth()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3;
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            string expected;
            string actual;


            //Act
            myList1.Add(valueOne);
            myList1.Add(valueTwo);
            myList1.Add(valueThree);
            myList2.Add(valueThree);
            myList2.Add(valueTwo);
            myList2.Add(valueOne);
            expected = "Contents : 5 10 15 15 10 5 ";
            myList3 = myList1 + myList2;
            actual = myList3.ToString();
            



            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void PlusOperator_DoubleDigitIntListOnePlusDoubleDigitIntListTwo_ReturnNewTripleDigitIntListWithContentsOfBoth()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();
            CustomList<int> myList4;
            string actual;
            string expected;            
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;


            CustomList<CustomList<int>> list1 = new CustomList<CustomList<int>>();

            //Act
            for (var i = 0; i < 50; i++)
            {
                myList3.Add(5);
            }
            for (var i = 0; i < 50; i++)
            {
                myList3.Add(10);
            }
            for (var i = 0; i < 50; i++)
            {
                myList1.Add(5);
            }
            for (var i = 0; i < 50; i++)
            {
                myList2.Add(10);
            }
            myList4 = myList1 + myList2;
            actual = myList4.ToString();
            expected = "Contents : 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 10 ";

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MinusOperator_ListOneMinusListTwo_ReturnNewListWithDifferenceOfBoth()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3;
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            int valueFour = 20;
            string expected;
            string actual;


            //Act
            myList1.Add(valueOne);
            myList1.Add(valueTwo);
            myList1.Add(valueThree);
            myList2.Add(valueFour);
            myList2.Add(valueTwo);
            myList2.Add(valueOne);
            expected = "Contents : 15 20 ";
            myList3 = myList1 - myList2;
            actual = myList3.ToString();




            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MinusOperator_ListOneMinusListTwo_ReturnNewListWithDifferenceOfBoth()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3;
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            int valueFour = 20;
            string expected;
            string actual;


            //Act
            myList1.Add(valueOne);
            myList1.Add(valueTwo);
            myList1.Add(valueThree);
            myList2.Add(valueFour);
            myList2.Add(valueTwo);
            myList2.Add(valueOne);
            expected = "Contents : 15 20 ";
            myList3 = myList1 - myList2;
            actual = myList3.ToString();


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MinusOperator_RemoveSecondValueFromFirstList_ReturnNewListThirdValueNowSecond()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3;
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            int valueFour = 20;
            int valueFive = 25;
            string expected;
            string actual;


            //Act
            myList1.Add(valueOne);
            myList1.Add(valueTwo);
            myList1.Add(valueThree);
            myList2.Add(valueFour);
            myList2.Add(valueTwo);
            myList2.Add(valueFive);
            expected = "Contents : 5 15 ";
            myList3 = myList1 - myList2;
            actual = myList3.ToString();


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MinusOperator_RemoveFromFirstListAddValueRemoveFirstListValuesFromNewList_ReturnNewListMinusListOneValues()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3;
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            int valueFour = 20;
            int valueFive = 25;
            string expected;
            string actual;


            //Act
            myList1.Add(valueOne);
            myList1.Add(valueTwo);
            myList1.Add(valueThree);
            myList2.Add(valueFour);
            myList2.Add(valueTwo);
            myList2.Add(valueFive);            
            myList3 = myList1 - myList2;
            myList3.Add(30);
            myList3 = myList3 - myList1;
            actual = myList3.ToString();
            expected = "Contents : 30 ";


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MinusOperator_ListOneMinusListOne_ReturnEmptyNewList()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2;
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            int valueFour = 20;
            string expected;
            string actual;


            //Act
            myList1.Add(valueOne);
            myList1.Add(valueTwo);
            myList1.Add(valueThree);
            expected = "Contents : ";
            myList2 = myList1 - myList1;
            actual = myList2.ToString();


            //Assert
            Assert.AreEqual(expected, actual);

        }



    }
}

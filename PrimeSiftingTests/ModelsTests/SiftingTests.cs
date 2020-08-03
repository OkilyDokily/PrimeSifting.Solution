using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;
using System.Collections.Generic;

namespace PrimeSiftingTests
{
    [TestClass]
    public class SiftingTests
    {
        [TestMethod]
        public void Sifter_SifterConstructor_True(){
            Sifter s = new Sifter(5);
            Assert.AreEqual(typeof(Sifter),s.GetType());
        }

        [TestMethod]
        public void Sifter_SifterConstructorCreatesList_True(){
            //Arrange
            Sifter s = new Sifter(5);
            List<string> al = new List<string>{"X","O","O","O","O"};

            //act
            List<string> actl = s._initalList;
            
            CollectionAssert.AreEqual(al,actl);
        }

        [TestMethod]
        public void Sifter_SifterConstructorCreatesList_False(){
            //Arrange
            Sifter s = new Sifter(5);
            List<string> al = new List<string>{"X","X","O","O","O"};

            //act
            List<string> actl = s._initalList;
            
            CollectionAssert.AreNotEqual(al,actl);
        }

        [TestMethod]
        public void OperateOnFinalList_ReturnPrimeList_True(){
            //Arrange
            Sifter s = new Sifter(5);
            List<string> al = new List<string>{"X","O","O","X","O"};
            s._initalList = al;
            List<int> pl = new List<int>(){2,3,5};
            //act
            List<int> result = s.OperateOnFinalList();
            CollectionAssert.AreEqual(result,pl);
        }

        [TestMethod]
        public void OperateOnFinalList_ReturnPrimeList_False(){
            //Arrange
            Sifter s = new Sifter(5);
            List<string> al = new List<string>{"X","O","O","X","O"};
            s._initalList = al;
            List<int> pl = new List<int>(){2,3,4};
            //act
            List<int> result = s.OperateOnFinalList();
            CollectionAssert.AreNotEqual(result,pl);
        }

        [TestMethod]
        public void Sift_ReturnPrimeList_True(){
            //Arrange
            Sifter s = new Sifter(5);
            List<int> pl = new List<int>(){2,3,5};
            //act
            List<int> result = s.Sift();
           
            CollectionAssert.AreEqual(result,pl);
        }
    }
}
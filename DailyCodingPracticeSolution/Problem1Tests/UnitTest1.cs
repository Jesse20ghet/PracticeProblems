using System;
using System.Linq;
using DailyCodingPracticeSolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1Tests
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void ThreeAndFourPassInSevenReturnTrue()
      {
         // Arrange
         int[] numberList = { 3, 4, 5, 6 };
         int returnNumber = 7;

         var classToAct = new ProblemOneClass();

         // Act
         var response = classToAct.DoesListSumToPassedInInteger(numberList, returnNumber);

         // Assert
         Assert.AreEqual(response, true);
      }

      [TestMethod]
      public void OneTwoThreePassInSevenShouldReturnFalse()
      {
         // Arrange
         int[] numberList = { 1, 2, 3 };
         int returnNumber = 7;

         var classToAct = new ProblemOneClass();

         // Act
         var response = classToAct.DoesListSumToPassedInInteger(numberList, returnNumber);
         
         // Assert
         Assert.AreEqual(response, false);
      }
      
      [TestMethod]
      public void ZeroZeroZeroFivePassInFiveShouldReturnTrue()
      {
         // Arrange
         int[] numberList = { 0, 0, 0, 5 };
         int returnNumber = 5;

         var classToAct = new ProblemOneClass();

         // Act
         var response = classToAct.DoesListSumToPassedInInteger(numberList, returnNumber);

         // Assert
         Assert.AreEqual(response, true);
      }

      [TestMethod]
      public void OnePass_ThreeAndFourShouldPassInSevenReturnTrue()
      {
         // Arrange
         int[] numberList = { 3, 4, 5, 6 };
         int returnNumber = 7;

         var classToAct = new ProblemOneClass();

         // Act
         var response = classToAct.SumsToKOnePass(numberList.ToList(), returnNumber);

         // Assert
         Assert.AreEqual(response, true);
      }

      [TestMethod]
      public void OnePass_OneTwoThreePassInSevenShouldReturnFalse()
      {
         // Arrange
         int[] numberList = { 1, 2, 3 };
         int returnNumber = 7;

         var classToAct = new ProblemOneClass();

         // Act
         var response = classToAct.SumsToKOnePass(numberList.ToList(), returnNumber);

         // Assert
         Assert.AreEqual(response, false);
      }

      [TestMethod]
      public void OnePass_ZeroZeroZeroFivePassInFiveShouldReturnTrue()
      {
         // Arrange
         int[] numberList = { 0, 0, 0, 5 };
         int returnNumber = 5;

         var classToAct = new ProblemOneClass();

         // Act
         var response = classToAct.SumsToKOnePass(numberList.ToList(), returnNumber);

         // Assert
         Assert.AreEqual(response, true);
      }

      [TestMethod]
      public void OnePass_ZeroZeroZeroSevenPassInFiveShouldReturnFalse()
      {
         // Arrange
         int[] numberList = { 0, 0, 0, 7 };
         int returnNumber = 5;

         var classToAct = new ProblemOneClass();

         // Act
         var response = classToAct.SumsToKOnePass(numberList.ToList(), returnNumber);

         // Assert
         Assert.AreEqual(response, false);
      }
   }
}

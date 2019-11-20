using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AllKindQuestions;


namespace UnitTest
{
    [TestFixture]
    public class Class1
    {
        //ListAnalyzer analyzer;
        //[SetUp]
        //public void Setup()
        //{
        //    analyzer = new ListAnalyzer();
        //}


        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 5, 22, 93 }, 93)]
        [TestCase(new int[] { -1, -2, -3 }, -1)]
        public void FindBiggestNumber_ReturnTheBiggestNumber_WhenGivenAListOfNumbers(int[] numbersArray, int expectedResult)
        {
            #region Arrange
            ListAnalyzer analyzer = new ListAnalyzer();
            List<int> numbers = numbersArray.ToList();
            #endregion

            #region Act
            int biggestNumber = analyzer.FindBiggestNumber(numbers);
            #endregion

            #region Assert
            Assert.That(biggestNumber, Is.EqualTo(expectedResult));
            #endregion
        }
    }
}

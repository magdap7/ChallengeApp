//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void testOfReferenceTypes()
        {
            //arrange
            var user1 = GetEmployee("Magda","P",40);
            var user2 = GetEmployee("Magda","M",40);
            //assert
            Assert.AreNotEqual(user1, user2);
            Assert.AreNotSame(user1, user2);
            Assert.AreEqual(user1.firstName, user2.firstName);
            Assert.AreNotEqual(user1.lastName, user2.lastName);
            Assert.AreEqual(user1.age, user2.age);
            
        }

        [Test]
        public void testOfStringToCharArray()
        {
            //arrange
            string word1 = "kot Ali";
            string word2 = "kot Ali";
            //act
            char[] tabOfChars1 = word1.ToCharArray();
            char[] tabOfChars2 = word2.ToCharArray();
            //assert
            Assert.AreEqual(word1, word2);
            Assert.AreSame(word1, word2);
            Assert.AreEqual(tabOfChars1, tabOfChars2);
            Assert.AreNotSame(tabOfChars1, tabOfChars2);

        }

        [Test]
        public void testOfValueTypes()
        {
            int number1 = 5;
            double number2 = 5.0;
            float number3 = 5.0f;
            decimal number4 = 5.0M;
            //String number5 = "5"; //nie zadziała tu porównanie

            Assert.AreEqual(number1, number2);
            Assert.AreEqual(number1, number3);
            Assert.AreEqual(number1, number4);
            Assert.AreEqual(number2, number3);
            Assert.AreEqual(number2, number4);
        }

        private Employee GetEmployee(string  firstName, string lastName, int age)
        {
            return new Employee(firstName, lastName, age);
        }
    }
}

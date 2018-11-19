using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace CitrusByte.Tests
{
    [TestClass()]
    public class ExerciseTests
    {
        [TestMethod()]
        public void SampleTest()
        {
            ArrayList sampleTest = new ArrayList() { new ArrayList() { 1, 2, new ArrayList() { 3 } }, 4 };
            int[] expectedResult = new int[] { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expectedResult, Exercise.FlattenArray(sampleTest));
        }

        [TestMethod()]
        public void SimpleTest()
        {
            ArrayList simpleTest = new ArrayList() { 5, 4, 3, 2, 1 };
            int[] expectedResult = new int[] { 5, 4, 3, 2, 1 };
            CollectionAssert.AreEqual(expectedResult, Exercise.FlattenArray(simpleTest));
        }

        [TestMethod()]
        public void EmptyArray()
        {
            int[] emptyArray = new int[0];
            CollectionAssert.AreEqual(emptyArray, Exercise.FlattenArray(null), "Null List");
            CollectionAssert.AreEqual(emptyArray, Exercise.FlattenArray(new ArrayList()), "Empty List");
        }
    }
}
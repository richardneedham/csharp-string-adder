using Microsoft.VisualStudio.TestTools.UnitTesting;
using string_concat;

namespace string_concatenator_test
{
    [TestClass]
    public class StringConcatenatorTest
    {
        [TestMethod]
        public void test_add_two_non_empty_strings_inserting_single_space()
        {
            //Arange
            StringConcatenator cut = new StringConcatenator();
            string LH = "AA";
            string RH = "BB";
            string expected = "AA BB";
            //Act
            string actual = cut.AddStrings(LH, RH);
            //Assert
            Assert.AreEqual(expected, actual, "Error");
        }
    }
}

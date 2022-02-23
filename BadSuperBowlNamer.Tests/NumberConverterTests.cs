using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    public class NumberConverterTests
    {
        [Fact] //Fact attribute is required so that xUnit will detect this method as a test
        public void Number_One_Is_Converted_To_Roman_Numeral_Correctly()
        {
            //tests pass when no exceptions are thrown during the test
            //tests fail when any exception is thrown during the test
            //throw new Exception("This test has failed!");

            //Arrange -> context that the test is run inside of, Given this...
            var numberToTest = 1;
            var expectedOutcome = "I";

            //Act -> the actual thing we're testing, do this thing, When this happens....
            var converter = new NumberConverter();
            var actualOutcome = converter.Convert(numberToTest);

            //Assert -> lay out the expectations in such a way that, if not met, exceptions are thrown, Then this should happen...
            //Assert.True(expectedOutcome == actualOutcome); //doesn't give a very good message when a failure occurs
            Assert.Equal(expectedOutcome, actualOutcome); //gives a better message when a failure occurs

        }

        [Fact]
        public void Number_Four_Is_Converted_To_Roman_Numerals_Correctly()
        {
            //arrange
            var numberToTest = 4;
            var expectedOutcome = "IV";

            //act
            var converter = new NumberConverter();
            var actualOutcome = converter.Convert(numberToTest);

            //assert
            Assert.Equal(expectedOutcome, actualOutcome);
        }


        //to debug a theory test with a specific set of inline data,
        //set your breakpoint, then right-click the specific test in the Test Explorer, and choose debug
        [InlineData(1,"I")]
        [InlineData(2,"II")]
        [InlineData(3,"III")]
        [InlineData(4,"IV")]
        [InlineData(5,"V")]
        [InlineData(6,"VI")]
        [InlineData(7,"VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [Theory]
        public void Numbers_Can_Be_Converted_To_Roman_Numerals_Correctly(int numberToTest, string expectedOutcome)
        {
            //arrange
            //numberToTest = 4;
            //expectedOutcome = "IV";

            //act
            var converter = new NumberConverter();
            var actualOutcome = converter.Convert(numberToTest);

            //assert
            Assert.Equal(expectedOutcome, actualOutcome);
        }
    }
}
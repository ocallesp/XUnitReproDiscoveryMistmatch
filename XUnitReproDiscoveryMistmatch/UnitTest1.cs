namespace XUnitReproDiscoveryMistmatch
{
    public class UnitTest1
    {
        [Theory]
        [ClassData(typeof(MyDescriptorClass))]
        public void ReproBug(string recipeName, MyDescriptor expected)
        {
            if (string.IsNullOrEmpty(recipeName))
            {
                throw new ArgumentException($"'{nameof(recipeName)}' cannot be null or empty.", nameof(recipeName));
            }

            if (expected is null)
            {
                throw new ArgumentNullException(nameof(expected));
            }
        }

        [Theory]
        [ClassData(typeof(StartsWithCharTestData))]
        public void StartsWithChar(string input, char character, bool expectedResult)
        {
            // Act
            bool result = input.StartsWith(character);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(5, false)]
        public void IsEvenTest(int number, bool expected)
        {
            bool isEven = number % 2 == 0;
            Assert.Equal(expected, isEven);
        }
    }
}
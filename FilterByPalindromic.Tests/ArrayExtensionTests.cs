using NUnit.Framework;

namespace FilterByPalindromic.Tests
{
    [TestFixture]
    public class ArrayExtensionTests
    {
        [TestCase(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, ExpectedResult = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9})]
        [TestCase(new[] {717, 828, 45, 58, 881, 11711, 252}, ExpectedResult = new[] {717, 828, 11711, 252})]
        [TestCase(new[] {17, 82, 45, 58, 881, 117, 25}, ExpectedResult = new int[] { })]
        public int[] FilterByPalindromicTests(int[] source)
            => source.FilterByPredicate();
        
        //TODO: Add tests for Exception cases here.
    }
}
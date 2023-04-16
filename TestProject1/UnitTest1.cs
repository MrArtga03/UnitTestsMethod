using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json.Linq;

using ClassLibrary1;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            // Arrange
            int[,] a = new int[,] {
                { 1, 2, 3, 4, 5, 6, 7, 8 },
                { 1, 2, 3, 4, 5, 6, 7, 8 }
            };
            int value = 36;

            // Act
            Class1 class1 = new Class1();
            int[,] result = class1.Method(a, value);

            // Assert
            int[,] expected = new int[,] { 
                { 36, 0, 0, 0, 0, 0, 0, 0 }, 
                { 36, 0, 0, 0, 0, 0, 0, 0 } 
            };
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Assert.IsTrue(result[i, j] == expected[i, j]);
                }
            }
        }

        [TestMethod]
        public void Test2()
        {
            // Arrange
            int[,] a = new int[,] {
                { 1, 2 },
                { 1, 2 }
            };
            int value = 3;

            // Act
            Class1 class1 = new Class1();
            int[,] result = class1.Method(a, value);

            // Assert
            int[,] expected = new int[,] {
                { 3, 0 },
                { 3, 0 }
            };
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Assert.IsTrue(result[i, j] == expected[i, j]);
                }
            }
        }

        [TestMethod]
        public void Test3()
        {
            // Arrange
            int[,] a = new int[,] {
                { 1, 2 },
                { 1, 2 }
            };
            int value = 3;

            // Act
            Class1 class1 = new Class1();
            int[,] result = class1.Method(a, value);

            // Assert
            int[,] expected = new int[,] {
                { 4, 0 },
                { 0, 4 }
            };

            bool areEqual = true;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (result[i, j] != expected[i, j])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            Assert.IsFalse(areEqual);
        }
    }
}

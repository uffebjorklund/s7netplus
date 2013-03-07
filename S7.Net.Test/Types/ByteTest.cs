using NUnit.Framework;
using S7.Types;
using Should;

namespace S7.Net.Test.Types
{
    [TestFixture]
    public class ByteTest
    {
        [Test]
        public void should_return_byte_value_as_array()
        {
            //Arrange
            byte testValue = 15; //00001111b;

            //Act
            byte[] result = testValue.ToByteArray();

            //Assert
            result.Length.ShouldEqual(1);
            result[0].ShouldEqual((byte)15);
        }
    }
}

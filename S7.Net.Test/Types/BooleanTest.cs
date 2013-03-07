using NUnit.Framework;
using S7.Types;
using Should;

namespace S7.Net.Test.Types
{
    [TestFixture]
    public class BooleanTest
    {
        [Test]
        public void should_return_bit_status_of_true()
        {
            //Arange
            byte testValue = 1 << 3; //00001000b

            //Act
            bool result = testValue.GetBit(3);

            //Assert
            result.ShouldBeTrue();
        }

        [Test]
        public void should_return_bit_status_of_false()
        {
            //Arrange
            byte testValue = 1 << 3; //00001000b

            //Act
            bool result = testValue.GetBit(1);

            //Assert
            result.ShouldBeFalse();
        }

        [Test]
        public void should_set_bit_to_true()
        {
            //Arrange
            byte testvalue = 0;

            //Act
            byte result = testvalue.SetBit(1);

            //Assert
            result.ShouldEqual((byte)2);
        }

        [Test]
        public void should_clear_bit()
        {
            //Arrange
            byte testValue = 2;

            //Act
            byte result = testValue.ClearBit(1);

            //Assert
            result.ShouldEqual((byte) 0);
        }
    }
}

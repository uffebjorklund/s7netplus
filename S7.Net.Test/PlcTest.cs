using NUnit.Framework;
using Should;

namespace S7.Net.Test
{
    [TestFixture]
    public class PlcTest
    {
        [Test]
        public void should_instantiate_new_default_plc()
        {
            //Arrange
            IPlc testPlc;

            //Act
            testPlc = new Plc();

            //Assert
            testPlc.CPU.ShouldEqual(CpuType.S7300);
            testPlc.IP.ShouldEqual("127.0.0.1");
            testPlc.IsConnected.ShouldBeFalse();
            testPlc.Rack.ShouldEqual((short) 0);
            testPlc.Slot.ShouldEqual((short) 1);
        }

        [Test]
        public void should_instantiate_new_plc()
        {
            //Arrange
            IPlc testPlc;

            //Act
            testPlc = new Plc(CpuType.S7400, "127.0.0.2",1,2);

            //Assert
            testPlc.CPU.ShouldEqual(CpuType.S7400);
            testPlc.IP.ShouldEqual("127.0.0.2");
            testPlc.IsConnected.ShouldBeFalse();
            testPlc.Rack.ShouldEqual((short) 1);
            testPlc.Slot.ShouldEqual((short) 2);
        }

        [Test]
        public void should_check_if_device_is_available()
        {
            //Arrange
            IPlc testPlc = new Plc();
        }
    }
}

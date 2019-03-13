using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvoPhone.Common;
using EvoPhone.Common.Output;

namespace evoPhone.biz.PhoneParts.Sound.Headset.Tests {
    [TestClass()]
    public class BluetoothHeadsetTests {
        [TestMethod()]
        public void BluetoothHeadsetPlayTest() {
            //GIVEN BluetoothHeadset with microphone
            //AND BluetoothHeadset is connected
            TestOutputContainer testOutputContainer = new TestOutputContainer();
            IOutput outputComponent = new TestOutput(testOutputContainer);
            BluetoothHeadset bluetoothHeadset = new BluetoothHeadset("Bluetooth 4.2", outputComponent);
            bluetoothHeadset.IsConnected = true;
            string expectedReult = "BluetoothHeadset playback. \n Bluetooth version is: Bluetooth 4.2\n Sound is like this: \n Pleasant music\n";
            //WHEN: try to play "sound"
            bluetoothHeadset.Play("Pleasant music");
            //THEN
            Assert.AreEqual(expectedReult, testOutputContainer.Output);
        }
    }
}
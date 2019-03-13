using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvoPhone.Common;
using EvoPhone.Common.Output;

namespace evoPhone.biz.PhoneParts.Sound.Headset.Tests {
    [TestClass()]
    public class StereoHeadsetTests {
        [TestMethod()]
        public void StereoHeadsetPlayTest() {
            //GIVEN: StereoHeadset with microphone
            //AND StereoHeadset is connected
            TestOutputContainer testOutputContainer = new TestOutputContainer();
            IOutput outputComponent = new TestOutput(testOutputContainer);
            StereoHeadset stereoHeadset = new StereoHeadset(true, outputComponent);
            stereoHeadset.IsConnected = true;
            string expectedReult = "StereoHeadset playback. Microphone is: Present.\n Sound is like this: \n Pleasant music\n";
            //WHEN: try to play "sound"
            stereoHeadset.Play("Pleasant music");
            //THEN
            Assert.AreEqual(expectedReult, testOutputContainer.Output);
        }
    }
}
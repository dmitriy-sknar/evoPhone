using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvoPhone.Common;
using EvoPhone.Common.Output;

namespace evoPhone.biz.PhoneParts.Sound.Headset.Tests {
    [TestClass()]
    public class MaxStereoHeadsetTests {
        [TestMethod()]
        public void MaxStereoHeadsetPlayTest() {
            //GIVEN MaxStereoHeadset with microphone
            //AND MaxStereoHeadset is connected
            TestOutputContainer testOutputContainer = new TestOutputContainer();
            IOutput outputComponent = new TestOutput(testOutputContainer);
            MaxStereoHeadset maxStereoHeadset = new MaxStereoHeadset(true, outputComponent);
            maxStereoHeadset.IsConnected = true;
            string expectedReult = "MaxStereoHeadset playback. Microphone is: Present.\nThis is stereo sound. So you can 'hear' two sounds: \n Pleasant music \n PLEASANT MUSIC\n";
            //WHEN: try to play "sound"
            maxStereoHeadset.Play("Pleasant music");
            //THEN
            Assert.AreEqual(expectedReult, testOutputContainer.Output);
        }
    }
}
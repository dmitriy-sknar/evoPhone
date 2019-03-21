using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoPhone.Common.Output {
    public class TestOutput : IOutput {
        private TestOutputContainer vTestOutputContainer;
        public TestOutput(TestOutputContainer testOutputContainer) {
            vTestOutputContainer = testOutputContainer;
        }
        public void Write(string text) {
            vTestOutputContainer.Output = text;
        }

        public void WriteLine(string text) {
            vTestOutputContainer.Output = text + '\n';
        }
    }
}

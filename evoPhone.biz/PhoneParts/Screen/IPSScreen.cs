using System;

namespace evoPhone.biz {
    class IPSScreen : TouchScreen {
        public IPSScreen(double size, int pixelsX, int pixelsY, int colorDepth, MultiTouch touches)
            : base(size, pixelsX, pixelsY, colorDepth, touches) {}

        public IPSScreen(double size, int pixelsX, int pixelsY, int colorDepth)
            : base(size, pixelsX, pixelsY, colorDepth) {}

        public override void Show(IScreenImage screenImage) {
            Console.WriteLine("Hello world!");
        }

        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine("Hello bright world!");
        }

        public override string ToString() {
            return "IPS Touch Screen";
        }
    }
}
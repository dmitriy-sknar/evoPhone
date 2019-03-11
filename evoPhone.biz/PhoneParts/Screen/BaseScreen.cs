namespace evoPhone.biz {
    public abstract class BaseScreen : Screen {
        /// <summary>
        /// Basic screen
        /// </summary>
        /// <param name="size"></param>
        /// <param name="pixelsX"></param>
        /// <param name="pixelsY"></param>
        /// <param name="colorDepth"></param>
        public BaseScreen(double size, int pixelsX, int pixelsY, int colorDepth) {
            ImageSize = size;
            PixelsX = pixelsX;
            PixelsY = pixelsY;
            ColorDepth = colorDepth;
        }

        public override double ImageSize { get; protected set; }
        public override int PixelsX { get; protected set; }
        public override int PixelsY { get; protected set; }
        public override int ColorDepth { get; protected set; }
    }
}
namespace evoPhone.biz {
    public abstract class TouchScreen : BaseScreen {
        public TouchScreen(double size, int pixelsX, int pixelsY, int colorDepth, MultiTouch touches)
            : base(size, pixelsX, pixelsY, colorDepth) {
            Touches = touches;
        }

        public TouchScreen(double size, int pixelsX, int pixelsY, int colorDepth)
            : base(size, pixelsX, pixelsY, colorDepth) {
            Touches = MultiTouch.getInstance(5);
        }

        public MultiTouch Touches { get; private set; }

        public void OnTouched(SingleTouch newTouch) {
            Touches.AddTouche(newTouch);
        }

        public void OnUnTouched(SingleTouch oldTouch) {
            Touches.DeleteTouch(oldTouch);
        }
    }
}
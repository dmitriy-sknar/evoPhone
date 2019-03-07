using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public abstract class TouchScreen : BaseScreen{

        public TouchScreen(double size, int pixelsX, int pixelsY, int colorDepth, MultiTouch touches) : base(size, pixelsX, pixelsY, colorDepth)
        {
            this.Touches = touches;
        }

        public TouchScreen(double size, int pixelsX, int pixelsY, int colorDepth) : base(size, pixelsX, pixelsY, colorDepth) {
            this.Touches = MultiTouch.getInstance(5);
        }

        private MultiTouch touches;

        public MultiTouch Touches
        {
            get { return touches; }
            set { touches = value; }
        }

        public void OnTouched(SingleTouch newTouch)
        {
            touches.AddTouche(newTouch);
        }

        public void OnUnTouched(SingleTouch oldTouch) {
            touches.DeleteTouch(oldTouch);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public abstract class Screen : IScreen, IPhonePart {

        public abstract void Show(IScreenImage screenImage);

        public abstract void Show(IScreenImage screenImage, int brightness);

        public abstract double ImageSize { get; set; }
        public abstract int ColorDepth { get; set; }
        public abstract int PixelsX { get; set; }
        public abstract int PixelsY { get; set; }
    }
}

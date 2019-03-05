using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {

    public abstract class BaseScreen : Screen{

        /// <summary>
        /// Basic screen
        /// </summary>
        /// <param name="size"></param>
        /// <param name="pixelsX"></param>
        /// <param name="pixelsY"></param>
        /// <param name="colorDepth"></param>
        public BaseScreen(double size, int pixelsX, int pixelsY, int colorDepth)
        {
            this.ImageSize = size;
            this.PixelsX = pixelsX;
            this.PixelsY = pixelsY;
            this.ColorDepth = colorDepth;
        }

        private double imageSize;

        public override double ImageSize 
        {
            get { return imageSize; }
            set { imageSize = value; }
        }

        private int pixelsX;

        public override int PixelsX
        {
            get { return pixelsX; }
            set { pixelsX = value; }
        }

        private int pixelsY;

        public override int PixelsY
        {
            get { return pixelsY; }
            set { pixelsY = value; }
        }

        private int colorDepth;

        public override int ColorDepth
        {
            get { return colorDepth; }
            set { colorDepth = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {

    public class BaseCase : IPhonePart {
        /// <summary>
        /// Phone case
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        public BaseCase(int height, int width, int length, CaseMaterial caseMaterial)
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

    }
}

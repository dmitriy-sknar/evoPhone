using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {

    /// <summary>
    /// Touch with coordinates
    /// </summary>
    public class BaseTouch : ITouch, IPhonePart {
        public BaseTouch(int touchPosX, int touchPosY)
        {
            this.TouchPosX = touchPosX;
            this.TouchPosY = touchPosY;
        }

        private int touchPosX;

        public int TouchPosX
        {
            get { return touchPosX; }
            set { touchPosX = value; }
        }

        private int touchPosY;

        public int TouchPosY
        {
            get { return touchPosY; }
            set { touchPosY = value; }
        }
    }
}

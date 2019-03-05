using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public class SingleTouch : BaseTouch{

        /// <summary>
        /// Single touch
        /// </summary>
        /// <param name="touchPosX"></param>
        /// <param name="touchPosY"></param>
        /// <param name="isTouched"></param>
        public SingleTouch(int touchPosX, int touchPosY, bool isTouched) : base(touchPosX, touchPosY)
        {
            this.IsTouched = isTouched;
        }

        private bool isTouched;

        public bool IsTouched
        {
            get { return isTouched; }
            set { isTouched = value; }
        }

    }
}

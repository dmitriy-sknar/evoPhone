using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace evoPhone.biz {
    public class MultiTouch : IPhonePart {
        private static MultiTouch instance;

        private MultiTouch()
        {
            touches = new ArrayList();
        }

        private MultiTouch(int maxTouches) : this() {
            this.MaxTouches = maxTouches;
        }

        /// <summary>
        /// Single touch
        /// </summary>
        /// <returns></returns>
        public static MultiTouch getInstance()
        {
            return instance == null ? instance = new MultiTouch(1) : instance;
        }

        /// <summary>
        /// Multitouch with limited touches
        /// </summary>
        /// <param name="maxTouches"></param>
        /// <returns></returns>
        public static MultiTouch getInstance(int maxTouches) {
            return instance == null ? instance = new MultiTouch(maxTouches) : instance;
        }

        private ArrayList touches;
        private int maxTouches;

        public int MaxTouches   
        {
            get { return maxTouches; }
            set { maxTouches = value; }
        }


        public void AddTouche(SingleTouch singleTouch)
        {
            if (touches.Count >= maxTouches)
            {
                //Try to find obsolescent touch and free the place for new one
                foreach (SingleTouch touch in touches)
                {
                    if (!touch.IsTouched) 
                    {
                        touches.Remove(singleTouch);
                    }
                }
                if (touches.Count >= maxTouches) return;
            }
            singleTouch.IsTouched = true;
            touches.Add(singleTouch);
        }

        //Touch is actually not deleted but marked as untouched.
        public void DeleteTouch(SingleTouch singleTouch)
        {
            int ix = touches.IndexOf(singleTouch);
            SingleTouch touch = (SingleTouch) touches[ix];
            touch.IsTouched = false;
            touches[ix] = touch;
        }

        public void ClearTouches() {
            touches.Clear();
        }

 
        public override string ToString()
        {
            int touchCount = 0;
            foreach (SingleTouch touch in touches)
            {
                if (touch.IsTouched) touchCount++;
            }
            return "Multitouch with " + touchCount + " active touches";
        }
    }
}

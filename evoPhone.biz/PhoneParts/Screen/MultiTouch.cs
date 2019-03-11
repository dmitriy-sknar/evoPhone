using System.Collections;
using EvoPhone.Common;

namespace evoPhone.biz {
    public class MultiTouch : IPhonePart {
        private static MultiTouch vMultiTouchInstance;

        private MultiTouch() {
            vTouches = new ArrayList();
        }

        private MultiTouch(int maxTouches) : this() {
            MaxTouches = maxTouches;
        }

        /// <summary>
        /// Single touch
        /// </summary>
        /// <returns></returns>
        public static MultiTouch getInstance() {
            return vMultiTouchInstance == null ? vMultiTouchInstance = new MultiTouch(1) : vMultiTouchInstance;
        }

        /// <summary>
        /// Multitouch with limited touches
        /// </summary>
        /// <param name="maxTouches"></param>
        /// <returns></returns>
        public static MultiTouch getInstance(int maxTouches) {
            return vMultiTouchInstance == null ? vMultiTouchInstance = new MultiTouch(maxTouches) : vMultiTouchInstance;
        }

        private readonly ArrayList vTouches;

        public int MaxTouches { get; private set; }

        public void AddTouche(SingleTouch singleTouch) {
            if (vTouches.Count >= MaxTouches) {
                //Try to find obsolescent touch and free the place for new one
                foreach (SingleTouch touch in vTouches) {
                    if (!touch.IsTouched) {
                        vTouches.Remove(singleTouch);
                    }
                }
                if (vTouches.Count >= MaxTouches) return;
            }
            singleTouch.IsTouched = true;
            vTouches.Add(singleTouch);
        }

        //Touch is actually not deleted but marked as untouched.
        public void DeleteTouch(SingleTouch singleTouch) {
            int ix = vTouches.IndexOf(singleTouch);
            SingleTouch touch = (SingleTouch) vTouches[ix];
            touch.IsTouched = false;
            vTouches[ix] = touch;
        }

        public void ClearTouches() {
            vTouches.Clear();
        }

        public override string ToString() {
            int touchCount = 0;
            foreach (SingleTouch touch in vTouches) {
                if (touch.IsTouched) touchCount++;
            }
            return "Multitouch with " + touchCount + " active touches";
        }

        private PartStatus vPartStatus;

        public PartStatus GetStatus() {
            return vPartStatus;
        }

        public void SetActive() {
            vPartStatus = PartStatus.Activated;
        }

        public void SetDeactivated() {
            vPartStatus = PartStatus.Deactivated;
        }
    }
}
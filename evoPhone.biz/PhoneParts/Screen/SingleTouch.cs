namespace evoPhone.biz {
    public class SingleTouch : BaseTouch {
        /// <summary>
        /// Single touch
        /// </summary>
        /// <param name="touchPosX"></param>
        /// <param name="touchPosY"></param>
        /// <param name="isTouched"></param>
        public SingleTouch(int touchPosX, int touchPosY, bool isTouched) : base(touchPosX, touchPosY) {
            IsTouched = isTouched;
        }

        public bool IsTouched { get; set; }
    }
}
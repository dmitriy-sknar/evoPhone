using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public class Microphone : IPhonePart {

        /// <summary>
        /// Phone microphone.
        /// </summary>
        /// <param name="sensivity"></param>
        /// <param name="isMuted"></param>
        public Microphone(int sensivity, bool isMuted)
        {
            this.Sensivity = sensivity;
            this.IsMuted = isMuted;
        }

        private int sensivity;

        public int Sensivity
        {
            get { return sensivity; }
            set { sensivity = value; }
        }

        private bool isMuted;

        public bool IsMuted
        {
            get { return isMuted; }
            set { isMuted = value; }
        }

        public override string ToString() {
            return "Microphone";
        }
    }
}

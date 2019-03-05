using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public class Dynamic : IPhonePart {

        /// <summary>
        /// Phone Dynamic. Can be mono or stereo.
        /// </summary>
        /// <param name="maxVol"></param>
        /// <param name="isStereo"></param>
        public Dynamic(int maxVol, bool isStereo)
        {
            this.MaxVol = maxVol;
            this.IsStereo = isStereo;
        }

        private int maxVol;

        public int MaxVol
        {
            get { return maxVol; }
            set { maxVol = value; }
        }

        private bool isStereo;

        public bool IsStereo
        {
            get { return isStereo; }
            set { isStereo = value; }
        }

        public override string ToString() {
            return "Dynamic";
        }
    }
}

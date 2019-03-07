using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public abstract class BaseBattery : IBattery, IPhonePart {
        public BaseBattery()
        {
            this.Volume = 800;
            this.Size = new int[] {80, 40, 5};
        }
        public BaseBattery(int volume, int height, int width, int length)
        {
            this.Volume = volume;
            this.Size = new int[]{height, width, length };
        }
        private int volume;

        public abstract void Charge();
   
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        private int[] size;

        public int[] Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}

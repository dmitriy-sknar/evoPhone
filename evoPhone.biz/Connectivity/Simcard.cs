using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public class Simcard : IPhonePart {

        /// <summary>
        /// Phone Sim Card
        /// </summary>
        /// <param name="simCardType"></param>
        public Simcard(SimCardType simCardType)
        {
            this.SimCardType = simCardType;
        }

        private SimCardType simCardType;

        public SimCardType SimCardType
        {
            get { return simCardType; }
            set { simCardType = value; }
        }
        public override string ToString() {
            return SimCardType + " SimCard";
        }
    }

    public enum SimCardType
    {
        G2,
        G3,
        G4
    }
}

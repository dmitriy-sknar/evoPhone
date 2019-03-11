using EvoPhone.Common;

namespace evoPhone.biz {
    public class Simcard : IPhonePart {
        /// <summary>
        /// Phone Sim Card
        /// </summary>
        /// <param name="simCardType"></param>
        /// <param name="simCardFormFactor"></param>
        public Simcard(SimCardType simCardType, SimCardFormFactor simCardFormFactor) {
            SimCardType = simCardType;
            SimCardFormFactor = simCardFormFactor;
        }

        public SimCardType SimCardType { get; private set; }

        public SimCardFormFactor SimCardFormFactor { get; private set; }


        public override string ToString() {
            return $"{SimCardType} SimCard with formfactor: {SimCardFormFactor}";
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

    public enum SimCardType {
        G2 = 1,
        G3 = 2,
        G4 = 3
    }

    public enum SimCardFormFactor {
        Mini = 1,
        Micro = 2,
        Nano = 3
    }
}
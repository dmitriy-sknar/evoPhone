namespace evoPhone.biz {
    public class MaterialCase : BaseCase {
        /// <summary>
        /// Phone Case with material specified.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="caseMaterial"></param>
        public MaterialCase(int height, int width, int length, CaseMaterial caseMaterial) : base(height, width, length) {
            CaseMaterial = caseMaterial;
        }

        public CaseMaterial CaseMaterial { get; private set; }

        public override string ToString() {
            return "Case with materail : " + CaseMaterial;
        }
    }

    public enum CaseMaterial {
        Plastic,
        Metal
    }
}
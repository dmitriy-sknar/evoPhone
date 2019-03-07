using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public class MaterialCase : BaseCase{

        /// <summary>
        /// Phone Case with material specified.
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="caseMaterial"></param>
        public MaterialCase(int height, int width, int length, CaseMaterial caseMaterial) : base(height, width, length, caseMaterial)
        {
            this.CaseMaterial = caseMaterial;
        }

        private CaseMaterial caseMaterial;

        public CaseMaterial CaseMaterial
        {
            get { return caseMaterial; }
            set { caseMaterial = value; }
        }
 
        public override string ToString() {
            return "Case with materail : " + CaseMaterial;
        }
    }

    public enum CaseMaterial {
        Plastic,
        Metal
    }
}


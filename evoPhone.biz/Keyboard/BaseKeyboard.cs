using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {

    public class BaseKeyboard : IPhonePart {
        /// <summary>
        /// Basic keyboard with English alphabet
        /// </summary>
        public BaseKeyboard()
        {
            this.Figures = new int[] {1,2,3,4,5,6,7,8,9,0};
            this.Letters = new char[]
            {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                'A','B','C','D','E','F','G','H','I','G','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                ' ','_','!','?','@','%','$','#','(',')'
            };
        }

        /// <summary>
        /// Basic keyboard 
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="letters"></param>
        public BaseKeyboard(int[] figures, char[] letters)
        {
            this.Figures = figures;
            this.Letters = letters;
        }

        private int[] figures;

        public int[] Figures
        {
            get { return figures; }
            set { figures = value; }
        }

        private char[] letters;

        public char[] Letters
        {
            get { return letters; }
            set { letters = value; }
        }
        public override string ToString() {
            return "Base Keyboard";
        }
    }
}

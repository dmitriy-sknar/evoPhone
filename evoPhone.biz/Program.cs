using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    class Program {
        static void Main(string[] args)
        {
            PhoneBuilder builder;
            PhoneConstructor phoneConstructor = new PhoneConstructor();

            builder = new SimCorpPhoneBuilder();
            phoneConstructor.Construct(builder);
            builder.Mobile.GetDescription();

            Console.ReadKey();
        }
    }
}

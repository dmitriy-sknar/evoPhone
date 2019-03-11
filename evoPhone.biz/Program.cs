using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using evoPhone.biz.Builder;

namespace evoPhone.biz {
    class Program {
        private PhoneBuilder builder;

        static void Main(string[] args) {
            PhoneBuilder builder = new SimCorpPhoneBuilder();
            var phoneConstructor = new PhoneConstructor(builder);

            phoneConstructor.Construct();
            var mobile = builder.GetMobile;
            mobile.SetAllActive();
            Console.WriteLine(mobile);

            builder = new BlueBayPhoneBuilder();
            phoneConstructor = new PhoneConstructor(builder);

            phoneConstructor.Construct();
            mobile = builder.GetMobile;
            mobile.SetAllActive();
            mobile.SetScreenOff();
            Console.WriteLine(mobile);

            Console.ReadKey();
        }
    }
}
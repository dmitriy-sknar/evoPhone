using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz
{

    public class Mobile {
        public string PhoneModel { get; }
        private Dictionary<string, IPhonePart> parts = new Dictionary<string, IPhonePart>();

        public Mobile(string phoneModel) {
            this.PhoneModel = phoneModel;
        }
        
        public IPhonePart this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public void GetDescription() {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Phone Model: {0}",   PhoneModel);
            Console.WriteLine(" Screen : {0}",      parts["screen"].ToString());
            Console.WriteLine(" Case : {0}",        parts["case"].ToString());
            Console.WriteLine(" Keyboard : {0}",    parts["keyboard"].ToString());
            Console.WriteLine(" Dynamic : {0}",     parts["dynamic"].ToString());
            Console.WriteLine(" Battery : {0}",     parts["battery"].ToString());
            Console.WriteLine(" Microphone : {0}",  parts["microphone"].ToString());
            Console.WriteLine(" SimCard : {0}",     parts["simcard"].ToString());
            Console.WriteLine("\n---------------------------");
        }
    }
}
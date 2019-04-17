using System.Collections.Generic;

namespace evoPhone.biz.Contacts {
    public class Contact {
        public Contact(string name, long mainNumber) {
            Name = name;
            MainNumber = mainNumber;
            Numbers = new List<long> {MainNumber};
        }
        public string Name { get; }
        public long MainNumber { get; }
        public List<long> Numbers { get; }
        public void AddNumber(long number) { Numbers.Add(number); }
    }
}

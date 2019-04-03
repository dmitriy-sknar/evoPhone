namespace evoPhone.biz.PhoneParts.Contacts {
    public class Contact {
        public Contact(string name, long number) {
            Name = name;
            Number = number;
        }
        public string Name { get; }
        public long Number { get; }

    }
}

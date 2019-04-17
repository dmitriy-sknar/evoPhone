using System;
using System.Collections.Generic;
using evoPhone.biz.Contacts;

namespace evoPhone.biz.PhoneParts.SMS {
    public class Message {
        public Contact Contact { get; set; }
        public string Text { get; set; }
        public DateTime ReceivingTime { get; set; }

        public Message(int contactNumber, string text, DateTime receivingTime) {
            Contact = GetContact(contactNumber);
            Text = text;
            ReceivingTime = receivingTime;
        }

        private Contact GetContact(int contactNumber) {
            //dummy stub of ContactName db
            List<Contact> contactsDb = new List<Contact>() {
                new Contact("Billy Jones", 380671234560),
                new Contact("Farrokh Bulsara", 380680000001),
                new Contact("Vitaliy Klitchko, the Orator", 380509876540),
                new Contact("Unknown contact", 380630000002)
            };
            if (contactNumber > 3) return contactsDb[3];
            return contactsDb[contactNumber];
        }

        public override string ToString() {
            return $">>>>>>>>> Received on: {ReceivingTime}\nContact number:{Contact.MainNumber};\n{Contact.Name}: {Text}\n";
        }
    }
}
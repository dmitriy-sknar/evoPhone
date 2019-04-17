using System.Collections;

namespace evoPhone.biz.Contacts {
    public class ContactsListProvider {
        private ArrayList vList;

        public ContactsListProvider() {
            GetContactsFromDB();
        }

        //DB stub
        private ArrayList GetContactsFromDB() {
            vList = new ArrayList();
            Contact contact1 = new Contact("John Travolta", 380670000001);
            contact1.AddNumber(380670000002);
            contact1.AddNumber(380670000003);
            Contact contact2 = new Contact("Bill Gates", 380681111111);
            contact2.AddNumber(380681111112);
            contact2.AddNumber(380681111113);
            Contact contact3 = new Contact("Billy Jean", 380972222221);
            contact3.AddNumber(380972222222);
            contact3.AddNumber(380972222223);
            Contact contact4 = new Contact("Albert Einstein", 380993333331);
            contact4.AddNumber(380993333332);
            contact4.AddNumber(380993333333);
            Contact contact5 = new Contact("Leonardo Da Vinci", 380504444441);
            contact5.AddNumber(380504444442);
            contact5.AddNumber(380504444443);
            Contact contact6 = new Contact("Abraham Lincoln", 380635555551);
            contact6.AddNumber(380635555552);
            Contact contact7 = new Contact("Sir Isaac Newton", 380506666661);

            vList.Add(contact1);
            vList.Add(contact2);
            vList.Add(contact3);
            vList.Add(contact4);
            vList.Add(contact5);
            vList.Add(contact6);
            vList.Add(contact7);

            return vList;
        }

        public ArrayList GetList() {
            return vList;
        }
    }
}
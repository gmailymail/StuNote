using StuNote.Domain.Btos.Address;
using StuNote.Domain.Btos.Contact;

namespace StuNote.Domain.Btos.Person
{

    public abstract record PersonBto : BtoBase
    {
        public PersonBto()
        {
            ContactInfo = new();
            Billing = new();
            Shipping = new();
        }
        public string Number { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public ContactBto ContactInfo { get; private set; }
        public AddressBto Billing { get; private set; }
        public AddressBto Shipping { get; private set; }
    }
}

using Microsoft.Azure.Amqp.Framing;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookManagement_System
{
    class AddressBookBuilder
    {
        public List<Data> list;
        public AddressBookBuilder()
        {
            this.list = new List<Data>();
        }
        public void AddContact(Info contact)
        {
            this.list.Add(contact);
        }
        public void Display_Contacts()
        {
            Console.WriteLine("Contacts in Address Books System: ");

            foreach (var i in this.list)
            {
                Console.WriteLine(value:"{i.first_name} : {i.last_name} : {i.address} : {i.city} : {i.state} : {i.Pincode} : {i.Phone_No}");
            }
        }

    }
}

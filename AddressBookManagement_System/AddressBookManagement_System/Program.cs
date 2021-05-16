using System;

namespace AddressBookManagement_System
{
    class Program
    {
        int PinCode;
        long Phone_No;
        String first_name, last_name, address, city, state;
        public void Enter(Info contact)
        {
            Console.Write("Enter First Name: ");
            first_name = (Console.ReadLine());
            Console.Write("Enter Last Name: ");
            last_name = (Console.ReadLine());
            Console.Write("Enter Address: ");
            address = (Console.ReadLine());
            Console.Write("Enter City: ");
            city = (Console.ReadLine());
            Console.Write("Enter State: ");
            state = (Console.ReadLine());
            Console.Write("Enter Pincode: ");
            PinCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number: ");
            Phone_No = Convert.ToInt64(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine("" + first_name + "\t" + last_name + "\t" + address + "\t" + city + "\t" + state + "\t" + PinCode + "\t" + Phone_No);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookBuilder addressbook = new AddressBookBuilder();
            Program addressbooks = new Program();
            int choice = 1;
            while (choice != 3)
            {
                Console.WriteLine("Menu : \n 1.Add_Contact \n 2.Display_Contact \n 3.Exit ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Info contact = new Info();
                        addressbooks.Enter(contact);
                        addressbook.AddContact(contact);
                        Console.WriteLine("Contact Added Successfully.");
                        break;
                    case 2:
                        addressbook.Display_Contacts();
                        break;
                    case 3:
                        Console.WriteLine("Program Exited");
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            }
        }
    }
}

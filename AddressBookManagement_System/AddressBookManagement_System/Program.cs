using System;

namespace AddressBookManagement_System
{
    class Program
    {
        int PinCode;
        long Phone_No;
        String first_name, last_name, address, city, state;
        public void Enter()
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
            Console.WriteLine("Contact Details Are ");
            Program details = new Program();
            details.Enter();
            details.Show();
        }
    }
}

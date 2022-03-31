using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class CreateContacts
    {
        public void contactcreate()
        { 

            string firstName, lastName, Address, City, State, Email;   //variable
            int zip, phoneNumber;  // integer variable eg:-1,2,3...


            Console.WriteLine("Enter your First Name : ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            City = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            State = Console.ReadLine();
            Console.WriteLine("Enter your Email Address: ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            phoneNumber = Convert.ToInt32(Console.ReadLine());
                                                                 // print all records input data
            Console.WriteLine(" your  Name : "+firstName+lastName);
            Console.WriteLine("Address:"+Address);
            Console.WriteLine("Your city:"+City);
            Console.WriteLine("Your state:"+Email);
            Console.WriteLine("your zip code:"+zip);
            Console.WriteLine("Your phone number:"+phoneNumber);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegistrationExample
{
    class Utility
    {
        public string RegExUtility()
        {
            //Standard String
            string StandardMessage = "Hello << name >>, We have your full name as <<full name>> in our " +
                "system.your contact number is 91-xxxxxxxxxx.Please, let us know in case of any clarification " +
                "Thank you BridgeLabz 01/01/2016.";
            //RegEx formats for MobileNumber
            Regex MobileNumberFormat = new Regex("^[1-9]{1}[0-9]{9}$");
            //regex format for Name
            Regex NameFormat = new Regex("^[a-zA-Z]{3,20}$");
            Console.WriteLine("Enter Your First Name");
            string FirstName = Console.ReadLine();
            //if name format not matches regex then it returns the error else enter to next step
            if (NameFormat.IsMatch(FirstName))
            {
                Console.WriteLine("Enter Your Last Name");
                string LastName = Console.ReadLine();
                //if name format not matches regex then it returns the error else enter to next step
                if (NameFormat.IsMatch(LastName))
                {
                    Console.WriteLine("Enter Your Mobile Number");
                    string PhoneNumber = Console.ReadLine();
                    //if Mobile Number format not matches regex then it returns the error else enter to next step
                    //and returns String to display
                    if (MobileNumberFormat.IsMatch(PhoneNumber))
                    {
                        StandardMessage = StandardMessage.Replace("<< name >>", FirstName);
                        StandardMessage = StandardMessage.Replace("<<full name>>", FirstName + " " + LastName);
                        StandardMessage = StandardMessage.Replace("xxxxxxxxxx", PhoneNumber);
                        StandardMessage = StandardMessage.Replace("01/01/2016", DateTime.Now.ToString(@"dd\/MM\/yyyy"));
                        return StandardMessage;
                    }
                    else
                        return "Your Mobile Number is Not in the Number Format";
                }
                else
                    return "Your Last Name is Not in the Charector Format";
            }
            else
            {
                return "Your First Name is Not in the Charector Format";
            }
        }
    }
}
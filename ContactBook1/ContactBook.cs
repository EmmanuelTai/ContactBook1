using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace ContactBook1
{
    public class ContactBook
    {

        Dictionary<string, string> contactBook = new Dictionary<string, string>();


        public string AddContact(string name, string phoneNo)
        {

            contactBook.Add(name, phoneNo);

            if (contactBook.ContainsKey(name))
            {
                return "ERROR!  Contact already exists";
            }
            else
            {
                return "Contact Successfully added";
            }

        }

    
    
        public string RemoveContact(string name)
        {
            contactBook.Remove(name);
            return "Contact Removed";
        }
    
        
        public string FindContactByName (string name)
        {
            if (contactBook.ContainsKey(name))
            {
                return "Contact Exists";
            }
            else
            {
                return "Contact Not Found";
            }
        }

        public void ListAllContacts()
        {
               foreach(var contact in contactBook)
               {
                Console.WriteLine(contact.Key + " : " + contact.Value);
               }
        }
        
        public void ExitProgram()
        {
            Environment.Exit(0);
        }
        
    
    
    }








}

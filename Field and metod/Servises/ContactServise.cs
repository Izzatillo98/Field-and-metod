using Field_and_metod.Models;

namespace Field_and_metod.Servises
{
    internal class ContactServise
    {
        private Contact[] contacts = new Contact[10];
        
        public void PopulateContacts()

        {
            contacts[0] = new Contact
            {
                Phone = "933718998",
                Name = "Tillo"
            };

            contacts[1] = new Contact
            {
                Phone = "972140207",
                Name = "Dadam"
            };
        }

        public void ShowAllDate()
        {
            foreach (Contact contact in contacts ) 
            {
                Console.WriteLine(contact.Name);
                Console.WriteLine(contact.Phone);
            }
            
        }
       
    }
    
}

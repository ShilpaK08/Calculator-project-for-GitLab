using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestingTestverktygLektion7
{
    public class Name
    {
        public string firstName;
        public string lastName { get; set; }
        /*prop*/

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public void setFirstName(string name)
        {
            if (!name.Equals(""))
            {
                firstName = name;
            }
        }

        public void setFirstNameThrowsError(string name)
        {
            if (name.Equals(""))
            {
                throw new ArgumentException("No name");
            }
            firstName = name;
        }
        
        public Name NameFactory(string socialSecurityNumber)
        {
            if (!string.IsNullOrEmpty(socialSecurityNumber))
            {
                Person person = new Person();
                person.SocialSecurityNumber = socialSecurityNumber;
                return person;
            }
            return new Name();
        }
    }
}

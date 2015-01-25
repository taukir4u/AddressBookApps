using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBookApps
{
    class AddressBook
    {
        private List<Person> personsList = new List<Person>();
        private int indexForEditPerson = -1;
        public string SetAddressInfo(Person aPerson)
        {
            if (HasThisEmailAlreadySystem(aPerson))
            {
                if (CheckEmailFormat(aPerson))
                {
                    personsList.Add(aPerson);
                    return "Person Information successfully saved";
                }
                return "Email format is not correct";
            }
            return "This email already in system";
        }

        private bool CheckEmailFormat(Person aPerson)
        {
            Regex re = new Regex(@"^[a-zA-Z0-9._]{1,20}[@][a-zA-Z0-9]{1,20}[.][a-zA-Z]{2,4}$");
            if (re.IsMatch(aPerson.Email))
                return true;
            return false;
        }

        private bool HasThisEmailAlreadySystem(Person aPerson)
        {
            foreach (Person person in personsList)
            {
                if (person.Email == aPerson.Email)
                    return false;
            }
            return true;
        }


        public List<Person> GetAllPersons()
        {
            return personsList.ToList();
        }

        public Person GetMatchEmail(string email)
        {
            int count = 0;
            foreach (Person person in personsList)
            {
                if (person.Email == email)
                {
                    indexForEditPerson = count;
                    return person;
                }
                count++;
            }
            throw new Exception("Email not match to any address");
        }

        public List<Person> GetListByFirstName(string firstName)
        {
            List<Person> aList = new List<Person>();
            foreach (Person aPerson in personsList)
            {
                if ((aPerson.FirstName ?? "").Contains(firstName))
                {
                    aList.Add(aPerson);
                }
            }
            return aList;
        }

        public List<Person> GetListByLastName(string lastName)
        {
            List<Person> aList = new List<Person>();
            foreach (Person aPerson in personsList)
            {
                if ((aPerson.LastName ?? "").Contains(lastName))
                {
                    aList.Add(aPerson);
                }
            }
            return aList;
        }

        public List<Person> GetListByEmail(string email)
        {
            List<Person> aList = new List<Person>();
            foreach (Person aPerson in personsList)
            {
                if ((aPerson.Email ?? "").Contains(email))
                {
                    aList.Add(aPerson);
                }
            }
            return aList;
        }

        public List<Person> GetListByMobile(string mobile)
        {
            List<Person> aList = new List<Person>();
            foreach (Person aPerson in personsList)
            {
                if ((aPerson.Mobile ?? "").Contains(mobile))
                {
                    aList.Add(aPerson);
                }
            }
            return aList;
        }

        public string UpdatePerson(Person aPerson)
        {
            Person removePerson = personsList[indexForEditPerson];
            personsList.RemoveAt(indexForEditPerson);
            if (HasThisEmailAlreadySystem(aPerson))
            {
                if (CheckEmailFormat(aPerson))
                {
                    personsList.Insert(indexForEditPerson,aPerson);
                    return "Person Information successfully update";
                }
                personsList.Insert(indexForEditPerson, removePerson);
                return "Update Email format is not correct";
            }
            personsList.Insert(indexForEditPerson, removePerson);
            return "Update email already in system";
        }
    }
}

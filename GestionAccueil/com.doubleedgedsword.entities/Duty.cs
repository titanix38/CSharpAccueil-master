using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAccueil.com.doubleedgedsword.entities
{
    class Duty : Entity
    {
        private List<Person> people = new List<Person>();
        private Person[] onDuty = new Person[3];

        public List<Person> getAll()
        {
            return people;
        }

        public void addPerson(Person p1, Person p2,Person p3)
        {
            onDuty[0] = p1;
            onDuty[1] = p2;
            onDuty[2] = p3;
        }

        public Person getByFirstName(string fn)
        {            
            foreach(Person p in people)
            {
                if (p.FirstName == fn)
                {                    
                    return p;
                }
            }

            return null;
        }

        public Person getById(int id)
        {
            foreach (Person p in people)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAccueil.com.doubleedgedsword.entities
{
    class Person : Entity
    {
        private int id;
        private string lastName;
        private string firstName;
        private string phoneNumber;
        
        public new int Id { get; set; }

        public string LastName { get ; set ; }

        public string FirstName { get; set; }

        public string PhoneNumber { get; set; }    
    }
}

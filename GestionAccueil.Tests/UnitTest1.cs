using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionAccueil.com.doubleedgedsword.entities;
using System.Collections.Generic;

namespace GestionAccueil.Tests
{
    [TestClass]
    public class PeopleTest
    {
        [TestMethod]
        public void TestaddUser()
        {
            Person p = new Person();
            List<Person> lp = new List<Person>();
        
            p.Id = 1;
            p.FirstName = "Lolo";
            p.LastName = "TOTO";

            lp.Add(p);

            p.Id = 2;
            p.FirstName = "Lala";
            p.LastName = "TATA";

            lp.Add(p);

            Assert.AreEqual(2, lp.Count);
        }
    }
}

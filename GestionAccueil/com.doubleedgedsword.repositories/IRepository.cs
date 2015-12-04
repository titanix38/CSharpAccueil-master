using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAccueil.com.doubleedgedsword.repositories
{
    interface IRepository<Entities>
    {
        List<Entities> getAll();

        Entities getById(int id);
    }
}

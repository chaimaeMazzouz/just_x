using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_mines.Classes
{
    public class Type_Permis
    {
        public int Id { get; set; }
        public string Type { get; set; }
        //les relations
        public List<Permis> Les_Permis { get; set; }
    }
}

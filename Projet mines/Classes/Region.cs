using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_mines.Classes
{
    public class Region
    {
        public int Id { get; set; }
        public string Nom_Region { get; set; }
        public List<Province> Provinces { get; set; }
    }
}

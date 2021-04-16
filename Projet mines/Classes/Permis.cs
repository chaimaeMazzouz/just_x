using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_mines.Classes
{
    class Permis
    {
        public int id { get; set; }
        public int num_demmande { get; set; }
        public int num_permis{ get; set; }
        public DateTime date_depot { get; set; }
        public double investisement_projet { get; set; }
        public string occupation_temporaire { get; set; }
        public DateTime date_institition { get; set; }
        public DateTime echeance { get; set; }
        public double investisement_realise { get; set; }
        public bool inscription_conservation { get; set; }
        public DateTime date_depart_CRI { get; set; }
        public DateTime date_retour_CRI { get; set; }
        public DateTime date_decision { get; set; }
        public DateTime date_enquete { get; set; }
        public DateTime date_rapot { get; set; }
    }
}
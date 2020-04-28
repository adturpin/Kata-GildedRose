using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class Rapport
    {
        protected Rapport()
        {
            
        }
    }
    public class Rapport<T> : Rapport where  T : Item 
    {

        public List<RapportSection<T>> Sections { get; private set; }

        public Rapport()
        {
            Sections = new List<RapportSection<T>>();
        }

        public RapportSection<T> CreateSection(int jourDuRapport, IList<T> list)
        {
            return new RapportSection<T>(jourDuRapport, list);
        }

        public void AjouterSection(RapportSection<T> section)
        {
            Sections.Add(section);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GildedRose
{
    public class RapportSection<T> where T: Item
    {
        public int JourDuRapport { get; private set; }
        private IList<T> list;

        public RapportSection(int jourDuRapport)
        {
            this.JourDuRapport = jourDuRapport;
        }
        public RapportSection(int jourDuRapport, IList<T> list) 
            : this(jourDuRapport)
        {
            this.list = list;
        }

        public string GetHeader()
        {
            PropertyInfo[] propertyInfos = typeof(T).GetProperties();
            return String.Join(", " ,propertyInfos.Select(propertyInfo => propertyInfo.Name));
        }

        public IList<T> GetDataItems()
        {
            return  new List<T>(list);
        }
    }
}
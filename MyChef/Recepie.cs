using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChef
{
    public class Recepie
    {
        public string Name { get; set; }
        public string Context { get; set; }
        public int totalTime { get; set; }
        public string Category { get; set; }
        public string Taste { get; set; }
        public int totalPersons { get; set; }
        public List<Recepie> Recepies;

        public Recepie (string name, string context, int time, string category, string taste, int persons)
        {
            Name = name;
            Context = context;
            totalTime = time;
            Category = category;
            Taste = taste;
            totalPersons = persons;
            Recepies = new List<Recepie>();
        }
        public override string ToString()
        {
            return string.Format("{0} - подготовка за: {1} минути", Name, totalTime);
        }

        public void AddRecepie(Recepie recepie)
        {
            Recepies.Add(recepie);
        }

        public List<Recepie> getAll()
        {
            return Recepies;
        }
    }
}

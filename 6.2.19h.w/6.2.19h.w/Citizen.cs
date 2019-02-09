using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._19h.w
{
    class Citizen
    {
        public string name;
        public Citizen[] children;
        public int fatherId;
        public readonly int id=1;
        public static int numberOfCurrentCitizens;
        public const int maximumNumberOfCitizens=50;

        public Citizen(string name, int fatherId)
        {
            this.name = name;
            this.fatherId = fatherId;
            this.id++;
            numberOfCurrentCitizens++;
        }
        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine($"Number of current citizens:{Citizen.numberOfCurrentCitizens}");
        }
        public static bool ReachedHalfOfMaximumSize()
        {
            if (numberOfCurrentCitizens >= maximumNumberOfCitizens)
            {
                return true;
            }
            else
                return false;
        }
        public void PrintId()
        {
            Console.WriteLine($"ID number:{this.id}");
        }
        public void PrintGapBetweenMyIDAndFather()
        {
            int gap = this.id - this.fatherId;
            Console.WriteLine($"The gap between my ID and my father:{gap}");
        }
        public void SetChildren(Citizen[]c)
        {
            this.children = new Citizen[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                this.children[i].name = c[i].name;
                this.children[i].fatherId = c[i].fatherId;
            }
        }

        public override string ToString()
        {
            return $"Citizen name:{this.name},ID:{this.id},father ID:{this.fatherId},number of current citizens:{Citizen.numberOfCurrentCitizens}";
        }
    }
}

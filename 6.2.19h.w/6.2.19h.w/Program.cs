using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._19h.w
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen Noam = new Citizen("Noam", 5);
            
            Citizen Bob = new Citizen("Bob", 1);
            Citizen Alma = new Citizen("Alma", 1);
            Citizen Shir = new Citizen("Shir", 1);
            Citizen[] citizens = { Bob, Alma, Shir };
            Noam.SetChildren(citizens);
            Console.WriteLine(Noam);
            Console.WriteLine(HasChildren(Noam));
            Console.WriteLine(ChekValidity(Noam));

            

        }
        public static bool HasChildren(Citizen b)
        {
            int NumberOfChildren = 0;
            for (int i = 0; i <b.children.Length; i++)
            {
                if(b.children[i].name!=null)
                {
                    NumberOfChildren++;
                }
            }
            if (NumberOfChildren==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ChekValidity(Citizen b)
        {
            int father = 0;
            if (HasChildren(b) == true)
            {
                for (int i = 0; i < b.children.Length; i++)
                {
                    if (b.children[i].fatherId == b.id)
                    {
                        father++;
                    }
                }
                if (b.children.Length == father)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}

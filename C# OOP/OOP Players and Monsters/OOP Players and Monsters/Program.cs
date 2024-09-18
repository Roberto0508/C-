using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Players_and_Monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Hero1", 1);
            Console.WriteLine(hero.ToString());

            Elf elf = new Elf("Elf1", 2);
            Console.WriteLine(elf.ToString());

            MuseElf museElf = new MuseElf("MuseElf1", 3);
            Console.WriteLine(museElf.ToString());
        }
    }
}

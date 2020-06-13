using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._06._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //9,feladat: Írjunk programot, amely bekéri két pont koordinátáit, 
            //majd kiszámolja azok távolságát.
            Console.Write("Kérem adjon meg az első pont x koordinátáját: ");
            int x1  = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg az első pont y koordinátáját: ");
            int y1  = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg az második pont x koordinátáját: ");
            int x2  =  int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg az második pont y koordinátáját: ");
            int y2  =  int.Parse(Console.ReadLine());
            double pont_tavolsag = Math.Sqrt((x1  -  x2)  *  (x1  -  x2)  +  (y2  -  y1)  *  (y2  -  y1));
            Console.WriteLine($"A két pont közötti távolság: {pont_tavolsag} ");

            //10.feladat: Készítsünk programot, amely bekéri a víz hőmérsékletét, majd eldönti, 
            //hogy az milyen halmazállapotú. A halmazállapot lehet folyékony, gőz, vagy jég.
            Console.Write("Kérem adjon -50 és 200 fok közötti értéket: ");
            int fok  =  int.Parse(Console.ReadLine());
            if (fok == 0)
            {
                Console.WriteLine("A 0-fok lehet jég és folyékony halmazállapotú!");
            }
            if (fok >0 && fok<100)
            {
                Console.WriteLine($"{fok}-on a halmazállapot folyékony!");
            }
            if (fok>=100)
            {
                Console.WriteLine($"{fok}-on a halmazállapot gőz!");
            }
            if (fok<0)
            {
                Console.WriteLine($"{fok}-on a halmazállapot jég!");
            }

            //11.feladat:Írj programot C# nyelven, amely bekér a felhasználótól egy kezdő és végző egész számot, 
            //majd kiírja a közöttük lévé egész számokat is, beleértve a kezdő és végző számokat is! 
            //A program elkészíthető while és for ciklussal is!
            Console.Write("Kérem adjon meg egy kezdő egész számot: ");
            int kezdo  =  int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy végző egész számot: ");
            int vegzo = int.Parse(Console.ReadLine());
            /*for (int i = kezdo; i <= vegzo; i++)
            {
                Console.Write($"{i} ");
            }*/
            int szamlalo = kezdo;
            while (szamlalo <= vegzo)
            {
                Console.Write($"{szamlalo} ");
                szamlalo++;
            }
            Console.ReadKey();

        }
    }
}

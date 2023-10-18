using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upravljanjeGreskama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godRod;
            bool kontrola = false;
            do
            {
                Console.Write("Upisi svoju godinu rodenja");
                try
                {
                    godRod = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Roden si " + godRod + "godine");
                    kontrola = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    kontrola=false;
                }
            } while (kontrola == true);
            Console.ReadKey();
        }
    }
}

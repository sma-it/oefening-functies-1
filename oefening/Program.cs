using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int oefreeksNr;
            do
            {
                Console.WriteLine("Nummer oefeningenreeks? (1-2-3)");
                oefreeksNr = Convert.ToInt32(Console.ReadLine());
                if (oefreeksNr != 1 && oefreeksNr != 2 && oefreeksNr != 3)
                {
                    Console.WriteLine("Ongeldig nummer");
                    continue;
                }
                else
                {
                    break;
                }

            } while (true);
            Console.WriteLine();


            switch (oefreeksNr) 
            {
                case 1: // !!!Verwijder de commentaartag voor de oefening(en) die je wil testen!!!

                    //Console.WriteLine("ZetOmCm \t\t 24.13 \t\t\t " + Oef1_functies.ZetOmCm(9.5f));

                    //Console.WriteLine("BerekenOppRh \t\t 41.34 \t\t\t " + Oef1_functies.BerekenOppRh(5.3, 7.8));

                    //Console.WriteLine("BerekenBoete \t\t 1.05 \t\t\t " + Oef1_functies.BerekenBoete(3, 5));
                    //Console.WriteLine("BerekenBoete \t\t 1.35 \t\t\t " + Oef1_functies.BerekenBoete(3, 5, 0.09));

                    //Console.WriteLine("BerekenTelKost \t\t 0.75 \t\t\t " + Oef1_functies.BerekenTelKost(50));
                    //Console.WriteLine("BerekenTelKost \t\t 1.2 \t\t\t " + Oef1_functies.BerekenTelKost(105));
                    //Console.WriteLine("BerekenTelKost \t\t 0.9 \t\t\t " + Oef1_functies.BerekenTelKost(50, 0.90));
                    //Console.WriteLine("BerekenTelKost \t\t 1.35 \t\t\t " + Oef1_functies.BerekenTelKost(105, 0.90));

                    //Console.WriteLine("BepaalVolgendPriemgetal  59 \t\t\t " + Oef1_functies.BepaalVolgendPriemgetal(54));
                    //Console.WriteLine("BepaalVolgendPriemgetal  11 \t\t\t " + Oef1_functies.BepaalVolgendPriemgetal(7));

                    //Console.WriteLine("BerekenBmi \t\t 21.7 \t\t\t " + Oef1_functies.BerekenBmi(65, 1.73));

                    //Console.WriteLine("BoodschapBmi \t\t Ondergewicht \t\t " + Oef1_functies.BoodschapBmi(55, 1.73));
                    //Console.WriteLine("BoodschapBmi \t\t Gezond gewicht \t " + Oef1_functies.BoodschapBmi(70, 1.73));
                    //Console.WriteLine("BoodschapBmi \t\t Overgewicht \t\t " + Oef1_functies.BoodschapBmi(80, 1.73));
                    //Console.WriteLine("BoodschapBmi \t\t Obesitas \t\t " + Oef1_functies.BoodschapBmi(120, 1.73));

                    break;

                case 2: // !!!Verwijder de commentaartag voor de oefening(en) die je wil testen!!!

                    //Console.WriteLine("IsNatuurlijkGetal overload1 \t false \t\t\t" + Oef2_functies.IsNatuurlijkGetal(3.5));
                    //Console.WriteLine("IsNatuurlijkGetal overload1 \t true \t\t\t" + Oef2_functies.IsNatuurlijkGetal(3));

                    //Console.WriteLine("IsNatuurlijkGetal overload2 \t false \t\t\t" + Oef2_functies.IsNatuurlijkGetal(3.5, 6));
                    //Console.WriteLine("IsNatuurlijkGetal overload2 \t true \t\t\t" + Oef2_functies.IsNatuurlijkGetal(3, 4));
                    //Console.WriteLine("IsNatuurlijkGetal overload2 \t false \t\t\t" + Oef2_functies.IsNatuurlijkGetal(3.1, 4.5));

                    //Console.WriteLine("IsNatuurlijkGetal overload3 \t false \t\t\t" + Oef2_functies.IsNatuurlijkGetal(3.5, 6.1, 4));
                    //Console.WriteLine("IsNatuurlijkGetal overload3 \t true \t\t\t" + Oef2_functies.IsNatuurlijkGetal(3, 4, 5));
                    //Console.WriteLine("IsNatuurlijkGetal overload3 \t false \t\t\t" + Oef2_functies.IsNatuurlijkGetal(3.1, 3.2, 4.5));

                    //Console.WriteLine("ZijnIdentiek overload1 \t\t false \t\t\t" + Oef2_functies.ZijnIdentiek("zomer", "winter", "herfst"));
                    //Console.WriteLine("ZijnIdentiek overload1 \t\t true \t\t\t" + Oef2_functies.ZijnIdentiek("zomer", "Zomer", "zomer"));
                    //Console.WriteLine("ZijnIdentiek overload1 \t\t false \t\t\t" + Oef2_functies.ZijnIdentiek("zomer", "herfst", "zomer"));

                    //Console.WriteLine("ZijnIdentiek overload2 \t\t false \t\t\t" + Oef2_functies.ZijnIdentiek("zomer", "winter", "herfst", "lente"));
                    //Console.WriteLine("ZijnIdentiek overload2 \t\t true \t\t\t" + Oef2_functies.ZijnIdentiek("zomer", "Zomer", "zomer", "Zomer"));
                    //Console.WriteLine("ZijnIdentiek overload2 \t\t false \t\t\t" + Oef2_functies.ZijnIdentiek("zomer", "herfst", "zomer", "zomer"));

                    //Console.WriteLine("ZijnIdentiek overload3 \t\t false \t\t\t" + Oef2_functies.ZijnIdentiek(3, 4, 5));
                    //Console.WriteLine("ZijnIdentiek overload3 \t\t true \t\t\t" + Oef2_functies.ZijnIdentiek(3, 3, 3));
                    //Console.WriteLine("ZijnIdentiek overload3 \t\t false \t\t\t" + Oef2_functies.ZijnIdentiek(3, 4, 3));

                    //Console.WriteLine("ZijnIdentiek overload4 \t\t false \t\t\t" + Oef2_functies.ZijnIdentiek(3, 4, 5, 1));
                    //Console.WriteLine("ZijnIdentiek overload4 \t\t true \t\t\t" + Oef2_functies.ZijnIdentiek(3, 3, 3, 3));
                    // Console.WriteLine("ZijnIdentiek overload4 \t\t false \t\t\t" + Oef2_functies.ZijnIdentiek(3, 4, 6, 3));

                    break;

            }
            Console.ReadKey();
        }


    }
}


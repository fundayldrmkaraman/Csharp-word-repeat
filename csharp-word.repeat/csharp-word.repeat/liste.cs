using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_word.repeat
{
    class liste
    {
        public void BilgiGir()
        {
            try
            {
                Console.WriteLine("1.cumle giriniz:");
                string ilkCumle = Console.ReadLine();
                ilkCumle = ilkCumle.ToLower();
                string[] ilkcumle = ilkCumle.Split(' ');

                Console.WriteLine("2.cumle giriniz:");
                string ikiCumle = Console.ReadLine();
                ikiCumle = ikiCumle.ToLower();
                string[] ikicumle = ikiCumle.Split(' ');

                Console.WriteLine("3.cumle giriniz:");
                string ucCumle = Console.ReadLine();
                ucCumle = ucCumle.ToLower();
                string[] uccumle = ucCumle.Split(' ');

                string butunCumle = ilkCumle + "" + ikiCumle + "" + ucCumle;
                butunCumle = butunCumle.ToLower();
                string[] butuncumle = butunCumle.Split(' ');

                Console.WriteLine("Toplam Girilen sozcuk:" + (ilkcumle.Length + ikicumle.Length + uccumle.Length));

                HashSet<string> hs = new HashSet<string>(ilkcumle);

                for (int i = 0; i < ikicumle.Length; i++)
                {
                    hs.Add(ikicumle[i]);
                }
                for (int i = 0; i < uccumle.Length; i++)
                {
                    hs.Add(uccumle[i]);
                }

                Console.WriteLine("Farkli sozcuk adedi:" + hs.Count);
                Console.WriteLine("Sozcuk Frekansi:");
                int sayac, enfazla = 0;
                string kelime = "";
                for (int i = 0; i < butunCumle.Length; i++)
                {
                    sayac = 0;
                    for (int j = 0; j < butunCumle.Length; j++)
                    {
                        if (butunCumle[i] == butunCumle[j])
                        {
                            sayac++;
                        }
                    }
                    Console.WriteLine(butunCumle[i] + ":" + sayac);
                    if (sayac > enfazla)
                    {
                        enfazla = sayac;
                        kelime = butunCumle;
                    }
                }
                Console.WriteLine("En cok kullanılan sozcuk:" + kelime);
                Console.WriteLine("En cok kullanılan sozcuk frekansı:" + enfazla);
            }
            catch (Exception except)
            {
                throw new Exception("Yanlıs:" + except.Message);
            }

        }
    }
}

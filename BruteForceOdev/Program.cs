using System;
using System.IO;
using System.Linq;

namespace BruteForceOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kulanıcı adı = ADMİN");
            Console.WriteLine("Şifrenizi Giriniz");
            string sifre = Console.ReadLine();
            string DosyaYolu = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\sifreler.txt";
            StreamWriter Yaz = new StreamWriter(DosyaYolu);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Yardimci parametre giriniz");
            char[] cr = Console.ReadLine().ToArray();
            Console.WriteLine("----------------------------");
            string kelime = "";
            int deneme = 0;
            for (int t = 0; t < cr.Length; t++)
            {
                for (int i = 0; i < cr.Length; i++)
                {
                    for (int j = 0; j < cr.Length; j++)
                    {
                        for (int n = 0; n < cr.Length; n++)
                        {
                            for (int m = 0; m < cr.Length; m++)
                            {
                                deneme++;
                                kelime += cr[n];
                                kelime += cr[m];
                                kelime += cr[j];
                                kelime += cr[t];
                                kelime += cr[i];
                                if (File.Exists(DosyaYolu))
                                {
                                    Yaz.WriteLine(kelime);
                                }
                                else
                                {
                                    File.Create(DosyaYolu);
                                    Yaz.WriteLine(DosyaYolu);
                                }

                                //Console.Write(kelime + "\t");

                                kelime = "";

                            }
                        }
                    }
                }
            }
            
            Yaz.Close();
            deneme = 0;//şifrenin bulunduğu satırı bulmak için
            StreamReader sr = new StreamReader(DosyaYolu);
            string satir; //burada okuduğunuz her satırı atamamız için gerekli değişkeni tanımlıyoruz.
            while ((satir = sr.ReadLine()) != null) 
            {
                deneme++;
                Console.Write(satir+"\t");
                
                if (sifre==satir)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t"+"*********"+"şifreniz: "+satir);
                    Console.WriteLine("\t" + "*********" + "şifrenin bulunduğu satır: "+deneme);
                    break;
                }
            }
            sr.Close();

            Console.Read();

        }
    }
}

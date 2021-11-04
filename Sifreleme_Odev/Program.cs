using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifreleme_Odev
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            //metnin şiflrenemiş hali = charcevirisi dizisi


            string gecici = "";
            Console.WriteLine("Şifrelemek istediğiniz kelime veya cümleyi girin:");
            string sifrlenecekmetin = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------Şifreleme Kısmı---------------------------");
            Console.WriteLine();
            string siflrenemishali = "";

            char[] charcevirisi = sifrlenecekmetin.ToCharArray();
            Console.WriteLine();
            Console.WriteLine("***Büyük harfi küçüğe,Küçük harfi büyüğe dödürme ve Rakamları 9 a tamamalama***");
            Console.WriteLine();
            for (int i = 0; i < charcevirisi.Length; i++)
            {
                if (char.IsUpper(charcevirisi[i]))
                {
                    gecici = charcevirisi[i].ToString();
                    gecici = gecici.ToLower();
                    charcevirisi[i] = Convert.ToChar(gecici);
                    siflrenemishali += charcevirisi[i];


                }
                else
                {
                    gecici = charcevirisi[i].ToString();
                    gecici = gecici.ToUpper();
                    charcevirisi[i] = Convert.ToChar(gecici);
                    siflrenemishali += charcevirisi[i];

                }

                if (char.IsNumber(charcevirisi[i]) == true)
                {
                    if (charcevirisi[i] == '1')
                    {
                        charcevirisi[i] = '8';
                        continue;

                    }
                    if (charcevirisi[i] == '2')
                    {
                        charcevirisi[i] = '7';
                        continue;
                    }

                    if (charcevirisi[i] == '3')
                    {
                        charcevirisi[i] = '6';
                        continue;
                    }

                    if (charcevirisi[i] == '4')
                    {
                        charcevirisi[i] = '5';
                        continue;
                    }

                    if (charcevirisi[i] == '5')
                    {
                        charcevirisi[i] = '4';
                        continue;
                    }

                    if (charcevirisi[i] == '6')
                    {
                        charcevirisi[i] = '3';
                        continue;
                    }
                    if (charcevirisi[i] == '7')
                    {
                        charcevirisi[i] = '2';
                        continue;
                    }
                    if (charcevirisi[i] == '8')
                    {
                        charcevirisi[i] = '1';
                        continue;
                    }
                    if (charcevirisi[i] == '0')
                    {
                        charcevirisi[i] = '9';
                        continue;
                    }
                    if (charcevirisi[i] == '9')
                    {
                        charcevirisi[i] = '0';
                        continue;
                    }

                    siflrenemishali += charcevirisi[i];
                }

            }
            Console.WriteLine(siflrenemishali);
            int karakterno = 0;
            int fark = 0;
            Console.WriteLine();
            Console.WriteLine("***127 -ASCII Kod***");
            Console.WriteLine();
            for (int j = 0; j < charcevirisi.Length; j++)
            {
                karakterno = (int)charcevirisi[j];
                fark = (int)(127 - karakterno);

                string degis = fark.ToString();
                charcevirisi[j] = ((char)(int)fark);


            }
            
            Console.WriteLine(charcevirisi);
            Console.WriteLine();
            Console.WriteLine("***ASCII Kodda 15 karakter ileri kaydırma***");
            Console.WriteLine();
            siflrenemishali = "";
            foreach (var item in charcevirisi)
            {
                siflrenemishali += Convert.ToChar(item + 15).ToString();
            }
            Console.WriteLine(siflrenemishali);
            #region


            Console.WriteLine();
            Console.WriteLine("----------------Deşifreleme Kısmı---------------------------");
            Console.WriteLine();
            Console.WriteLine("***ASCII Kodda 15 karakter geri kaydırma***");


            string desifre = "";
            foreach (char item in siflrenemishali)
            {
                desifre += Convert.ToChar(item - 15).ToString();

            }
            Console.WriteLine(desifre);


            Console.WriteLine();

            #endregion

            int chardegeri;
            string yeni = "";

            Console.WriteLine("***ASCII Koddan normale dödürme*** ");
            for (int i = 0; i < desifre.Length; i++)
            {
                chardegeri = 127 - desifre[i];

                yeni += (char)chardegeri;


            }
            Console.WriteLine(yeni);
            Console.WriteLine();
            Console.WriteLine("***Büyük harfi küçüğe,Küçük harfi büyüğe dödürme ve Rakamları 9 a tamamlama***");
            Console.WriteLine();

            string gecici2 = "";
            char[] yeniMetin = yeni.ToCharArray();
            string cozulmusHali = "";
            for (int i = 0; i < yeniMetin.Length; i++)
            {
                if (char.IsUpper(yeni[i]))
                {
                    gecici2 = yeniMetin[i].ToString();
                    gecici2 = gecici2.ToLower();
                    yeniMetin[i] = Convert.ToChar(gecici2);
                    cozulmusHali += yeniMetin[i];
                }
                else
                {
                    gecici2 = yeniMetin[i].ToString();
                    gecici2 = gecici2.ToUpper();
                    yeniMetin[i] = Convert.ToChar(gecici2);
                    cozulmusHali += yeniMetin[i];

                }
                if (char.IsNumber(yeniMetin[i]))
                {
                    if (yeniMetin[i] == '8')
                    {
                        yeniMetin[i] = '1';

                        continue;

                    }
                    if (yeniMetin[i] == '7')
                    {
                        yeniMetin[i] = '2';
                        continue;
                    }

                    if (yeniMetin[i] == '6')
                    {
                        yeniMetin[i] = '3';
                        continue;
                    }

                    if (yeniMetin[i] == '5')
                    {
                        yeniMetin[i] = '4';
                        continue;
                    }

                    if (yeniMetin[i] == '4')
                    {
                        yeniMetin[i] = '5';
                        continue;
                    }

                    if (yeniMetin[i] == '3')
                    {
                        yeniMetin[i] = '6';
                        continue;
                    }
                    if (yeniMetin[i] == '2')
                    {
                        yeniMetin[i] = '7';
                        continue;
                    }
                    if (yeniMetin[i] == '1')
                    {
                        yeniMetin[i] = '8';
                        continue;
                    }
                    if (yeniMetin[i] == '9')
                    {
                        yeniMetin[i] = '0';
                        continue;
                    }
                    if (yeniMetin[i] == '0')
                    {
                        yeniMetin[i] = '9';
                        continue;
                    }
                }
            }
            Console.WriteLine(yeniMetin);
            Console.ReadLine();
        }
    }

}



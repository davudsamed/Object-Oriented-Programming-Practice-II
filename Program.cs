/****************************************************************************
**					    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI.......: 2
**				ÖĞRENCİ ADI.........: Davud Samed Tombul
**				ÖĞRENCİ NUMARASI....: B171210007
**              DERSİN ALINDIĞI GRUP: 1D grubu (İngilizce)
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RastgeleSayi = new Random();

            List<Futbolcu> takim = new List<Futbolcu>();//

            takim.Add(new Defans("Pique", 1));
            takim.Add(new Defans("Umtiti", 2));
            takim.Add(new Defans("Varane", 3));
            takim.Add(new Defans("Jordy Alba", 4));
            takim.Add(new Ortasaha("Mesut Özil", 5));
            takim.Add(new Ortasaha("Kevın De Bruyne", 6));
            takim.Add(new Ortasaha("Isco", 7));
            takim.Add(new Ortasaha("Schools", 8));
            takim.Add(new Forvet("Thierry Henry", 9));
            takim.Add(new Forvet("Pelé", 10));

            int FormaNo;
            Boolean gololabilir = true;
            int OncekiFormaNo = 0;//

            for (int i = 1; i <= 3; i++)
            {
                FormaNo = RastgeleSayi.Next(1, 10);


                if (!takim[FormaNo].PasVer())
                {
                    gololabilir = false;
                    break;
                }
                else if (OncekiFormaNo == FormaNo)
                {
                    gololabilir = false;
                    Console.WriteLine("Hatalı Pas!");
                    break;
                }
                Console.WriteLine("{0} Numaralı Oyuncudan Başarılı Pas", FormaNo);
                OncekiFormaNo = FormaNo;

            }

            if (gololabilir)
            {
                FormaNo = RastgeleSayi.Next(1, 11);
                if (takim[FormaNo].GolVurusu())
                {
                    Console.WriteLine("GOOOLLL!!!");
                }
                else
                {
                    Console.WriteLine("{0} Numaralı Oyuncu Bitirici Vuruşu Yapamadı", FormaNo);
                }

            }


            Console.ReadLine();
        }
    }
}


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
    class Defans : Futbolcu
    {
        public int PozisyonAlma;
        public int KafaVurusu;
        public int Sicrama;

        public override Boolean PasVer()
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + PozisyonAlma * 0.1 + Sans * 0.2;

            return PasSkor > 60;
        }

        public override Boolean GolVurusu()
        {
            double GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + KafaVurusu * 0.1 + Sicrama * 0.1 + Sans * 0.1;

            return GolSkor > 70;
        }

        private readonly Random random = new Random();// 

        public Defans(string AdSoyad, int FormaNo) : base(AdSoyad, FormaNo)
        {
            PozisyonAlma = random.Next(50, 90);
            KafaVurusu = random.Next(50, 90);
            Sicrama = random.Next(50, 90);

            Sut = random.Next(50, 90);
            Yetenek = random.Next(50, 90);
            Kararlilik = random.Next(50, 90);
            Hiz = random.Next(50, 90);
            Dayaniklilik = random.Next(50, 90);
            Pas = random.Next(50, 90);
            DogalForm = random.Next(50, 90);
            Sans = random.Next(50, 90);
        }

        public Defans()
        {

        }

    }

}
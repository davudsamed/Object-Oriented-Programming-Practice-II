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
    class Forvet:Futbolcu
    {
        public int Bitiricilik;
        public int IlkDokunus;
        public int KafaVurusu;
        public int OzelYetenek;
        public int SogukKanlilik;

        public override bool PasVer()
        {
           double PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;

            return PasSkor > 60;//
        }

        public override bool GolVurusu()
        {
            double GolSkor = Yetenek * 0.2 + OzelYetenek * 0.2 + Sut * 0.1 + KafaVurusu * 0.1 + IlkDokunus * 0.1 + Bitiricilik * 0.1 + SogukKanlilik * 0.1 + Kararlilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;

            return GolSkor > 70;
        }

        private readonly Random random = new Random();

        public Forvet(string AdSoyad, int FormaNo):base(AdSoyad,FormaNo)
        {
            OzelYetenek = random.Next(70, 100);
            SogukKanlilik = random.Next(70, 100);
            Bitiricilik = random.Next(70, 100);
            KafaVurusu = random.Next(70, 100);
            IlkDokunus = random.Next(70, 100);

            Kararlilik = random.Next(60, 100);
            DogalForm = random.Next(60, 100);
            Sans = random.Next(60, 100);
            FormaNo = random.Next(70, 100);//
            Hiz = random.Next(60, 100);
            Sut = random.Next(60, 100);
            Yetenek = random.Next(60, 100);
            Dayaniklilik = random.Next(60, 100);
            Pas = random.Next(60, 100);
            
        }

        public Forvet()
        {

        }

    }
}

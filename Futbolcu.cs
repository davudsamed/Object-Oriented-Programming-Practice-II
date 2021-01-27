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
    class Futbolcu
    {
        public string AdSoyad;
        public int FormaNo;
        public int Hiz;
        public int Dayaniklilik;
        public int Pas;
        public int Sut;
        public int Yetenek;
        public int Kararlilik;
        public int DogalForm;
        public int Sans;

        Random OyucuRandom = new Random();// 

        public virtual Boolean PasVer()
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2;

            return PasSkor > 60;// 
        }

        public virtual Boolean GolVurusu()
        {
            double GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2;

            return GolSkor > 70;//
        }

        Random random = new Random();

        public Futbolcu(string AdSoyad, int FormaNo)
        {
            this.FormaNo = FormaNo;
            this.AdSoyad = AdSoyad;
           

            Sut = random.Next(50, 100);
            Yetenek = random.Next(50, 100);
            Kararlilik = random.Next(50, 100);
            DogalForm = random.Next(50, 100);
            Hiz = random.Next(50, 100);
            Dayaniklilik = random.Next(50, 100);
            Pas = random.Next(50, 100);
            Sans= random.Next(50, 100);
        }

        public Futbolcu()
        {

        }

    }
}

namespace MusteriveSiparis
{
    class Siparis
    {
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }

        public Siparis(DateTime tarih, string durum)
        {
            Durum = durum;
            Tarih = tarih;
        }
    }

    class Urun
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }

        public Urun(string ad, string telefon)
        {
            Telefon = telefon;
            Ad = ad;
        }


        public void SiparisVer()
        {
            Console.WriteLine($"Ürün adı: {Ad} , Telefon no: {Telefon}");
        }
    }
}

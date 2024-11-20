namespace OkulVeOgrenci
{
    class Ogrenci
    {
        public string Ad { get; set; }
        private int Yas { get; set; }

        public Ogrenci(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;  
        }

        public void OgrenciBilgisi()
        {
            Console.WriteLine($"Öğrenci Adı: {Ad}, Yaş: {Yas}");
        }
    }

    class Okul
    {
        public string Ad { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public Okul(string ad)
        {
            Ad = ad;
            Ogrenciler = new List<Ogrenci>();
        }

        public void OgrenciOlustur(string ad, int yas)
        {
            Ogrenciler.Add(new Ogrenci(ad, yas));
        }
    }
}

namespace NtpOdevHafta6
{
    public class Kitap
    {
        public string Baslik { get; set; }
        public string ISBN { get; set; }

        public Kitap(string baslik, string isbn)
        {
            Baslik = baslik;
            ISBN = isbn;
        }
    }

    public class Yazar
    {
        string Ad { get; set; }
        string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Yazar(string ad, string ulke)
        {
            Ad = ad;
            Ulke = ulke;
            Kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            if (!Kitaplar.Contains(kitap))
            {
                Kitaplar.Add(kitap);

            }
        }
    }
}

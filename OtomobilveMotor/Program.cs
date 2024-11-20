namespace OtomobilveMotor
{
    class Motor
    {
        public string Tip { get; set; }
        private int Guc { get; set; }
        public Motor(string tip, int guc)
        {
            Tip = tip;
            Guc = guc;
        }

        public void MotorBilgisi()
        {
            Console.WriteLine($"Tip: {Tip}, Güç: {Guc}");
        }
    }

    class Otomobil
    {
        public string Marka { get; set; }
        public Motor Motor { get; set; }

        public Otomobil(string marka) 
        {
            Marka = marka;
            Motor = new Motor("Dizel motor", 150);
        }

        public void MotorOlustur(string tip, int guc)
        {
            Motor = new Motor(tip, guc);
            Console.WriteLine("Yeni bir motor oluşturuldu.");
        }
    }

}

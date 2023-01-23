namespace OOP_HomeWork_2
{
    public class Time
    {
        public int soat1 
        { 
            get 
            {
                return soat;
            } 
            set 
            {
                if (value <= 23 & value >= 0)
                {
                    soat = value;
                }
            } 
        }
        private int soat;
        public int minut1
        {
            get
            {
                return minut;
            }
            set
            {
                if (value <= 59 & value >= 0)
                {
                    minut = value;
                }
            }
        }
        private int minut;
        public int sekund1
        {
            get
            {
                return sekund;
            }
            set
            {
                if (value <= 59 & value >= 0)
                {
                    sekund = value;
                }
            }
        }
        private int sekund;

        public Time(int soat, int minut, int sekund)
        {
            this.soat1 = soat;
            this.minut1 = minut;
            this.sekund1 = sekund;
        }

        public void GetTimeInfo()
        {
            Console.WriteLine((soat < 10 ? "0"+soat : soat) + ":" + (minut < 10 ? "0" + minut : minut) 
                + ":" + (sekund < 10 ? "0" + sekund : sekund));
        }
    }
}

namespace OOP_HomeWork_2
{
    internal class Account
    {
        private string AccountNumber = "";
        public string AccountNumber1 
        {
            get
            {
                if (AccountNumber == "") return "0";
                return AccountNumber;
            }
            set
            {
                bool count = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if ((int)value[i] >= 48 && (int)value[i] <= 57 && value.Length >= 8)
                    {
                        count = true;
                    }
                    else
                    {
                        count = false;
                        break;
                    }
                }
                if (count) AccountNumber = value;
                else
                {
                    Console.WriteLine("Hisob raqam noto'g'ri kiritildi...");
                    Console.WriteLine();
                }

                //while (value != "12345678" && value != "87654321" && value != "19981205")
                //{
                //    Console.WriteLine("Hisob raqamni noto'g'ri kiritdingiz...");
                //    Console.Write("Qaytadan kiriting : ");
                //    value = Console.ReadLine()!;
                //    Console.WriteLine();
                //}
                //AccountNumber = value;
            }
        }

        private string fullNameOne = "Aliyev Vali";
        private string fullNameTwo = "Boltavoy";
        private string fullNameThree = "Akramov Bahromjon";
        public string fullName1
        { 
            get
            {
                if (AccountNumber == "12345678") return fullNameOne;
                else if (AccountNumber == "87654321") return fullNameTwo;
                else if (AccountNumber == "19981205") return fullNameThree;
                return "No Name";
            } 
            //set
            //{
            //    bool isLetter = false;
            //    for (int i = 0; i < value.Length; i++)
            //    {
            //        if ((int)value[i] >= 65 && (int)value[i] <= 90 || (int)value[i] >= 97 && (int)value[i] <= 122 || (int)value[i] == 32)
            //        {
            //            isLetter = true;
            //        }
            //        else
            //        {
            //            isLetter = false;
            //            break;
            //        }
            //    }
            //    if (isLetter) fullName = value;
            //    else Console.WriteLine("Ismni faqar Harflar bilan yozing...");
            //}
        }

        private double balansOne = 72_128_543.215;
        private double balansTwo = 1_285_430.22;
        private double balansThree = 105_108_543.78;
        public double balans1
        {
            get
            {
                if (AccountNumber == "12345678") return balansOne;
                else if (AccountNumber == "87654321") return balansTwo;
                else if (AccountNumber == "19981205") return balansThree;
                return 0;
            }
        }


        public void GetInfo()
        {
            Console.WriteLine($"Hisob Raqam : {AccountNumber1}\nHisob Raqam egasi : {fullName1}\nBalans : {balans1}");
        }
    }
}

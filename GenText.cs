using System;

namespace gen_csv
{
    class GenText
    {
        char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] lettersCyrillic = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        
        Random rand = new Random();

        public int GenIntNumber()
        { 
            return rand.Next(-2147483648, 2147483647);
        }
        public float GenFloatNumber()
        {
            return (float)rand.NextDouble();
        }
        public string GenWord(int numLetters)
        {
            string word = "";
            for (int j = 0; j < numLetters; j++)
            {
                int letter_num = rand.Next(0, lettersCyrillic.Length - 1);
                word += lettersCyrillic[letter_num];
            }
            return word;
        }

        public string GenDate()
        {
            DateTime start = new DateTime(1900, 1, 1);
            int range = (DateTime.Today - start).Days;
            var randDate = start.AddDays(rand.Next(range));
            return randDate.ToString("dd.MM.yyyy");
        }


    }
}

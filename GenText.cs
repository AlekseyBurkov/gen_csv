using System;

namespace GenScv 
{
    class GenText
    {
        char[] _letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] _lettersCyrillic = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        
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
                int letterNum = rand.Next(0, _lettersCyrillic.Length - 1);
                word += _lettersCyrillic[letterNum];
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

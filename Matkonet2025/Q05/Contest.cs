using System;

namespace Matkonet2025.Q05
{
    public class Contest
    {
        Song[] arrSongs;
        int numSongs;

        public Contest()
        {
            this.arrSongs = new Song[1000];
            this.numSongs = 0;
        }

        public void Add(Song song)
        {
          //  if (numSongs < arrSongs.Length)
            if (numSongs < 1000)
            {
                arrSongs[numSongs] = song;
                numSongs++;
            }
        }
        public void MaxSongs()
        {
            //מערך מונים של השירים לפי מדינה, כל מדינה כמות השירים  ששלחה   
            int[] countries = new int[35];// מהערך מאותחל באפסים

            for (int i = 0; i < numSongs; i++)
            {
                countries[arrSongs[i].GetCountry()] += 1;
            }

            int max = 0;// מציאת מספר מקסימלי
            for (int i = 1; i < countries.Length; i++)
            {
                if (countries[i] > max)
                {
                    max = countries[i];
                }
            }

            for (int i = 1; i < countries.Length; i++)
            {
                if (countries[i] == max)
                {
                    Console.WriteLine("The country with the most songs is: " + i + " with " + max + " songs.");
                }
            }

        }
    }
}
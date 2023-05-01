using Chap3Example13SongsArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Example13SongsArray
{
    public class Chap3Exmple13Songs
    {
        public static void Main(string[] args)// הפעולה הראשית // 
        {
            Song[] songs = new Song[10];
            string name;
            string singer;
            int length;
            // קליטת נתוני כל אחד מן השירים, בניית עצם מטיפוס שיר והשמתו במערך השירים //
            for (int i = 0; i < songs.Length; i++)
            {
                Console.WriteLine("Enter song name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter song singer:");
                singer = Console.ReadLine();
                Console.WriteLine("Enter song Length:");
                length = int.Parse(Console.ReadLine());
                songs[i] = new Song(name, length, singer);
            }

            //חישוב ממוצע אורכי השירים //
            double sum = 0;
            for (int i = 0; i < songs.Length; i++)
            {
                sum = sum + songs[i].GetLength();
            }
            double avg = sum / songs.Length;
            for (int i = 0; i < songs.Length; i++)
            {
                if (avg > songs[i].GetLength())
                    Console.WriteLine(songs[i].GetName());
            }
        }
    }
}

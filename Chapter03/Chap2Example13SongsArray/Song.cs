using System.Security.AccessControl;

namespace Chap2Example13SongsArray
{
    public class Song
    {
        private string name;
        private string singer;
        private int length;
       

        public Song(string name, int length, string singer)
        {
            this.name = name;
            this.length = length;
            this.singer = singer;
        }

        public int GetLength()
        {
            return length;
        }

        public void SetLength(int length)
        {
            this.length = length;
        }
        public string GetName()
        { return name; }


    }
}

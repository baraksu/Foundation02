namespace Chap2Example13SongsArray
{
    public class Song
    {
        private string _name;
        private string _singer;
        private int _length;
       

        public Song(string name, int length, string singer)
        {
            this._name = name;
            this._length = length;
            this._singer = singer;
        }

        public int GetLength()
        {
            return _length;
        }
        public string GetName()
        { return _name; }
    }
}

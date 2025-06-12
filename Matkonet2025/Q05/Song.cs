namespace Matkonet2025.Q05
{
    public class Song
    {

        private string name;

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        private int country;

        public int GetCountry()
        {
            return this.country;
        }
        public void SetCountry(int country)
        {
            this.country = country;
        }

        private bool isFinal;

        public bool GetIsFinal()
        {
            return this.isFinal;
        }
        public void SetIsFinal(bool isFinal)
        {
            this.isFinal = isFinal;
        }

        public Song(string name, int country, bool isFinal)
        {
            this.name = name;
            this.country = country;
            this.isFinal = isFinal;
        }  
    }
}
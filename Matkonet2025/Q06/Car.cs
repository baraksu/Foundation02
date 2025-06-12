namespace Matkonet2025.Q06
{
    public class Car
    {

        public Car(string license, int year, double km)
        {
            this.license = license;
            this.year = year;
            this.km = km;
        }
        private string license;

        public string GetLicense()
        {
            return this.license;
        }
        public void SetLicense(string license)
        {
            this.license = license;
        }

        private int year;

        public int GetYear()
        {
            return this.year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }

        private double km;

        public double GetKm()
        {
            return this.km;
        }
        public void SetKm(double km)
        {
            this.km = km;
        }

    }
}
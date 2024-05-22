namespace Bagrut2019Q03;

public class AllCars
{			
	private Car[] cars;
    private int num;

    public AllCars(int max)
    {
        this.cars = new Car[max];
        num = 0;
    }

    public bool AddCar(Car car)
    {
        if (num < cars.Length)
        {
            cars[num] = car;
            num++;
            return true;
        }
        return false;
    }

    public void Print(int min, int max)
    {
        for (int i = 0; i < this.num; i++)
        {
            if (cars[i].Range(min, max) && !cars[i].GetHadAccident())
            {
                Console.WriteLine(cars[i].GetLicenseNum());
            }
        }
    }

}
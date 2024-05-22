namespace Bagrut2019Q02;

public class Flashlight
{
	private string model;
    private double price;

    public Flashlight(string model, double price)
    {
        this.model = model;
        this.price = price;
    }
    public string GetModel()
	{
		return this.model;
	}

    public double GetPrice()
    {
        return this.price;
    }

    public void SetModel(string model)
	{
		this.model = model;
	}

    public void SetPrice(double price)
	{
		this.price = price;
	}


}
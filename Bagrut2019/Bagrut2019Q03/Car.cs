namespace Bagrut2019Q03;

public class Car
{
	private string licenseNum;

    private bool hadAccident;

    private int price;

    public Car(string licenseNum, bool hadAccident, int price)
    {
        this.licenseNum = licenseNum;
        this.hadAccident= hadAccident;
        this.price = price;
    }
    public string GetLicenseNum()
	{
		return this.licenseNum;
	}

    public bool GetHadAccident()
    {
        return this.hadAccident;
    }

    public int GetPrice()
    {
        return this.price;
    }

    public void SetLicenseNum(string lisenceNum)
	{
		this.licenseNum = lisenceNum;
	}

    public void SetHadAccident(bool hadAccident)
	{
		this.hadAccident = hadAccident;
	}

    public void SetPrice(int price)
	{
		this.price = price;
	}

    public bool Range(int min, int max)
    {
        return this.price >= min && this.price <= max;
    }

}
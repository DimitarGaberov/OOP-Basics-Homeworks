public class Car
{
    public string model;
    public double fuelAmount;
    public double fuelConsumption;
    public double distance = 0;

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
    }

    public bool HasEnoughFuel(double distance)
    {
        if (fuelConsumption * distance <= fuelAmount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


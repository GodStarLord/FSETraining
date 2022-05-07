namespace FactoryCaseStudy
{

    public enum CarType
    {
        MICRO, MINI, LUXARY
    }

    public enum Location
    {
        DEFAULT, INDIA, USA
    }

    public abstract class Car
    {

        public Car(CarType model, Location location)
        {
            this.CarType = model;
            this.Location = location;
        }

        public abstract void Construct();

        public CarType CarType { get; set; }
        public Location Location { get; set; }

        public override string ToString()
        {
            return "Car Model - " + CarType.ToString() + " located in " + Location.ToString();
        }
    }
}
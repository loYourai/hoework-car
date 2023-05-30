

public class Car
{
    

    public string Model { get; set; }
    public int Weight { get; set; }

    public string Color { get; set; }

    
    public  virtual void Drive2()
    {
    Console.WriteLine("машина едет!");
    }
}



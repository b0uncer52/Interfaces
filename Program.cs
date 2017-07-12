using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int PassengerCapacity { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
}
public interface IWaterVehicle 
{
    double MaxWaterSpeed {get; set;}
    void Drive();
}

public interface ILandVehicle 
{
    double MaxLandSpeed {get; set;}
    int Doors {get; set;}
    void Drive();
    int Wheels {get; set;}
    string TransmissionType {get; set;}
}

public interface IAirVehicle 
{
    double MaxAirSpeed {get; set;}
    void Fly();
    bool Winged {get; set;}
    int Doors {get; set;}
    int Wheels {get; set;}
}
public class Freighter : IVehicle, IWaterVehicle 
{
    public int PassengerCapacity {get; set;} = 500;
    public double EngineVolume {get; set;} = 600.5;
    public double MaxWaterSpeed {get; set;} = 8.1;
    public void Drive() 
    {
        Console.WriteLine("The freighter lurches through the sea");
    }
    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }    
}

public class JetSki : IVehicle, IWaterVehicle
{
    public int PassengerCapacity { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Truck : IVehicle, ILandVehicle 
{
    public int Wheels {get; set;} = 4;
    public int Doors {get; set;} = 2;
    public int PassengerCapacity {get; set;} = 3;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 6.3;
    public double MaxLandSpeed { get; set; } = 100.0;
    public void Drive()
    {
        Console.WriteLine("The truck rumbles down the highway");
    }
    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IVehicle, ILandVehicle
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 2;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;
    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }
    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Copter : IVehicle, IAirVehicle
{
    public int Wheels {get; set;} = 0;
    public int Doors {get; set;} = 4;
    public int PassengerCapacity {get; set;} = 6;
    public bool Winged {get; set;} = false;
    public double EngineVolume {get; set;} = 25.2;
    public double MaxAirSpeed {get; set;} = 180;
    public void Fly () {
        Console.WriteLine("Make lots of noise, but move pretty fast");
    }
    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Cessna : IVehicle, IAirVehicle 
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 113;
  public bool Winged { get; set; } = true;
  public double EngineVolume { get; set; } = 31.1;
  public double MaxAirSpeed { get; set; } = 309.0;
  public void Fly()
  {
    Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
  }

  public void Start()
  {
    throw new NotImplementedException();
  }

  public void Stop()
  {
    throw new NotImplementedException();
  }
}


public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        List<IAirVehicle> flyers = new List<IAirVehicle>();
        Copter heli = new Copter();
        Cessna plane = new Cessna();
        flyers.Add(heli);
        flyers.Add(plane);

        // With a single `foreach`, have each vehicle Fly()
        foreach (var flyer in flyers)
        {   
            flyer.Fly();
        }

        // Build a collection of all vehicles that operate on roads
        List<ILandVehicle> grounders = new List<ILandVehicle>{
            new Truck(),
            new Motorcycle()
        };

        // With a single `foreach`, have each road vehicle Drive()
        foreach (var vehicle in grounders)
        {   
            vehicle.Drive();
        }

        // Build a collection of all vehicles that operate on water
        List<IWaterVehicle> boats = new List<IWaterVehicle>{
            new JetSki(),
            new Freighter()
        };
        
        // With a single `foreach`, have each water vehicle Drive()
        foreach (var boat in boats) {
            boat.Drive();
        }
    }

}

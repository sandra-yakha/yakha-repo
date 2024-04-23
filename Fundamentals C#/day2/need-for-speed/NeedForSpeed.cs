using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    int speed;
    int batteryDrain;   
    int battery = 100;
    int metersDriven;
    
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    
    public bool BatteryDrained()
    {
        if (battery > 0 && battery >= batteryDrain)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public int DistanceDriven()
    {
        return metersDriven;
    }

    public void Drive()
    {
        
        if (battery > 0 && battery >= batteryDrain)
        {
            metersDriven += speed;
            battery -=batteryDrain;
        }
        else 
        {
            return;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    
    int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(car.BatteryDrained() == false)
        {
            car.Drive();
        }
        if(car.DistanceDriven() >= this.distance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

using System;

class RemoteControlCar
{
    private int _drivenMeters = 0;
    private int _batteryLevel = 100;

    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_drivenMeters} meters";
    }

    public string BatteryDisplay()
    {
            if(_batteryLevel > 0)
            {
                return $"Battery at {_batteryLevel}%";
            }
            else
            {
                return $"Battery empty";
            }
    }


    public void Drive()
    {
        if (_batteryLevel > 0)
        {
            _drivenMeters += 20;
            _batteryLevel -= 1;
        }

    }
}

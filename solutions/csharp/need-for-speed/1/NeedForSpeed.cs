class RemoteControlCar
{
    int _speed;
    int _batteryDrain;
    int _batteryCharge = 100;
    int _distanceDriven;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;      
    }

    public bool BatteryDrained()
    {
       return _batteryCharge < _batteryDrain;
    }

    public int DistanceDriven()
    {
       return _distanceDriven;
    }

    public void Drive()
    {      
        if(!BatteryDrained())
        {
        _distanceDriven += _speed;
        _batteryCharge -= _batteryDrain;
        }

        
    }

    public static RemoteControlCar Nitro()
    {
        int speed = 50;
        int batteryDrain = 4;
        var car = new RemoteControlCar(speed, batteryDrain);

        return car;
    }
}

class RaceTrack
{
    int _distance;
   
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained())
        {
            car.Drive();
        }
                   
        return car.DistanceDriven() >= _distance;
    }
}

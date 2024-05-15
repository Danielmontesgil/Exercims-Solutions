using System;

class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    
    private int _battery = 100;
    private int _drivedMeters = 0;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _battery < _batteryDrain;

    public int DistanceDriven() => _drivedMeters;

    public void Drive()
    {
        if (BatteryDrained())
        {
            return;
        }

        _drivedMeters += _speed;
        _battery -= _batteryDrain;
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;
    
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }

        return car.DistanceDriven() >= _distance;
    }
}

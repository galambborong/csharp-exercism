class RemoteControlCar
{
    private int TotalDistanceDriven { get; set; }
    private int BatteryRemaining { get; set; } = 100;

    public static RemoteControlCar Buy() => new RemoteControlCar();
    public string DistanceDisplay() => $"Driven {TotalDistanceDriven} meters";
    public string BatteryDisplay()
    {
        if (BatteryRemaining == 0)
            return "Battery empty";

        return $"Battery at {BatteryRemaining}%";
    }
    public void Drive()
    {
        if (BatteryRemaining <= 0)
            return;

        IncrementDistance();
        DecrementBatteryLife();
    }

    private void DecrementBatteryLife() => BatteryRemaining -= 1;

    private void IncrementDistance() => TotalDistanceDriven += 20;
}
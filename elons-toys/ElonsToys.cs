class RemoteControlCar
{
    private int TotalDistanceDriven { get; set; } = 0;
    private int BatteryLifeRemaining { get; set; } = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {TotalDistanceDriven} meters";

    public string BatteryDisplay() => $"Battery at {BatteryLifeRemaining}%";

    public void Drive()
    {
        UpdateTotalDistance();
        UpdateBatteryLife();
    }

    private void UpdateBatteryLife() => BatteryLifeRemaining -= 1;

    private void UpdateTotalDistance() => TotalDistanceDriven += 20;
}

class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int NumberOfLanes { get; set; }
    public double TrafficLevel { get; set; }
}

class Vehicle : IDriveable
{
    public double Speed { get; set; }
    public double Size { get; set; }
    public string Type { get; set; }

    public void Move()
    public void Stop()
}

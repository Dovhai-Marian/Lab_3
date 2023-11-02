class Computer
{
    public string IpAddress { get; set; }
    public double Power { get; set; }
    public string OperatingSystem { get; set; }
}

class Server : Computer, IConnectable
{
    public void ConnectTo(Computer other)
    public void DisconnectFrom(Computer other)
    public void TransmitData(byte[] data)
}

class Workstation : Computer, IConnectable
{
    public void ConnectTo(Computer other)

    public void DisconnectFrom(Computer other)

    public void TransmitData(byte[] data)
}

class Router : Computer, IConnectable
{
    public void ConnectTo(Computer other)
    public void DisconnectFrom(Computer other)
    public void TransmitData(byte[] data)
}

class Network
{
    public List<Computer> Computers { get; set; }

    public void SimulateNetworkActivity()
}

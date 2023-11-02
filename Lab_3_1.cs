class LivingOrganism
{
    public double Energy { get; set; }
    public int Age { get; set; }
    public double Size { get; set; }
}

class Animal : LivingOrganism, IReproducible, IPredator
{
    public string Species { get; set; }

    public void Reproduce()

    public void Hunt()
}

class Plant : LivingOrganism, IReproducible
{
    public string Species { get; set; }

    public void Reproduce()
}

class Microorganism : LivingOrganism, IReproducible
{
    public string Species { get; set; }

    public void Reproduce()
}

class Ecosystem
{
    public List<LivingOrganism> Organisms { get; set; }

    public void SimulateInteractions()
}

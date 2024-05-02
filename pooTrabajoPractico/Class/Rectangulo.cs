namespace pooTrabajoPractico;

public class Rectangulo : Figura
{

    public double Base { get; set; }
    public double Altura { get; set; }

    

    public override double CalculateArea()
    {
        return Base * Altura;
    }
}

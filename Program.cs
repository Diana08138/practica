using System;

class Program
{
    static void Main(string[] args);
    {
        Enemigo orco = new Enemigo("orco", 100);
        EnemigoVolador murcielago = new EnemigoVolador("murcielago", 50);
        EnemigoGriego Amadeus  = new EnemigoGriego("Amadeus", 30);


        orco.Atacar();        // Orco ataca con un golpe basico.
        murcielago.Atacar();  // Murcielago lanza un ataque desde el aire.
        Amadeus.Atacar(); // Amadeus lanza un corte de navaja al aire. 
    }
}


{
public class EnemigoVolador : Enemigo;

    public EnemigoVolador(string nombre, int vida) : base(nombre, vida);

    public override void Atacar();
    {
        Console.WriteLine(nombre + "Lanza un ataque desde el aire.");
    }
}

public class EnemigoGriego : Enemigo;
{
    public EnemigoGriego(string nombre, int vida) : base(nombre, vida);

    public override void Atacar();
    {
        Console.WriteLine(nombre + "Lanza un corte de navaja al aire.");
    }
}

public class Enemigo : EnemigoGriego
{
    public Enemigo(string nombre, int vida) : base(nombre, vida);

    public override void  Atacar();
    {
        Console.WriteLine(nombre + "ataca con un golpe basico.");
    }
}



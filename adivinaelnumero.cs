using System; 

int numeroSecreto = random.next(1,101);
int intentos = 7;
Random random = new Random();
bool adivinado = false;

Console.Write("Bienvenido al juego. Elige un numero del 1 al 101. Tienes 7 intentos");
while (intentos > 0 && !adivinado)
{
    Console.Write("Ingresa tu numero: ");
    int intento =
    int.Parse(Console.ReadLine());

    if (intento == numeroSecreto)
    {
        Console.WriteLine("¡Correcto! Adivinaste el numero");
        adivinado = true;
    }
    else 
    {
        intentos--;
        if (intento < numeroSecreto)
        Console.WriteLine("Demasiado bajo");
        else 
        Console.WriteLine("Demasiado alto");
        Console.WriteLine("Te quedan {intentos} intentos");
    }
}
if (!adivinado)
    Console.WriteLine("Perdiste. El numero era {numeroSecreto}.");
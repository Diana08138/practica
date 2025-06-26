Main

nombre PiedraPapelTijera
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniciar las variables
            int contadorJugador = 0; // lleva el numero de rondas ganadas del jugador 
            int contadorPC = 0; // lleva el numero de rondas ganadas de la computadora
            int intentos = 3; // rondas 
            Random random = new Random(); // la computadora elelgira al asar
            string[] opciones = { "piedra", "papel", "tijeras" }; // opciones validas

            // Bucle principal
            while (intentos > 0)
            {
                // Mostrar las opciones al jugador
                Console.WriteLine("Elige una opcion (piedra, papel o tijeras):");
                string jugada = Console.ReadLine().ToLower();

                // Validar la eleccion del jugador
                if (jugada != "piedra" && jugada != "papel" && jugada != "tijeras")
                {
                    Console.WriteLine("Eleccion invalida. Intenta nuevamente");
                    continue;
                }

                // Generar eleccion de la computadora
                string jugadaPC = opciones[random.Next(0, 3)].ToLower();

                // Mostrar elecciones
                Console.WriteLine($"Elegiste: {jugada}");
                Console.WriteLine($"La computadora eligio: {jugadaPC}");

                // Determinar el ganador
                if (jugada == jugadaPC)
                {
                    Console.WriteLine("EMPATE");
                }
                else if ((jugada == "piedra" && jugadaPC == "tijeras") ||
                         (jugada == "papel" && jugadaPC == "piedra") ||
                         (jugada == "tijeras" && jugadaPC == "papel"))
                {
                    Console.WriteLine("GANAS LA RONDA");
                    contadorJugador++;
                }
                else
                {
                    Console.WriteLine("LA COMPUTADORA GANA ESTA RONDA");
                    contadorPC++;
                }

                intentos--; // Restar un intento despues de cada ronda

                // Mostrar la puntuacion
                Console.WriteLine($"Tu puntuacion fue: {contadorJugador} - computadora: {contadorPC}");
                Console.WriteLine($"Intentos restantes: {intentos}");

                // Preguntar si quiere seguir jugando
                if (intentos > 0)
                {
                    Console.WriteLine("QUIERES SEGUIR JUGANDO? (s/n)");
                    string respuesta = Console.ReadLine().ToLower();
                    if (respuesta != "s")
                    {
                        break;
                    }
                }
            }

            // Mostrar el resultado final
            if (contadorJugador > contadorPC)
            {
                Console.WriteLine("GANASTE EL JUEGO");
            }
            else if (contadorJugador < contadorPC)
            {
                Console.WriteLine("LA COMPUTADORA GANO EL JUEGO");
            }
            else
            {
                Console.WriteLine("EMPATE");
            }
        }
    }
}

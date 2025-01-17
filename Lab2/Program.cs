using Lab2.entities;

   Carro carro = new Carro("Toyota", "Corolla", 15000, "Rojo");

        Console.WriteLine("\nDividir y unir marca y modelo:");
        string reunido = carro.DividirYUnir();
        Console.WriteLine($"Resultado reunido: {reunido}");

        Console.WriteLine("\nSubstrings de la marca (longitud 2):");
        var substringsMarca = carro.ObtenerSubstringsDeMarca(2);
        foreach (string s in substringsMarca)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("\nSubstrings del modelo (longitud 3):");
        var substringsModelo = carro.ObtenerSubstringsDeModelo(3);
        foreach (string s in substringsModelo)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("\nBuscar en el modelo:");
        bool encontrado = carro.BuscarEnModelo("roll");
        Console.WriteLine($"¿Se encontró 'roll' en el modelo? {encontrado}");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    
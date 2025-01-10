using Week1Laboratorie.models;

 var dataTypes = new DataTypes();

        while (true)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Mostrar los parámetros (Actuales, osea ninguno xD).");
            Console.WriteLine("2. Realizar conversiones de tipos.");
            Console.WriteLine("3. Salir.");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                MostrarParametros(args);
            }
            else if (opcion == "2")
            {
                RealizarConversiones(dataTypes);
            }
            else if (opcion == "3")
            {
                break; 
            }
            else
            {
                Console.WriteLine("Opción no válida, por favor intente nuevamente.");
            }
        }
    

    static void MostrarParametros(string[] args)
    {
        Console.WriteLine("\nNúmero de parámetros: " + args.Length );
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"Parámetro {i}: {args[i]}" + "xD");
        }
    }

    static void RealizarConversiones(DataTypes dataTypes)
    {
        Console.WriteLine("\nConversión de tipos:");

        Console.WriteLine($"int a short: {dataTypes.ConvertIntToShort(12345)}");
        Console.WriteLine($"int a long: {dataTypes.ConvertIntToLong(12345)}");
        Console.WriteLine($"float a int: {dataTypes.ConvertFloatToInt(12.45f)}");
        Console.WriteLine($"int a float: {dataTypes.ConvertIntToFloat(123)}");
        Console.WriteLine($"int a double: {dataTypes.ConvertIntToDouble(123)}");

        Console.WriteLine($"bool a string: {dataTypes.ConvertBoolToString(true)}");

        try
        {
            int convertedInt = dataTypes.ConvertStringToInt("12345");
                Console.WriteLine($"string a int: \"12345\" -> {convertedInt}");
        }
        catch (FormatException)
        {
            Console.WriteLine("No se pudo convertir a int");
        }

        object boxed = dataTypes.Boxing(12345); 
        Console.WriteLine($"\nBoxing: {12345} -> {boxed}");

        int unboxed = dataTypes.Unboxing(boxed); 
        Console.WriteLine($"Unboxing: {boxed} -> {unboxed}");
    }
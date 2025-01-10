# Objetivo del Proyecto

El objetivo de este proyecto es crear una aplicación de consola simple que muestre en la consola los parámetros que se utilizan al ejecutar la aplicación. Para ello, se usará la CLI de .NET para agregar dichos parámetros. Además, la aplicación incluirá métodos para realizar diversas conversiones de datos y mostrar los resultados en la consola.

Las conversiones incluyen:

- int a short
- int a long
- float a int
- int a float
- int a double
- bool a string
- string a int
- Boxing (cualquier tipo a objeto)
- Unboxing (objeto a tipo original)

## Requisitos

- Utilizar la CLI de .NET para agregar parámetros al ejecutar la aplicación.
- Crear métodos en la clase `DataTypes` para realizar las conversiones de datos.
- Mostrar en consola los resultados de cada conversión.

## Descripción de la Implementación

El proyecto contiene un bucle principal que permite al usuario seleccionar entre diferentes opciones:

1. **Mostrar los parámetros:** Este método muestra la cantidad de parámetros pasados a la aplicación y sus valores. Actualmente, no funciona correctamente ya que no se están pasando parámetros en el momento de la ejecución.
2. **Realizar conversiones de tipos:** Utiliza la clase `DataTypes` para convertir entre diferentes tipos de datos usando métodos simples. Por ejemplo:
    - `ConvertIntToShort`: convierte un entero a short.
    - `ConvertFloatToInt`: convierte un flotante a entero.
    - `ConvertBoolToString`: convierte un booleano a cadena de texto.
    - Entre otros métodos similares para realizar conversiones de datos básicas.
3. **Salir:** Finaliza la ejecución del programa.

## Detalles Técnicos

Se definió la clase `DataTypes`, la cual contiene métodos para realizar las conversiones de datos mencionadas anteriormente. A continuación, se describe el flujo del programa:

```csharp
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

```


<div align="center">
<h2>
🛠️ Lo que aprendimos
</h2>
</div>

Practicamente algo tan sencillo como hacer una app de este indole de consola puede representar un avance inicial en el aprendizaje de programación si añadimos la conversion de los tipos de datos que son la base cuando estemos pasando a programar relaciones entre entidades, definiendo campos con los tipos que mas consideremos convenientes y implementando las conversiones que apenas aprendimos en clase.
# **Guía del Proyecto: Sistema de Gestión de Carros**

## **Objetivo del Proyecto**  
Crear una aplicación de consola que permita gestionar información sobre carros y realizar operaciones relacionadas con cadenas de texto. El proyecto incluye funcionalidades como dividir y unir cadenas, obtener substrings, realizar comparaciones y búsquedas, todo desde el contexto de la información de los carros.

---

## **Requisitos**  

- Crear una clase principal llamada `Carro` para gestionar la información básica de cada vehículo.
- Implementar métodos en la clase `Carro` que permitan realizar operaciones avanzadas con cadenas, tales como:  
  - Dividir y unir cadenas.
  - Generar substrings.
  - Realizar búsquedas en las cadenas.  
- Mostrar los resultados de las operaciones en la consola.  

---

## **Clases y Métodos**

### **Clase: Carro**
elegi lo mas simple posible, en este caso solo se necesita una clase para almacenar los datos de un carro, para ello creamos una clase llamada `Carro` y dentro de ella crearemos los atributos que necesitamos para almacenar los datos de un carro.

#### **Propiedades:**  
```csharp
public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public decimal Precio { get; set; }
    public string Color { get; set; }

    public Carro(string marca, string modelo, decimal precio, string color)
    {
        Marca = marca;
        Modelo = modelo;
        Precio = precio;
        Color = color;
    }
}
```

## Metodos

```csharp
  public string DividirYUnir()
        {
            string concatenado = $"{Marca} {Modelo}";
            char[] caracteres = concatenado.ToCharArray(); 
            Console.WriteLine($"Array de caracteres de '{concatenado}':");
            foreach (char c in caracteres)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            return new string(caracteres);
        } 
```

```csharp


private List<string> ObtenerSubstrings(string input, int longitud)
        {
            List<string> substrings = new List<string>();
            for (int i = 0; i <= input.Length - longitud; i++)
            {
                substrings.Add(input.Substring(i, longitud));
            }
            return substrings;
        }


```

```csharp


public bool BuscarEnModelo(string busqueda)
        {
            return Modelo.Contains(busqueda, StringComparison.OrdinalIgnoreCase);
        }
```

## Como se llama o funciona?


```csharp
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
```
para ejecutar el programa solo basta con ejecutar el archivo .cs con el comando:

```bash
dotnet run --project .\Lab2\
```

<div align="center">
<h2>
🛠️ Lo que aprendi
</h2>
</div>

Esta actividad sencilla sirve mucho a poder darse cuenta que sin importar el lenguaje de programacion siempre de mantienen los mismos conceptos y operaciones con los tipos de datos referidos
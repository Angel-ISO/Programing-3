using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.entities;

    public class Carro
    {
        // desde luego mas de 3 clases como estipulo el profe jeje
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public string Color { get; set; }

        public Carro(string marca, string modelo,  decimal precio, string color)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Color = color;
        }

        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Precio: {Precio}, Color: {Color}";
        }
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

        public List<string> ObtenerSubstringsDeMarca(int longitud)
        {
            return ObtenerSubstrings(Marca, longitud);
        }

        public List<string> ObtenerSubstringsDeModelo(int longitud)
        {
            return ObtenerSubstrings(Modelo, longitud);
        }

        private List<string> ObtenerSubstrings(string input, int longitud)
        {
            List<string> substrings = new List<string>();
            for (int i = 0; i <= input.Length - longitud; i++)
            {
                substrings.Add(input.Substring(i, longitud));
            }
            return substrings;
        }

        public bool BuscarEnModelo(string busqueda)
        {
            return Modelo.Contains(busqueda, StringComparison.OrdinalIgnoreCase);
        }

    // de esta manera se creaban destructores para cada clase que se cree en el programa y se llama al destructor cuando se destruye el objeto
    ~Carro()
    {
        Console.WriteLine($"El objeto carro de marca {Marca} y modelo {Modelo} está siendo destruido.");
    }

}

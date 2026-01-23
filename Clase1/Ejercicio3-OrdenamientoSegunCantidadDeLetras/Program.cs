namespace Ejercicio3_OrdenamientoSegunCantidadDeLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var laLista = new List<string>() { "Ana", "Juan", "Pedro", "Alejandro", "Maximiliano" };

            laLista.Sort((nombre1, nombre2) =>
            {
                return nombre1.Length.CompareTo(nombre2.Length);
            });

            foreach (var item in laLista)
            {
                Console.WriteLine(item);
            }



            //En caso de querer ordenar por orden de mas letras a menos o descendente invertimos las variables nombre1 y nombre 2 en la comparacion
            //Ejemplo :
            Console.WriteLine();
            laLista.Sort((nombre1, nombre2) =>
            {
                return nombre2.Length.CompareTo(nombre1.Length);
            });

            Console.WriteLine("Mostrando ordenamiento por orden de más a menos");
            foreach (var item in laLista)
            {
                Console.WriteLine(item);
            }
        }
    }
}

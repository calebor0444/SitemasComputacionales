

using System.Collections;
using System.Diagnostics;

namespace ColeccionesDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ComparacionDeOrdenamiento();
            //  ManejoDeLista();
            //ManejoDeDiccionario();
           // ListaEnlazada();
        }

        private static void ListaEnlazada()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("a");
            lista.AddLast("b");
            lista.AddLast("c");
            lista.AddLast("d");
            lista.AddLast("f");

            var elNodo = lista.Find("d");
            if (elNodo != null)
                lista.AddAfter(elNodo, "e");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            
        }

        private static void ComparacionDeOrdenamiento()
        {
            //generic list
            List<int> ListGeneric = new List<int> { 5, 9, 1, 4, 15, 23, 58, 98, 31, 99, 67 };
            //non-generic list
            ArrayList ListNonGeneric = new ArrayList { 5, 9, 1, 4, 15, 23, 58, 98, 31, 99, 67 };
            // timer for generic list sort
            Stopwatch s = Stopwatch.StartNew();
            ListGeneric.Sort();
            s.Stop();
            Console.WriteLine($"Generic Sort: {ListGeneric}  \n Time taken: {s.Elapsed.TotalMilliseconds}ms");

            //timer for non-generic list sort
            Stopwatch s2 = Stopwatch.StartNew();

            ListNonGeneric.Sort();
            s2.Stop();
            Console.WriteLine($"Non-Generic Sort: {ListNonGeneric}  \n Time taken: {s2.Elapsed.TotalMilliseconds}ms");

            int[] arregloDeEntero = new int[] { 5, 9, 1, 4, 15, 23, 58, 98, 31, 99, 67 };
            Stopwatch s3 = Stopwatch.StartNew();
            Array.Sort(arregloDeEntero);
            s3.Stop();
            Console.WriteLine($"Array Sort: {arregloDeEntero}  \n Time taken: {s3.Elapsed.TotalMilliseconds}ms");

            Console.ReadLine();
        }
        private static void ManejoDeLista()
        {
            var laLista = new List<string>();

            laLista.Add("Juan");
            laLista.Add("Pedro");
            laLista.Add("Ana");
            laLista.Add("Mariana");

            var laLista2 = new List<string>() { "item1", "item2" };
            laLista.AddRange(["Leo", "Marta", "Miguel", "Alex"]);
            laLista.AddRange(laLista2);

            string? elElementoEncontrado = laLista.Find(l => l == "Mariana2");

            if (elElementoEncontrado != null)
            {
                Console.WriteLine($"Se encontró en la búsqueda la persona: {elElementoEncontrado}");
                laLista.Remove(elElementoEncontrado);
            }
            else
                Console.WriteLine("Persona no encontrada!");

            foreach (var item in laLista)
            {
                Console.WriteLine(item);
            }
            //laLista.Remove("Ana");

            Console.WriteLine(laLista.FindIndex(nombre => nombre == "Pedro"));


            laLista.TrueForAll(nombre => nombre.Length > 3);
            //if (laLista.Exists(nombre => nombre == "Juan"))
            //{
            //    laLista.Remove("Juan");

            //}

            laLista.Contains("Pedro");

            laLista.Sort((nombre1, nombre2) => nombre2.Length.CompareTo(nombre1.Length));
            laLista.Sort((a, b) =>
            {
                int countA = a.Count(c => c == 'a');
                int countB = b.Count(c => c == 'a');

                return countB.CompareTo(countA);
            });


            foreach (var nombre in laLista)
            {
                Console.WriteLine(nombre);
            }

            var listaDePersona = new List<Persona>();
            listaDePersona.Add(new Persona { Nombre = "Caleb", Apellido = "Oreamuno" });
            var laPersona = listaDePersona.Find(p => p.Apellido.Contains("Orea"));
            listaDePersona.Remove(laPersona);
            Console.WriteLine(laPersona.Nombre);

            listaDePersona.ForEach(p => Console.WriteLine(p.Nombre));
        }
        public struct Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
        }

        private static void ManejoDeDiccionario()
        {
            var elDiccionario = new Dictionary<int, string>();

            elDiccionario.Add(1, "Juan");
            elDiccionario.Add(2, "Ana");
            elDiccionario.Add(3, "Pedro");
            foreach (var llave in elDiccionario.Keys)
            {
                Console.WriteLine($"Llave: {llave}, Valor: {elDiccionario[llave]}");
            }

            elDiccionario.Remove(5);
            elDiccionario.TryAdd(4, "Luis");
            elDiccionario.TryAdd(2, "Luis");
            Console.WriteLine(elDiccionario.ContainsKey(8));

            elDiccionario.TryGetValue(4, out string? valorObtenido);

            if (valorObtenido is not null)
            {
                Console.WriteLine($"Valor obtenido: {valorObtenido}");
            }
        }
    }
}

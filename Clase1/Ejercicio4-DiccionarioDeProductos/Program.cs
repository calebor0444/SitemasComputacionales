namespace Ejercicio4_DiccionarioDeProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var losProductos = new Dictionary<string, string>();
            bool seDebeSalir = false;
            while (seDebeSalir == false)
            {
                MuestreLasOpciones();

                var laOpcion = Console.ReadKey(true);

                switch (laOpcion.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Digite el Nombre del producto:");
                        var elValorDigitado = Console.ReadLine();
                        Console.WriteLine("Digite el código del producto:");
                        var elCodigo = Console.ReadLine();
                        if (elValorDigitado != null && elCodigo != null)
                        {
                            bool sePudoAgregar = losProductos.TryAdd(elCodigo, elValorDigitado);
                            if (sePudoAgregar)
                                Console.WriteLine("Se agregó el producto!, digite cualquier tecla para continuar");
                            else
                                Console.WriteLine("El código de producto ya existe, digite cualquier tecla para continuar");

                            Console.ReadKey(true);
                            Console.Clear();
                        }

                        break;


                    case '2':
                        Console.Clear();
                        PinteLosProductos(losProductos);

                        break;
                    case '3':
                        bool existe = false;
                        Console.WriteLine("Indique código a buscar:");
                        string? elCodigoABuscar = Console.ReadLine();
                        if (elCodigoABuscar != null && elCodigoABuscar.Length > 0)
                            existe = losProductos.ContainsKey(elCodigoABuscar);

                        if (existe)
                            Console.WriteLine("El producto existe");
                        else
                            Console.WriteLine("El producto no existe!");

                        Console.WriteLine("Indique cualquier tecla para continuar");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;

                    case '4':
                        bool seElimino = false;
                        Console.WriteLine("Indique código de producto a eliminar:");
                        string? elCodigoAElimianr = Console.ReadLine();
                        if (elCodigoAElimianr != null && elCodigoAElimianr.Length > 0)
                            seElimino = losProductos.Remove(elCodigoAElimianr);

                        if (seElimino)
                            Console.WriteLine("Se elimino correctamente");
                        else
                            Console.WriteLine("El código del producto a eliminar no existe");

                        break;
                    default:
                        seDebeSalir = true;
                        break;
                }

            }
        }

        private static void MuestreLasOpciones()
        {

            Console.WriteLine("Indique una opción:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Buscar por codigo");
            Console.WriteLine("4. Eliminar productos");
        }

        private static void PinteLosProductos(Dictionary<string, string> losProductos)
        {
            Console.WriteLine("****************Estudiantes actuales*******************");
            if (losProductos.Count > 0)
            {
                foreach (var item in losProductos)
                {
                    Console.WriteLine($"Codigo: {item.Key} , Nombre: {item.Value}");
                }
            }
            else
                Console.WriteLine("No hay productos");
        }
    }
}

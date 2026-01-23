namespace Ejercicio6_HistorialDeAcciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> historial = new Stack<string>();
            string accionActual = "";

            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║   SISTEMA DE UNDO CON STACK<T>           ║");
            Console.WriteLine("╚══════════════════════════════════════════╝\n");
            Console.WriteLine("Sistema de Undo – escribe líneas de texto");
            Console.WriteLine("Comandos: undo, mostrar, salir\n");

            while (true)
            {
                Console.Write(" > ");
                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                    continue;

                switch (input.ToLower())
                {
                    case "salir":
                        return;

                    case "undo":
                        if (historial.Count > 0)
                        {
                            accionActual = historial.Pop();
                            Console.WriteLine("Deshecho. Estado restaurado.");
                        }
                        else
                        {
                            Console.WriteLine("Nada que deshacer.");
                        }
                        break;

                    case "mostrar":
                        Console.WriteLine("\nContenido actual:");
                        Console.WriteLine(accionActual.Length > 0 ? accionActual : "(vacío)");
                        Console.WriteLine($"\nAcciones en historial: {historial.Count}\n");
                        break;

                    default:
                        // Guardamos el estado ANTES del cambio
                        historial.Push(accionActual);

                        // Aplicamos el nuevo texto
                        if (accionActual.Length > 0)
                            accionActual += "\n";
                        accionActual += input;

                        Console.WriteLine($"Se agregó: \"{input}\"");
                        break;
                }

                Console.WriteLine($"  Líneas actuales: {accionActual.Split('\n').Length - (accionActual.EndsWith("\n") ? 1 : 0)}");
                Console.WriteLine();
            }
        }
    }
}

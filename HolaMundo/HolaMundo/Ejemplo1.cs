namespace HolaMundo
{
    internal class Ejemplo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Gabriel Lacayo");

            // Tipos de datos primitivos
            int edad = 20;
            Console.WriteLine($"Tu edad es: {edad}");

            string nombre = "Gabriel Norwin Lacayo Marenco";
            Console.WriteLine($"Tu nombre completo es: {nombre}");
            Console.WriteLine($"Tu nombre completo es: {nombre.ToUpper()}");
            Console.WriteLine($"Tu nombre completo es: {nombre.ToLower()}");
            Console.WriteLine($"Tu nombre completo tiene: {nombre.Length} letras");

            //Variabls con doble precision
            Double precio = 39.90;
            Console.WriteLine($"El precio es de: ${precio}");
            Console.WriteLine($"El precio es de: ${precio++}");
            Console.WriteLine($"El precio es de: ${++precio}");

            /* Valores logicos*/
            Boolean isSingle = true;
            Console.WriteLine($"¿Tu eres soltero?: {isSingle}");
            Console.WriteLine($"¿Tu eres soltero?: {!isSingle}");
            Console.WriteLine($"¿Tu eres soltero?: {isSingle}");
        }

    }
}
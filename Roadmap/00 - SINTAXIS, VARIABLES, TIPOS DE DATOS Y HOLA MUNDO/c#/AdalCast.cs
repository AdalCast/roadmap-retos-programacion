namespace Primer_Reto_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO:
 * - Crea un comentario en el código y coloca la URL del sitio web oficial del
 *   lenguaje de programación que has seleccionado.
 * - Representa las diferentes sintaxis que existen de crear comentarios
 *   en el lenguaje (en una línea, varias...).
 * - Crea una variable (y una constante si el lenguaje lo soporta).
 * - Crea variables representando todos los tipos de datos primitivos
 *   del lenguaje (cadenas de texto, enteros, booleanos...).
 * - Imprime por terminal el texto: "¡Hola, [y el nombre de tu lenguaje]!"*/

            //https://learn.microsoft.com/es-es/dotnet/csharp/

            /// <summary> </summary>
            /// <param name="ejercicios"></param>
            /// <returns></returns>
            /// <exception cref="ArgumentException"</exception>

            //* - Crea una variable (y una constante si el lenguaje lo soporta).
            //Variable
            // Una variable es un espacio en memoria que puede cambiar su valor a lo largo de la ejecucion del programa.
            int numero = 10; // Esto es una variable llamada 'numero' de tipo entero
            numero = 20; // Se puede cambiar su valor mas tarde

            //Constante
            // Una constante es un valor que se establece al momento de la declaración y no puede ser modificado más adelante.
            const int numeroConstante = 30; // Se declaro una constante de tipo entero
                                            // numeroConstante = 60; Esto daría error, porque una constante no puede cambiar de valor


            // * - Crea variables representando todos los tipos de datos primitivos del lenguaje(cadenas de texto, enteros, booleanos...).
            // Enteros con signo
            sbyte numeroPequenoConSigno = -100;                   // Rango: -128 a 127
            short numeroCorto = 30000;                            // Rango: -32,768 a 32,767
            int numeroEntero = 100000;                            // Rango: -2,147,483,648 a 2,147,483,647
            long numeroGrande = 10000000000L;                     // Rango: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807 
             
            byte numeroPequenoSinSigno = 255;                     // Rango: 0 a 255
            ushort numeroCortoSinSigno = 60000;                   // Rango: 0 a 65,535
            uint numeroEnteroSinSigno = 4000000000U;              // Rango: 0 a 4,294,967,295
            ulong numeroGrandeSinSigno = 18000000000000000000UL;  // Rango: 0 a 18,446,744,073,709,551,615

            // Tipos de punto flotante
            float numeroDecimalPequeno = 3.14f;                     // Precision de 7 digitos
            double numeroDecimal = 3.14159265359;                   // Precision de 15-16 dígitos
            decimal numeroPreciso = 79228162514264337593543950335M; // Precisión de 28-29 dígitos, ideal para cálculos financieros

            //Otros tipos primitivos de datos 
            char letra = 'A';                                       // Representa un solo caracter Unicode
            bool esVerdadero = true;                                // valor booleano: true o false
            string texto = "Hola mundo";                            // Tipo especial que representa una secuencia de caracteres

            //*-Imprime por terminal el texto: "¡Hola, [y el nombre de tu lenguaje]!"

            string MiLenguaje = "C#!";

            Console.WriteLine($"¡Hola,{MiLenguaje}");


        }
    }
}

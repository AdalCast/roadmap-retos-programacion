namespace Segundo_Reto_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO:
            * - Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje:
            *   Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...
            *   (Ten en cuenta que cada lenguaje puede poseer unos diferentes)
            * - Utilizando las operaciones con operadores que tú quieras, crea ejemplos
            *   que representen todos los tipos de estructuras de control que existan
            *   en tu lenguaje:
            *   Condicionales, iterativas, excepciones...
            * - Debes hacer print por consola del resultado de todos los ejemplos.
            *
            * DIFICULTAD EXTRA (opcional):
            * Crea un programa que imprima por consola todos los números comprendidos
            * entre 10 y 55 (incluidos), pares, y que no son ni el 16 ni múltiplos de 3.
            *
            * Seguro que al revisar detenidamente las posibilidades has descubierto algo nuevo.*/



            /* - Crea ejemplos utilizando todos los tipos de operadores de tu lenguaje: Aritméticos, lógicos, de comparación, asignación, identidad, pertenencia, bits...
            *(Ten en cuenta que cada lenguaje puede poseer unos diferentes)*/
            // Operadores aritmeticos
            int suma = 10 + 5;                 // Suma
            int resta = 10 - 5;                // Resta
            int multiplicacion = 10 * 5;       // Multiplicacion
            int division = 10 / 5;             // Division
            int modulo = 10 % 5;               // Modulo
            int incremento = ++suma;           // Incremento (pre-incremento)
            int decremento = --resta;          // Decremento (pre-decrenmento)

            // Operador de asignacion 
            int x = 10;
            x += 5;                            // Asignacion con suma (x = x + 5)
            x -= 3;                            // Asignacion con resta (x = x - 3)
            x *= 2;                            // Asignacion con multiplicacion (x = x * 2)
            x /= 2;                            // Asignacion con division (x = x / 2)
            x %= 3;                            // Asignacion con modulo (x = x % 3)


            // Operador de comparacion 
            int a = 5;
            int b = 10;
            bool igual = a == b;             // Igual a 
            bool diferente = a != b;         // Diferente a 
            bool mayor = a > b;              // Mayor que 
            bool menor = a < b;              // Menor que
            bool mayorIgual = a >= b;        // Mayor o igual que
            bool menorIgual = a <= b;        // Menor o igual que

            // Operadores logicos
            bool verdadero = true;
            bool falos = false;
            bool and = verdadero && false;   // Operador AND logico
            bool or = verdadero || false;    // Operador OR logico
            bool not = !verdadero;           // Operador NOT logico

            // Operadores a nivel de bits
            int bitwiseAnd = a & b;          // AND a nivel de bits
            int bitwiseOr = a | b;           // OR a nivel de bits
            int bitwiseXor = a ^ b;          // XOR a nivel de bits
            int bitwiseComplement = ~a;      // Complemento a nivel de bits
            int desplazarIzq = a << 2;       // Desplazar bits a la izquierda
            int desplazarDer = b >> 2;       // Despalzar bits a la derecha


            // Operadores de Identidad y Pertenencia
            // En C#, no hay un operador específico de pertenencia como en otros lenguajes (como Python), pero podemos usar los condicionales para verificar pertenencia.
            string texto = "Hola, mundo";
            bool contieneHola = texto.Contains("Hola");  // Operador de pertenencia implícito

            // Operador ternario (if corto)
            int resultado = (a < b) ? a : b;  // Si a es menor que b, entonces toma a, de lo contrario toma b



            int nota = 45;  // Puedes cambiar el valor de la calificación aquí

            // Usamos el operador ternario para determinar la categoría
            string categoria = (nota >= 90) ? "Excelente" :
                               (nota >= 75) ? "Bueno" :
                               (nota >= 50) ? "Regular" :
                               "Insuficiente";

            Console.WriteLine($"La calificación es {nota}, y su categoría es: {categoria}");

            string nombre = "Damian";  // Puedes cambiar el valor del nombre aquí

            // Usamos el operador ternario para clasificar la longitud del nombre
            string clasificacion = (nombre.Length <= 4) ? "Corto" :
                                   (nombre.Length <= 7) ? "Mediano" :
                                   "Largo";

            Console.WriteLine($"El nombre '{nombre}' tiene {nombre.Length} caracteres, y es considerado: {clasificacion}");

            /* - Utilizando las operaciones con operadores que tú quieras, crea ejemplos
            que representen todos los tipos de estructuras de control que existan en tu lenguaje: Condicionales, iterativas, excepciones...*/

            // 1. Condicionales
            Console.WriteLine("Condicionales:");

            int nota1 = 85;
            int nota2 = 70;
            int nota3 = 90;

            // Calcula el promedio
            double promedio = (nota1 + nota2 + nota3) / 3.0;

            // Clasificacion de promedio
            string clasification = (promedio >= 90) ? "Excelente" :
                                   (promedio >= 75) ? "Bueno" :
                                   (promedio >= 50) ? "Regular" :
                                   "Insuficiente";

            Console.WriteLine($"El promedio de la nota es: {promedio}");
            Console.WriteLine($"Clasificacion: {clasification}");
            Console.WriteLine();

            // 2. Interativa
            Console.WriteLine("Interativa");

            Console.WriteLine("Calificaciones");
            for (int i = 0; i < 5; i++) // Bucle for
            {
                Console.WriteLine($"Calificaciones {i + 1}: {nota1 + 1 * 5}");
            }

            Console.WriteLine();

            //Bucle while
            int contador = 0;
            while (contador < 5)
            {
                Console.WriteLine($"Esto es un bucle while, contador: {contador}");
                contador++;
            }
            Console.WriteLine();

            // Bucle do-while
            int j = 0;
            do
            {
                Console.WriteLine($"Esto es un bucle do-while, j: {j}");
                j++;
            } while (j < 5);

            Console.WriteLine();

            // 3. Manejo de excepciones
            Console.WriteLine("Manejo de excepciones:");

            try
            {
                // Se intenta dividir por cero pero provoca una exepcion
                int result = 10 / 2;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: no se puede dividir entre cero");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine();

            // 4. Estructura switch
            Console.WriteLine("Estructura switch: ");

            int diaSemana = 5; // Se puede cambiar el numero para probar diferentes dias
            switch( diaSemana )
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("Martes");
                    break;

                case 3:
                    Console.WriteLine("Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Jueves");
                    break;

                case 5:
                    Console.WriteLine("Viernes");
                    break;

                case 6:
                    Console.WriteLine("Sabado");
                    break;

                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Numero de dia invalido.");
                    break ;

            }

            Console.WriteLine("Fin del programa.");

        }
    }

}

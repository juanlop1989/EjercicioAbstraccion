// Método Main para ejecutar la aplicación
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***********JUAN LOPEZ T32351200***********");
        Console.WriteLine("**********OPERACIONES MATEMÁTICAS**********");
        Console.WriteLine();

        // Solicitar al usuario los números para las operaciones
        Console.WriteLine("Ingrese el primer número:");
        double N1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double N2 = double.Parse(Console.ReadLine());

        Console.WriteLine();

        // Crear una instancia de la clase Calculadora
        Calcular calculadora = new Calcular(N1, N2);

        // Realizar y mostrar las operaciones
        double resultadoSuma = calculadora.Sumar(N1, N2);
        calculadora.Imprimir("Suma", resultadoSuma);

        double resultadoResta = calculadora.Restar(N1, N2);
        calculadora.Imprimir("Resta", resultadoResta);

        double resultadoMultiplicacion = calculadora.Multiplicar(N1, N2);
        calculadora.Imprimir("Multiplicación", resultadoMultiplicacion);
       
      
        double resultadoDivision = calculadora.Dividir(N1, N2);
        if (calculadora.N2 != 0)
        {
            calculadora.Imprimir("División", resultadoDivision);
        }
        else
        {


            Console.WriteLine("Resultado de la operacion División: 'Error, no se puede dividir entre 0'");

        }

    }
}

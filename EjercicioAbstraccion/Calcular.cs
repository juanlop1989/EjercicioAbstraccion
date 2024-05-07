// Clase que hereda de Operaciones e implementa los métodos abstractos
class Calcular : Operaciones
{
    // Atributos para almacenar los números ingresados por el usuario
    public double N1;
    public double N2;

    // Constructor para inicializar los atributos
    public Calcular(double N1, double N2)
    {
        this.N1 = N1;
        this.N2 = N2;
    }

    // Implementación del método Sumar
    public override double Sumar(double N1, double N2)
    {
        return N1 + N2;
    }

    // Implementación del método Restar
    public override double Restar(double N1, double N2)
    {
        return N1 - N2;
    }

    // Implementación del método Multiplicar
    public override double Multiplicar(double N1, double N2)
    {
        return N1 * N2;
    }

    // Implementación del método Dividir
    public override double Dividir(double N1, double N2)
    {
        
        return N1 / N2;
    }

    // Implementación del método Imprimir
    public override void Imprimir(string operacion, double resultado)
    {
        Console.WriteLine("Resultado de la operación {0}: {1}", operacion, resultado);
    }
}

using System;

// Clase abstracta que define las operaciones básicas
abstract class Operaciones
{
    // Método abstracto para sumar dos números
    public abstract double Sumar(double N1, double N2);

    // Método abstracto para restar dos números
    public abstract double Restar(double N1, double N2);

    // Método abstracto para multiplicar dos números
    public abstract double Multiplicar(double N1, double N2);

    // Método abstracto para dividir dos números
    public abstract double Dividir(double N1, double N2);

    // Método abstracto para imprimir un resultado
    public abstract void Imprimir(string operacion, double resultado);
}
using System;

namespace FigurasGeometricas
{
    public class Cuadrado
    {    // Almacena el valor del lado del cuadrado
        public double Lado { get; set; }
        // Inicializa el cuadrado con un valor de lado
        public Cuadrado(double lado)
        {
            Lado = lado;
        }
         // Calcula el área del cuadrado
        public double CalcularArea()
        {
            return Lado * Lado;
        }
        // Calcula el perímetro del cuadrado
        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}


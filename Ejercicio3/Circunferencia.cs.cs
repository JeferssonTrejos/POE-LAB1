using System;

namespace FigurasGeometricas
{
    public class Circunferencia
    {    // Almacena el valor del radio de la circunferencia
        public double Radio { get; set; }
        // Inicializa la circunferencia con un valor de radio
        public Circunferencia(double radio)
        {
            Radio = radio;
        }
        // Calcula el área de la circunferencia
        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
        // Calcula el perímetro de la circunferencia
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}

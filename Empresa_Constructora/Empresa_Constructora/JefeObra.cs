using System;

namespace Empresa_Constructora
{
    // JefeObra hereda de Obrero
    public class JefeObra : Obrero
    {
        public double Bonificacion { get; set; }

        // Constructor de JefeObra
        // Llama al constructor de la clase base (Obrero) usando 'base'
        public JefeObra(string nombre, string apellido, string dni, int legajo, double sueldo, string cargo, double bonificacion)
            : base(nombre, apellido, dni, legajo, sueldo, cargo)
        {
            Bonificacion = bonificacion;
        }

    }
}
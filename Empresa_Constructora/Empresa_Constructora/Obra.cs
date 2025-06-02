// Obra.cs
using System;
using System.Collections; // Necesario para ArrayList

namespace Empresa_Constructora
{
    public class Obra
    {
        public string Nombre { get; set; }
        public string TipoObra { get; set; }
        public int CodigoObra { get; set; } // Identificador único para la obra
        public string EstadoObra { get; set; } // Ej: "En Ejecución", "Finalizada", "Pausada"
        public double CostoObra { get; set; }
        public JefeObra JefeAsignado { get; set; } // Referencia al Jefe de Obra asignado
        public ArrayList GruposAsignados { get; set; } // Colección de objetos GrupoObreros

        // Constructor
        public Obra(string nombre, string tipoObra, int codigoObra, string estadoObra, double costoObra, JefeObra jefeAsignado)
        {
            Nombre = nombre;
            TipoObra = tipoObra;
            CodigoObra = codigoObra;
            EstadoObra = estadoObra;
            CostoObra = costoObra;
            JefeAsignado = jefeAsignado;
            GruposAsignados = new ArrayList(); // Inicializa el ArrayList vacío
        }
    }
}
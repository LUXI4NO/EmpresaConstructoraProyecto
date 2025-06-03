using System;
using System.Collections;

namespace Empresa_Constructora
{
    public class GrupoObreros
    {
        public int GrupoId { get; set; }
        public string NombreGrupo { get; set; }
        public ArrayList ListaObreros { get; set; }

        public GrupoObreros(int id, string nombre)
        {
            GrupoId = id;
            NombreGrupo = nombre;
            ListaObreros = new ArrayList();
        }

        public void AgregarObrero(Obrero obrero)
        {
            ListaObreros.Add(obrero);
            Console.WriteLine("Se asignó a " + obrero.Nombre + " " + obrero.Apellido + " al grupo " + NombreGrupo);
        }

        public void EliminarObreros(int legajoObrero)
        {
            Obrero obreroARemover = null;

            foreach (Obrero o in ListaObreros)
            {
                if (o.Legajo == legajoObrero)
                {
                    obreroARemover = o;
                    break;
                }
            }

            if (obreroARemover != null)
            {
                ListaObreros.Remove(obreroARemover);
                Console.WriteLine("Obrero " + obreroARemover.Nombre + " " + obreroARemover.Apellido + " (Legajo: " + legajoObrero + ") eliminado del Grupo " + GrupoId);
            }
            else
            {
                Console.WriteLine("Obrero con legajo " + legajoObrero + " no encontrado en el Grupo " + GrupoId);
            }
        }
    }
}

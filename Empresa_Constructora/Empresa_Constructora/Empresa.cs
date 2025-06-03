using System;
using System.Collections;

namespace Empresa_Constructora
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public ArrayList ObrasEnEjecucion { get; set; }
        public ArrayList ObrasFinalizadas { get; set; }
        public ArrayList TodosLosObreros { get; set; }
        public ArrayList TodosLosGrupos { get; set; }

        public Empresa(string nombre)
        {
            Nombre = nombre;
            ObrasEnEjecucion = new ArrayList();
            ObrasFinalizadas = new ArrayList();
            TodosLosObreros = new ArrayList();
            TodosLosGrupos = new ArrayList();
        }

        public void ContratarObrero(Obrero nuevoObrero)
        {
            foreach (Obrero o in TodosLosObreros)
            {
                if (o.Legajo == nuevoObrero.Legajo)
                {
                    throw new LegajoDuplicadoException("El legajo " + nuevoObrero.Legajo + " ya está registrado.");
                }
            }

            TodosLosObreros.Add(nuevoObrero);
            Console.WriteLine("Se ha añadido a " + nuevoObrero.Nombre + " " + nuevoObrero.Apellido + " a la empresa " + Nombre);
        }

        public void AsignarObreroAGrupo(int legajoObrero, int grupoId)
        {
            Obrero obreroEncontrado = null;
            GrupoObreros grupoEncontrado = null;

            foreach (Obrero o in TodosLosObreros)
            {
                if (o.Legajo == legajoObrero)
                {
                    obreroEncontrado = o;
                    break;
                }
            }

            if (obreroEncontrado == null)
                throw new ObreroNoEncontradoException("No se encontró obrero con legajo " + legajoObrero);

            foreach (GrupoObreros g in TodosLosGrupos)
            {
                if (g.GrupoId == grupoId)
                {
                    grupoEncontrado = g;
                    break;
                }
            }

            if (grupoEncontrado == null)
                throw new GrupoObrerosNoEncontradoException("No se encontró grupo con ID " + grupoId);

            grupoEncontrado.ListaObreros .Add(obreroEncontrado);
            Console.WriteLine("Se asignó a " + obreroEncontrado.Nombre + " " + obreroEncontrado.Apellido + " al grupo " + grupoEncontrado.NombreGrupo);
        }
        
       
		public void EliminarObreroPorLegajo(int legajo)
		{
		    Obrero obreroAEliminar = null;
		
		    foreach (Obrero o in TodosLosObreros)
		    {
		        if (o.Legajo == legajo)
		        {
		            obreroAEliminar = o;
		            break;
		        }
		    }
		
		    if (obreroAEliminar != null)
		    {
		        TodosLosObreros.Remove(obreroAEliminar);
		
		        foreach (GrupoObreros grupo in TodosLosGrupos)
		        {
		            grupo.EliminarObreros(legajo);
		        }
		
		        Console.WriteLine("Obrero eliminado completamente: " + obreroAEliminar.Nombre + " " + obreroAEliminar.Apellido);
		    }
		    else
		    {
		        throw new ObreroNoEncontradoException("No se encontró un obrero con legajo " + legajo);
		    }
		}

    }
}

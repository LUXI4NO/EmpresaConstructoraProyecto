using System.Collections;

namespace Empresa_Constructora
{
    public class GrupoObreros
    {
        public int GrupoId { get; set; }
        public string NombreGrupo { get; set; }
        public ArrayList ObrerosDelGrupo { get; set; }

        public GrupoObreros(int id, string nombre)
        {
            GrupoId = id;
            NombreGrupo = nombre;
            ObrerosDelGrupo = new ArrayList();
        }
    }
}

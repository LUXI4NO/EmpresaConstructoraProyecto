using System;

namespace Empresa_Constructora
{
    public class LegajoDuplicadoException : Exception
    {
        public LegajoDuplicadoException(string mensaje) : base(mensaje) { }
    }

    public class ObreroNoEncontradoException : Exception
    {
        public ObreroNoEncontradoException(string mensaje) : base(mensaje) { }
    }

    public class GrupoObrerosNoEncontradoException : Exception
    {
        public GrupoObrerosNoEncontradoException(string mensaje) : base(mensaje) { }
    }
}

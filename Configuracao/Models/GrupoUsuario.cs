

using System;
using System.Collections.Generic;

namespace Models
{
    public class GrupoUsuario
    {
        public string NomeGrupo { get; set; }
        public List<Permissao> Permissoes { get; set; }
        public int Id { get; set; }

        public void Add(GrupoUsuario grupousuario)
        {
            throw new NotImplementedException();
        }
    }
}

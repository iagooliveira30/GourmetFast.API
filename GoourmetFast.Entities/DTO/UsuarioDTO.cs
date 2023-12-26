using GourmetFast.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetFast.Core.DTO
{
    public class UsuarioDTO
    {
        public  Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        //public Usuario(UsuarioDTO usuario)
        //{
        //    Id = usuario.Id;
        //    Name = usuario.Name;
        //    Email = usuario.Email;
        //    Telefone = usuario.Telefone;
        //    Endereco = usuario.Endereco;

        //}
    }   
}

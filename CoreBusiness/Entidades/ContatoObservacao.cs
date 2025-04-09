using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Entidades
{
    public class ContatoObsercavao
    {

        public ContatoObsercavao()
        {

        }

        public ContatoObsercavao(string nome, string? email, string observacao)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Observacao = observacao;

        }

        public ContatoObsercavao(Guid id, string nome, string? email, string observacao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Observacao = observacao;
        }

        [Required]
        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Observacao { get; set; }
    }


}

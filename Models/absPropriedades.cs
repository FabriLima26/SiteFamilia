using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace SiteFamilia.Models
{
    public abstract class absPropriedades : intMetodo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MaxLength(50)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Sobrenome é obrigatório")]
        [MaxLength(50)]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O Cpf é obrigatório")]
        [MaxLength(11)]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "É necessário um endereço de E-mail")]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Insira uma Data de Nascimento")]
        public DateTime Nascimento { get; set; }
        [Required(ErrorMessage = "Insira a sua altura")]
        public int Altura { get; set; }

        public absPropriedades(int id, string nome, string sobrenome, string cpf, string email, DateTime nascimento, int altura)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Email = email;
            Nascimento = nascimento;
            Altura = altura;
        }

        protected absPropriedades()
        {
        }

        public virtual void Executar()
        {
          
        }
    }
}

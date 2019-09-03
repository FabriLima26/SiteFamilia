using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteFamilia.Models
{
    public class Mae : absPropriedades
    {
        public Mae(int id, string nome, string sobrenome, string cpf, string email, DateTime nascimento, int altura) : base(id, nome, sobrenome, cpf, email, nascimento, altura)
        {
            Executar();
        }

        public  Mae()
        {

        }

        public override void Executar()
        {
            base.Executar();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
              
       
        public Int32 idade { get; set; }

        public CPF CPF { get; private set; }

        public Cliente(string nome, string email, string cpfNumero, DateTime cpfDataEmissao)
        {

            Nome = nome;

            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Nome em branco! Não é possível criar instância de Cliente");

            if (!AtribuirCpf(cpfNumero, cpfDataEmissao))
                throw new Exception("CPF Inválido! Não é possível criar instância de Cliente");

            
        }

        // Para o EF
        protected Cliente() { }

        public bool AtribuirCpf(string cpfNumero, DateTime cpfDataEmissao)
        {
            var cpf = new CPF(cpfNumero, cpfDataEmissao);
            if (!cpf.Validar()) return false;

            CPF = cpf;
            return true;
        }

       

        public bool EhValido()
        {
            if (string.IsNullOrEmpty(Nome))
                return false;

           

            if (!CPF.Validar())
                return false;

            return true;
        }


    }
}

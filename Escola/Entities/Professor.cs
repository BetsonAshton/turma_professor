using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Escola.Entities
{
    public class Professor
    {
        private Guid _idProfessor;
        private string _nomeProfessor;
        private string _telefone;
        private string _cpfProfessor;


        public Guid IdProdessor
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("Por favor informe O id do professor correto");

                _idProfessor = value;
            }

            get => _idProfessor;



        }

        public string NomeProfessor
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor, Informe o nome do professor");

                var regex = new Regex("^[A-Za-z\\s]{8,50}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe um nome válido.");

                _nomeProfessor = value;
            }

            get => _nomeProfessor;
        }

        public string telefone
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor o Telefone do professor");

                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor informe um Número de telefone inválido");
                _telefone = value;
            }
            get => _telefone;
        }

        public string cpfProfessor
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Por favor informe o cpf");

                var regex = new Regex("^[0-9]{11}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe um cpf válido");

                _cpfProfessor = value;
            }

            get => _cpfProfessor;
        }


        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Escola.Entities
{
    public class Turma
    {
        private Guid _id;
        private string _nome;
        private DateTime _DataInicio;
        private Professor _professor;



        public Guid Id
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentNullException("Por favor insira um Id válido!");
                _id = value;
            }

            get => _id;

        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Informe o nome da  turma.");

                var regex = new Regex("^[A-za-zÁ-Üá-ü\\s]{8,100}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe um nome válido.");
                _nome = value;
            }

            get => _nome;
        }

        public DateTime DataInicio
        {
            set
            {
                if (value == DateTime.MinValue)
                    throw new ArgumentException("Por favor insira um data válida");

                _DataInicio = value;


            }
            get => _DataInicio;
        }


        public Professor Professor
        {
            set { _professor = value; }
            get => _professor;

        }

    }





}

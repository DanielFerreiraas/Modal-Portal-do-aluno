using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    public class Aluno
    {

        public string Nome {  get; set; }

        public int Idade { get; set; }

        public string Curso { get; set; }

        public Aluno() { }

        public Aluno(string nome, string idade, string curso)
        {

            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("O Nome é obrigatório");
            }

            if (string.IsNullOrEmpty(idade))
            {
                throw new Exception("A Idade é obrigatória");
            }

            if (string.IsNullOrEmpty(curso))
            {
                throw new Exception("O curso é obrigatório");
            }

            Nome = nome;
            Idade = int.Parse(idade);
            Curso = curso;
        }
    }
    }

using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infrastructure
{
    public class AlunoRepository
    {

        public bool Add(Aluno aluno)
        {
            using var conn = new DbConnect();

            string query = @"INSERT INTO public.alunos(nome, idade, curso) VALUES (@nome, @idade, @curso);";
            var result = conn.Connection.Execute(sql: query, param: aluno);

            return result == 1;
        }

        public List<Aluno> GetAll()
        {
            using var conn = new DbConnect();
            string query = @"SELECT * FROM alunos;";

            var alunos = conn.Connection.Query<Aluno>(sql: query);

            return alunos.ToList();
        }
    }
}

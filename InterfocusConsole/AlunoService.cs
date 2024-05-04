using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InterfocusConsole
{
    public class AlunoService
    {
        private static List<Aluno> Alunos = new List<Aluno>();
        private static int Contador = 0;

        public static bool Validar(Aluno aluno, out List<ValidationResult> err)
        {
            err = new List<ValidationResult>();
            
            var valido = Validator.TryValidateObject(aluno, new ValidationContext(aluno), err, true);
            var diaMinimo = DateTime.Today.AddYears(-18);

            if(aluno.DataNascimento > diaMinimo)
            {
                err.Add(new ValidationResult("Aluno menor de idade", new[] { "DataNascimento" }));
                valido = false;
            }

            return valido;
        }
        public static bool CriarAluno(Aluno aluno, out List<ValidationResult> err)
        {
            aluno.Codigo = Contador++;
            var valido = Validar(aluno, out err);

            if (valido)
            {
                Alunos.Add(aluno);
            }
            else
            {
                foreach (var erro in err)
                {
                    Console.WriteLine("{0}: {1}",
                        erro.MemberNames.First(),
                        erro.ErrorMessage
                    );
                }
            }
        }

        public static bool Editar(Aluno alunos, out List<ValidationResult> err)
        {
            var alunoExistente = Alunos.FirstOrDefault(x => x.Codigo == alunos.Codigo);

            err = new List<ValidationResult>();

            if(alunoExistente == null)
            {
                return false;
            }

            if(valido)
            {
                alunoExistente.Nome = alunos.Nome;
                alunoExistente.Email = alunos.Email;
                alunoExistente.DataNascimento = alunos.DataNascimento;
            }

            return valido;
        }

        public static List<Aluno> Listar()
        {
            return Alunos;
        }
        public static List<Aluno> Listar(string buscaAluno, int skip = 0, int pageSize = 0)
        {
            var consulta = Alunos.Where(procura =>
                procura.Codigo.ToString() == buscaAluno
                ).ToList();
 
            return consulta;
        }

        public static Aluno Remover(int codigo)
        {
            var aluno = Alunos
                        .Where(x => x.Codigo == codigo)
                        .FirstOrDefault();

            Alunos.Remove(aluno);
            return aluno;
        }
    }
}

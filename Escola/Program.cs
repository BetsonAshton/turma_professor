
using Escola.Entities;
using Escola.Repositories;

namespace Escola
{

    public class Program
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("\n *** Digite a turma ***\n");

            var turma = new Turma();
            turma.Professor = new Professor();

            try
            {
                turma.Id = Guid.NewGuid();
                turma.Professor.IdProdessor = Guid.NewGuid();

                Console.Write("Informe a turma...: ");
                turma.Nome = Console.ReadLine();

                Console.Write("Informe a Data de Início....: ");
                turma.DataInicio = DateTime.Parse(Console.ReadLine());


                Console.WriteLine("\nDados do Professor...: ");

                Console.WriteLine("\nInforme o nome do professor...: ");
                turma.Professor.NomeProfessor = Console.ReadLine();

                Console.WriteLine("\nInforme o Telefone....: ");
                turma.Professor.telefone = Console.ReadLine();

                Console.WriteLine("\nInforme o Cpf....: ");
                turma.Professor.cpfProfessor = Console.ReadLine();


                Console.WriteLine("\nDados da turma\n ");
                Console.WriteLine($"\tId........:{turma.Id}");
                Console.WriteLine($"\tNome.......: {turma.Nome}");
                Console.WriteLine($"\tData de Início.......: {turma.DataInicio}");
                Console.WriteLine($"\tId do professor.......:{turma.Professor.IdProdessor}");
                Console.WriteLine($"\tNome do professor......:{turma.Professor.NomeProfessor}");
                Console.WriteLine($"\tTelefone do professor.....{turma.Professor.telefone}");
                Console.WriteLine($"\tCpf do Professor......:{turma.Professor.cpfProfessor}");

                Console.WriteLine("\nEscolha (1)JSON ou (2)XML...:");

                var opcao = int.Parse(Console.ReadLine());

                var turmaRepository = new TurmaRepository();

                switch (opcao)
                {
                    case 1:

                        turmaRepository.ExportarJson(turma);
                        Console.WriteLine("\nArquivo JSON gravado com sucesso!");
                        break;

                    case 2:

                        turmaRepository.ExportarXml(turma);
                        Console.WriteLine("\nArquivo XML gravado com sucesso!");
                        break;

                    default:

                        Console.WriteLine("\nOpção Inválida!");
                        break;
                }

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nErro de validação: ");
                Console.WriteLine(e.Message);

                Console.WriteLine("\nDeseja Tentar de Novo? (S,N)");

                var opcao = Console.ReadLine();

                if (opcao.Equals("S", StringComparison.OrdinalIgnoreCase))

                {
                    Console.Clear(); 
                    Main(args);
                }
                else
                {
                    Console.WriteLine("\nFim!");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nFalha ao executar o Programa: ");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }

}



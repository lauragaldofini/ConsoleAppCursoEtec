using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contD = 0;
            int contE = 0;
            int contA = 0;
            int contM = 0;
            string respost = "S";
            while (respost == "S")
            {
                Console.WriteLine("[Informe qual o seu curso: (A)administração, (E)" +
                    "edificaçoes,(D)desenvolvimento, (M)mecatrônica]");
                string curso = Console.ReadLine().ToUpper();
                switch (curso)
                {
                    

                    case "A":
                        if (contA < 5)
                        {
                            contA++;
                            Console.WriteLine("Matrícula em Administração realizada! ");
                        }
                        else
                        {
                            Console.WriteLine("Não existe mais vagas disponíveis para este curso");
                        }
                        break;


                    case "E":
                        if (contE < 5)
                        {
                            contE++;
                            Console.WriteLine("Matrícula em Edificações realizada! ");
                        }
                        else
                        {
                            Console.WriteLine("Não existe mais vagas disponíveis para este curso");
                        }
                        break;

                    case "D":
                        if (contD < 5)
                        {
                            contD++;
                            Console.WriteLine("Matrícula em desenvolvimento realizada! ");
                        }
                        else
                        {
                            Console.WriteLine("Não existe mais vagas disponíveis para este curso");
                        }
                        break;

                    case "M":
                        if (contM < 5)
                        {
                            contM++;
                            Console.WriteLine("Matrícula em Mecatrônica realizada! ");
                        }
                        else
                        {
                            Console.WriteLine("Não existe mais vagas disponíveis para este curso");
                        }
                        break;

                    default:
                        Console.WriteLine("opção inválida!");
                        break;

                }
                Console.WriteLine("VAGAS RESTANTES" +
                           "| Administração:" + (5 - contA) +
                           "| Desenvolvimento:" + (5 - contD) +
                           "| Mecatrônica:" + (5 - contM) +
                           "| Edificaçoes:" + (5 - contE));


                Console.WriteLine("Deseja cadastrar outro aluno?:[N- não, S- sim ");
                respost = Console.ReadLine().ToUpper();
                Console.Clear();

            }
            Console.WriteLine("ALUNOS MATRICULADOS:" +
                       "| Administração:" + contA +
                       "| Mecatrônica:" + contM +
                        " Desenvolvimento:" + contD +
                       "| Edificações:" + contE +
                        "| Total de matrículas:" + (contA + contM + contD + contE));
            Console.ReadKey();
        }
    }
}
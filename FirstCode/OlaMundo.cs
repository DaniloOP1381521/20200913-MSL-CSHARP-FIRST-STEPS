using System;

namespace FirstCode
{
    public class OlaMundo
    {
        public static void MeuPrimeiroCodigo()
        {
            Console.Clear();
            Console.WriteLine ("Bem-Vindo ao Módulo Escreva seu primeiro código C#(CSharp)");
            Console.WriteLine ("----------------------------------------------------------");
            Console.WriteLine("Gostaria de ver o código ? ");
            Option();
        }

        static void Option()
        {
            try
            {
                Console.WriteLine("1 - Sim");
                Console.WriteLine("0 - Não");
                Console.ReadKey();

                short op = short.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: VerCodigo(); break;
                    case 0: System.Environment.Exit(0);
                            Console.WriteLine("Obrigado pela sua presença");
                            break;
                    default: break;
                }
            }
            catch (System.FormatException ex)
            {
                // https://social.msdn.microsoft.com/Forums/vstudio/en-US/fc6b2e87-3d54-4608-b6bf-4723613333bf/input-string-was-not-in-a-correct-format?forum=netfxbcl
                throw ex;
                // throw new ArgumentException("A string de entrada não estava em um formato correto", ex.Message);
            }
        }

        static void VerCodigo()
        {
            Console.WriteLine("Escreva alguma frase ?");
            string frases = (Console.ReadLine());

            Console.WriteLine(string.Format($"Console.WriteLine({frases}"));
        }
    }
}
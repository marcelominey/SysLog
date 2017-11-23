using System;
using System.Security.Cryptography;
using System.Text;

namespace Syslog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(encriptSenha("123"));

            string opcao = "";

            do{
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Logar");
                Console.WriteLine("3 - Logout");
                Console.WriteLine("9 - Sair");

                Console.WriteLine();
                Console.WriteLine("Digite a opção desejada:");

                opcao = Console.ReadLine();
                        
                switch (opcao){
                    case "1":
                    break;

                    case "2":
                    break;

                    case "3":
                    break;

                    case "9":
                    break;

                     default:
                        Console.WriteLine("Opção inválida");
                    break;
                }
            }
            while(opcao != "9");




        }
        static string encriptSenha(string senha){
            byte[] senhaOriginal; //cada letra tem um conjunto de bytes. Cada letra vai virar um ARRAY de bytes.
            byte[] senhaModificada;
            MD5 mD5;

            senhaOriginal = Encoding.Default.GetBytes(senha);
            //pegando os bytes dentro do ARRAY de bytes;
            // Pega cada letra, retira os bytes daquela letra e coloca numa posição.
            //Encoding.Default: estou usando o padrão de caractere que o meu SO usa.

            mD5 = MD5.Create(); //Classe ABSTRATA: não tem construtor (new, etc). então uso diretamente o método CREATE, do MD5.
            senhaModificada = mD5.ComputeHash(senhaOriginal); //
            return Convert.ToBase64String(senhaModificada); //ToBase: convertendo cada elemento do ARRAY de bytes numa STRING            
        }
    }
}

using System;
using System.IO;

namespace Syslog
{
    public class cadUsuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public cadUsuario(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }

        public bool Cadastrar(){
            bool cadEfetuado = false;
            StreamWriter arquivo = null;
            
            arquivo = new StreamWriter("cadUsuario.txt", true);
            arquivo.WriteLine(Login + ";" + Senha);

            cadEfetuado = true;

            arquivo.Close();

            return cadEfetuado;

        }
    }
}

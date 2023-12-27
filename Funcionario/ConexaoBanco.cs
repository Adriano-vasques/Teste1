using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    static class ConexaoBanco
    {
        // variáveis declaraas passano as informações do banco de dados
        private const string servidor = "localhost";
        private const string bancoDados = "dbFuncionarios";
        private const string usuario = "root";
        private const string senha = "Calale200495!";

        // declarando variável conexaoBanco para fazer a conexão com o banco de dados
        static public string bancoServidor = $"server ={servidor}; user id ={usuario}; database ={bancoDados}; password ={senha}";
    
    }
}

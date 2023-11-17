using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Prototipo_po2.Conexao
{
    internal class Conexoes
    {
        private string _servidor = "localhost";
        private string _porta = "3360";
        private string _usuario = "root";
        private string _senha = "root";
        private string _bancosDadosnome = "Empresa_x2a_bd";
        private MySqlConnection connection;
        private MySqlCommand command;


        public Conexoes()
        {
            try
            {
                connection = new MySqlConnection($"server={_servidor};database={_bancosDadosnome};port={_porta};user={_usuario};password={_senha}");
                connection.Open();
            }
            catch ( Exception ex ) 
            {
                throw ex;
            }   

        }

        public MySqlCommand Comando(string comando)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = comando;
                return command;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}

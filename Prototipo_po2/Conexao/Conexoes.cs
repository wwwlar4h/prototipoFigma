using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Prototipo_po2.Conexao
{
    public class Conexoes
    {
        private string _servidor = "localhost";
        private string _porta = "3306";
        private string _usuario = "root";
        private string _senha = "Lar4h_2006#";
        private string _bancosDadosnome = "bd_Prototipo_atvfinal";
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

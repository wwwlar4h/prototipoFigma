using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using Prototipo_po2.Conexao;
using Org.BouncyCastle.Math.Field;

namespace Prototipo_po2
{
    public partial class Form1 : Form
    {
        List<Funcionario> listafun = new List<Funcionario>();
        public Form1()
        {
            InitializeComponent();

            Consultar();

            btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_cadastrar.FlatAppearance.BorderSize = 0;
            btn_cadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_cadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_cadastrar.BackColor = Color.Transparent;

            btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_cancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_cancelar.BackColor = Color.Transparent;

            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

            string sala = msk_sala.Text;
            string nome = txt_name.Text;
            string datanas = msk_data.Text;
            string tele = msk_tele.Text;
            string email = txt_email.Text;
            string ende = txt_ende.Text;
            string estado = txt_estado.Text;
            string cpf = msk_cpf.Text;
            string rg = msk_rg.Text;
            string funcao = cm_estadocivil.Text;
            string cidade = txt_cidade.Text;
            string id = txt_id.Text;

            Funcionario f = new Funcionario();

        }
        private void Inserir(Funcionario funcionario)
        {
            try
            {
                Conexoes conexao = new Conexoes();

                var comando = conexao.Comando("INSERT INTO Funcionario (nome_Fun,email_Fun,endereco_Fun,estado_Fun,cidade_Fun,telefone_Fun, rg_Fun, cpf_Fun,data_nas_Fun, funcao_social_Fun, estado_civil_Fun, salario_Fun ) " +
                    "VALUES (@nome_Fun, @email_Fun, @endereco_Fun, @estado_Fun, @cidade_Fun, @telefone_Fun, @rg_Fun, @cpf_Fun, @data_nas_Fun, @funcao_social_Fun, @estado_civil_Fun, @salario_Fun)");

                comando.Parameters.AddWithValue("@nome_Fun", funcionario.name);
                comando.Parameters.AddWithValue("@email_Fun", funcionario.email);
                comando.Parameters.AddWithValue("@endereco_Fun", funcionario.endereco);
                comando.Parameters.AddWithValue("@estado_Fun", funcionario.estado);
                comando.Parameters.AddWithValue("@cidade_Fun", funcionario.cidade);
                comando.Parameters.AddWithValue("@telefone_Fun", funcionario.telefone);
                comando.Parameters.AddWithValue("@rg_Fun", funcionario.rg);
                comando.Parameters.AddWithValue("@cpf_Fun", funcionario.cpf);
                comando.Parameters.AddWithValue("@data_nas_Fun", funcionario.datanas);
                comando.Parameters.AddWithValue("@funcao_social_Fun", funcionario.funcao);
                comando.Parameters.AddWithValue("@estado_civil_Fun", funcionario.estsocial);
                comando.Parameters.AddWithValue("@salario_Fun", funcionario.salario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0) { MessageBox.Show("Funcionario Cadastrado com Sucesso", "OK", MessageBoxButtons.OK); }

            }
            catch (Exception ex) { throw ex; }
        }

        public void Consultar()
        {
            try
            {
                var conexao = new Conexoes();

                var comando = conexao.Comando("SELECT * FROM funcionario");

                var leitor = comando.ExecuteReader();

                string resultado = null;

                while (leitor.Read())
                {
                    Funcionario fun = new Funcionario();
                    fun.name = DAOHelper.GetString(leitor, "nome_Fun");
                    fun.email = DAOHelper.GetString(leitor, "email_Fun"); 
                    fun.endereco = DAOHelper.GetString(leitor, "endereco_Fun");
                    fun.estado = DAOHelper.GetString(leitor, "estado_Fun");
                    fun.cidade = DAOHelper.GetString(leitor, "cidade_Fun");
                    fun.telefone = DAOHelper.GetString(leitor, "telefone_Fun");
                    fun.rg = DAOHelper.GetString(leitor, "rg_Fun");
                    fun.cpf = DAOHelper.GetString(leitor, "cpf_Fun");
                    fun.datanas = DAOHelper.GetString(leitor, "data_nas_Fun");
                    fun.funcao = DAOHelper.GetString(leitor, "funcao_social_Fun");
                    fun.estsocial = DAOHelper.GetString(leitor, "estado_civil_Fun");
                    fun.salario = DAOHelper.GetString(leitor, "salario_Fun");

                    listafun.Add(fun);
                }
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = listafun;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LimparTextBoxs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }

        public bool ExistemTextBoxVazios()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    var text = control.Text.Replace(",", "").Replace("-", "").Trim();

                    if (text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
          
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
        }

        private void msk_sala_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void msk_tele_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void msk_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void msk_rg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void msk_data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void msk_rg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void cm_funcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {

            Validacoes.ValidaCpf(msk_cpf.Text);
            Validacoes.ValidarEmail(txt_email.Text);
            MessageBox.Show(Validacoes.ValidaCpf(msk_cpf.Text).ToString());


            Funcionario f = new Funcionario();
            f.name = txt_name.Text;
            f.datanas = msk_data.Text;
            f.telefone = msk_tele.Text;
            f.email = txt_email.Text;
            f.endereco = txt_ende.Text;
            f.estado = txt_estado.Text;
            f.cpf = msk_cpf.Text;
            f.rg = msk_rg.Text;
            f.funcao = cm_estadocivil.Text;
            f.cidade = txt_cidade.Text;
            f.id = txt_id.Text;
            f.salario = msk_sala.Text;
            f.estsocial = cm_estadocivil.Text;


            if (ExistemTextBoxVazios())
            {
                MessageBox.Show("Todos os campos são obrigatótios. Favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Inserir(f);
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            cm_estadocivil.Text = "";
            cm_funcao.Text = "";
            msk_data.Text = "";
            msk_tele.Text = "";
            txt_id.Clear();
            txt_name.Clear();
            msk_data.Clear();
            msk_cpf.Clear();
            msk_rg.Clear();
            txt_ende.Clear();
            txt_email.Clear();
            txt_cidade.Clear();
            msk_sala.Clear();
            txt_estado.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button_voltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
        

       


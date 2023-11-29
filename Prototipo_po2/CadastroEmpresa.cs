using Prototipo_po2.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_po2
{
    public partial class CadastroEmpresa : Form
    {
        private List<Empresa> listaemp = new List<Empresa>();
       

        public CadastroEmpresa()
        {
            InitializeComponent();
            Consultar();
        }

        private void Inserir(Empresa empresa)
        {
            try
            {
                Conexoes conexao = new Conexoes();

                var comando = conexao.Comando("INSERT INTO empresa (cnpj_Emp, situacao_cadastral_Emp, capital_social_Emp, razao_social_Emp, nome_fantasia_Emp, tipo_Emp, data_inicio_atividade_Emp, telefone_Emp, regime_tributario_Emp, cidade_Emp, natureza_jur_Emp, estado_Emp, porte_Empresa_Emp, nome_proprietario_Emp, cpf_proprietario_Emp)" +
                    " VALUES (@cnpj_Emp,@situacao_cadastral_Emp,@capital_social_Emp,@razao_social_Emp,@nome_fantasia_Emp,@tipo_Emp,@data_inicio_atividade_Emp,@telefone_Emp,@regime_tributario_Emp,@cidade_Emp,@natureza_jur_Emp,@estado_Emp,@porte_Empresa_Emp,@nome_proprietario_Emp,@cpf_proprietario_Emp)");

                comando.Parameters.AddWithValue("@cnpj_Emp", empresa.cnpj);
                comando.Parameters.AddWithValue("@situacao_cadastral_Emp", empresa.situacaoCadastral); 
                comando.Parameters.AddWithValue("@capital_social_Emp", empresa.capitalsocial);
                comando.Parameters.AddWithValue("@razao_social_Emp", empresa.razaosocial);
                comando.Parameters.AddWithValue("@nome_fantasia_Emp", empresa.nomeFantasia);
                comando.Parameters.AddWithValue("@tipo_Emp", empresa.tipo);
                comando.Parameters.AddWithValue("@data_inicio_atividade_Emp", empresa.datainicio);
                comando.Parameters.AddWithValue("@telefone_Emp", empresa.telefone);
                comando.Parameters.AddWithValue("@regime_tributario_Emp", empresa.regimeTribu); 
                comando.Parameters.AddWithValue("@cidade_Emp", empresa.cidade);
                comando.Parameters.AddWithValue("@natureza_jur_Emp", empresa.natureza);
                comando.Parameters.AddWithValue("@estado_Emp", empresa.estado);
                comando.Parameters.AddWithValue("@porte_Empresa_Emp", empresa.porte);
                comando.Parameters.AddWithValue("@nome_proprietario_Emp", empresa.nomeproprie);
                comando.Parameters.AddWithValue("@cpf_proprietario_Emp", empresa.cpfproprie);


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0) { MessageBox.Show("Empresa Cadastrada com Sucesso", "OK", MessageBoxButtons.OK); }

            }
            catch (Exception ex) { throw ex; }
        }
        public void Consultar()
        {
            try
            {
                var conexao = new Conexoes();

                var comando = conexao.Comando("SELECT * FROM empresa");

                var leitor = comando.ExecuteReader();

                string resultado = null;

                while (leitor.Read())
                {
                    Empresa empresa = new Empresa();
                    empresa.cnpj = DAOHelper.GetString(leitor, "cnpj_Emp");
                    empresa.situacaoCadastral = DAOHelper.GetString(leitor, "situacao_cadastral_Emp");
                    empresa.capitalsocial = DAOHelper.GetDouble(leitor, "capital_social_Emp");
                    empresa.razaosocial = DAOHelper.GetString(leitor, "razao_social_Emp");
                    empresa.nomeFantasia = DAOHelper.GetString(leitor, "nome_fantasia_Emp");
                    empresa.tipo = DAOHelper.GetString(leitor, "tipo_emp");
                    empresa.datainicio = DAOHelper.GetString(leitor, "data_inicio_atividade_Emp");
                    empresa.telefone = DAOHelper.GetString(leitor, "telefone_Emp");
                    empresa.regimeTribu = DAOHelper.GetString(leitor, "regime_tributario_Emp");
                    empresa.cidade = DAOHelper.GetString(leitor, "cidade_emp");
                    empresa.natureza = DAOHelper.GetString(leitor, "natureza_jur_Emp");
                    empresa.estado = DAOHelper.GetString(leitor, "estado_Emp");
                    empresa.porte = DAOHelper.GetString(leitor, "porte_Empresa_Emp");
                    empresa.nomeproprie = DAOHelper.GetString(leitor, "nome_proprietario_Emp");
                    empresa.cpfproprie = DAOHelper.GetString(leitor, "cpf_proprietario_Emp");


                    listaemp.Add(empresa);
                }
                dtv_empresa.DataSource = null;
                dtv_empresa.Refresh();
                dtv_empresa.DataSource = listaemp;
            }

            catch
            {
                throw;
            }
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void CadastroEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ExistemTextBoxVazios()
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

        private void cancelar_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = false;
            radioButton4.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;   
            radioButton3.Checked = false;

            txt_cnpj.Clear();
            txt_razao.Clear();
            capsocial.Clear();
            comboBox2.Text = "";
            msk_datainicio.Clear();          
            msk_telefone.Clear();
            txt_nome.Clear();
            txt_cpf.Clear();
            comboBox1.Text = "";
            textBox6.Clear();
            cb_situ_cadastral.Text = "";
            txt_nomefantasia.Clear();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string PercorrerPanelPorte()
        {
            string radio = "";

            foreach (Control ctrl in panel5.Controls)
            {
                if(ctrl is RadioButton rb && rb.Checked)    
                  {
                    radio = rb.Text;
                    break;
                  }
            }
            return radio;
        }

        public string PercorrerPanelTipo()
        {
            string radio = "";

            foreach(Control ctrl in panel2.Controls)
            {
                if(ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }
            return radio; 
        }

        public string PercorrerPanelRegime()
        {
            string radio = "";

            foreach (Control ctrl in panelRegime.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }
            return radio;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Empresa emp = new Empresa();
            emp.cnpj = txt_cnpj.Text;
            emp.razaosocial = txt_razao.Text;
            emp.capitalsocial = Convert.ToDouble(capsocial.Text);
            emp.natureza = comboBox2.Text;
            emp.datainicio = msk_datainicio.Text;
            emp.telefone = msk_telefone.Text;
            emp.nomeproprie = txt_nome.Text;
            emp.cpfproprie = txt_cpf.Text;
            emp.estado = comboBox1.Text;
            emp.cidade = textBox6.Text;
            emp.porte = PercorrerPanelPorte();
            emp.tipo = PercorrerPanelTipo();
            emp.regimeTribu = PercorrerPanelRegime();
            emp.situacaoCadastral = cb_situ_cadastral.Text;
            emp.nomeFantasia = txt_nomefantasia.Text;
            
            if (ExistemTextBoxVazios())
            {
                MessageBox.Show("Todos os campos são obrigatótios. Favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Inserir(emp);
            }
        }
      
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

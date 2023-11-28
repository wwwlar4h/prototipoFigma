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
        public CadastroEmpresa()
        {
            InitializeComponent();
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

            foreach (Control ctrl in panel1.Controls)
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
            emp.datainicio = Convert.ToDateTime(msk_datainicio.Text);
            emp.regimeTribu = PercorrerPanelRegime();
            emp.telefone = msk_telefone.Text;
            emp.nomeproprie = txt_nome.Text;
            emp.cpfproprie = txt_cpf.Text;
            emp.estado = comboBox1.Text;
            emp.cidade = textBox6.Text;
            emp.porte = PercorrerPanelPorte();
            emp.tipo = PercorrerPanelTipo();
            emp.situacaoCadastral = cb_situ_cadastral.Text;




        }
    }
}

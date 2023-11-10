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

namespace Prototipo_po2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

           Funcionario f = new Funcionario (id, nome, datanas, email, ende, estado, tele, funcao, rg, cpf, cidade, funcao);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cm_estadocivil.Text = " ";
            cm_funcao.Text = " ";
            msk_data.Text = " ";
            msk_tele.Text = " ";
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

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Validacoes.ValidaCpf(msk_cpf.Text);
            Validacoes.ValidarEmail(txt_email.Text); 
            MessageBox.Show(Validacoes.ValidaCpf(msk_cpf.Text).ToString());
           

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
    }
}

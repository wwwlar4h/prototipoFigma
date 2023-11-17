namespace Prototipo_po2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cm_estadocivil = new System.Windows.Forms.ComboBox();
            this.cm_funcao = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_ende = new System.Windows.Forms.TextBox();
            this.msk_data = new System.Windows.Forms.MaskedTextBox();
            this.msk_tele = new System.Windows.Forms.MaskedTextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.msk_sala = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cm_estadocivil
            // 
            this.cm_estadocivil.BackColor = System.Drawing.Color.LightBlue;
            this.cm_estadocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_estadocivil.ForeColor = System.Drawing.Color.Navy;
            this.cm_estadocivil.FormattingEnabled = true;
            this.cm_estadocivil.Items.AddRange(new object[] {
            "Solteiro (a)",
            "Casado (a)",
            "Viúvo (a)"});
            this.cm_estadocivil.Location = new System.Drawing.Point(600, 287);
            this.cm_estadocivil.Name = "cm_estadocivil";
            this.cm_estadocivil.Size = new System.Drawing.Size(134, 24);
            this.cm_estadocivil.TabIndex = 0;
            // 
            // cm_funcao
            // 
            this.cm_funcao.BackColor = System.Drawing.Color.LightBlue;
            this.cm_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm_funcao.ForeColor = System.Drawing.Color.Navy;
            this.cm_funcao.FormattingEnabled = true;
            this.cm_funcao.Items.AddRange(new object[] {
            "Agente de Viagens",
            "Consultor de Viagens Corporativas",
            "Consultor de Viagens de Lazer",
            "Especialista em Reservas e Tarifas",
            "Atendimento ao Cliente",
            "Marketing e Publicidade",
            "Gerente de Operações",
            "Especialista em Documentação e Vistos",
            "Especialista em Cruzeiros",
            "Especialista em Viagens de Aventura",
            "Agente de Reservas Online",
            "Especialista em Eventos Corporativos"});
            this.cm_funcao.Location = new System.Drawing.Point(449, 287);
            this.cm_funcao.Name = "cm_funcao";
            this.cm_funcao.Size = new System.Drawing.Size(134, 24);
            this.cm_funcao.TabIndex = 1;
            this.cm_funcao.SelectedIndexChanged += new System.EventHandler(this.cm_funcao_SelectedIndexChanged);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.LightBlue;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Navy;
            this.txt_id.Location = new System.Drawing.Point(93, 110);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 26);
            this.txt_id.TabIndex = 2;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.LightBlue;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Navy;
            this.txt_name.Location = new System.Drawing.Point(29, 217);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(306, 26);
            this.txt_name.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.LightBlue;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Navy;
            this.txt_email.Location = new System.Drawing.Point(449, 94);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(285, 26);
            this.txt_email.TabIndex = 5;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_ende
            // 
            this.txt_ende.BackColor = System.Drawing.Color.LightBlue;
            this.txt_ende.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ende.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ende.ForeColor = System.Drawing.Color.Navy;
            this.txt_ende.Location = new System.Drawing.Point(449, 163);
            this.txt_ende.Name = "txt_ende";
            this.txt_ende.Size = new System.Drawing.Size(285, 26);
            this.txt_ende.TabIndex = 6;
            // 
            // msk_data
            // 
            this.msk_data.BackColor = System.Drawing.Color.LightBlue;
            this.msk_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_data.ForeColor = System.Drawing.Color.Navy;
            this.msk_data.Location = new System.Drawing.Point(29, 290);
            this.msk_data.Mask = "00/00/0000";
            this.msk_data.Name = "msk_data";
            this.msk_data.Size = new System.Drawing.Size(93, 26);
            this.msk_data.TabIndex = 7;
            this.msk_data.ValidatingType = typeof(System.DateTime);
            this.msk_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_data_KeyPress);
            // 
            // msk_tele
            // 
            this.msk_tele.BackColor = System.Drawing.Color.LightBlue;
            this.msk_tele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_tele.ForeColor = System.Drawing.Color.Navy;
            this.msk_tele.Location = new System.Drawing.Point(204, 290);
            this.msk_tele.Mask = "(000)0000-9999";
            this.msk_tele.Name = "msk_tele";
            this.msk_tele.Size = new System.Drawing.Size(131, 26);
            this.msk_tele.TabIndex = 11;
            this.msk_tele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_tele_KeyPress);
            // 
            // txt_estado
            // 
            this.txt_estado.BackColor = System.Drawing.Color.LightBlue;
            this.txt_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.ForeColor = System.Drawing.Color.Navy;
            this.txt_estado.Location = new System.Drawing.Point(449, 233);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(134, 26);
            this.txt_estado.TabIndex = 13;
            // 
            // txt_cidade
            // 
            this.txt_cidade.BackColor = System.Drawing.Color.LightBlue;
            this.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.ForeColor = System.Drawing.Color.Navy;
            this.txt_cidade.Location = new System.Drawing.Point(600, 233);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(134, 26);
            this.txt_cidade.TabIndex = 14;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Location = new System.Drawing.Point(58, 462);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(83, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cadastrar.Location = new System.Drawing.Point(193, 462);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(94, 23);
            this.btn_cadastrar.TabIndex = 16;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.Location = new System.Drawing.Point(849, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 21);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msk_sala
            // 
            this.msk_sala.BackColor = System.Drawing.Color.LightBlue;
            this.msk_sala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_sala.ForeColor = System.Drawing.Color.Navy;
            this.msk_sala.Location = new System.Drawing.Point(449, 343);
            this.msk_sala.Mask = "000000000000000";
            this.msk_sala.Name = "msk_sala";
            this.msk_sala.Size = new System.Drawing.Size(134, 26);
            this.msk_sala.TabIndex = 18;
            this.msk_sala.ValidatingType = typeof(int);
            this.msk_sala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_sala_KeyPress);
            // 
            // msk_cpf
            // 
            this.msk_cpf.BackColor = System.Drawing.Color.LightBlue;
            this.msk_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cpf.ForeColor = System.Drawing.Color.Navy;
            this.msk_cpf.Location = new System.Drawing.Point(29, 343);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(131, 26);
            this.msk_cpf.TabIndex = 19;
            this.msk_cpf.ValidatingType = typeof(int);
            this.msk_cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_cpf_KeyPress);
            // 
            // msk_rg
            // 
            this.msk_rg.BackColor = System.Drawing.Color.LightBlue;
            this.msk_rg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_rg.ForeColor = System.Drawing.Color.Navy;
            this.msk_rg.Location = new System.Drawing.Point(204, 343);
            this.msk_rg.Mask = "00000000";
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.Size = new System.Drawing.Size(131, 26);
            this.msk_rg.TabIndex = 20;
            this.msk_rg.ValidatingType = typeof(int);
            this.msk_rg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msk_rg_MaskInputRejected);
            this.msk_rg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msk_rg_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 509);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 247);
            this.dataGridView1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prototipo_po2.Properties.Resources.Frame_1__7_;
            this.ClientSize = new System.Drawing.Size(881, 768);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.msk_rg);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.msk_sala);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.msk_tele);
            this.Controls.Add(this.msk_data);
            this.Controls.Add(this.txt_ende);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.cm_funcao);
            this.Controls.Add(this.cm_estadocivil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cm_estadocivil;
        private System.Windows.Forms.ComboBox cm_funcao;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_ende;
        private System.Windows.Forms.MaskedTextBox msk_data;
        private System.Windows.Forms.MaskedTextBox msk_tele;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox msk_sala;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


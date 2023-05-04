namespace Projeto_TCC
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.box_estado = new System.Windows.Forms.ComboBox();
            this.box_cep = new System.Windows.Forms.MaskedTextBox();
            this.box_comp = new System.Windows.Forms.TextBox();
            this.box_rua = new System.Windows.Forms.TextBox();
            this.box_cidade = new System.Windows.Forms.TextBox();
            this.box_num = new System.Windows.Forms.TextBox();
            this.box_bairro = new System.Windows.Forms.TextBox();
            this.box_nome = new System.Windows.Forms.TextBox();
            this.box_senha = new System.Windows.Forms.TextBox();
            this.box_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.box_rg = new System.Windows.Forms.MaskedTextBox();
            this.box_cpf = new System.Windows.Forms.MaskedTextBox();
            this.t_nome = new System.Windows.Forms.Label();
            this.t_cpf = new System.Windows.Forms.Label();
            this.t_rg = new System.Windows.Forms.Label();
            this.t_email = new System.Windows.Forms.Label();
            this.data_nasc = new System.Windows.Forms.DateTimePicker();
            this.t_fone = new System.Windows.Forms.Label();
            this.box_fone = new System.Windows.Forms.MaskedTextBox();
            this.t_data_nasc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t_senha = new System.Windows.Forms.Label();
            this.box_sabendo = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_dados_pessoais = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.box_estado);
            this.groupBox1.Controls.Add(this.box_cep);
            this.groupBox1.Controls.Add(this.box_comp);
            this.groupBox1.Controls.Add(this.box_rua);
            this.groupBox1.Controls.Add(this.box_cidade);
            this.groupBox1.Controls.Add(this.box_num);
            this.groupBox1.Controls.Add(this.box_bairro);
            this.groupBox1.Controls.Add(this.box_nome);
            this.groupBox1.Controls.Add(this.box_senha);
            this.groupBox1.Controls.Add(this.box_email);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.box_rg);
            this.groupBox1.Controls.Add(this.box_cpf);
            this.groupBox1.Controls.Add(this.t_nome);
            this.groupBox1.Controls.Add(this.t_cpf);
            this.groupBox1.Controls.Add(this.t_rg);
            this.groupBox1.Controls.Add(this.t_email);
            this.groupBox1.Controls.Add(this.data_nasc);
            this.groupBox1.Controls.Add(this.t_fone);
            this.groupBox1.Controls.Add(this.box_fone);
            this.groupBox1.Controls.Add(this.t_data_nasc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.t_senha);
            this.groupBox1.Location = new System.Drawing.Point(7, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 204);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Paciente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // box_estado
            // 
            this.box_estado.FormattingEnabled = true;
            this.box_estado.Location = new System.Drawing.Point(87, 130);
            this.box_estado.Name = "box_estado";
            this.box_estado.Size = new System.Drawing.Size(67, 21);
            this.box_estado.TabIndex = 51;
            // 
            // box_cep
            // 
            this.box_cep.Location = new System.Drawing.Point(575, 98);
            this.box_cep.Mask = "00000-000";
            this.box_cep.Name = "box_cep";
            this.box_cep.Size = new System.Drawing.Size(63, 20);
            this.box_cep.TabIndex = 49;
            // 
            // box_comp
            // 
            this.box_comp.Location = new System.Drawing.Point(783, 101);
            this.box_comp.Name = "box_comp";
            this.box_comp.Size = new System.Drawing.Size(144, 20);
            this.box_comp.TabIndex = 48;
            // 
            // box_rua
            // 
            this.box_rua.Location = new System.Drawing.Point(385, 60);
            this.box_rua.Name = "box_rua";
            this.box_rua.Size = new System.Drawing.Size(314, 20);
            this.box_rua.TabIndex = 45;
            // 
            // box_cidade
            // 
            this.box_cidade.Location = new System.Drawing.Point(87, 95);
            this.box_cidade.Name = "box_cidade";
            this.box_cidade.Size = new System.Drawing.Size(153, 20);
            this.box_cidade.TabIndex = 44;
            // 
            // box_num
            // 
            this.box_num.Location = new System.Drawing.Point(862, 63);
            this.box_num.Name = "box_num";
            this.box_num.Size = new System.Drawing.Size(65, 20);
            this.box_num.TabIndex = 40;
            // 
            // box_bairro
            // 
            this.box_bairro.Location = new System.Drawing.Point(317, 98);
            this.box_bairro.Name = "box_bairro";
            this.box_bairro.Size = new System.Drawing.Size(199, 20);
            this.box_bairro.TabIndex = 39;
            // 
            // box_nome
            // 
            this.box_nome.Location = new System.Drawing.Point(87, 28);
            this.box_nome.Name = "box_nome";
            this.box_nome.Size = new System.Drawing.Size(351, 20);
            this.box_nome.TabIndex = 1;
            // 
            // box_senha
            // 
            this.box_senha.Location = new System.Drawing.Point(635, 150);
            this.box_senha.Name = "box_senha";
            this.box_senha.Size = new System.Drawing.Size(209, 20);
            this.box_senha.TabIndex = 9;
            // 
            // box_email
            // 
            this.box_email.Location = new System.Drawing.Point(334, 147);
            this.box_email.Name = "box_email";
            this.box_email.Size = new System.Drawing.Size(209, 20);
            this.box_email.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(644, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "Complemento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(522, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(334, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Rua:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "UF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(246, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(705, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Número da casa:";
            // 
            // box_rg
            // 
            this.box_rg.Location = new System.Drawing.Point(228, 60);
            this.box_rg.Name = "box_rg";
            this.box_rg.Size = new System.Drawing.Size(100, 20);
            this.box_rg.TabIndex = 24;
            // 
            // box_cpf
            // 
            this.box_cpf.Location = new System.Drawing.Point(87, 60);
            this.box_cpf.Mask = "000.000.000-00";
            this.box_cpf.Name = "box_cpf";
            this.box_cpf.Size = new System.Drawing.Size(100, 20);
            this.box_cpf.TabIndex = 23;
            // 
            // t_nome
            // 
            this.t_nome.AutoSize = true;
            this.t_nome.BackColor = System.Drawing.Color.Transparent;
            this.t_nome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_nome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_nome.Location = new System.Drawing.Point(16, 28);
            this.t_nome.Name = "t_nome";
            this.t_nome.Size = new System.Drawing.Size(65, 23);
            this.t_nome.TabIndex = 0;
            this.t_nome.Text = "Nome:";
            // 
            // t_cpf
            // 
            this.t_cpf.AutoSize = true;
            this.t_cpf.BackColor = System.Drawing.Color.Transparent;
            this.t_cpf.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_cpf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_cpf.Location = new System.Drawing.Point(35, 60);
            this.t_cpf.Name = "t_cpf";
            this.t_cpf.Size = new System.Drawing.Size(46, 23);
            this.t_cpf.TabIndex = 13;
            this.t_cpf.Text = "CPF:";
            // 
            // t_rg
            // 
            this.t_rg.AutoSize = true;
            this.t_rg.BackColor = System.Drawing.Color.Transparent;
            this.t_rg.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_rg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_rg.Location = new System.Drawing.Point(192, 60);
            this.t_rg.Name = "t_rg";
            this.t_rg.Size = new System.Drawing.Size(38, 23);
            this.t_rg.TabIndex = 15;
            this.t_rg.Text = "RG:";
            // 
            // t_email
            // 
            this.t_email.AutoSize = true;
            this.t_email.BackColor = System.Drawing.Color.Transparent;
            this.t_email.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_email.Location = new System.Drawing.Point(268, 147);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(60, 23);
            this.t_email.TabIndex = 12;
            this.t_email.Text = "Email:";
            // 
            // data_nasc
            // 
            this.data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nasc.Location = new System.Drawing.Point(631, 28);
            this.data_nasc.Name = "data_nasc";
            this.data_nasc.Size = new System.Drawing.Size(104, 20);
            this.data_nasc.TabIndex = 10;
            // 
            // t_fone
            // 
            this.t_fone.AutoSize = true;
            this.t_fone.BackColor = System.Drawing.Color.Transparent;
            this.t_fone.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_fone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_fone.Location = new System.Drawing.Point(741, 28);
            this.t_fone.Name = "t_fone";
            this.t_fone.Size = new System.Drawing.Size(87, 23);
            this.t_fone.TabIndex = 20;
            this.t_fone.Text = "Telefone:";
            // 
            // box_fone
            // 
            this.box_fone.Location = new System.Drawing.Point(830, 28);
            this.box_fone.Mask = "(99)99999-9999";
            this.box_fone.Name = "box_fone";
            this.box_fone.Size = new System.Drawing.Size(97, 20);
            this.box_fone.TabIndex = 21;
            // 
            // t_data_nasc
            // 
            this.t_data_nasc.AutoSize = true;
            this.t_data_nasc.BackColor = System.Drawing.Color.Transparent;
            this.t_data_nasc.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_data_nasc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_data_nasc.Location = new System.Drawing.Point(444, 25);
            this.t_data_nasc.Name = "t_data_nasc";
            this.t_data_nasc.Size = new System.Drawing.Size(181, 23);
            this.t_data_nasc.TabIndex = 17;
            this.t_data_nasc.Text = "Data de nascimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(160, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 23);
            this.label8.TabIndex = 18;
            // 
            // t_senha
            // 
            this.t_senha.AutoSize = true;
            this.t_senha.BackColor = System.Drawing.Color.Transparent;
            this.t_senha.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_senha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.t_senha.Location = new System.Drawing.Point(563, 147);
            this.t_senha.Name = "t_senha";
            this.t_senha.Size = new System.Drawing.Size(66, 23);
            this.t_senha.TabIndex = 18;
            this.t_senha.Text = "Senha:";
            // 
            // box_sabendo
            // 
            this.box_sabendo.Location = new System.Drawing.Point(203, 326);
            this.box_sabendo.Multiline = true;
            this.box_sabendo.Name = "box_sabendo";
            this.box_sabendo.Size = new System.Drawing.Size(382, 210);
            this.box_sabendo.TabIndex = 60;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(181)))));
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConectar.Location = new System.Drawing.Point(675, 412);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(201, 58);
            this.btnConectar.TabIndex = 62;
            this.btnConectar.Text = " Cadastrar";
            this.btnConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(5, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 23);
            this.label9.TabIndex = 61;
            this.label9.Text = "Dados Adicionais:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(32, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 63;
            this.label10.Text = "(Alergias)";
            // 
            // btn_dados_pessoais
            // 
            this.btn_dados_pessoais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(181)))));
            this.btn_dados_pessoais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dados_pessoais.FlatAppearance.BorderSize = 0;
            this.btn_dados_pessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dados_pessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dados_pessoais.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dados_pessoais.Image = ((System.Drawing.Image)(resources.GetObject("btn_dados_pessoais.Image")));
            this.btn_dados_pessoais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dados_pessoais.Location = new System.Drawing.Point(0, 0);
            this.btn_dados_pessoais.Name = "btn_dados_pessoais";
            this.btn_dados_pessoais.Size = new System.Drawing.Size(958, 71);
            this.btn_dados_pessoais.TabIndex = 59;
            this.btn_dados_pessoais.Text = "Dados Pessoais";
            this.btn_dados_pessoais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dados_pessoais.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 681);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.box_sabendo);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_dados_pessoais);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Cadastro_paciente--Recepcao";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dados_pessoais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox box_estado;
        private System.Windows.Forms.MaskedTextBox box_cep;
        private System.Windows.Forms.TextBox box_comp;
        private System.Windows.Forms.TextBox box_rua;
        private System.Windows.Forms.TextBox box_cidade;
        private System.Windows.Forms.TextBox box_num;
        private System.Windows.Forms.TextBox box_bairro;
        private System.Windows.Forms.TextBox box_nome;
        private System.Windows.Forms.TextBox box_senha;
        private System.Windows.Forms.TextBox box_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox box_rg;
        private System.Windows.Forms.MaskedTextBox box_cpf;
        private System.Windows.Forms.Label t_nome;
        private System.Windows.Forms.Label t_cpf;
        private System.Windows.Forms.Label t_rg;
        private System.Windows.Forms.Label t_email;
        private System.Windows.Forms.DateTimePicker data_nasc;
        private System.Windows.Forms.Label t_fone;
        private System.Windows.Forms.MaskedTextBox box_fone;
        private System.Windows.Forms.Label t_data_nasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label t_senha;
        private System.Windows.Forms.TextBox box_sabendo;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
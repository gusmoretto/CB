namespace Projeto_TCC
{
    partial class Cursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dados_curso = new System.Windows.Forms.DataGridView();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carga_horaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_t = new System.Windows.Forms.RadioButton();
            this.r_r = new System.Windows.Forms.RadioButton();
            this.r_a = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Ncurso = new System.Windows.Forms.Label();
            this.Desqcurso = new System.Windows.Forms.Label();
            this.Reqcurso = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tcurso = new System.Windows.Forms.Label();
            this.Mcurso = new System.Windows.Forms.Label();
            this.Hcurso = new System.Windows.Forms.Label();
            this.L_curso = new System.Windows.Forms.Label();
            this.Pcurso = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dados_curso)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dados_curso
            // 
            this.dados_curso.AllowUserToAddRows = false;
            this.dados_curso.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dados_curso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dados_curso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dados_curso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dados_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dados_curso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_curso,
            this.nome_curso,
            this.requisitos,
            this.descricao,
            this.localizacao,
            this.preco,
            this.carga_horaria,
            this.id_modalidade,
            this.id_turno});
            this.dados_curso.Location = new System.Drawing.Point(12, 75);
            this.dados_curso.Name = "dados_curso";
            this.dados_curso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dados_curso.Size = new System.Drawing.Size(1904, 966);
            this.dados_curso.TabIndex = 5;
            this.dados_curso.Visible = false;
            this.dados_curso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dados_curso_CellContentClick_1);
            this.dados_curso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dados_curso_CellDobleClick);
            this.dados_curso.SelectionChanged += new System.EventHandler(this.dados_curso_SelectionChanged);
            // 
            // id_curso
            // 
            this.id_curso.DataPropertyName = "id_curso";
            this.id_curso.HeaderText = "Código do curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            // 
            // nome_curso
            // 
            this.nome_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome_curso.DataPropertyName = "nome_curso";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_curso.DefaultCellStyle = dataGridViewCellStyle2;
            this.nome_curso.HeaderText = "Nome do curso";
            this.nome_curso.Name = "nome_curso";
            this.nome_curso.ReadOnly = true;
            // 
            // requisitos
            // 
            this.requisitos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.requisitos.DataPropertyName = "requisitos";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requisitos.DefaultCellStyle = dataGridViewCellStyle3;
            this.requisitos.HeaderText = "Requisitos";
            this.requisitos.Name = "requisitos";
            this.requisitos.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.DefaultCellStyle = dataGridViewCellStyle4;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // localizacao
            // 
            this.localizacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.localizacao.DataPropertyName = "localizacao";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localizacao.DefaultCellStyle = dataGridViewCellStyle5;
            this.localizacao.HeaderText = "Localização";
            this.localizacao.Name = "localizacao";
            this.localizacao.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preco.DataPropertyName = "preco";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco.DefaultCellStyle = dataGridViewCellStyle6;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // carga_horaria
            // 
            this.carga_horaria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carga_horaria.DataPropertyName = "carga_horaria";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carga_horaria.DefaultCellStyle = dataGridViewCellStyle7;
            this.carga_horaria.HeaderText = "Carga Horaria";
            this.carga_horaria.Name = "carga_horaria";
            // 
            // id_modalidade
            // 
            this.id_modalidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_modalidade.DataPropertyName = "modalidade";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_modalidade.DefaultCellStyle = dataGridViewCellStyle8;
            this.id_modalidade.HeaderText = "Modalidade";
            this.id_modalidade.Name = "id_modalidade";
            this.id_modalidade.ReadOnly = true;
            // 
            // id_turno
            // 
            this.id_turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_turno.DataPropertyName = "tipo_turno";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_turno.DefaultCellStyle = dataGridViewCellStyle9;
            this.id_turno.HeaderText = "Turno";
            this.id_turno.Name = "id_turno";
            // 
            // r_t
            // 
            this.r_t.AutoSize = true;
            this.r_t.BackColor = System.Drawing.Color.Transparent;
            this.r_t.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_t.ForeColor = System.Drawing.SystemColors.Control;
            this.r_t.Location = new System.Drawing.Point(44, 12);
            this.r_t.Name = "r_t";
            this.r_t.Size = new System.Drawing.Size(299, 51);
            this.r_t.TabIndex = 7;
            this.r_t.Text = "Cursos Tecnicos";
            this.r_t.UseVisualStyleBackColor = false;
            this.r_t.CheckedChanged += new System.EventHandler(this.r_t_CheckedChanged);
            // 
            // r_r
            // 
            this.r_r.AutoSize = true;
            this.r_r.BackColor = System.Drawing.Color.Transparent;
            this.r_r.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_r.ForeColor = System.Drawing.SystemColors.Control;
            this.r_r.Location = new System.Drawing.Point(745, 12);
            this.r_r.Name = "r_r";
            this.r_r.Size = new System.Drawing.Size(291, 51);
            this.r_r.TabIndex = 8;
            this.r_r.Text = "Cursos Rapidos";
            this.r_r.UseVisualStyleBackColor = false;
            this.r_r.CheckedChanged += new System.EventHandler(this.r_r_CheckedChanged);
            // 
            // r_a
            // 
            this.r_a.AutoSize = true;
            this.r_a.BackColor = System.Drawing.Color.Transparent;
            this.r_a.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_a.ForeColor = System.Drawing.SystemColors.Control;
            this.r_a.Location = new System.Drawing.Point(1438, 12);
            this.r_a.Name = "r_a";
            this.r_a.Size = new System.Drawing.Size(440, 51);
            this.r_a.TabIndex = 9;
            this.r_a.Text = "Aprendizagem Industrial";
            this.r_a.UseVisualStyleBackColor = false;
            this.r_a.CheckedChanged += new System.EventHandler(this.r_a_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.r_a);
            this.panel1.Controls.Add(this.r_t);
            this.panel1.Controls.Add(this.r_r);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 75);
            this.panel1.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // Ncurso
            // 
            this.Ncurso.AutoSize = true;
            this.Ncurso.BackColor = System.Drawing.Color.Transparent;
            this.Ncurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ncurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Ncurso.Location = new System.Drawing.Point(403, 15);
            this.Ncurso.Name = "Ncurso";
            this.Ncurso.Size = new System.Drawing.Size(109, 42);
            this.Ncurso.TabIndex = 13;
            this.Ncurso.Text = "Titulo";
            this.Ncurso.Visible = false;
            this.Ncurso.Click += new System.EventHandler(this.label1_Click);
            // 
            // Desqcurso
            // 
            this.Desqcurso.AutoSize = true;
            this.Desqcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desqcurso.Location = new System.Drawing.Point(404, 154);
            this.Desqcurso.MaximumSize = new System.Drawing.Size(700, 500);
            this.Desqcurso.Name = "Desqcurso";
            this.Desqcurso.Size = new System.Drawing.Size(146, 33);
            this.Desqcurso.TabIndex = 15;
            this.Desqcurso.Text = "Descrição";
            this.Desqcurso.Visible = false;
            // 
            // Reqcurso
            // 
            this.Reqcurso.AutoSize = true;
            this.Reqcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reqcurso.Location = new System.Drawing.Point(1140, 154);
            this.Reqcurso.MaximumSize = new System.Drawing.Size(670, 0);
            this.Reqcurso.Name = "Reqcurso";
            this.Reqcurso.Size = new System.Drawing.Size(152, 33);
            this.Reqcurso.TabIndex = 14;
            this.Reqcurso.Text = "Requisitos";
            this.Reqcurso.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Reqcurso);
            this.panel2.Controls.Add(this.Desqcurso);
            this.panel2.Controls.Add(this.Ncurso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 747);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Tcurso
            // 
            this.Tcurso.AutoSize = true;
            this.Tcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcurso.ForeColor = System.Drawing.Color.White;
            this.Tcurso.Location = new System.Drawing.Point(12, 433);
            this.Tcurso.Name = "Tcurso";
            this.Tcurso.Size = new System.Drawing.Size(85, 31);
            this.Tcurso.TabIndex = 19;
            this.Tcurso.Text = "Turno";
            this.Tcurso.Visible = false;
            // 
            // Mcurso
            // 
            this.Mcurso.AutoSize = true;
            this.Mcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mcurso.ForeColor = System.Drawing.Color.White;
            this.Mcurso.Location = new System.Drawing.Point(12, 303);
            this.Mcurso.Name = "Mcurso";
            this.Mcurso.Size = new System.Drawing.Size(153, 31);
            this.Mcurso.TabIndex = 18;
            this.Mcurso.Text = "Modalidade";
            this.Mcurso.Visible = false;
            // 
            // Hcurso
            // 
            this.Hcurso.AutoSize = true;
            this.Hcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hcurso.ForeColor = System.Drawing.Color.White;
            this.Hcurso.Location = new System.Drawing.Point(12, 173);
            this.Hcurso.Name = "Hcurso";
            this.Hcurso.Size = new System.Drawing.Size(184, 31);
            this.Hcurso.TabIndex = 17;
            this.Hcurso.Text = "Carga Horaria";
            this.Hcurso.Visible = false;
            // 
            // L_curso
            // 
            this.L_curso.AutoSize = true;
            this.L_curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_curso.ForeColor = System.Drawing.Color.White;
            this.L_curso.Location = new System.Drawing.Point(12, 563);
            this.L_curso.Name = "L_curso";
            this.L_curso.Size = new System.Drawing.Size(158, 31);
            this.L_curso.TabIndex = 20;
            this.L_curso.Text = "Localização";
            this.L_curso.Visible = false;
            // 
            // Pcurso
            // 
            this.Pcurso.AutoSize = true;
            this.Pcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pcurso.ForeColor = System.Drawing.Color.White;
            this.Pcurso.Location = new System.Drawing.Point(12, 43);
            this.Pcurso.Name = "Pcurso";
            this.Pcurso.Size = new System.Drawing.Size(85, 31);
            this.Pcurso.TabIndex = 16;
            this.Pcurso.Text = "Preço";
            this.Pcurso.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Pcurso);
            this.panel3.Controls.Add(this.L_curso);
            this.panel3.Controls.Add(this.Hcurso);
            this.panel3.Controls.Add(this.Mcurso);
            this.panel3.Controls.Add(this.Tcurso);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 840);
            this.panel3.TabIndex = 21;
            this.panel3.Visible = false;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dados_curso);
            this.Controls.Add(this.panel1);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dados_curso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dados_curso;
        private System.Windows.Forms.RadioButton r_t;
        private System.Windows.Forms.RadioButton r_r;
        private System.Windows.Forms.RadioButton r_a;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn carga_horaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_turno;
        private System.Windows.Forms.Label Ncurso;
        private System.Windows.Forms.Label Desqcurso;
        private System.Windows.Forms.Label Reqcurso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Pcurso;
        private System.Windows.Forms.Label L_curso;
        private System.Windows.Forms.Label Hcurso;
        private System.Windows.Forms.Label Mcurso;
        private System.Windows.Forms.Label Tcurso;
    }
}
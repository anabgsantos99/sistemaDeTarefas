
namespace cadastrodeatividades
{
    partial class frmCadastrodeAtividades
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
            this.panelTopo = new System.Windows.Forms.Panel();
            this.pbSaida = new System.Windows.Forms.PictureBox();
            this.pbTelaAtividade = new System.Windows.Forms.PictureBox();
            this.lblBibliotecaSenac = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxAtividade = new System.Windows.Forms.ComboBox();
            this.comboBoxSemana = new System.Windows.Forms.ComboBox();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.comboBoxAno = new System.Windows.Forms.ComboBox();
            this.comboBoxFuncionaria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblFuncionaria = new System.Windows.Forms.Label();
            this.lblCadastrodeAtividades = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaAtividade)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.White;
            this.panelTopo.Controls.Add(this.pbSaida);
            this.panelTopo.Controls.Add(this.pbTelaAtividade);
            this.panelTopo.Controls.Add(this.lblBibliotecaSenac);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(1604, 37);
            this.panelTopo.TabIndex = 0;
            // 
            // pbSaida
            // 
            this.pbSaida.BackColor = System.Drawing.Color.Transparent;
            this.pbSaida.Image = global::cadastrodeatividades.Properties.Resources.logout_100dp_F7941D_FILL0_wght600_GRAD200_opsz48;
            this.pbSaida.Location = new System.Drawing.Point(1571, 3);
            this.pbSaida.Name = "pbSaida";
            this.pbSaida.Size = new System.Drawing.Size(30, 30);
            this.pbSaida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSaida.TabIndex = 3;
            this.pbSaida.TabStop = false;
            // 
            // pbTelaAtividade
            // 
            this.pbTelaAtividade.BackColor = System.Drawing.Color.Transparent;
            this.pbTelaAtividade.Image = global::cadastrodeatividades.Properties.Resources.task_alt_100dp_F7941D_FILL0_wght600_GRAD200_opsz48;
            this.pbTelaAtividade.Location = new System.Drawing.Point(3, 4);
            this.pbTelaAtividade.Name = "pbTelaAtividade";
            this.pbTelaAtividade.Size = new System.Drawing.Size(30, 30);
            this.pbTelaAtividade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTelaAtividade.TabIndex = 2;
            this.pbTelaAtividade.TabStop = false;
            // 
            // lblBibliotecaSenac
            // 
            this.lblBibliotecaSenac.AutoSize = true;
            this.lblBibliotecaSenac.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotecaSenac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblBibliotecaSenac.Location = new System.Drawing.Point(1291, 9);
            this.lblBibliotecaSenac.Name = "lblBibliotecaSenac";
            this.lblBibliotecaSenac.Size = new System.Drawing.Size(263, 18);
            this.lblBibliotecaSenac.TabIndex = 1;
            this.lblBibliotecaSenac.Text = "BIBLIOTECA SENAC LARGO TREZE";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.comboBoxAtividade);
            this.panelMenu.Controls.Add(this.comboBoxSemana);
            this.panelMenu.Controls.Add(this.comboBoxMes);
            this.panelMenu.Controls.Add(this.comboBoxAno);
            this.panelMenu.Controls.Add(this.comboBoxFuncionaria);
            this.panelMenu.Controls.Add(this.btnCancelar);
            this.panelMenu.Controls.Add(this.btnSalvar);
            this.panelMenu.Controls.Add(this.lblAtividade);
            this.panelMenu.Controls.Add(this.lblSemana);
            this.panelMenu.Controls.Add(this.lblMes);
            this.panelMenu.Controls.Add(this.lblAno);
            this.panelMenu.Controls.Add(this.lblFuncionaria);
            this.panelMenu.Controls.Add(this.lblCadastrodeAtividades);
            this.panelMenu.Location = new System.Drawing.Point(450, 139);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(705, 605);
            this.panelMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.pictureBox1.Image = global::cadastrodeatividades.Properties.Resources.line;
            this.pictureBox1.Location = new System.Drawing.Point(341, 533);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxAtividade
            // 
            this.comboBoxAtividade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(128)))));
            this.comboBoxAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAtividade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAtividade.FormattingEnabled = true;
            this.comboBoxAtividade.Items.AddRange(new object[] {
            "Arrumação dos armários e gaveteiros",
            "Arquivo dos livros",
            "Cobranças",
            "Divulgação (TV, Comunicação, etc)",
            "EEBs (Devoluções, checagem de baixas no BN, prazo das solicitações)",
            "Etiquetas",
            "Organização do acervo (Estantes 1,2 e 3)",
            "Organização do acervo (Estantes 4,5 e 6)",
            "Organização do acervo (Estantes 7,8 e 9)",
            "Organização do acervo (Estantes 10,11, 12 e 13)",
            "Vitrine"});
            this.comboBoxAtividade.Location = new System.Drawing.Point(67, 483);
            this.comboBoxAtividade.Name = "comboBoxAtividade";
            this.comboBoxAtividade.Size = new System.Drawing.Size(558, 26);
            this.comboBoxAtividade.TabIndex = 15;
            // 
            // comboBoxSemana
            // 
            this.comboBoxSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(128)))));
            this.comboBoxSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSemana.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSemana.FormattingEnabled = true;
            this.comboBoxSemana.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxSemana.Location = new System.Drawing.Point(67, 408);
            this.comboBoxSemana.Name = "comboBoxSemana";
            this.comboBoxSemana.Size = new System.Drawing.Size(558, 26);
            this.comboBoxSemana.TabIndex = 14;
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(128)))));
            this.comboBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBoxMes.Location = new System.Drawing.Point(67, 333);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(558, 26);
            this.comboBoxMes.TabIndex = 13;
            // 
            // comboBoxAno
            // 
            this.comboBoxAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(128)))));
            this.comboBoxAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAno.FormattingEnabled = true;
            this.comboBoxAno.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.comboBoxAno.Location = new System.Drawing.Point(67, 258);
            this.comboBoxAno.Name = "comboBoxAno";
            this.comboBoxAno.Size = new System.Drawing.Size(558, 26);
            this.comboBoxAno.TabIndex = 12;
            // 
            // comboBoxFuncionaria
            // 
            this.comboBoxFuncionaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(128)))));
            this.comboBoxFuncionaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncionaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFuncionaria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFuncionaria.FormattingEnabled = true;
            this.comboBoxFuncionaria.Items.AddRange(new object[] {
            "Alice",
            "Josy",
            "Manu",
            "Ofélia"});
            this.comboBoxFuncionaria.Location = new System.Drawing.Point(67, 183);
            this.comboBoxFuncionaria.Name = "comboBoxFuncionaria";
            this.comboBoxFuncionaria.Size = new System.Drawing.Size(558, 26);
            this.comboBoxFuncionaria.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnCancelar.Location = new System.Drawing.Point(509, 533);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 41);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(29)))));
            this.btnSalvar.Location = new System.Drawing.Point(67, 534);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 41);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblAtividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblAtividade.Location = new System.Drawing.Point(293, 446);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(107, 26);
            this.lblAtividade.TabIndex = 7;
            this.lblAtividade.Text = "Atividade";
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblSemana.Location = new System.Drawing.Point(299, 370);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(95, 26);
            this.lblSemana.TabIndex = 6;
            this.lblSemana.Text = "Semana";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblMes.Location = new System.Drawing.Point(320, 294);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(53, 26);
            this.lblMes.TabIndex = 5;
            this.lblMes.Text = "Mês";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblAno.Location = new System.Drawing.Point(320, 218);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(53, 26);
            this.lblAno.TabIndex = 4;
            this.lblAno.Text = "Ano";
            // 
            // lblFuncionaria
            // 
            this.lblFuncionaria.AutoSize = true;
            this.lblFuncionaria.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblFuncionaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblFuncionaria.Location = new System.Drawing.Point(281, 142);
            this.lblFuncionaria.Name = "lblFuncionaria";
            this.lblFuncionaria.Size = new System.Drawing.Size(131, 26);
            this.lblFuncionaria.TabIndex = 3;
            this.lblFuncionaria.Text = "Funcionária";
            // 
            // lblCadastrodeAtividades
            // 
            this.lblCadastrodeAtividades.AutoSize = true;
            this.lblCadastrodeAtividades.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrodeAtividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.lblCadastrodeAtividades.Location = new System.Drawing.Point(207, 63);
            this.lblCadastrodeAtividades.Name = "lblCadastrodeAtividades";
            this.lblCadastrodeAtividades.Size = new System.Drawing.Size(278, 29);
            this.lblCadastrodeAtividades.TabIndex = 2;
            this.lblCadastrodeAtividades.Text = "Cadastro de Atividades";
            // 
            // frmCadastrodeAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(1604, 861);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTopo);
            this.MaximizeBox = false;
            this.Name = "frmCadastrodeAtividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Atividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastrodeAtividades_Load);
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTelaAtividade)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblBibliotecaSenac;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ComboBox comboBoxAtividade;
        private System.Windows.Forms.ComboBox comboBoxSemana;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.ComboBox comboBoxAno;
        private System.Windows.Forms.ComboBox comboBoxFuncionaria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblFuncionaria;
        private System.Windows.Forms.Label lblCadastrodeAtividades;
        private System.Windows.Forms.PictureBox pbTelaAtividade;
        private System.Windows.Forms.PictureBox pbSaida;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


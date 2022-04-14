namespace ListaTecnica {
    partial class frmListaTecnica {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtElementos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTiragem = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.dBListaTecnicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBListaTecnicaDataSet = new ListaTecnica.DBListaTecnicaDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbVersao = new System.Windows.Forms.ComboBox();
            this.cbTipoMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAdicionarVersao = new System.Windows.Forms.Button();
            this.cbCiclo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbCicloPesquisa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoMaterialPesquisa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVersaoPesquisa = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiragem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Versao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Papel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Gramatura = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Bobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBListaTecnicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBListaTecnicaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtElementos
            // 
            this.txtElementos.Location = new System.Drawing.Point(162, 104);
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(33, 20);
            this.txtElementos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qtde de Elementos + Capa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiragem:";
            // 
            // txtTiragem
            // 
            this.txtTiragem.Location = new System.Drawing.Point(78, 75);
            this.txtTiragem.Name = "txtTiragem";
            this.txtTiragem.Size = new System.Drawing.Size(117, 20);
            this.txtTiragem.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ciclo,
            this.Tiragem,
            this.Material,
            this.Versao,
            this.Elemento,
            this.Paginas,
            this.Papel,
            this.Gramatura,
            this.Bobina});
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(12, 159);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 10;
            this.grid.Size = new System.Drawing.Size(871, 222);
            this.grid.TabIndex = 5;
            // 
            // dBListaTecnicaDataSetBindingSource
            // 
            this.dBListaTecnicaDataSetBindingSource.DataSource = this.dBListaTecnicaDataSet;
            this.dBListaTecnicaDataSetBindingSource.Position = 0;
            // 
            // dBListaTecnicaDataSet
            // 
            this.dBListaTecnicaDataSet.DataSetName = "DBListaTecnicaDataSet";
            this.dBListaTecnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Versão:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(808, 391);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbVersao
            // 
            this.cbVersao.FormattingEnabled = true;
            this.cbVersao.Items.AddRange(new object[] {
            "V1",
            "V2",
            "V3",
            "V4"});
            this.cbVersao.Location = new System.Drawing.Point(78, 20);
            this.cbVersao.Name = "cbVersao";
            this.cbVersao.Size = new System.Drawing.Size(78, 21);
            this.cbVersao.TabIndex = 13;
            // 
            // cbTipoMaterial
            // 
            this.cbTipoMaterial.FormattingEnabled = true;
            this.cbTipoMaterial.Items.AddRange(new object[] {
            "Revista",
            "Minha Natura",
            "Folheto Inativas"});
            this.cbTipoMaterial.Location = new System.Drawing.Point(78, 48);
            this.cbTipoMaterial.Name = "cbTipoMaterial";
            this.cbTipoMaterial.Size = new System.Drawing.Size(117, 21);
            this.cbTipoMaterial.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Material:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(718, 391);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(73, 101);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAdicionarVersao
            // 
            this.btnAdicionarVersao.Location = new System.Drawing.Point(212, 102);
            this.btnAdicionarVersao.Name = "btnAdicionarVersao";
            this.btnAdicionarVersao.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarVersao.TabIndex = 20;
            this.btnAdicionarVersao.Text = "Adicionar";
            this.btnAdicionarVersao.UseVisualStyleBackColor = true;
            this.btnAdicionarVersao.Click += new System.EventHandler(this.btnAdicionarVersao_Click);
            // 
            // cbCiclo
            // 
            this.cbCiclo.FormattingEnabled = true;
            this.cbCiclo.Items.AddRange(new object[] {
            "01/2022",
            "02/2022",
            "03/2022",
            "04/2022",
            "05/2022",
            "06/2022",
            "07/2022",
            "08/2022",
            "09/2022",
            "10/2022",
            "11/2022",
            "12/2022",
            "13/2022",
            "14/2022",
            "15/2022",
            "16/2022",
            "17/2022",
            "18/2022",
            "19/2022",
            "20/2022"});
            this.cbCiclo.Location = new System.Drawing.Point(57, 39);
            this.cbCiclo.Name = "cbCiclo";
            this.cbCiclo.Size = new System.Drawing.Size(78, 21);
            this.cbCiclo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ciclo:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(141, 38);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Cadastrar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCiclo);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 102);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Ciclo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdicionarVersao);
            this.groupBox2.Controls.Add(this.txtElementos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTiragem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbTipoMaterial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbVersao);
            this.groupBox2.Location = new System.Drawing.Point(315, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 133);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar Elementos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTipoMaterialPesquisa);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbCicloPesquisa);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbVersaoPesquisa);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Location = new System.Drawing.Point(683, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 133);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa";
            // 
            // cbCicloPesquisa
            // 
            this.cbCicloPesquisa.FormattingEnabled = true;
            this.cbCicloPesquisa.Items.AddRange(new object[] {
            "01/2022",
            "02/2022",
            "03/2022",
            "04/2022",
            "05/2022",
            "06/2022",
            "07/2022",
            "08/2022",
            "09/2022",
            "10/2022",
            "11/2022",
            "12/2022",
            "13/2022",
            "14/2022",
            "15/2022",
            "16/2022",
            "17/2022",
            "18/2022",
            "19/2022",
            "20/2022"});
            this.cbCicloPesquisa.Location = new System.Drawing.Point(56, 20);
            this.cbCicloPesquisa.Name = "cbCicloPesquisa";
            this.cbCicloPesquisa.Size = new System.Drawing.Size(78, 21);
            this.cbCicloPesquisa.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ciclo:";
            // 
            // cbTipoMaterialPesquisa
            // 
            this.cbTipoMaterialPesquisa.FormattingEnabled = true;
            this.cbTipoMaterialPesquisa.Items.AddRange(new object[] {
            "Revista",
            "Minha Natura",
            "Folheto Inativas"});
            this.cbTipoMaterialPesquisa.Location = new System.Drawing.Point(56, 74);
            this.cbTipoMaterialPesquisa.Name = "cbTipoMaterialPesquisa";
            this.cbTipoMaterialPesquisa.Size = new System.Drawing.Size(117, 21);
            this.cbTipoMaterialPesquisa.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Versão:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Material:";
            // 
            // cbVersaoPesquisa
            // 
            this.cbVersaoPesquisa.FormattingEnabled = true;
            this.cbVersaoPesquisa.Items.AddRange(new object[] {
            "V1",
            "V2",
            "V3",
            "V4"});
            this.cbVersaoPesquisa.Location = new System.Drawing.Point(56, 46);
            this.cbVersaoPesquisa.Name = "cbVersaoPesquisa";
            this.cbVersaoPesquisa.Size = new System.Drawing.Size(78, 21);
            this.cbVersaoPesquisa.TabIndex = 22;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ciclo
            // 
            this.ciclo.HeaderText = "Ciclo";
            this.ciclo.Name = "ciclo";
            // 
            // Tiragem
            // 
            this.Tiragem.HeaderText = "Tiragem";
            this.Tiragem.MaxInputLength = 32767667;
            this.Tiragem.Name = "Tiragem";
            this.Tiragem.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.HeaderText = "Tipo de Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // Versao
            // 
            this.Versao.HeaderText = "Versão";
            this.Versao.Name = "Versao";
            this.Versao.ReadOnly = true;
            // 
            // Elemento
            // 
            this.Elemento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Elemento.HeaderText = "Elemento";
            this.Elemento.Name = "Elemento";
            this.Elemento.Width = 76;
            // 
            // Paginas
            // 
            this.Paginas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Paginas.HeaderText = "Págs";
            this.Paginas.Name = "Paginas";
            this.Paginas.Width = 56;
            // 
            // Papel
            // 
            this.Papel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Papel.HeaderText = "Papel";
            this.Papel.Items.AddRange(new object[] {
            "Couche",
            "LWC"});
            this.Papel.MinimumWidth = 80;
            this.Papel.Name = "Papel";
            this.Papel.Width = 80;
            // 
            // Gramatura
            // 
            this.Gramatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Gramatura.HeaderText = "Gramatura";
            this.Gramatura.Items.AddRange(new object[] {
            "150",
            "70",
            "65"});
            this.Gramatura.Name = "Gramatura";
            this.Gramatura.Width = 62;
            // 
            // Bobina
            // 
            this.Bobina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Bobina.HeaderText = "Bobina";
            this.Bobina.Name = "Bobina";
            this.Bobina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bobina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bobina.Width = 46;
            // 
            // frmListaTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(895, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grid);
            this.MaximizeBox = false;
            this.Name = "frmListaTecnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Técnica";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmListaTecnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBListaTecnicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBListaTecnicaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTiragem;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbVersao;
        private System.Windows.Forms.ComboBox cbTipoMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.BindingSource dBListaTecnicaDataSetBindingSource;
        private DBListaTecnicaDataSet dBListaTecnicaDataSet;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAdicionarVersao;
        private System.Windows.Forms.ComboBox cbCiclo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTipoMaterialPesquisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCicloPesquisa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVersaoPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiragem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Versao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paginas;
        private System.Windows.Forms.DataGridViewComboBoxColumn Papel;
        private System.Windows.Forms.DataGridViewComboBoxColumn Gramatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bobina;
    }
}


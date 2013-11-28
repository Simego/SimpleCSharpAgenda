namespace ControleDeContatos
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPesquisar = new System.Windows.Forms.TabPage();
            this.lblCriterios = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbTelefone_P = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.groupPesquisar = new System.Windows.Forms.GroupBox();
            this.listPesquisa = new System.Windows.Forms.ListView();
            this.pesquisa_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pesquisa_nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pesquisa_telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pesquisa_endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pesquisa_dataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbNome_P = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.txtbTelefone_C = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupAtividades = new System.Windows.Forms.GroupBox();
            this.toolStripAtividades = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRemover = new System.Windows.Forms.ToolStripButton();
            this.listAtividades = new System.Windows.Forms.ListView();
            this.atividades_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.atividades_descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.atividades_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbComplemento_C = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbEndereco_C = new System.Windows.Forms.TextBox();
            this.txtbNome_C = new System.Windows.Forms.TextBox();
            this.dtpickData_C = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPesquisar.SuspendLayout();
            this.groupPesquisar.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.groupAtividades.SuspendLayout();
            this.toolStripAtividades.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPesquisar);
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 402);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPesquisar
            // 
            this.tabPesquisar.Controls.Add(this.lblCriterios);
            this.tabPesquisar.Controls.Add(this.btnBuscar);
            this.tabPesquisar.Controls.Add(this.txtbTelefone_P);
            this.tabPesquisar.Controls.Add(this.lblTelefone);
            this.tabPesquisar.Controls.Add(this.groupPesquisar);
            this.tabPesquisar.Controls.Add(this.txtbNome_P);
            this.tabPesquisar.Controls.Add(this.lblNome);
            this.tabPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPesquisar.Location = new System.Drawing.Point(4, 29);
            this.tabPesquisar.Name = "tabPesquisar";
            this.tabPesquisar.Size = new System.Drawing.Size(863, 369);
            this.tabPesquisar.TabIndex = 0;
            this.tabPesquisar.Text = "Pesquisar";
            this.tabPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblCriterios
            // 
            this.lblCriterios.AutoSize = true;
            this.lblCriterios.Location = new System.Drawing.Point(660, 24);
            this.lblCriterios.Name = "lblCriterios";
            this.lblCriterios.Size = new System.Drawing.Size(0, 13);
            this.lblCriterios.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(549, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbTelefone_P
            // 
            this.txtbTelefone_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTelefone_P.Location = new System.Drawing.Point(379, 16);
            this.txtbTelefone_P.Name = "txtbTelefone_P";
            this.txtbTelefone_P.Size = new System.Drawing.Size(146, 26);
            this.txtbTelefone_P.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(298, 19);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 20);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            // 
            // groupPesquisar
            // 
            this.groupPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPesquisar.Controls.Add(this.listPesquisa);
            this.groupPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPesquisar.Location = new System.Drawing.Point(8, 48);
            this.groupPesquisar.Name = "groupPesquisar";
            this.groupPesquisar.Size = new System.Drawing.Size(847, 313);
            this.groupPesquisar.TabIndex = 4;
            this.groupPesquisar.TabStop = false;
            this.groupPesquisar.Text = "Lista de Pessoas";
            // 
            // listPesquisa
            // 
            this.listPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pesquisa_id,
            this.pesquisa_nome,
            this.pesquisa_telefone,
            this.pesquisa_endereco,
            this.pesquisa_dataCadastro});
            this.listPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPesquisa.FullRowSelect = true;
            this.listPesquisa.GridLines = true;
            this.listPesquisa.HideSelection = false;
            this.listPesquisa.Location = new System.Drawing.Point(6, 21);
            this.listPesquisa.MultiSelect = false;
            this.listPesquisa.Name = "listPesquisa";
            this.listPesquisa.Size = new System.Drawing.Size(835, 286);
            this.listPesquisa.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listPesquisa.TabIndex = 3;
            this.listPesquisa.UseCompatibleStateImageBehavior = false;
            this.listPesquisa.View = System.Windows.Forms.View.Details;
            this.listPesquisa.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listPesquisa_ColumnClick);
            this.listPesquisa.DoubleClick += new System.EventHandler(this.listPesquisa_DoubleClick);
            this.listPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listPesquisa_KeyDown);
            // 
            // pesquisa_id
            // 
            this.pesquisa_id.Text = "ID";
            this.pesquisa_id.Width = 40;
            // 
            // pesquisa_nome
            // 
            this.pesquisa_nome.Text = "Nome";
            this.pesquisa_nome.Width = 222;
            // 
            // pesquisa_telefone
            // 
            this.pesquisa_telefone.Text = "Telefone";
            this.pesquisa_telefone.Width = 108;
            // 
            // pesquisa_endereco
            // 
            this.pesquisa_endereco.Text = "Endereço";
            this.pesquisa_endereco.Width = 340;
            // 
            // pesquisa_dataCadastro
            // 
            this.pesquisa_dataCadastro.Text = "Data de Cadastro";
            this.pesquisa_dataCadastro.Width = 121;
            // 
            // txtbNome_P
            // 
            this.txtbNome_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNome_P.Location = new System.Drawing.Point(71, 16);
            this.txtbNome_P.Name = "txtbNome_P";
            this.txtbNome_P.Size = new System.Drawing.Size(221, 26);
            this.txtbNome_P.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(10, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.Controls.Add(this.txtbTelefone_C);
            this.tabCadastrar.Controls.Add(this.btnSalvar);
            this.tabCadastrar.Controls.Add(this.groupAtividades);
            this.tabCadastrar.Controls.Add(this.txtbComplemento_C);
            this.tabCadastrar.Controls.Add(this.label5);
            this.tabCadastrar.Controls.Add(this.txtbEndereco_C);
            this.tabCadastrar.Controls.Add(this.txtbNome_C);
            this.tabCadastrar.Controls.Add(this.dtpickData_C);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.label1);
            this.tabCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCadastrar.Location = new System.Drawing.Point(4, 29);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Size = new System.Drawing.Size(863, 369);
            this.tabCadastrar.TabIndex = 1;
            this.tabCadastrar.Text = "Cadastrar";
            this.tabCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtbTelefone_C
            // 
            this.txtbTelefone_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTelefone_C.Location = new System.Drawing.Point(102, 78);
            this.txtbTelefone_C.Name = "txtbTelefone_C";
            this.txtbTelefone_C.Size = new System.Drawing.Size(146, 26);
            this.txtbTelefone_C.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(712, 78);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 26);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupAtividades
            // 
            this.groupAtividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAtividades.Controls.Add(this.toolStripAtividades);
            this.groupAtividades.Controls.Add(this.listAtividades);
            this.groupAtividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAtividades.Location = new System.Drawing.Point(8, 110);
            this.groupAtividades.Name = "groupAtividades";
            this.groupAtividades.Size = new System.Drawing.Size(847, 251);
            this.groupAtividades.TabIndex = 10;
            this.groupAtividades.TabStop = false;
            this.groupAtividades.Text = "Atividades";
            // 
            // toolStripAtividades
            // 
            this.toolStripAtividades.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripAtividades.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAtividades.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStripAtividades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAtualizar,
            this.toolStripBtnAdicionar,
            this.toolStripBtnRemover});
            this.toolStripAtividades.Location = new System.Drawing.Point(3, 22);
            this.toolStripAtividades.Name = "toolStripAtividades";
            this.toolStripAtividades.Size = new System.Drawing.Size(841, 32);
            this.toolStripAtividades.TabIndex = 4;
            this.toolStripAtividades.Text = "toolStrip1";
            // 
            // toolStripBtnAtualizar
            // 
            this.toolStripBtnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAtualizar.Image")));
            this.toolStripBtnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAtualizar.Name = "toolStripBtnAtualizar";
            this.toolStripBtnAtualizar.Size = new System.Drawing.Size(81, 29);
            this.toolStripBtnAtualizar.Text = "Atualizar";
            this.toolStripBtnAtualizar.Click += new System.EventHandler(this.toolStripBtnAtualizar_Click);
            // 
            // toolStripBtnAdicionar
            // 
            this.toolStripBtnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAdicionar.Image")));
            this.toolStripBtnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAdicionar.Name = "toolStripBtnAdicionar";
            this.toolStripBtnAdicionar.Size = new System.Drawing.Size(85, 29);
            this.toolStripBtnAdicionar.Text = "Adicionar";
            this.toolStripBtnAdicionar.Click += new System.EventHandler(this.toolStripBtnAdicionar_Click);
            // 
            // toolStripBtnRemover
            // 
            this.toolStripBtnRemover.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRemover.Image")));
            this.toolStripBtnRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRemover.Name = "toolStripBtnRemover";
            this.toolStripBtnRemover.Size = new System.Drawing.Size(80, 29);
            this.toolStripBtnRemover.Text = "Remover";
            this.toolStripBtnRemover.Click += new System.EventHandler(this.toolStripBtnRemover_Click);
            // 
            // listAtividades
            // 
            this.listAtividades.AllowColumnReorder = true;
            this.listAtividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAtividades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.atividades_id,
            this.atividades_descricao,
            this.atividades_data});
            this.listAtividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAtividades.FullRowSelect = true;
            this.listAtividades.GridLines = true;
            this.listAtividades.HideSelection = false;
            this.listAtividades.Location = new System.Drawing.Point(6, 57);
            this.listAtividades.MultiSelect = false;
            this.listAtividades.Name = "listAtividades";
            this.listAtividades.Size = new System.Drawing.Size(835, 188);
            this.listAtividades.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listAtividades.TabIndex = 3;
            this.listAtividades.UseCompatibleStateImageBehavior = false;
            this.listAtividades.View = System.Windows.Forms.View.Details;
            this.listAtividades.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listAtividades_ColumnClick);
            this.listAtividades.DoubleClick += new System.EventHandler(this.listAtividades_DoubleClick);
            // 
            // atividades_id
            // 
            this.atividades_id.Text = "ID";
            this.atividades_id.Width = 36;
            // 
            // atividades_descricao
            // 
            this.atividades_descricao.Text = "Descrição";
            this.atividades_descricao.Width = 670;
            // 
            // atividades_data
            // 
            this.atividades_data.Text = "Data";
            this.atividades_data.Width = 130;
            // 
            // txtbComplemento_C
            // 
            this.txtbComplemento_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbComplemento_C.Location = new System.Drawing.Point(712, 46);
            this.txtbComplemento_C.MaxLength = 150;
            this.txtbComplemento_C.Name = "txtbComplemento_C";
            this.txtbComplemento_C.Size = new System.Drawing.Size(137, 26);
            this.txtbComplemento_C.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(594, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Complemento:";
            // 
            // txtbEndereco_C
            // 
            this.txtbEndereco_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEndereco_C.Location = new System.Drawing.Point(102, 46);
            this.txtbEndereco_C.MaxLength = 150;
            this.txtbEndereco_C.Name = "txtbEndereco_C";
            this.txtbEndereco_C.Size = new System.Drawing.Size(486, 26);
            this.txtbEndereco_C.TabIndex = 1;
            // 
            // txtbNome_C
            // 
            this.txtbNome_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNome_C.Location = new System.Drawing.Point(102, 14);
            this.txtbNome_C.MaxLength = 150;
            this.txtbNome_C.Name = "txtbNome_C";
            this.txtbNome_C.Size = new System.Drawing.Size(486, 26);
            this.txtbNome_C.TabIndex = 0;
            // 
            // dtpickData_C
            // 
            this.dtpickData_C.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickData_C.CustomFormat = "dd/MM/yyyy";
            this.dtpickData_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickData_C.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickData_C.Location = new System.Drawing.Point(332, 78);
            this.dtpickData_C.Name = "dtpickData_C";
            this.dtpickData_C.Size = new System.Drawing.Size(146, 26);
            this.dtpickData_C.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.groupBox6);
            this.tabInfo.Controls.Add(this.groupBox5);
            this.tabInfo.Controls.Add(this.groupBox2);
            this.tabInfo.Controls.Add(this.groupBox4);
            this.tabInfo.Controls.Add(this.groupBox3);
            this.tabInfo.Controls.Add(this.linkLabel1);
            this.tabInfo.Controls.Add(this.groupBox1);
            this.tabInfo.Controls.Add(this.label6);
            this.tabInfo.Location = new System.Drawing.Point(4, 29);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(863, 369);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Informações";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Este sistema foi criado por Daniel Amorim Rafaelli.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criando uma Pessoa";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(350, 331);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "contato@thesimego.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Clique na aba Cadastrar,\r\npreencha todos os campos e clique Salvar.";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(432, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 85);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criando Atividade para uma Pessoa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 48);
            this.label8.TabIndex = 0;
            this.label8.Text = "Na aba Pesquisar, clique duas vezes no registro desejado.\r\nAssim que for redireci" +
    "onado para a aba Cadastrar,\r\nclique em Adicionar, na lista de Atividades";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(432, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 85);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deletando Atividade de uma Pessoa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(361, 48);
            this.label9.TabIndex = 0;
            this.label9.Text = "Na aba Pesquisar, clique duas vezes no registro desejado.\r\nAssim que for redireci" +
    "onado para a aba Cadastrar,\r\nclique em Remover, na lista de Atividades";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(8, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deletando uma Pessoa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(354, 48);
            this.label10.TabIndex = 0;
            this.label10.Text = "Na aba Pesquisar, selecione o registro desejado na lista\r\ne aperte o botão DELETE" +
    " do teclado,\r\nao confirmar a Pessoa e suas Atividades serão excluídas.";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(8, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(418, 85);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Editando uma Pessoa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(361, 48);
            this.label11.TabIndex = 0;
            this.label11.Text = "Na aba Pesquisar, clique duas vezes no registro desejado.\r\nApós ser redirecionado" +
    " para a aba Cadastrar,\r\naltere os campos desejados e clique Salvar.";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(432, 205);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(418, 85);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Editando uma Atividade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(361, 64);
            this.label12.TabIndex = 0;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // TelaPrincipal
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 402);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Contatos";
            this.tabControl1.ResumeLayout(false);
            this.tabPesquisar.ResumeLayout(false);
            this.tabPesquisar.PerformLayout();
            this.groupPesquisar.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.groupAtividades.ResumeLayout(false);
            this.groupAtividades.PerformLayout();
            this.toolStripAtividades.ResumeLayout(false);
            this.toolStripAtividades.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPesquisar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.GroupBox groupPesquisar;
        private System.Windows.Forms.ListView listPesquisa;
        private System.Windows.Forms.TextBox txtbNome_P;
        private System.Windows.Forms.TextBox txtbTelefone_P;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ColumnHeader pesquisa_nome;
        private System.Windows.Forms.ColumnHeader pesquisa_telefone;
        private System.Windows.Forms.ColumnHeader pesquisa_endereco;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNome_C;
        private System.Windows.Forms.DateTimePicker dtpickData_C;
        private System.Windows.Forms.TextBox txtbComplemento_C;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbEndereco_C;
        private System.Windows.Forms.GroupBox groupAtividades;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ColumnHeader pesquisa_id;
        private System.Windows.Forms.ColumnHeader pesquisa_dataCadastro;
        private System.Windows.Forms.TextBox txtbTelefone_C;
        private System.Windows.Forms.ToolStrip toolStripAtividades;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdicionar;
        private System.Windows.Forms.ToolStripButton toolStripBtnRemover;
        private System.Windows.Forms.ListView listAtividades;
        private System.Windows.Forms.ToolStripButton toolStripBtnAtualizar;
        private System.Windows.Forms.Label lblCriterios;
        private System.Windows.Forms.ColumnHeader atividades_id;
        private System.Windows.Forms.ColumnHeader atividades_descricao;
        private System.Windows.Forms.ColumnHeader atividades_data;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
    }
}


namespace ScannerAdvSQLInjection
{
    partial class Frm_Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.cbSearchEngineLang = new System.Windows.Forms.ComboBox();
            this.gbSearchEngineLang = new System.Windows.Forms.GroupBox();
            this.rbSearchEngine2 = new System.Windows.Forms.RadioButton();
            this.rbSearchEngine1 = new System.Windows.Forms.RadioButton();
            this.gbSearchEngineUrl = new System.Windows.Forms.GroupBox();
            this.txtSearchEngineUrl = new System.Windows.Forms.TextBox();
            this.gbSearchEngineParam = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSearchEnginePages2 = new System.Windows.Forms.RadioButton();
            this.rbSearchEnginePages1 = new System.Windows.Forms.RadioButton();
            this.lblSearchEngineWords = new System.Windows.Forms.Label();
            this.txtSearchEngineWords = new System.Windows.Forms.TextBox();
            this.txtSearchEngineSeed = new System.Windows.Forms.NumericUpDown();
            this.lblSearchEngineSeed = new System.Windows.Forms.Label();
            this.lblSearchEngineParam = new System.Windows.Forms.Label();
            this.txtSearchEngineParam = new System.Windows.Forms.TextBox();
            this.gbSearchEngineResults = new System.Windows.Forms.GroupBox();
            this.lblSearchEngineResults = new System.Windows.Forms.Label();
            this.lblSearchEngineResultsValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSearchEngineResults = new System.Windows.Forms.ProgressBar();
            this.txtSearchEngineResults = new System.Windows.Forms.TextBox();
            this.gbVulnResults = new System.Windows.Forms.GroupBox();
            this.lblVulnResults = new System.Windows.Forms.Label();
            this.lblVulnResultsValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbVulnResults = new System.Windows.Forms.ProgressBar();
            this.txtVulnResults = new System.Windows.Forms.TextBox();
            this.btnSearchVuln = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbThreads = new System.Windows.Forms.GroupBox();
            this.txtThreads = new System.Windows.Forms.NumericUpDown();
            this.lblThreads = new System.Windows.Forms.Label();
            this.gbTimeout = new System.Windows.Forms.GroupBox();
            this.txtTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.gbTimeoutVuln = new System.Windows.Forms.GroupBox();
            this.txtTimeoutVuln = new System.Windows.Forms.NumericUpDown();
            this.lblTimeoutVuln = new System.Windows.Forms.Label();
            this.gbThreadsVuln = new System.Windows.Forms.GroupBox();
            this.txtThreadsVuln = new System.Windows.Forms.NumericUpDown();
            this.lblThreadsVuln = new System.Windows.Forms.Label();
            this.gbSearchEngineLang.SuspendLayout();
            this.gbSearchEngineUrl.SuspendLayout();
            this.gbSearchEngineParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchEngineSeed)).BeginInit();
            this.gbSearchEngineResults.SuspendLayout();
            this.gbVulnResults.SuspendLayout();
            this.gbThreads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThreads)).BeginInit();
            this.gbTimeout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).BeginInit();
            this.gbTimeoutVuln.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeoutVuln)).BeginInit();
            this.gbThreadsVuln.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThreadsVuln)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSearchEngineLang
            // 
            this.cbSearchEngineLang.BackColor = System.Drawing.Color.SeaShell;
            this.cbSearchEngineLang.FormattingEnabled = true;
            this.cbSearchEngineLang.Items.AddRange(new object[] {
            "Alemania - de",
            "Argentina - ar",
            "Australia - au",
            "Austria - at",
            "Brasil - br",
            "Canadá - ca",
            "Chile - cl",
            "China - cn",
            "Colombia - co",
            "Dinamarca - dk",
            "España - es",
            "Filipinas - ph",
            "Finlandia - fi",
            "Francia - fr",
            "Grecia - gr",
            "Holanda - nl",
            "Hong Kong - hk",
            "India - in",
            "Indonesia - id",
            "Italia - it",
            "Japón - je",
            "Malasia - me",
            "Noruega - no",
            "Nueva Zelanda - nz",
            "Perú - pe",
            "Polonia - pl",
            "Quebec - qc",
            "Reino Unido - uk",
            "Rumanía - ro",
            "Rusia - ru",
            "Suecia - se",
            "Suiza - ch",
            "Tailandia - th",
            "Taiwan - tw",
            "Turquía - tr",
            "Tuvalu - tv",
            "Venezuela - ve",
            "Vietnam - vn"});
            this.cbSearchEngineLang.Location = new System.Drawing.Point(71, 47);
            this.cbSearchEngineLang.Name = "cbSearchEngineLang";
            this.cbSearchEngineLang.Size = new System.Drawing.Size(142, 21);
            this.cbSearchEngineLang.TabIndex = 2;
            this.cbSearchEngineLang.SelectedIndexChanged += new System.EventHandler(this.cbSearchEngineLang_SelectedIndexChanged);
            // 
            // gbSearchEngineLang
            // 
            this.gbSearchEngineLang.Controls.Add(this.rbSearchEngine2);
            this.gbSearchEngineLang.Controls.Add(this.rbSearchEngine1);
            this.gbSearchEngineLang.Controls.Add(this.cbSearchEngineLang);
            this.gbSearchEngineLang.Location = new System.Drawing.Point(12, 12);
            this.gbSearchEngineLang.Name = "gbSearchEngineLang";
            this.gbSearchEngineLang.Size = new System.Drawing.Size(315, 78);
            this.gbSearchEngineLang.TabIndex = 0;
            this.gbSearchEngineLang.TabStop = false;
            this.gbSearchEngineLang.Text = "Yahoo! Buscador - Idioma";
            // 
            // rbSearchEngine2
            // 
            this.rbSearchEngine2.AutoSize = true;
            this.rbSearchEngine2.Location = new System.Drawing.Point(20, 49);
            this.rbSearchEngine2.Name = "rbSearchEngine2";
            this.rbSearchEngine2.Size = new System.Drawing.Size(45, 17);
            this.rbSearchEngine2.TabIndex = 1;
            this.rbSearchEngine2.TabStop = true;
            this.rbSearchEngine2.Text = "Pais";
            this.rbSearchEngine2.UseVisualStyleBackColor = true;
            this.rbSearchEngine2.CheckedChanged += new System.EventHandler(this.rbSearchEngine2_CheckedChanged);
            // 
            // rbSearchEngine1
            // 
            this.rbSearchEngine1.AutoSize = true;
            this.rbSearchEngine1.Location = new System.Drawing.Point(20, 24);
            this.rbSearchEngine1.Name = "rbSearchEngine1";
            this.rbSearchEngine1.Size = new System.Drawing.Size(115, 17);
            this.rbSearchEngine1.TabIndex = 0;
            this.rbSearchEngine1.TabStop = true;
            this.rbSearchEngine1.Text = "Internacional - com";
            this.rbSearchEngine1.UseVisualStyleBackColor = true;
            // 
            // gbSearchEngineUrl
            // 
            this.gbSearchEngineUrl.Controls.Add(this.txtSearchEngineUrl);
            this.gbSearchEngineUrl.Location = new System.Drawing.Point(12, 153);
            this.gbSearchEngineUrl.Name = "gbSearchEngineUrl";
            this.gbSearchEngineUrl.Size = new System.Drawing.Size(485, 40);
            this.gbSearchEngineUrl.TabIndex = 4;
            this.gbSearchEngineUrl.TabStop = false;
            this.gbSearchEngineUrl.Text = "URL";
            // 
            // txtSearchEngineUrl
            // 
            this.txtSearchEngineUrl.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSearchEngineUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEngineUrl.Location = new System.Drawing.Point(39, 13);
            this.txtSearchEngineUrl.Name = "txtSearchEngineUrl";
            this.txtSearchEngineUrl.ReadOnly = true;
            this.txtSearchEngineUrl.Size = new System.Drawing.Size(423, 20);
            this.txtSearchEngineUrl.TabIndex = 0;
            // 
            // gbSearchEngineParam
            // 
            this.gbSearchEngineParam.Controls.Add(this.label2);
            this.gbSearchEngineParam.Controls.Add(this.rbSearchEnginePages2);
            this.gbSearchEngineParam.Controls.Add(this.rbSearchEnginePages1);
            this.gbSearchEngineParam.Controls.Add(this.lblSearchEngineWords);
            this.gbSearchEngineParam.Controls.Add(this.txtSearchEngineWords);
            this.gbSearchEngineParam.Controls.Add(this.txtSearchEngineSeed);
            this.gbSearchEngineParam.Controls.Add(this.lblSearchEngineSeed);
            this.gbSearchEngineParam.Controls.Add(this.lblSearchEngineParam);
            this.gbSearchEngineParam.Controls.Add(this.txtSearchEngineParam);
            this.gbSearchEngineParam.Location = new System.Drawing.Point(338, 12);
            this.gbSearchEngineParam.Name = "gbSearchEngineParam";
            this.gbSearchEngineParam.Size = new System.Drawing.Size(229, 136);
            this.gbSearchEngineParam.TabIndex = 1;
            this.gbSearchEngineParam.TabStop = false;
            this.gbSearchEngineParam.Text = "Yahoo! Buscador - Parámetros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Páginas";
            // 
            // rbSearchEnginePages2
            // 
            this.rbSearchEnginePages2.AutoSize = true;
            this.rbSearchEnginePages2.Location = new System.Drawing.Point(139, 24);
            this.rbSearchEnginePages2.Name = "rbSearchEnginePages2";
            this.rbSearchEnginePages2.Size = new System.Drawing.Size(47, 17);
            this.rbSearchEnginePages2.TabIndex = 6;
            this.rbSearchEnginePages2.TabStop = true;
            this.rbSearchEnginePages2.Text = "aspx";
            this.rbSearchEnginePages2.UseVisualStyleBackColor = true;
            this.rbSearchEnginePages2.CheckedChanged += new System.EventHandler(this.rbSearchEnginePages2_CheckedChanged);
            // 
            // rbSearchEnginePages1
            // 
            this.rbSearchEnginePages1.AutoSize = true;
            this.rbSearchEnginePages1.Location = new System.Drawing.Point(73, 24);
            this.rbSearchEnginePages1.Name = "rbSearchEnginePages1";
            this.rbSearchEnginePages1.Size = new System.Drawing.Size(42, 17);
            this.rbSearchEnginePages1.TabIndex = 3;
            this.rbSearchEnginePages1.TabStop = true;
            this.rbSearchEnginePages1.Text = "asp";
            this.rbSearchEnginePages1.UseVisualStyleBackColor = true;
            this.rbSearchEnginePages1.CheckedChanged += new System.EventHandler(this.rbSearchEnginePages1_CheckedChanged);
            // 
            // lblSearchEngineWords
            // 
            this.lblSearchEngineWords.AutoSize = true;
            this.lblSearchEngineWords.Location = new System.Drawing.Point(10, 74);
            this.lblSearchEngineWords.Name = "lblSearchEngineWords";
            this.lblSearchEngineWords.Size = new System.Drawing.Size(48, 13);
            this.lblSearchEngineWords.TabIndex = 2;
            this.lblSearchEngineWords.Text = "Palabras";
            // 
            // txtSearchEngineWords
            // 
            this.txtSearchEngineWords.BackColor = System.Drawing.Color.SeaShell;
            this.txtSearchEngineWords.Location = new System.Drawing.Point(72, 71);
            this.txtSearchEngineWords.MaxLength = 25;
            this.txtSearchEngineWords.Name = "txtSearchEngineWords";
            this.txtSearchEngineWords.Size = new System.Drawing.Size(138, 20);
            this.txtSearchEngineWords.TabIndex = 3;
            this.txtSearchEngineWords.TextChanged += new System.EventHandler(this.txtSearchEngineWords_TextChanged);
            this.txtSearchEngineWords.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchEngineWords_KeyPress);
            // 
            // txtSearchEngineSeed
            // 
            this.txtSearchEngineSeed.BackColor = System.Drawing.Color.SeaShell;
            this.txtSearchEngineSeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtSearchEngineSeed.Location = new System.Drawing.Point(72, 97);
            this.txtSearchEngineSeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSearchEngineSeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtSearchEngineSeed.Name = "txtSearchEngineSeed";
            this.txtSearchEngineSeed.ReadOnly = true;
            this.txtSearchEngineSeed.Size = new System.Drawing.Size(86, 20);
            this.txtSearchEngineSeed.TabIndex = 5;
            this.txtSearchEngineSeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblSearchEngineSeed
            // 
            this.lblSearchEngineSeed.AutoSize = true;
            this.lblSearchEngineSeed.Location = new System.Drawing.Point(10, 101);
            this.lblSearchEngineSeed.Name = "lblSearchEngineSeed";
            this.lblSearchEngineSeed.Size = new System.Drawing.Size(60, 13);
            this.lblSearchEngineSeed.TabIndex = 4;
            this.lblSearchEngineSeed.Text = "Máx. URLs";
            // 
            // lblSearchEngineParam
            // 
            this.lblSearchEngineParam.AutoSize = true;
            this.lblSearchEngineParam.Location = new System.Drawing.Point(10, 49);
            this.lblSearchEngineParam.Name = "lblSearchEngineParam";
            this.lblSearchEngineParam.Size = new System.Drawing.Size(55, 13);
            this.lblSearchEngineParam.TabIndex = 0;
            this.lblSearchEngineParam.Text = "Parámetro";
            // 
            // txtSearchEngineParam
            // 
            this.txtSearchEngineParam.BackColor = System.Drawing.Color.SeaShell;
            this.txtSearchEngineParam.Location = new System.Drawing.Point(72, 46);
            this.txtSearchEngineParam.MaxLength = 15;
            this.txtSearchEngineParam.Name = "txtSearchEngineParam";
            this.txtSearchEngineParam.Size = new System.Drawing.Size(138, 20);
            this.txtSearchEngineParam.TabIndex = 1;
            this.txtSearchEngineParam.TextChanged += new System.EventHandler(this.txtSearchEngineParam_TextChanged);
            this.txtSearchEngineParam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchEngineParam_KeyPress);
            // 
            // gbSearchEngineResults
            // 
            this.gbSearchEngineResults.Controls.Add(this.lblSearchEngineResults);
            this.gbSearchEngineResults.Controls.Add(this.lblSearchEngineResultsValue);
            this.gbSearchEngineResults.Controls.Add(this.label1);
            this.gbSearchEngineResults.Controls.Add(this.pbSearchEngineResults);
            this.gbSearchEngineResults.Controls.Add(this.txtSearchEngineResults);
            this.gbSearchEngineResults.Location = new System.Drawing.Point(12, 200);
            this.gbSearchEngineResults.Name = "gbSearchEngineResults";
            this.gbSearchEngineResults.Size = new System.Drawing.Size(558, 223);
            this.gbSearchEngineResults.TabIndex = 6;
            this.gbSearchEngineResults.TabStop = false;
            this.gbSearchEngineResults.Text = "Direcciones Válidas";
            // 
            // lblSearchEngineResults
            // 
            this.lblSearchEngineResults.AutoSize = true;
            this.lblSearchEngineResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEngineResults.ForeColor = System.Drawing.Color.Black;
            this.lblSearchEngineResults.Location = new System.Drawing.Point(414, 9);
            this.lblSearchEngineResults.Name = "lblSearchEngineResults";
            this.lblSearchEngineResults.Size = new System.Drawing.Size(81, 13);
            this.lblSearchEngineResults.TabIndex = 0;
            this.lblSearchEngineResults.Text = "Nº Direcciones:";
            // 
            // lblSearchEngineResultsValue
            // 
            this.lblSearchEngineResultsValue.AutoSize = true;
            this.lblSearchEngineResultsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEngineResultsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSearchEngineResultsValue.Location = new System.Drawing.Point(494, 9);
            this.lblSearchEngineResultsValue.Name = "lblSearchEngineResultsValue";
            this.lblSearchEngineResultsValue.Size = new System.Drawing.Size(14, 13);
            this.lblSearchEngineResultsValue.TabIndex = 1;
            this.lblSearchEngineResultsValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Completado";
            // 
            // pbSearchEngineResults
            // 
            this.pbSearchEngineResults.BackColor = System.Drawing.SystemColors.Control;
            this.pbSearchEngineResults.Location = new System.Drawing.Point(87, 198);
            this.pbSearchEngineResults.Name = "pbSearchEngineResults";
            this.pbSearchEngineResults.Size = new System.Drawing.Size(450, 17);
            this.pbSearchEngineResults.TabIndex = 4;
            // 
            // txtSearchEngineResults
            // 
            this.txtSearchEngineResults.BackColor = System.Drawing.Color.SeaShell;
            this.txtSearchEngineResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEngineResults.Location = new System.Drawing.Point(20, 23);
            this.txtSearchEngineResults.Multiline = true;
            this.txtSearchEngineResults.Name = "txtSearchEngineResults";
            this.txtSearchEngineResults.ReadOnly = true;
            this.txtSearchEngineResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchEngineResults.Size = new System.Drawing.Size(517, 170);
            this.txtSearchEngineResults.TabIndex = 2;
            // 
            // gbVulnResults
            // 
            this.gbVulnResults.Controls.Add(this.lblVulnResults);
            this.gbVulnResults.Controls.Add(this.lblVulnResultsValue);
            this.gbVulnResults.Controls.Add(this.label4);
            this.gbVulnResults.Controls.Add(this.pbVulnResults);
            this.gbVulnResults.Controls.Add(this.txtVulnResults);
            this.gbVulnResults.Location = new System.Drawing.Point(12, 488);
            this.gbVulnResults.Name = "gbVulnResults";
            this.gbVulnResults.Size = new System.Drawing.Size(560, 224);
            this.gbVulnResults.TabIndex = 8;
            this.gbVulnResults.TabStop = false;
            this.gbVulnResults.Text = "Direcciones Vulnerables";
            // 
            // lblVulnResults
            // 
            this.lblVulnResults.AutoSize = true;
            this.lblVulnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVulnResults.ForeColor = System.Drawing.Color.Black;
            this.lblVulnResults.Location = new System.Drawing.Point(414, 9);
            this.lblVulnResults.Name = "lblVulnResults";
            this.lblVulnResults.Size = new System.Drawing.Size(81, 13);
            this.lblVulnResults.TabIndex = 0;
            this.lblVulnResults.Text = "Nº Direcciones:";
            // 
            // lblVulnResultsValue
            // 
            this.lblVulnResultsValue.AutoSize = true;
            this.lblVulnResultsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVulnResultsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVulnResultsValue.Location = new System.Drawing.Point(494, 9);
            this.lblVulnResultsValue.Name = "lblVulnResultsValue";
            this.lblVulnResultsValue.Size = new System.Drawing.Size(14, 13);
            this.lblVulnResultsValue.TabIndex = 1;
            this.lblVulnResultsValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Completado";
            // 
            // pbVulnResults
            // 
            this.pbVulnResults.BackColor = System.Drawing.SystemColors.Control;
            this.pbVulnResults.Location = new System.Drawing.Point(87, 198);
            this.pbVulnResults.Name = "pbVulnResults";
            this.pbVulnResults.Size = new System.Drawing.Size(449, 17);
            this.pbVulnResults.TabIndex = 4;
            // 
            // txtVulnResults
            // 
            this.txtVulnResults.BackColor = System.Drawing.Color.SeaShell;
            this.txtVulnResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVulnResults.Location = new System.Drawing.Point(20, 23);
            this.txtVulnResults.Multiline = true;
            this.txtVulnResults.Name = "txtVulnResults";
            this.txtVulnResults.ReadOnly = true;
            this.txtVulnResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVulnResults.Size = new System.Drawing.Size(517, 170);
            this.txtVulnResults.TabIndex = 2;
            // 
            // btnSearchVuln
            // 
            this.btnSearchVuln.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchVuln.Image")));
            this.btnSearchVuln.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchVuln.Location = new System.Drawing.Point(338, 440);
            this.btnSearchVuln.Name = "btnSearchVuln";
            this.btnSearchVuln.Size = new System.Drawing.Size(232, 35);
            this.btnSearchVuln.TabIndex = 7;
            this.btnSearchVuln.Text = "Buscar Direcciones Vulnerables";
            this.btnSearchVuln.UseVisualStyleBackColor = true;
            this.btnSearchVuln.Click += new System.EventHandler(this.btnSearchVuln_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ScannerAdvSQLInjection.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(507, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbThreads
            // 
            this.gbThreads.Controls.Add(this.txtThreads);
            this.gbThreads.Controls.Add(this.lblThreads);
            this.gbThreads.Location = new System.Drawing.Point(12, 95);
            this.gbThreads.Name = "gbThreads";
            this.gbThreads.Size = new System.Drawing.Size(151, 51);
            this.gbThreads.TabIndex = 2;
            this.gbThreads.TabStop = false;
            this.gbThreads.Text = "Concurrencia";
            // 
            // txtThreads
            // 
            this.txtThreads.BackColor = System.Drawing.Color.SeaShell;
            this.txtThreads.Location = new System.Drawing.Point(81, 19);
            this.txtThreads.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.ReadOnly = true;
            this.txtThreads.Size = new System.Drawing.Size(56, 20);
            this.txtThreads.TabIndex = 1;
            this.txtThreads.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Location = new System.Drawing.Point(12, 23);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(58, 13);
            this.lblThreads.TabIndex = 0;
            this.lblThreads.Text = "Num. Hilos";
            // 
            // gbTimeout
            // 
            this.gbTimeout.Controls.Add(this.txtTimeout);
            this.gbTimeout.Controls.Add(this.lblTimeout);
            this.gbTimeout.Location = new System.Drawing.Point(177, 95);
            this.gbTimeout.Name = "gbTimeout";
            this.gbTimeout.Size = new System.Drawing.Size(151, 52);
            this.gbTimeout.TabIndex = 3;
            this.gbTimeout.TabStop = false;
            this.gbTimeout.Text = "Timeout";
            // 
            // txtTimeout
            // 
            this.txtTimeout.BackColor = System.Drawing.Color.SeaShell;
            this.txtTimeout.Location = new System.Drawing.Point(81, 19);
            this.txtTimeout.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.ReadOnly = true;
            this.txtTimeout.Size = new System.Drawing.Size(56, 20);
            this.txtTimeout.TabIndex = 1;
            this.txtTimeout.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(12, 23);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(57, 13);
            this.lblTimeout.TabIndex = 0;
            this.lblTimeout.Text = "Num. Seg.";
            // 
            // gbTimeoutVuln
            // 
            this.gbTimeoutVuln.Controls.Add(this.txtTimeoutVuln);
            this.gbTimeoutVuln.Controls.Add(this.lblTimeoutVuln);
            this.gbTimeoutVuln.Location = new System.Drawing.Point(177, 430);
            this.gbTimeoutVuln.Name = "gbTimeoutVuln";
            this.gbTimeoutVuln.Size = new System.Drawing.Size(151, 52);
            this.gbTimeoutVuln.TabIndex = 5;
            this.gbTimeoutVuln.TabStop = false;
            this.gbTimeoutVuln.Text = "Timeout";
            // 
            // txtTimeoutVuln
            // 
            this.txtTimeoutVuln.BackColor = System.Drawing.Color.SeaShell;
            this.txtTimeoutVuln.Location = new System.Drawing.Point(81, 19);
            this.txtTimeoutVuln.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtTimeoutVuln.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTimeoutVuln.Name = "txtTimeoutVuln";
            this.txtTimeoutVuln.ReadOnly = true;
            this.txtTimeoutVuln.Size = new System.Drawing.Size(56, 20);
            this.txtTimeoutVuln.TabIndex = 1;
            this.txtTimeoutVuln.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblTimeoutVuln
            // 
            this.lblTimeoutVuln.AutoSize = true;
            this.lblTimeoutVuln.Location = new System.Drawing.Point(12, 23);
            this.lblTimeoutVuln.Name = "lblTimeoutVuln";
            this.lblTimeoutVuln.Size = new System.Drawing.Size(57, 13);
            this.lblTimeoutVuln.TabIndex = 0;
            this.lblTimeoutVuln.Text = "Num. Seg.";
            // 
            // gbThreadsVuln
            // 
            this.gbThreadsVuln.Controls.Add(this.txtThreadsVuln);
            this.gbThreadsVuln.Controls.Add(this.lblThreadsVuln);
            this.gbThreadsVuln.Location = new System.Drawing.Point(12, 430);
            this.gbThreadsVuln.Name = "gbThreadsVuln";
            this.gbThreadsVuln.Size = new System.Drawing.Size(151, 51);
            this.gbThreadsVuln.TabIndex = 4;
            this.gbThreadsVuln.TabStop = false;
            this.gbThreadsVuln.Text = "Concurrencia";
            // 
            // txtThreadsVuln
            // 
            this.txtThreadsVuln.BackColor = System.Drawing.Color.SeaShell;
            this.txtThreadsVuln.Location = new System.Drawing.Point(81, 19);
            this.txtThreadsVuln.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtThreadsVuln.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtThreadsVuln.Name = "txtThreadsVuln";
            this.txtThreadsVuln.ReadOnly = true;
            this.txtThreadsVuln.Size = new System.Drawing.Size(56, 20);
            this.txtThreadsVuln.TabIndex = 1;
            this.txtThreadsVuln.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblThreadsVuln
            // 
            this.lblThreadsVuln.AutoSize = true;
            this.lblThreadsVuln.Location = new System.Drawing.Point(12, 23);
            this.lblThreadsVuln.Name = "lblThreadsVuln";
            this.lblThreadsVuln.Size = new System.Drawing.Size(58, 13);
            this.lblThreadsVuln.TabIndex = 0;
            this.lblThreadsVuln.Text = "Num. Hilos";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 723);
            this.Controls.Add(this.gbTimeoutVuln);
            this.Controls.Add(this.gbThreadsVuln);
            this.Controls.Add(this.gbTimeout);
            this.Controls.Add(this.gbThreads);
            this.Controls.Add(this.btnSearchVuln);
            this.Controls.Add(this.gbVulnResults);
            this.Controls.Add(this.gbSearchEngineResults);
            this.Controls.Add(this.gbSearchEngineParam);
            this.Controls.Add(this.gbSearchEngineUrl);
            this.Controls.Add(this.gbSearchEngineLang);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced SQL Injection v1.0";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.gbSearchEngineLang.ResumeLayout(false);
            this.gbSearchEngineLang.PerformLayout();
            this.gbSearchEngineUrl.ResumeLayout(false);
            this.gbSearchEngineUrl.PerformLayout();
            this.gbSearchEngineParam.ResumeLayout(false);
            this.gbSearchEngineParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchEngineSeed)).EndInit();
            this.gbSearchEngineResults.ResumeLayout(false);
            this.gbSearchEngineResults.PerformLayout();
            this.gbVulnResults.ResumeLayout(false);
            this.gbVulnResults.PerformLayout();
            this.gbThreads.ResumeLayout(false);
            this.gbThreads.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThreads)).EndInit();
            this.gbTimeout.ResumeLayout(false);
            this.gbTimeout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).EndInit();
            this.gbTimeoutVuln.ResumeLayout(false);
            this.gbTimeoutVuln.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeoutVuln)).EndInit();
            this.gbThreadsVuln.ResumeLayout(false);
            this.gbThreadsVuln.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThreadsVuln)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchEngineLang;
        private System.Windows.Forms.GroupBox gbSearchEngineLang;
        private System.Windows.Forms.RadioButton rbSearchEngine2;
        private System.Windows.Forms.RadioButton rbSearchEngine1;
        private System.Windows.Forms.GroupBox gbSearchEngineUrl;
        private System.Windows.Forms.TextBox txtSearchEngineUrl;
        private System.Windows.Forms.GroupBox gbSearchEngineParam;
        private System.Windows.Forms.Label lblSearchEngineParam;
        private System.Windows.Forms.TextBox txtSearchEngineParam;
        private System.Windows.Forms.Label lblSearchEngineSeed;
        private System.Windows.Forms.NumericUpDown txtSearchEngineSeed;
        private System.Windows.Forms.GroupBox gbSearchEngineResults;
        private System.Windows.Forms.TextBox txtSearchEngineResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbSearchEngineResults;
        private System.Windows.Forms.Label lblSearchEngineResults;
        private System.Windows.Forms.Label lblSearchEngineResultsValue;
        private System.Windows.Forms.GroupBox gbVulnResults;
        private System.Windows.Forms.Label lblVulnResults;
        private System.Windows.Forms.Label lblVulnResultsValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbVulnResults;
        private System.Windows.Forms.TextBox txtVulnResults;
        private System.Windows.Forms.Button btnSearchVuln;
        private System.Windows.Forms.GroupBox gbThreads;
        private System.Windows.Forms.NumericUpDown txtThreads;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.GroupBox gbTimeout;
        private System.Windows.Forms.NumericUpDown txtTimeout;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.Label lblSearchEngineWords;
        private System.Windows.Forms.TextBox txtSearchEngineWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSearchEnginePages2;
        private System.Windows.Forms.RadioButton rbSearchEnginePages1;
        private System.Windows.Forms.GroupBox gbTimeoutVuln;
        private System.Windows.Forms.NumericUpDown txtTimeoutVuln;
        private System.Windows.Forms.Label lblTimeoutVuln;
        private System.Windows.Forms.GroupBox gbThreadsVuln;
        private System.Windows.Forms.NumericUpDown txtThreadsVuln;
        private System.Windows.Forms.Label lblThreadsVuln;
    }
}


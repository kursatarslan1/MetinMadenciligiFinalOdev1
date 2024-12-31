namespace MetinMadenciligiFinalOdev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pnlMidTop = new System.Windows.Forms.Panel();
            this.txtText = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMetin = new System.Windows.Forms.Label();
            this.pnlMidTopBottom = new System.Windows.Forms.Panel();
            this.btnAnalyze = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMidTopTop = new System.Windows.Forms.Panel();
            this.pnlBottomBottom = new System.Windows.Forms.Panel();
            this.btnDownloadExcelFile = new Guna.UI2.WinForms.Guna2Button();
            this.WordCountBySuffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyllableCountByGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeastUsedLetters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MostUsedLetters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeastUsedSyllables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MostUsedSyllables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeastUsedRoots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MostUsedRoots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageLetterCountPerWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageSyllablePerWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageWordCountPerSentence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RootCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetterCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyllableCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SentenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PunctuationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResults = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlMidMid = new System.Windows.Forms.Panel();
            this.lblPunctuationCount = new System.Windows.Forms.Label();
            this.pnlMidMidLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSyllableCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAverageWordCountPerSentence = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMostUsedRoots = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblLeastUsedRoots = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAverageSyllableCountPerWord = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblLetterCount = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblSentenceCount = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblMostUsedSyllables = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblAverageLetterCountPerWord = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblRootCount = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblLeastUsedSyllables = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblMostUsedLetters = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.lblLeastUsedLetters = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lblSyllableGroupsByWord = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lblSuffixGroupByWord = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.pnlMidTop.SuspendLayout();
            this.pnlMidTopBottom.SuspendLayout();
            this.pnlMidTopTop.SuspendLayout();
            this.pnlBottomBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.pnlMidMid.SuspendLayout();
            this.pnlMidMidLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1326, 93);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1326, 93);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Metin Madenciliği Final Ödev";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.White;
            this.pnlMid.Controls.Add(this.pnlMidMid);
            this.pnlMid.Controls.Add(this.pnlBottomBottom);
            this.pnlMid.Controls.Add(this.dgvResults);
            this.pnlMid.Controls.Add(this.pnlMidTop);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.ForeColor = System.Drawing.Color.Black;
            this.pnlMid.Location = new System.Drawing.Point(0, 93);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(1326, 787);
            this.pnlMid.TabIndex = 1;
            // 
            // pnlMidTop
            // 
            this.pnlMidTop.Controls.Add(this.pnlMidTopTop);
            this.pnlMidTop.Controls.Add(this.pnlMidTopBottom);
            this.pnlMidTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMidTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMidTop.Name = "pnlMidTop";
            this.pnlMidTop.Size = new System.Drawing.Size(1326, 201);
            this.pnlMidTop.TabIndex = 0;
            // 
            // txtText
            // 
            this.txtText.BorderColor = System.Drawing.Color.Black;
            this.txtText.BorderRadius = 5;
            this.txtText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtText.DefaultText = "";
            this.txtText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtText.ForeColor = System.Drawing.Color.Black;
            this.txtText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtText.Location = new System.Drawing.Point(139, 20);
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtText.PlaceholderText = "";
            this.txtText.SelectedText = "";
            this.txtText.Size = new System.Drawing.Size(1167, 89);
            this.txtText.TabIndex = 1;
            // 
            // lblMetin
            // 
            this.lblMetin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMetin.Location = new System.Drawing.Point(20, 20);
            this.lblMetin.Name = "lblMetin";
            this.lblMetin.Size = new System.Drawing.Size(119, 89);
            this.lblMetin.TabIndex = 0;
            this.lblMetin.Text = "Metin Giriniz:";
            this.lblMetin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMidTopBottom
            // 
            this.pnlMidTopBottom.Controls.Add(this.btnAnalyze);
            this.pnlMidTopBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMidTopBottom.Location = new System.Drawing.Point(0, 129);
            this.pnlMidTopBottom.Name = "pnlMidTopBottom";
            this.pnlMidTopBottom.Padding = new System.Windows.Forms.Padding(135, 7, 20, 7);
            this.pnlMidTopBottom.Size = new System.Drawing.Size(1326, 72);
            this.pnlMidTopBottom.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BorderRadius = 6;
            this.btnAnalyze.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnalyze.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnalyze.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnalyze.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnalyze.FillColor = System.Drawing.Color.OliveDrab;
            this.btnAnalyze.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(135, 7);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(1171, 58);
            this.btnAnalyze.TabIndex = 0;
            this.btnAnalyze.Text = "Analizi Başlat";
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // pnlMidTopTop
            // 
            this.pnlMidTopTop.Controls.Add(this.txtText);
            this.pnlMidTopTop.Controls.Add(this.lblMetin);
            this.pnlMidTopTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMidTopTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMidTopTop.Name = "pnlMidTopTop";
            this.pnlMidTopTop.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMidTopTop.Size = new System.Drawing.Size(1326, 129);
            this.pnlMidTopTop.TabIndex = 1;
            // 
            // pnlBottomBottom
            // 
            this.pnlBottomBottom.Controls.Add(this.btnDownloadExcelFile);
            this.pnlBottomBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBottom.Location = new System.Drawing.Point(0, 687);
            this.pnlBottomBottom.Name = "pnlBottomBottom";
            this.pnlBottomBottom.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBottomBottom.Size = new System.Drawing.Size(1326, 100);
            this.pnlBottomBottom.TabIndex = 2;
            // 
            // btnDownloadExcelFile
            // 
            this.btnDownloadExcelFile.BorderRadius = 6;
            this.btnDownloadExcelFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownloadExcelFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownloadExcelFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownloadExcelFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownloadExcelFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDownloadExcelFile.FillColor = System.Drawing.Color.SteelBlue;
            this.btnDownloadExcelFile.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnDownloadExcelFile.ForeColor = System.Drawing.Color.White;
            this.btnDownloadExcelFile.Location = new System.Drawing.Point(20, 20);
            this.btnDownloadExcelFile.Name = "btnDownloadExcelFile";
            this.btnDownloadExcelFile.Size = new System.Drawing.Size(1286, 60);
            this.btnDownloadExcelFile.TabIndex = 1;
            this.btnDownloadExcelFile.Text = "Excel Olarak İndir";
            this.btnDownloadExcelFile.Click += new System.EventHandler(this.btnDownloadExcelFile_Click);
            // 
            // WordCountBySuffix
            // 
            this.WordCountBySuffix.HeaderText = "Ek Sayısına Göre Kelime Dağılımı";
            this.WordCountBySuffix.Name = "WordCountBySuffix";
            this.WordCountBySuffix.ReadOnly = true;
            // 
            // SyllableCountByGroup
            // 
            this.SyllableCountByGroup.HeaderText = "Hece Sayısına Göre Kelime Sayısı";
            this.SyllableCountByGroup.Name = "SyllableCountByGroup";
            this.SyllableCountByGroup.ReadOnly = true;
            // 
            // LeastUsedLetters
            // 
            this.LeastUsedLetters.HeaderText = "En Az Kullanılan Harfler";
            this.LeastUsedLetters.Name = "LeastUsedLetters";
            this.LeastUsedLetters.ReadOnly = true;
            // 
            // MostUsedLetters
            // 
            this.MostUsedLetters.HeaderText = "En Çok Kullanılan Harfler";
            this.MostUsedLetters.Name = "MostUsedLetters";
            this.MostUsedLetters.ReadOnly = true;
            // 
            // LeastUsedSyllables
            // 
            this.LeastUsedSyllables.HeaderText = "En Az Kullanılan Heceler";
            this.LeastUsedSyllables.Name = "LeastUsedSyllables";
            this.LeastUsedSyllables.ReadOnly = true;
            // 
            // MostUsedSyllables
            // 
            this.MostUsedSyllables.HeaderText = "En Çok Kullanılan Heceler";
            this.MostUsedSyllables.Name = "MostUsedSyllables";
            this.MostUsedSyllables.ReadOnly = true;
            // 
            // LeastUsedRoots
            // 
            this.LeastUsedRoots.HeaderText = "En Az Kullanılan Kökler";
            this.LeastUsedRoots.Name = "LeastUsedRoots";
            this.LeastUsedRoots.ReadOnly = true;
            // 
            // MostUsedRoots
            // 
            this.MostUsedRoots.HeaderText = "En Çok Kullanılan Kökler";
            this.MostUsedRoots.Name = "MostUsedRoots";
            this.MostUsedRoots.ReadOnly = true;
            // 
            // AverageLetterCountPerWord
            // 
            this.AverageLetterCountPerWord.HeaderText = "Kelime Başına Ortalama Harf Sayısı";
            this.AverageLetterCountPerWord.Name = "AverageLetterCountPerWord";
            this.AverageLetterCountPerWord.ReadOnly = true;
            // 
            // AverageSyllablePerWord
            // 
            this.AverageSyllablePerWord.HeaderText = "Kelime Başına Ortalama Hece Sayısı";
            this.AverageSyllablePerWord.Name = "AverageSyllablePerWord";
            this.AverageSyllablePerWord.ReadOnly = true;
            // 
            // AverageWordCountPerSentence
            // 
            this.AverageWordCountPerSentence.HeaderText = "Cümle Başına Ortalama Kelime Sayısı";
            this.AverageWordCountPerSentence.Name = "AverageWordCountPerSentence";
            this.AverageWordCountPerSentence.ReadOnly = true;
            // 
            // RootCount
            // 
            this.RootCount.HeaderText = "Kök Sayısı";
            this.RootCount.Name = "RootCount";
            this.RootCount.ReadOnly = true;
            // 
            // LetterCount
            // 
            this.LetterCount.HeaderText = "Harf Sayısı";
            this.LetterCount.Name = "LetterCount";
            this.LetterCount.ReadOnly = true;
            // 
            // SyllableCount
            // 
            this.SyllableCount.HeaderText = "Hece Sayısı";
            this.SyllableCount.Name = "SyllableCount";
            this.SyllableCount.ReadOnly = true;
            // 
            // WordNumber
            // 
            this.WordNumber.HeaderText = "Kelime Sayısı";
            this.WordNumber.Name = "WordNumber";
            this.WordNumber.ReadOnly = true;
            // 
            // SentenceNumber
            // 
            this.SentenceNumber.HeaderText = "Cümle Sayısı";
            this.SentenceNumber.Name = "SentenceNumber";
            this.SentenceNumber.ReadOnly = true;
            // 
            // PunctuationNumber
            // 
            this.PunctuationNumber.HeaderText = "Noktalama İşareti Sayısı";
            this.PunctuationNumber.Name = "PunctuationNumber";
            this.PunctuationNumber.ReadOnly = true;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.ColumnHeadersHeight = 67;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PunctuationNumber,
            this.SentenceNumber,
            this.WordNumber,
            this.SyllableCount,
            this.LetterCount,
            this.RootCount,
            this.AverageWordCountPerSentence,
            this.AverageSyllablePerWord,
            this.AverageLetterCountPerWord,
            this.MostUsedRoots,
            this.LeastUsedRoots,
            this.MostUsedSyllables,
            this.LeastUsedSyllables,
            this.MostUsedLetters,
            this.LeastUsedLetters,
            this.SyllableCountByGroup,
            this.WordCountBySuffix});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvResults.Location = new System.Drawing.Point(0, 201);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(1326, 586);
            this.dgvResults.TabIndex = 1;
            this.dgvResults.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvResults.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvResults.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvResults.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvResults.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvResults.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvResults.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvResults.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvResults.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResults.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvResults.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvResults.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvResults.ThemeStyle.HeaderStyle.Height = 67;
            this.dgvResults.ThemeStyle.ReadOnly = false;
            this.dgvResults.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvResults.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResults.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvResults.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvResults.ThemeStyle.RowsStyle.Height = 22;
            this.dgvResults.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvResults.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // pnlMidMid
            // 
            this.pnlMidMid.Controls.Add(this.panel10);
            this.pnlMidMid.Controls.Add(this.panel5);
            this.pnlMidMid.Controls.Add(this.pnlMidMidLeft);
            this.pnlMidMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMidMid.Location = new System.Drawing.Point(0, 201);
            this.pnlMidMid.Name = "pnlMidMid";
            this.pnlMidMid.Size = new System.Drawing.Size(1326, 486);
            this.pnlMidMid.TabIndex = 3;
            // 
            // lblPunctuationCount
            // 
            this.lblPunctuationCount.BackColor = System.Drawing.Color.Black;
            this.lblPunctuationCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPunctuationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPunctuationCount.ForeColor = System.Drawing.Color.White;
            this.lblPunctuationCount.Location = new System.Drawing.Point(0, 0);
            this.lblPunctuationCount.Name = "lblPunctuationCount";
            this.lblPunctuationCount.Size = new System.Drawing.Size(458, 64);
            this.lblPunctuationCount.TabIndex = 0;
            this.lblPunctuationCount.Text = "Noktalama İşareti Sayısı: ";
            this.lblPunctuationCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMidMidLeft
            // 
            this.pnlMidMidLeft.Controls.Add(this.panel18);
            this.pnlMidMidLeft.Controls.Add(this.panel15);
            this.pnlMidMidLeft.Controls.Add(this.panel4);
            this.pnlMidMidLeft.Controls.Add(this.panel3);
            this.pnlMidMidLeft.Controls.Add(this.panel2);
            this.pnlMidMidLeft.Controls.Add(this.panel1);
            this.pnlMidMidLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMidMidLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMidMidLeft.Name = "pnlMidMidLeft";
            this.pnlMidMidLeft.Size = new System.Drawing.Size(458, 486);
            this.pnlMidMidLeft.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPunctuationCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 64);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSyllableCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 64);
            this.panel2.TabIndex = 1;
            // 
            // lblSyllableCount
            // 
            this.lblSyllableCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSyllableCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSyllableCount.Location = new System.Drawing.Point(0, 0);
            this.lblSyllableCount.Name = "lblSyllableCount";
            this.lblSyllableCount.Size = new System.Drawing.Size(458, 64);
            this.lblSyllableCount.TabIndex = 0;
            this.lblSyllableCount.Text = "Hece Sayısı: ";
            this.lblSyllableCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAverageWordCountPerSentence);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 64);
            this.panel3.TabIndex = 2;
            // 
            // lblAverageWordCountPerSentence
            // 
            this.lblAverageWordCountPerSentence.BackColor = System.Drawing.Color.Black;
            this.lblAverageWordCountPerSentence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAverageWordCountPerSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverageWordCountPerSentence.ForeColor = System.Drawing.Color.White;
            this.lblAverageWordCountPerSentence.Location = new System.Drawing.Point(0, 0);
            this.lblAverageWordCountPerSentence.Name = "lblAverageWordCountPerSentence";
            this.lblAverageWordCountPerSentence.Size = new System.Drawing.Size(458, 64);
            this.lblAverageWordCountPerSentence.TabIndex = 0;
            this.lblAverageWordCountPerSentence.Text = "Cümle Başına Ortalama Kelime Sayısı:";
            this.lblAverageWordCountPerSentence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMostUsedRoots);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 64);
            this.panel4.TabIndex = 3;
            // 
            // lblMostUsedRoots
            // 
            this.lblMostUsedRoots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMostUsedRoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMostUsedRoots.Location = new System.Drawing.Point(0, 0);
            this.lblMostUsedRoots.Name = "lblMostUsedRoots";
            this.lblMostUsedRoots.Size = new System.Drawing.Size(458, 64);
            this.lblMostUsedRoots.TabIndex = 0;
            this.lblMostUsedRoots.Text = "En Çok Kullanılan Kökler:";
            this.lblMostUsedRoots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel19);
            this.panel5.Controls.Add(this.panel16);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(458, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 486);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblLeastUsedRoots);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 192);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 64);
            this.panel6.TabIndex = 3;
            // 
            // lblLeastUsedRoots
            // 
            this.lblLeastUsedRoots.BackColor = System.Drawing.Color.Black;
            this.lblLeastUsedRoots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeastUsedRoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLeastUsedRoots.ForeColor = System.Drawing.Color.White;
            this.lblLeastUsedRoots.Location = new System.Drawing.Point(0, 0);
            this.lblLeastUsedRoots.Name = "lblLeastUsedRoots";
            this.lblLeastUsedRoots.Size = new System.Drawing.Size(500, 64);
            this.lblLeastUsedRoots.TabIndex = 0;
            this.lblLeastUsedRoots.Text = "En Az Kullanılan Kökler:";
            this.lblLeastUsedRoots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblAverageSyllableCountPerWord);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 128);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(500, 64);
            this.panel7.TabIndex = 2;
            // 
            // lblAverageSyllableCountPerWord
            // 
            this.lblAverageSyllableCountPerWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAverageSyllableCountPerWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverageSyllableCountPerWord.Location = new System.Drawing.Point(0, 0);
            this.lblAverageSyllableCountPerWord.Name = "lblAverageSyllableCountPerWord";
            this.lblAverageSyllableCountPerWord.Size = new System.Drawing.Size(500, 64);
            this.lblAverageSyllableCountPerWord.TabIndex = 0;
            this.lblAverageSyllableCountPerWord.Text = "Kelime Başına Ortalama Hece Sayısı:";
            this.lblAverageSyllableCountPerWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblLetterCount);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 64);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(500, 64);
            this.panel8.TabIndex = 1;
            // 
            // lblLetterCount
            // 
            this.lblLetterCount.BackColor = System.Drawing.Color.Black;
            this.lblLetterCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLetterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLetterCount.ForeColor = System.Drawing.Color.White;
            this.lblLetterCount.Location = new System.Drawing.Point(0, 0);
            this.lblLetterCount.Name = "lblLetterCount";
            this.lblLetterCount.Size = new System.Drawing.Size(500, 64);
            this.lblLetterCount.TabIndex = 0;
            this.lblLetterCount.Text = "Harf Sayısı: ";
            this.lblLetterCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblSentenceCount);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(500, 64);
            this.panel9.TabIndex = 0;
            // 
            // lblSentenceCount
            // 
            this.lblSentenceCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSentenceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSentenceCount.Location = new System.Drawing.Point(0, 0);
            this.lblSentenceCount.Name = "lblSentenceCount";
            this.lblSentenceCount.Size = new System.Drawing.Size(500, 64);
            this.lblSentenceCount.TabIndex = 0;
            this.lblSentenceCount.Text = "Cümle Sayısı: ";
            this.lblSentenceCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel17);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(958, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(368, 486);
            this.panel10.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lblMostUsedSyllables);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 192);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(368, 64);
            this.panel11.TabIndex = 3;
            // 
            // lblMostUsedSyllables
            // 
            this.lblMostUsedSyllables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMostUsedSyllables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMostUsedSyllables.Location = new System.Drawing.Point(0, 0);
            this.lblMostUsedSyllables.Name = "lblMostUsedSyllables";
            this.lblMostUsedSyllables.Size = new System.Drawing.Size(368, 64);
            this.lblMostUsedSyllables.TabIndex = 0;
            this.lblMostUsedSyllables.Text = "En Çok Kullanılan Heceler:";
            this.lblMostUsedSyllables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lblAverageLetterCountPerWord);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 128);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(368, 64);
            this.panel12.TabIndex = 2;
            // 
            // lblAverageLetterCountPerWord
            // 
            this.lblAverageLetterCountPerWord.BackColor = System.Drawing.Color.Black;
            this.lblAverageLetterCountPerWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAverageLetterCountPerWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverageLetterCountPerWord.ForeColor = System.Drawing.Color.White;
            this.lblAverageLetterCountPerWord.Location = new System.Drawing.Point(0, 0);
            this.lblAverageLetterCountPerWord.Name = "lblAverageLetterCountPerWord";
            this.lblAverageLetterCountPerWord.Size = new System.Drawing.Size(368, 64);
            this.lblAverageLetterCountPerWord.TabIndex = 0;
            this.lblAverageLetterCountPerWord.Text = "Kelime Başına Ortalama Harf Sayısı:";
            this.lblAverageLetterCountPerWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.lblRootCount);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 64);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(368, 64);
            this.panel13.TabIndex = 1;
            // 
            // lblRootCount
            // 
            this.lblRootCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRootCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRootCount.Location = new System.Drawing.Point(0, 0);
            this.lblRootCount.Name = "lblRootCount";
            this.lblRootCount.Size = new System.Drawing.Size(368, 64);
            this.lblRootCount.TabIndex = 0;
            this.lblRootCount.Text = "Kök Sayısı:";
            this.lblRootCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.lblWordCount);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(368, 64);
            this.panel14.TabIndex = 0;
            // 
            // lblWordCount
            // 
            this.lblWordCount.BackColor = System.Drawing.Color.Black;
            this.lblWordCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWordCount.ForeColor = System.Drawing.Color.White;
            this.lblWordCount.Location = new System.Drawing.Point(0, 0);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(368, 64);
            this.lblWordCount.TabIndex = 0;
            this.lblWordCount.Text = "Kelime Sayısı";
            this.lblWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.lblLeastUsedSyllables);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 256);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(458, 64);
            this.panel15.TabIndex = 4;
            // 
            // lblLeastUsedSyllables
            // 
            this.lblLeastUsedSyllables.BackColor = System.Drawing.Color.Black;
            this.lblLeastUsedSyllables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeastUsedSyllables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLeastUsedSyllables.ForeColor = System.Drawing.Color.White;
            this.lblLeastUsedSyllables.Location = new System.Drawing.Point(0, 0);
            this.lblLeastUsedSyllables.Name = "lblLeastUsedSyllables";
            this.lblLeastUsedSyllables.Size = new System.Drawing.Size(458, 64);
            this.lblLeastUsedSyllables.TabIndex = 0;
            this.lblLeastUsedSyllables.Text = "En Az Kullanılan Heceler:";
            this.lblLeastUsedSyllables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.lblMostUsedLetters);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 256);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(500, 64);
            this.panel16.TabIndex = 4;
            // 
            // lblMostUsedLetters
            // 
            this.lblMostUsedLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMostUsedLetters.Location = new System.Drawing.Point(0, 0);
            this.lblMostUsedLetters.Name = "lblMostUsedLetters";
            this.lblMostUsedLetters.Size = new System.Drawing.Size(500, 64);
            this.lblMostUsedLetters.TabIndex = 0;
            this.lblMostUsedLetters.Text = "En Çok Kullanılan Harfler:";
            this.lblMostUsedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.lblLeastUsedLetters);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 256);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(368, 64);
            this.panel17.TabIndex = 4;
            // 
            // lblLeastUsedLetters
            // 
            this.lblLeastUsedLetters.BackColor = System.Drawing.Color.Black;
            this.lblLeastUsedLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeastUsedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLeastUsedLetters.ForeColor = System.Drawing.Color.White;
            this.lblLeastUsedLetters.Location = new System.Drawing.Point(0, 0);
            this.lblLeastUsedLetters.Name = "lblLeastUsedLetters";
            this.lblLeastUsedLetters.Size = new System.Drawing.Size(368, 64);
            this.lblLeastUsedLetters.TabIndex = 0;
            this.lblLeastUsedLetters.Text = "En Az Kullanılan Harfler:";
            this.lblLeastUsedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.lblSyllableGroupsByWord);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 320);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(458, 64);
            this.panel18.TabIndex = 5;
            // 
            // lblSyllableGroupsByWord
            // 
            this.lblSyllableGroupsByWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSyllableGroupsByWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSyllableGroupsByWord.Location = new System.Drawing.Point(0, 0);
            this.lblSyllableGroupsByWord.Name = "lblSyllableGroupsByWord";
            this.lblSyllableGroupsByWord.Size = new System.Drawing.Size(458, 64);
            this.lblSyllableGroupsByWord.TabIndex = 0;
            this.lblSyllableGroupsByWord.Text = "Hece Sayısına Göre Kelime Sayısı:";
            this.lblSyllableGroupsByWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.lblSuffixGroupByWord);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 320);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(500, 64);
            this.panel19.TabIndex = 5;
            // 
            // lblSuffixGroupByWord
            // 
            this.lblSuffixGroupByWord.BackColor = System.Drawing.Color.Black;
            this.lblSuffixGroupByWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSuffixGroupByWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuffixGroupByWord.ForeColor = System.Drawing.Color.White;
            this.lblSuffixGroupByWord.Location = new System.Drawing.Point(0, 0);
            this.lblSuffixGroupByWord.Name = "lblSuffixGroupByWord";
            this.lblSuffixGroupByWord.Size = new System.Drawing.Size(500, 64);
            this.lblSuffixGroupByWord.TabIndex = 0;
            this.lblSuffixGroupByWord.Text = "Ek Sayısına Göre Kelime Dağılımı:";
            this.lblSuffixGroupByWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1326, 880);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.pnlTop);
            this.Name = "Form1";
            this.Text = "Metin Madenciliği Final Ödev 1";
            this.pnlTop.ResumeLayout(false);
            this.pnlMid.ResumeLayout(false);
            this.pnlMidTop.ResumeLayout(false);
            this.pnlMidTopBottom.ResumeLayout(false);
            this.pnlMidTopTop.ResumeLayout(false);
            this.pnlBottomBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.pnlMidMid.ResumeLayout(false);
            this.pnlMidMidLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Panel pnlMidTop;
        private Guna.UI2.WinForms.Guna2TextBox txtText;
        private System.Windows.Forms.Label lblMetin;
        private System.Windows.Forms.Panel pnlMidTopBottom;
        private System.Windows.Forms.Panel pnlMidTopTop;
        private Guna.UI2.WinForms.Guna2Button btnAnalyze;
        private System.Windows.Forms.Panel pnlBottomBottom;
        private Guna.UI2.WinForms.Guna2Button btnDownloadExcelFile;
        private Guna.UI2.WinForms.Guna2DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn PunctuationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SentenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyllableCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RootCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageWordCountPerSentence;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageSyllablePerWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageLetterCountPerWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn MostUsedRoots;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeastUsedRoots;
        private System.Windows.Forms.DataGridViewTextBoxColumn MostUsedSyllables;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeastUsedSyllables;
        private System.Windows.Forms.DataGridViewTextBoxColumn MostUsedLetters;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeastUsedLetters;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyllableCountByGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordCountBySuffix;
        private System.Windows.Forms.Panel pnlMidMid;
        private System.Windows.Forms.Label lblPunctuationCount;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label lblLeastUsedLetters;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblMostUsedSyllables;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblAverageLetterCountPerWord;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblRootCount;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lblSuffixGroupByWord;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblMostUsedLetters;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLeastUsedRoots;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblAverageSyllableCountPerWord;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblLetterCount;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblSentenceCount;
        private System.Windows.Forms.Panel pnlMidMidLeft;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lblSyllableGroupsByWord;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lblLeastUsedSyllables;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMostUsedRoots;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAverageWordCountPerSentence;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSyllableCount;
        private System.Windows.Forms.Panel panel1;
    }
}


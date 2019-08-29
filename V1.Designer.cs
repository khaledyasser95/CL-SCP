namespace Print_SCP
{
    partial class V1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.serverStart = new System.Windows.Forms.Button();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.counter_lbl = new System.Windows.Forms.Label();
            this.about_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Printers_List = new System.Windows.Forms.ListView();
            this.colPrinterAE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrinterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrinterTray = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrinterPreview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrinterResolution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.footer_txt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.days_txt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.serverStart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.port_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.counter_lbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.about_btn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.days_txt, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 42);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // serverStart
            // 
            this.serverStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.serverStart.AutoSize = true;
            this.serverStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.serverStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.serverStart.Location = new System.Drawing.Point(2, 7);
            this.serverStart.Margin = new System.Windows.Forms.Padding(2);
            this.serverStart.Name = "serverStart";
            this.serverStart.Size = new System.Drawing.Size(86, 28);
            this.serverStart.TabIndex = 3;
            this.serverStart.Text = "Start";
            this.serverStart.UseVisualStyleBackColor = true;
            this.serverStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // port_txt
            // 
            this.port_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.port_txt.Location = new System.Drawing.Point(92, 10);
            this.port_txt.Margin = new System.Windows.Forms.Padding(2);
            this.port_txt.MaxLength = 10;
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(71, 22);
            this.port_txt.TabIndex = 4;
            this.port_txt.Text = "8000";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(167, 10);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "ToFile";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // counter_lbl
            // 
            this.counter_lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.counter_lbl.AutoSize = true;
            this.counter_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.counter_lbl.Location = new System.Drawing.Point(240, 12);
            this.counter_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.counter_lbl.Name = "counter_lbl";
            this.counter_lbl.Size = new System.Drawing.Size(58, 17);
            this.counter_lbl.TabIndex = 5;
            this.counter_lbl.Text = "Counter";
            this.counter_lbl.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // about_btn
            // 
            this.about_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.about_btn.Location = new System.Drawing.Point(303, 8);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(75, 26);
            this.about_btn.TabIndex = 8;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = true;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Printers_List);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 240);
            this.panel1.TabIndex = 8;
            // 
            // Printers_List
            // 
            this.Printers_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPrinterAE,
            this.colPrinterName,
            this.colPrinterTray,
            this.colPrinterPreview,
            this.colPrinterResolution});
            this.Printers_List.FullRowSelect = true;
            this.Printers_List.GridLines = true;
            this.Printers_List.HideSelection = false;
            this.Printers_List.Location = new System.Drawing.Point(13, 17);
            this.Printers_List.Margin = new System.Windows.Forms.Padding(4);
            this.Printers_List.MultiSelect = false;
            this.Printers_List.Name = "Printers_List";
            this.Printers_List.Size = new System.Drawing.Size(693, 149);
            this.Printers_List.TabIndex = 17;
            this.Printers_List.UseCompatibleStateImageBehavior = false;
            this.Printers_List.View = System.Windows.Forms.View.Details;
            this.Printers_List.DoubleClick += new System.EventHandler(this.lvPrinters_DoubleClick);
            this.Printers_List.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvPrinters_KeyDown);
            // 
            // colPrinterAE
            // 
            this.colPrinterAE.Text = "AE Title";
            this.colPrinterAE.Width = 100;
            // 
            // colPrinterName
            // 
            this.colPrinterName.Text = "Printer";
            this.colPrinterName.Width = 150;
            // 
            // colPrinterTray
            // 
            this.colPrinterTray.Text = "Tray";
            this.colPrinterTray.Width = 80;
            // 
            // colPrinterPreview
            // 
            this.colPrinterPreview.Text = "Preview";
            this.colPrinterPreview.Width = 80;
            // 
            // colPrinterResolution
            // 
            this.colPrinterResolution.Text = "Resolution";
            this.colPrinterResolution.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.footer_txt);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Footer";
            // 
            // footer_txt
            // 
            this.footer_txt.Location = new System.Drawing.Point(7, 27);
            this.footer_txt.Name = "footer_txt";
            this.footer_txt.Size = new System.Drawing.Size(687, 22);
            this.footer_txt.TabIndex = 0;
            this.footer_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(630, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(58, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.V1_Load);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // days_txt
            // 
            this.days_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.days_txt.AutoSize = true;
            this.days_txt.Location = new System.Drawing.Point(384, 12);
            this.days_txt.Name = "days_txt";
            this.days_txt.Size = new System.Drawing.Size(45, 17);
            this.days_txt.TabIndex = 9;
            this.days_txt.Text = "DAYS";
            // 
            // V1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(724, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "V1";
            this.Text = "Clevers_SCP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.V1_FormClosing);
            this.Load += new System.EventHandler(this.V1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Button serverStart;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox footer_txt;
        private System.Windows.Forms.ListView Printers_List;
        private System.Windows.Forms.ColumnHeader colPrinterAE;
        private System.Windows.Forms.ColumnHeader colPrinterName;
        private System.Windows.Forms.ColumnHeader colPrinterTray;
        private System.Windows.Forms.ColumnHeader colPrinterPreview;
        private System.Windows.Forms.ColumnHeader colPrinterResolution;
        private System.Windows.Forms.Label counter_lbl;
        private System.Windows.Forms.Button about_btn;
        public System.Windows.Forms.Label days_txt;
    }
}
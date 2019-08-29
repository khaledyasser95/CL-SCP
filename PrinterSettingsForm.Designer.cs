namespace Print_SCP
{
    partial class PrinterSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrinterSettingsForm));
            this.printerSelector = new System.Windows.Forms.Button();
            this.printerName_txt = new System.Windows.Forms.TextBox();
            this.tray = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AETITLE_txt = new System.Windows.Forms.TextBox();
            this.cbPreviewOnly = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.resolutionBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printerSelector
            // 
            this.printerSelector.Location = new System.Drawing.Point(356, 37);
            this.printerSelector.Margin = new System.Windows.Forms.Padding(4);
            this.printerSelector.Name = "printerSelector";
            this.printerSelector.Size = new System.Drawing.Size(45, 27);
            this.printerSelector.TabIndex = 33;
            this.printerSelector.Text = "...";
            this.printerSelector.UseVisualStyleBackColor = true;
            this.printerSelector.Click += new System.EventHandler(this.bttnSelectPrinter_Click);
            // 
            // printerName_txt
            // 
            this.printerName_txt.Location = new System.Drawing.Point(83, 39);
            this.printerName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.printerName_txt.Name = "printerName_txt";
            this.printerName_txt.ReadOnly = true;
            this.printerName_txt.Size = new System.Drawing.Size(265, 22);
            this.printerName_txt.TabIndex = 32;
            // 
            // tray
            // 
            this.tray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tray.FormattingEnabled = true;
            this.tray.Location = new System.Drawing.Point(83, 72);
            this.tray.Margin = new System.Windows.Forms.Padding(4);
            this.tray.Name = "tray";
            this.tray.Size = new System.Drawing.Size(265, 24);
            this.tray.TabIndex = 31;
            this.tray.SelectedIndexChanged += new System.EventHandler(this.cbPaperSource_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "AE Title:";
            // 
            // AETITLE_txt
            // 
            this.AETITLE_txt.Location = new System.Drawing.Point(83, 9);
            this.AETITLE_txt.Margin = new System.Windows.Forms.Padding(4);
            this.AETITLE_txt.MaxLength = 16;
            this.AETITLE_txt.Name = "AETITLE_txt";
            this.AETITLE_txt.Size = new System.Drawing.Size(132, 22);
            this.AETITLE_txt.TabIndex = 24;
            this.AETITLE_txt.TextChanged += new System.EventHandler(this.tbAETitle_TextChanged);
            // 
            // cbPreviewOnly
            // 
            this.cbPreviewOnly.AutoSize = true;
            this.cbPreviewOnly.Location = new System.Drawing.Point(356, 75);
            this.cbPreviewOnly.Margin = new System.Windows.Forms.Padding(4);
            this.cbPreviewOnly.Name = "cbPreviewOnly";
            this.cbPreviewOnly.Size = new System.Drawing.Size(112, 21);
            this.cbPreviewOnly.TabIndex = 25;
            this.cbPreviewOnly.Text = "Preview Only";
            this.cbPreviewOnly.UseVisualStyleBackColor = true;
            this.cbPreviewOnly.CheckedChanged += new System.EventHandler(this.cbPreviewOnly_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tray:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Printer:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(11, 264);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "&OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(323, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 28;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Left";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(324, 21);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 9;
            this.numericUpDown3.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(324, 52);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown4.TabIndex = 10;
            this.numericUpDown4.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Top";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bottom";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(45, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // resolutionBar
            // 
            this.resolutionBar.Location = new System.Drawing.Point(87, 80);
            this.resolutionBar.Maximum = 1200;
            this.resolutionBar.Minimum = 100;
            this.resolutionBar.Name = "resolutionBar";
            this.resolutionBar.Size = new System.Drawing.Size(361, 56);
            this.resolutionBar.TabIndex = 34;
            this.resolutionBar.Value = 100;
            this.resolutionBar.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Resolution";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(44, 52);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.resolutionBar);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(11, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 154);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Margin && Resolution";
            // 
            // PrinterSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.printerSelector);
            this.Controls.Add(this.printerName_txt);
            this.Controls.Add(this.tray);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AETITLE_txt);
            this.Controls.Add(this.cbPreviewOnly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrinterSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer_Setup";
            this.Load += new System.EventHandler(this.PrinterSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printerSelector;
        private System.Windows.Forms.TextBox printerName_txt;
        private System.Windows.Forms.ComboBox tray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AETITLE_txt;
        private System.Windows.Forms.CheckBox cbPreviewOnly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar resolutionBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

namespace Schattenhain_Screener
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbSpeicherort = new System.Windows.Forms.TextBox();
            this.tbIntervall = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSpeicherort
            // 
            this.tbSpeicherort.Location = new System.Drawing.Point(12, 189);
            this.tbSpeicherort.Name = "tbSpeicherort";
            this.tbSpeicherort.PlaceholderText = "Klicken zum Einstellen";
            this.tbSpeicherort.Size = new System.Drawing.Size(278, 23);
            this.tbSpeicherort.TabIndex = 10;
            this.tbSpeicherort.Click += new System.EventHandler(this.TbSpeicherort_Click);
            this.tbSpeicherort.TextChanged += new System.EventHandler(this.TbSpeicherort_TextChanged);
            // 
            // tbIntervall
            // 
            this.tbIntervall.Location = new System.Drawing.Point(207, 218);
            this.tbIntervall.Name = "tbIntervall";
            this.tbIntervall.PlaceholderText = "Empfohlen: 30";
            this.tbIntervall.Size = new System.Drawing.Size(83, 23);
            this.tbIntervall.TabIndex = 2;
            this.tbIntervall.Text = "30";
            this.tbIntervall.TextChanged += new System.EventHandler(this.TbIntervall_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Speicherort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intervall in Sekunden:";
            // 
            // tbProc
            // 
            this.tbProc.Location = new System.Drawing.Point(135, 145);
            this.tbProc.Name = "tbProc";
            this.tbProc.PlaceholderText = "Standart: Schattenhain";
            this.tbProc.Size = new System.Drawing.Size(155, 23);
            this.tbProc.TabIndex = 5;
            this.tbProc.Text = "Schattenhain";
            this.tbProc.TextChanged += new System.EventHandler(this.TbProc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prozess Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 75);
            this.label5.TabIndex = 8;
            this.label5.Text = "ACHTUNG! Das Programm,\r\nmacht einen Screenshot vom Fenster und allem\r\nwas vor dem" +
    " Fenster liegt.\r\nStelle sicher das dass Fenster im vordergrund liegt\r\nund nicht " +
    "verdeckt wird.";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 247);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(278, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Starte / Stoppe Schnüffeln";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(49, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bei Fragen/Problemen > Klick mich <";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 60);
            this.label6.TabIndex = 12;
            this.label6.Text = "Das Programm ist besten Wissens und Gewissens\r\nProgrammiert worden. Trotzdem kann" +
    " es zu \r\nFehlern kommen. Solltet ihr also wichtige Screenshots\r\nhaben, speichert" +
    " sie zusätzlich selbst ab. ";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Location = new System.Drawing.Point(60, 305);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(22, 15);
            this.lblversion.TabIndex = 13;
            this.lblversion.Text = "1.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Version:";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(88, 301);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(202, 23);
            this.btnDownload.TabIndex = 15;
            this.btnDownload.Text = "Download Update";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Visible = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 329);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIntervall);
            this.Controls.Add(this.tbSpeicherort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Schattenhain Schnüffler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSpeicherort;
        private System.Windows.Forms.TextBox tbIntervall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDownload;
    }
}



namespace WFAsuDeposu
{
    partial class Form1
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
            this.pnlDepo = new System.Windows.Forms.Panel();
            this.pnlSu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSuMiktari = new System.Windows.Forms.NumericUpDown();
            this.btnSuEkle = new System.Windows.Forms.Button();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.lblDolulukOrani = new System.Windows.Forms.Label();
            this.pnlDepo.SuspendLayout();
            this.pnlSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDepo
            // 
            this.pnlDepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDepo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDepo.Controls.Add(this.pnlSu);
            this.pnlDepo.Location = new System.Drawing.Point(416, 59);
            this.pnlDepo.Name = "pnlDepo";
            this.pnlDepo.Size = new System.Drawing.Size(200, 323);
            this.pnlDepo.TabIndex = 0;
            // 
            // pnlSu
            // 
            this.pnlSu.BackColor = System.Drawing.Color.Aqua;
            this.pnlSu.Controls.Add(this.lblDolulukOrani);
            this.pnlSu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSu.Location = new System.Drawing.Point(0, 252);
            this.pnlSu.Name = "pnlSu";
            this.pnlSu.Size = new System.Drawing.Size(198, 69);
            this.pnlSu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kapasite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Su Miktarı";
            // 
            // nudSuMiktari
            // 
            this.nudSuMiktari.DecimalPlaces = 2;
            this.nudSuMiktari.Location = new System.Drawing.Point(206, 184);
            this.nudSuMiktari.Name = "nudSuMiktari";
            this.nudSuMiktari.Size = new System.Drawing.Size(120, 20);
            this.nudSuMiktari.TabIndex = 3;
            // 
            // btnSuEkle
            // 
            this.btnSuEkle.Location = new System.Drawing.Point(134, 220);
            this.btnSuEkle.Name = "btnSuEkle";
            this.btnSuEkle.Size = new System.Drawing.Size(192, 23);
            this.btnSuEkle.TabIndex = 4;
            this.btnSuEkle.Text = "Su Ekle";
            this.btnSuEkle.UseVisualStyleBackColor = true;
            this.btnSuEkle.Click += new System.EventHandler(this.btnSuEkle_Click);
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Location = new System.Drawing.Point(467, 394);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(30, 13);
            this.lblKapasite.TabIndex = 5;
            this.lblKapasite.Text = "0 m3";
            // 
            // lblDolulukOrani
            // 
            this.lblDolulukOrani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDolulukOrani.Location = new System.Drawing.Point(89, 37);
            this.lblDolulukOrani.Name = "lblDolulukOrani";
            this.lblDolulukOrani.Size = new System.Drawing.Size(99, 23);
            this.lblDolulukOrani.TabIndex = 6;
            this.lblDolulukOrani.Text = "0%";
            this.lblDolulukOrani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.btnSuEkle);
            this.Controls.Add(this.nudSuMiktari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDepo);
            this.Name = "Form1";
            this.Text = "Ankara Su Deposu";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.pnlDepo.ResumeLayout(false);
            this.pnlSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSuMiktari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepo;
        private System.Windows.Forms.Panel pnlSu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSuMiktari;
        private System.Windows.Forms.Button btnSuEkle;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.Label lblDolulukOrani;
    }
}



namespace WFATura
{
    partial class FrmInsert
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbVeznev = new System.Windows.Forms.TextBox();
            this.tbKernev = new System.Windows.Forms.TextBox();
            this.tbVaros = new System.Windows.Forms.TextBox();
            this.tbTelszam = new System.Windows.Forms.TextBox();
            this.btnFelvetel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vezetéknév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Keresztnév:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Város:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefonszám:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(170, 17);
            this.tbId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(191, 22);
            this.tbId.TabIndex = 1;
            // 
            // tbVeznev
            // 
            this.tbVeznev.Location = new System.Drawing.Point(170, 68);
            this.tbVeznev.Margin = new System.Windows.Forms.Padding(4);
            this.tbVeznev.Name = "tbVeznev";
            this.tbVeznev.Size = new System.Drawing.Size(191, 22);
            this.tbVeznev.TabIndex = 1;
            // 
            // tbKernev
            // 
            this.tbKernev.Location = new System.Drawing.Point(170, 122);
            this.tbKernev.Margin = new System.Windows.Forms.Padding(4);
            this.tbKernev.Name = "tbKernev";
            this.tbKernev.Size = new System.Drawing.Size(191, 22);
            this.tbKernev.TabIndex = 1;
            // 
            // tbVaros
            // 
            this.tbVaros.Location = new System.Drawing.Point(170, 176);
            this.tbVaros.Margin = new System.Windows.Forms.Padding(4);
            this.tbVaros.Name = "tbVaros";
            this.tbVaros.Size = new System.Drawing.Size(191, 22);
            this.tbVaros.TabIndex = 1;
            // 
            // tbTelszam
            // 
            this.tbTelszam.Location = new System.Drawing.Point(170, 232);
            this.tbTelszam.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelszam.Name = "tbTelszam";
            this.tbTelszam.Size = new System.Drawing.Size(191, 22);
            this.tbTelszam.TabIndex = 1;
            // 
            // btnFelvetel
            // 
            this.btnFelvetel.Location = new System.Drawing.Point(32, 288);
            this.btnFelvetel.Name = "btnFelvetel";
            this.btnFelvetel.Size = new System.Drawing.Size(329, 67);
            this.btnFelvetel.TabIndex = 2;
            this.btnFelvetel.Text = "Új személy felvétele";
            this.btnFelvetel.UseVisualStyleBackColor = true;
            this.btnFelvetel.Click += new System.EventHandler(this.btnFelvetel_Click);
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 380);
            this.Controls.Add(this.btnFelvetel);
            this.Controls.Add(this.tbTelszam);
            this.Controls.Add(this.tbVaros);
            this.Controls.Add(this.tbKernev);
            this.Controls.Add(this.tbVeznev);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmInsert";
            this.Text = "FrmInsert";
            this.Load += new System.EventHandler(this.FrmInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbVeznev;
        private System.Windows.Forms.TextBox tbKernev;
        private System.Windows.Forms.TextBox tbVaros;
        private System.Windows.Forms.TextBox tbTelszam;
        private System.Windows.Forms.Button btnFelvetel;
    }
}
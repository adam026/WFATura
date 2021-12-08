
namespace WFATura
{
    partial class FrmAdatok
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
            this.tbSum = new System.Windows.Forms.TextBox();
            this.tbJutalom = new System.Windows.Forms.TextBox();
            this.dgvAdatok = new System.Windows.Forms.DataGridView();
            this.indulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erkezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdatok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(92, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A kiválasztott túrázó kirándulásai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(72, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "A túrázó összes megtett km-e:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(73, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jutalompontok összege:";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(346, 249);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(100, 20);
            this.tbSum.TabIndex = 1;
            // 
            // tbJutalom
            // 
            this.tbJutalom.Location = new System.Drawing.Point(346, 306);
            this.tbJutalom.Name = "tbJutalom";
            this.tbJutalom.Size = new System.Drawing.Size(100, 20);
            this.tbJutalom.TabIndex = 1;
            // 
            // dgvAdatok
            // 
            this.dgvAdatok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indulas,
            this.erkezes,
            this.ut});
            this.dgvAdatok.Location = new System.Drawing.Point(52, 74);
            this.dgvAdatok.Name = "dgvAdatok";
            this.dgvAdatok.RowHeadersVisible = false;
            this.dgvAdatok.Size = new System.Drawing.Size(413, 157);
            this.dgvAdatok.TabIndex = 2;
            // 
            // indulas
            // 
            this.indulas.HeaderText = "Indulás";
            this.indulas.Name = "indulas";
            // 
            // erkezes
            // 
            this.erkezes.HeaderText = "Érkezés";
            this.erkezes.Name = "erkezes";
            // 
            // ut
            // 
            this.ut.HeaderText = "Megtett út";
            this.ut.Name = "ut";
            // 
            // FrmAdatok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 360);
            this.Controls.Add(this.dgvAdatok);
            this.Controls.Add(this.tbJutalom);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdatok";
            this.Text = "FrmAdatok";
            this.Load += new System.EventHandler(this.FrmAdatok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.TextBox tbJutalom;
        private System.Windows.Forms.DataGridView dgvAdatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn indulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn erkezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ut;
    }
}
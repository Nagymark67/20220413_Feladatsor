namespace _20220413_Feladatsor
{
    partial class HetedikFeladat
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
            this.Felkover_CheckBox = new System.Windows.Forms.CheckBox();
            this.Dolt_CheckBox = new System.Windows.Forms.CheckBox();
            this.Alahuzott_CheckBox = new System.Windows.Forms.CheckBox();
            this.Vegrehajt_Gomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Felkover_CheckBox
            // 
            this.Felkover_CheckBox.AutoSize = true;
            this.Felkover_CheckBox.Location = new System.Drawing.Point(100, 144);
            this.Felkover_CheckBox.Name = "Felkover_CheckBox";
            this.Felkover_CheckBox.Size = new System.Drawing.Size(80, 17);
            this.Felkover_CheckBox.TabIndex = 1;
            this.Felkover_CheckBox.Text = "checkBox1";
            this.Felkover_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Dolt_CheckBox
            // 
            this.Dolt_CheckBox.AutoSize = true;
            this.Dolt_CheckBox.Location = new System.Drawing.Point(100, 180);
            this.Dolt_CheckBox.Name = "Dolt_CheckBox";
            this.Dolt_CheckBox.Size = new System.Drawing.Size(80, 17);
            this.Dolt_CheckBox.TabIndex = 2;
            this.Dolt_CheckBox.Text = "checkBox2";
            this.Dolt_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Alahuzott_CheckBox
            // 
            this.Alahuzott_CheckBox.AutoSize = true;
            this.Alahuzott_CheckBox.Location = new System.Drawing.Point(100, 216);
            this.Alahuzott_CheckBox.Name = "Alahuzott_CheckBox";
            this.Alahuzott_CheckBox.Size = new System.Drawing.Size(80, 17);
            this.Alahuzott_CheckBox.TabIndex = 3;
            this.Alahuzott_CheckBox.Text = "checkBox3";
            this.Alahuzott_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Vegrehajt_Gomb
            // 
            this.Vegrehajt_Gomb.Location = new System.Drawing.Point(100, 286);
            this.Vegrehajt_Gomb.Name = "Vegrehajt_Gomb";
            this.Vegrehajt_Gomb.Size = new System.Drawing.Size(80, 23);
            this.Vegrehajt_Gomb.TabIndex = 4;
            this.Vegrehajt_Gomb.Text = "button1";
            this.Vegrehajt_Gomb.UseVisualStyleBackColor = true;
            this.Vegrehajt_Gomb.Click += new System.EventHandler(this.Vegrehajt_Gomb_Click);
            // 
            // HetedikFeladat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.Vegrehajt_Gomb);
            this.Controls.Add(this.Alahuzott_CheckBox);
            this.Controls.Add(this.Dolt_CheckBox);
            this.Controls.Add(this.Felkover_CheckBox);
            this.Controls.Add(this.label1);
            this.Name = "HetedikFeladat";
            this.Text = "HetedikFeladat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HetedikFeladat_FormClosing);
            this.Load += new System.EventHandler(this.HetedikFeladat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Felkover_CheckBox;
        private System.Windows.Forms.CheckBox Dolt_CheckBox;
        private System.Windows.Forms.CheckBox Alahuzott_CheckBox;
        private System.Windows.Forms.Button Vegrehajt_Gomb;
    }
}
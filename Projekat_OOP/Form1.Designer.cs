
namespace Projekat_OOP
{
    partial class frmIgra
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
            this.pbxTabela = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTabela
            // 
            this.pbxTabela.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbxTabela.Location = new System.Drawing.Point(43, 40);
            this.pbxTabela.Name = "pbxTabela";
            this.pbxTabela.Size = new System.Drawing.Size(801, 497);
            this.pbxTabela.TabIndex = 0;
            this.pbxTabela.TabStop = false;
            this.pbxTabela.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbxTabela.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pbxTabela.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxTabela_MouseClick);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(386, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(85, 18);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = " Миноловац";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(389, 551);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(119, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Покрени игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.pbxTabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIgra";
            this.Text = "Миноловац";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxTabela;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnStart;
    }
}


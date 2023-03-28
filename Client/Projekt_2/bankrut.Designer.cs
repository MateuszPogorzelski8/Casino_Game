
namespace Projekt_2
{
    partial class bankrut
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.saldo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(143, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 134);
            this.button1.TabIndex = 0;
            this.button1.Text = "JESTEŚ BANKRUTEM";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(64, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Zarobiłes:";
            this.label2.Visible = false;
            // 
            // saldo
            // 
            this.saldo.Location = new System.Drawing.Point(288, 241);
            this.saldo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.saldo.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(120, 20);
            this.saldo.TabIndex = 16;
            this.saldo.Visible = false;
            // 
            // bankrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(532, 349);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "bankrut";
            this.Text = "bankrut";
            this.Load += new System.EventHandler(this.bankrut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown saldo;
    }
}
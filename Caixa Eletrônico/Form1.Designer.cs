namespace Caixa_Eletrônico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.btDep = new System.Windows.Forms.Button();
            this.btSac = new System.Windows.Forms.Button();
            this.numOperval = new System.Windows.Forms.NumericUpDown();
            this.numOperlim = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOperval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperlim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo =";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSal.Location = new System.Drawing.Point(493, 180);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(70, 33);
            this.lblSal.TabIndex = 2;
            this.lblSal.Text = "0,00";
            // 
            // btDep
            // 
            this.btDep.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDep.Location = new System.Drawing.Point(53, 188);
            this.btDep.Name = "btDep";
            this.btDep.Size = new System.Drawing.Size(104, 23);
            this.btDep.TabIndex = 3;
            this.btDep.Text = "DEPOSITAR";
            this.btDep.UseVisualStyleBackColor = true;
            // 
            // btSac
            // 
            this.btSac.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSac.Location = new System.Drawing.Point(201, 188);
            this.btSac.Name = "btSac";
            this.btSac.Size = new System.Drawing.Size(75, 23);
            this.btSac.TabIndex = 4;
            this.btSac.Text = "SACAR";
            this.btSac.UseVisualStyleBackColor = true;
            // 
            // numOperval
            // 
            this.numOperval.Location = new System.Drawing.Point(156, 126);
            this.numOperval.Name = "numOperval";
            this.numOperval.Size = new System.Drawing.Size(120, 20);
            this.numOperval.TabIndex = 5;
            // 
            // numOperlim
            // 
            this.numOperlim.Location = new System.Drawing.Point(156, 260);
            this.numOperlim.Name = "numOperlim";
            this.numOperlim.Size = new System.Drawing.Size(120, 20);
            this.numOperlim.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "LIMITE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "R$";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caixa_Eletrônico.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOperlim);
            this.Controls.Add(this.numOperval);
            this.Controls.Add(this.btSac);
            this.Controls.Add(this.btDep);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numOperval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperlim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Button btDep;
        private System.Windows.Forms.Button btSac;
        private System.Windows.Forms.NumericUpDown numOperval;
        private System.Windows.Forms.NumericUpDown numOperlim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


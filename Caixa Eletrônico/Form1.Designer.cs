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
            this.btDep = new System.Windows.Forms.Button();
            this.btSac = new System.Windows.Forms.Button();
            this.numOperval = new System.Windows.Forms.NumericUpDown();
            this.numOperlim = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numOperSaldo = new System.Windows.Forms.NumericUpDown();
            this.erro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOperval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperlim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperSaldo)).BeginInit();
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
            // btDep
            // 
            this.btDep.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDep.Location = new System.Drawing.Point(53, 188);
            this.btDep.Name = "btDep";
            this.btDep.Size = new System.Drawing.Size(104, 23);
            this.btDep.TabIndex = 3;
            this.btDep.Text = "DEPOSITAR";
            this.btDep.UseVisualStyleBackColor = true;
            this.btDep.Click += new System.EventHandler(this.btDep_Click);
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
            this.btSac.Click += new System.EventHandler(this.btSac_Click);
            // 
            // numOperval
            // 
            this.numOperval.Location = new System.Drawing.Point(156, 126);
            this.numOperval.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numOperval.Name = "numOperval";
            this.numOperval.Size = new System.Drawing.Size(120, 20);
            this.numOperval.TabIndex = 5;
            this.numOperval.ValueChanged += new System.EventHandler(this.numOperval_ValueChanged);
            // 
            // numOperlim
            // 
            this.numOperlim.Location = new System.Drawing.Point(156, 260);
            this.numOperlim.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.numOperlim.Name = "numOperlim";
            this.numOperlim.Size = new System.Drawing.Size(120, 20);
            this.numOperlim.TabIndex = 6;
            this.numOperlim.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOperlim.ValueChanged += new System.EventHandler(this.numOperlim_ValueChanged);
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
            // numOperSaldo
            // 
            this.numOperSaldo.Enabled = false;
            this.numOperSaldo.Location = new System.Drawing.Point(486, 192);
            this.numOperSaldo.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.numOperSaldo.Minimum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            -2147483648});
            this.numOperSaldo.Name = "numOperSaldo";
            this.numOperSaldo.Size = new System.Drawing.Size(120, 20);
            this.numOperSaldo.TabIndex = 8;
            this.numOperSaldo.ValueChanged += new System.EventHandler(this.numOperSaldo_ValueChanged);
            // 
            // erro
            // 
            this.erro.Location = new System.Drawing.Point(53, 318);
            this.erro.Name = "erro";
            this.erro.Size = new System.Drawing.Size(163, 20);
            this.erro.TabIndex = 9;
            this.erro.TextChanged += new System.EventHandler(this.erro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caixa_Eletrônico.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.erro);
            this.Controls.Add(this.numOperSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOperlim);
            this.Controls.Add(this.numOperval);
            this.Controls.Add(this.btSac);
            this.Controls.Add(this.btDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOperval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperlim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDep;
        private System.Windows.Forms.Button btSac;
        private System.Windows.Forms.NumericUpDown numOperval;
        private System.Windows.Forms.NumericUpDown numOperlim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numOperSaldo;
        private System.Windows.Forms.TextBox erro;
        private System.Windows.Forms.Label label3;
    }
}



namespace MáquinaDeComida
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtncompraH = new System.Windows.Forms.Button();
            this.BtnComparT = new System.Windows.Forms.Button();
            this.BtnCompraA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.lbltudo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblamer = new System.Windows.Forms.Label();
            this.lblhamb = new System.Windows.Forms.Label();
            this.lblbac = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btbcomparB = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RbtnPix = new System.Windows.Forms.RadioButton();
            this.RbtnCartao = new System.Windows.Forms.RadioButton();
            this.RbtnDinheiro = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtTroco = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "25,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "15,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "21,50";
            // 
            // BtncompraH
            // 
            this.BtncompraH.BackColor = System.Drawing.Color.Thistle;
            this.BtncompraH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtncompraH.Location = new System.Drawing.Point(6, 196);
            this.BtncompraH.Name = "BtncompraH";
            this.BtncompraH.Size = new System.Drawing.Size(75, 23);
            this.BtncompraH.TabIndex = 9;
            this.BtncompraH.Text = "Comprar";
            this.BtncompraH.UseVisualStyleBackColor = false;
            this.BtncompraH.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnComparT
            // 
            this.BtnComparT.BackColor = System.Drawing.Color.Thistle;
            this.BtnComparT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComparT.Location = new System.Drawing.Point(100, 196);
            this.BtnComparT.Name = "BtnComparT";
            this.BtnComparT.Size = new System.Drawing.Size(75, 23);
            this.BtnComparT.TabIndex = 10;
            this.BtnComparT.Text = "Comprar";
            this.BtnComparT.UseVisualStyleBackColor = false;
            this.BtnComparT.Click += new System.EventHandler(this.BtnComparT_Click);
            // 
            // BtnCompraA
            // 
            this.BtnCompraA.BackColor = System.Drawing.Color.Thistle;
            this.BtnCompraA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompraA.Location = new System.Drawing.Point(6, 76);
            this.BtnCompraA.Name = "BtnCompraA";
            this.BtnCompraA.Size = new System.Drawing.Size(75, 23);
            this.BtnCompraA.TabIndex = 11;
            this.BtnCompraA.Text = "Comprar";
            this.BtnCompraA.UseVisualStyleBackColor = false;
            this.BtnCompraA.Click += new System.EventHandler(this.BtnCompraA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btbcomparB);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblbac);
            this.groupBox1.Controls.Add(this.lblhamb);
            this.groupBox1.Controls.Add(this.lbltudo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblamer);
            this.groupBox1.Controls.Add(this.BtnComparT);
            this.groupBox1.Controls.Add(this.BtnCompraA);
            this.groupBox1.Controls.Add(this.BtncompraH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 335);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(8, 129);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(109, 20);
            this.TxtValor.TabIndex = 12;
            this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // lbltudo
            // 
            this.lbltudo.AutoSize = true;
            this.lbltudo.Location = new System.Drawing.Point(109, 141);
            this.lbltudo.Name = "lbltudo";
            this.lbltudo.Size = new System.Drawing.Size(38, 13);
            this.lbltudo.TabIndex = 13;
            this.lbltudo.Text = "X-tudo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // lblamer
            // 
            this.lblamer.AutoSize = true;
            this.lblamer.Location = new System.Drawing.Point(3, 21);
            this.lblamer.Name = "lblamer";
            this.lblamer.Size = new System.Drawing.Size(66, 13);
            this.lblamer.TabIndex = 15;
            this.lblamer.Text = "X-americano";
            // 
            // lblhamb
            // 
            this.lblhamb.AutoSize = true;
            this.lblhamb.Location = new System.Drawing.Point(6, 141);
            this.lblhamb.Name = "lblhamb";
            this.lblhamb.Size = new System.Drawing.Size(70, 13);
            this.lblhamb.TabIndex = 16;
            this.lblhamb.Text = "X-hamburgão";
            // 
            // lblbac
            // 
            this.lblbac.AutoSize = true;
            this.lblbac.Location = new System.Drawing.Point(97, 21);
            this.lblbac.Name = "lblbac";
            this.lblbac.Size = new System.Drawing.Size(47, 13);
            this.lblbac.TabIndex = 17;
            this.lblbac.Text = "X-bacon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 18;
            // 
            // btbcomparB
            // 
            this.btbcomparB.BackColor = System.Drawing.Color.Thistle;
            this.btbcomparB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbcomparB.Location = new System.Drawing.Point(100, 76);
            this.btbcomparB.Name = "btbcomparB";
            this.btbcomparB.Size = new System.Drawing.Size(75, 23);
            this.btbcomparB.TabIndex = 19;
            this.btbcomparB.Text = "Comprar";
            this.btbcomparB.UseVisualStyleBackColor = false;
            this.btbcomparB.Click += new System.EventHandler(this.btbcomparB_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "20,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Forma de pagamento";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.TxtTroco);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.RbtnDinheiro);
            this.groupBox2.Controls.Add(this.RbtnCartao);
            this.groupBox2.Controls.Add(this.RbtnPix);
            this.groupBox2.Controls.Add(this.TxtValor);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(218, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 214);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(122, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "MÁQUINA DE LANCHES";
            // 
            // RbtnPix
            // 
            this.RbtnPix.AutoSize = true;
            this.RbtnPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnPix.Location = new System.Drawing.Point(0, 34);
            this.RbtnPix.Name = "RbtnPix";
            this.RbtnPix.Size = new System.Drawing.Size(47, 20);
            this.RbtnPix.TabIndex = 16;
            this.RbtnPix.TabStop = true;
            this.RbtnPix.Text = "Pix";
            this.RbtnPix.UseVisualStyleBackColor = true;
            // 
            // RbtnCartao
            // 
            this.RbtnCartao.AutoSize = true;
            this.RbtnCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnCartao.Location = new System.Drawing.Point(0, 61);
            this.RbtnCartao.Name = "RbtnCartao";
            this.RbtnCartao.Size = new System.Drawing.Size(72, 20);
            this.RbtnCartao.TabIndex = 22;
            this.RbtnCartao.TabStop = true;
            this.RbtnCartao.Text = "Cartão";
            this.RbtnCartao.UseVisualStyleBackColor = true;
            // 
            // RbtnDinheiro
            // 
            this.RbtnDinheiro.AutoSize = true;
            this.RbtnDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnDinheiro.Location = new System.Drawing.Point(0, 87);
            this.RbtnDinheiro.Name = "RbtnDinheiro";
            this.RbtnDinheiro.Size = new System.Drawing.Size(84, 20);
            this.RbtnDinheiro.TabIndex = 24;
            this.RbtnDinheiro.TabStop = true;
            this.RbtnDinheiro.Text = "Dinheiro";
            this.RbtnDinheiro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Insira o valor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Troco";
            // 
            // TxtTroco
            // 
            this.TxtTroco.Location = new System.Drawing.Point(8, 177);
            this.TxtTroco.Name = "TxtTroco";
            this.TxtTroco.Size = new System.Drawing.Size(109, 20);
            this.TxtTroco.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtncompraH;
        private System.Windows.Forms.Button BtnComparT;
        private System.Windows.Forms.Button BtnCompraA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btbcomparB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblbac;
        private System.Windows.Forms.Label lblhamb;
        private System.Windows.Forms.Label lbltudo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblamer;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTroco;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RbtnDinheiro;
        private System.Windows.Forms.RadioButton RbtnCartao;
        private System.Windows.Forms.RadioButton RbtnPix;
        private System.Windows.Forms.Label label13;
    }
}


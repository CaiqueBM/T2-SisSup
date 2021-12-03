
namespace Elevador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.terreo = new System.Windows.Forms.Button();
            this.andar1 = new System.Windows.Forms.Button();
            this.andar2 = new System.Windows.Forms.Button();
            this.andar3 = new System.Windows.Forms.Button();
            this.andar4 = new System.Windows.Forms.Button();
            this.Subir = new System.Windows.Forms.Button();
            this.SD3 = new System.Windows.Forms.Button();
            this.SD1 = new System.Windows.Forms.Button();
            this.SD2 = new System.Windows.Forms.Button();
            this.Descer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descendo = new System.Windows.Forms.PictureBox();
            this.subindo = new System.Windows.Forms.PictureBox();
            this.br4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.descendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subindo)).BeginInit();
            this.SuspendLayout();
            // 
            // terreo
            // 
            this.terreo.Location = new System.Drawing.Point(84, 334);
            this.terreo.Name = "terreo";
            this.terreo.Size = new System.Drawing.Size(76, 60);
            this.terreo.TabIndex = 0;
            this.terreo.Text = "Terreo";
            this.terreo.UseVisualStyleBackColor = true;
            this.terreo.Click += new System.EventHandler(this.terreo_Click);
            // 
            // andar1
            // 
            this.andar1.Location = new System.Drawing.Point(32, 251);
            this.andar1.Name = "andar1";
            this.andar1.Size = new System.Drawing.Size(76, 60);
            this.andar1.TabIndex = 0;
            this.andar1.Text = "Andar 1";
            this.andar1.UseVisualStyleBackColor = true;
            this.andar1.Click += new System.EventHandler(this.andar1_Click);
            // 
            // andar2
            // 
            this.andar2.Location = new System.Drawing.Point(135, 251);
            this.andar2.Name = "andar2";
            this.andar2.Size = new System.Drawing.Size(76, 60);
            this.andar2.TabIndex = 0;
            this.andar2.Text = "Andar 2";
            this.andar2.UseVisualStyleBackColor = true;
            this.andar2.Click += new System.EventHandler(this.andar2_Click);
            // 
            // andar3
            // 
            this.andar3.Location = new System.Drawing.Point(32, 134);
            this.andar3.Name = "andar3";
            this.andar3.Size = new System.Drawing.Size(76, 60);
            this.andar3.TabIndex = 0;
            this.andar3.Text = "Andar 3";
            this.andar3.UseVisualStyleBackColor = true;
            this.andar3.Click += new System.EventHandler(this.andar3_Click);
            // 
            // andar4
            // 
            this.andar4.Image = ((System.Drawing.Image)(resources.GetObject("andar4.Image")));
            this.andar4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.andar4.Location = new System.Drawing.Point(135, 104);
            this.andar4.Name = "andar4";
            this.andar4.Size = new System.Drawing.Size(75, 90);
            this.andar4.TabIndex = 0;
            this.andar4.UseVisualStyleBackColor = true;
            this.andar4.Click += new System.EventHandler(this.andar4_Click);
            // 
            // Subir
            // 
            this.Subir.Location = new System.Drawing.Point(554, 345);
            this.Subir.Name = "Subir";
            this.Subir.Size = new System.Drawing.Size(76, 60);
            this.Subir.TabIndex = 0;
            this.Subir.Text = "Subir";
            this.Subir.UseVisualStyleBackColor = true;
            this.Subir.Click += new System.EventHandler(this.Subir_Click);
            // 
            // SD3
            // 
            this.SD3.Location = new System.Drawing.Point(675, 251);
            this.SD3.Name = "SD3";
            this.SD3.Size = new System.Drawing.Size(76, 60);
            this.SD3.TabIndex = 0;
            this.SD3.Text = "4Subir/Descer";
            this.SD3.UseVisualStyleBackColor = true;
            this.SD3.Click += new System.EventHandler(this.SD3_Click);
            // 
            // SD1
            // 
            this.SD1.Location = new System.Drawing.Point(675, 345);
            this.SD1.Name = "SD1";
            this.SD1.Size = new System.Drawing.Size(76, 60);
            this.SD1.TabIndex = 0;
            this.SD1.Text = "2Subir/Descer";
            this.SD1.UseVisualStyleBackColor = true;
            this.SD1.Click += new System.EventHandler(this.SD1_Click);
            // 
            // SD2
            // 
            this.SD2.Location = new System.Drawing.Point(554, 251);
            this.SD2.Name = "SD2";
            this.SD2.Size = new System.Drawing.Size(76, 60);
            this.SD2.TabIndex = 0;
            this.SD2.Text = "3Subir/Descer";
            this.SD2.UseVisualStyleBackColor = true;
            this.SD2.Click += new System.EventHandler(this.SD2_Click);
            // 
            // Descer
            // 
            this.Descer.Location = new System.Drawing.Point(618, 155);
            this.Descer.Name = "Descer";
            this.Descer.Size = new System.Drawing.Size(76, 60);
            this.Descer.TabIndex = 0;
            this.Descer.Text = "Descer";
            this.Descer.UseVisualStyleBackColor = true;
            this.Descer.Click += new System.EventHandler(this.Descer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Painel Interno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Painel Externo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(479, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Simulação";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "T";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Andar";
            // 
            // descendo
            // 
            this.descendo.Image = ((System.Drawing.Image)(resources.GetObject("descendo.Image")));
            this.descendo.Location = new System.Drawing.Point(336, 277);
            this.descendo.Name = "descendo";
            this.descendo.Size = new System.Drawing.Size(83, 117);
            this.descendo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.descendo.TabIndex = 8;
            this.descendo.TabStop = false;
            // 
            // subindo
            // 
            this.subindo.Image = ((System.Drawing.Image)(resources.GetObject("subindo.Image")));
            this.subindo.Location = new System.Drawing.Point(336, 277);
            this.subindo.Name = "subindo";
            this.subindo.Size = new System.Drawing.Size(83, 117);
            this.subindo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.subindo.TabIndex = 8;
            this.subindo.TabStop = false;
            // 
            // br4
            // 
            this.br4.Image = ((System.Drawing.Image)(resources.GetObject("br4.Image")));
            this.br4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.br4.Location = new System.Drawing.Point(136, 104);
            this.br4.Name = "br4";
            this.br4.Size = new System.Drawing.Size(75, 90);
            this.br4.TabIndex = 0;
            this.br4.UseVisualStyleBackColor = true;
            this.br4.Click += new System.EventHandler(this.andar4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subindo);
            this.Controls.Add(this.descendo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SD2);
            this.Controls.Add(this.SD1);
            this.Controls.Add(this.Descer);
            this.Controls.Add(this.SD3);
            this.Controls.Add(this.Subir);
            this.Controls.Add(this.br4);
            this.Controls.Add(this.andar4);
            this.Controls.Add(this.andar3);
            this.Controls.Add(this.andar2);
            this.Controls.Add(this.andar1);
            this.Controls.Add(this.terreo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.descendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subindo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button terreo;
        private System.Windows.Forms.Button andar1;
        private System.Windows.Forms.Button andar2;
        private System.Windows.Forms.Button andar3;
        private System.Windows.Forms.Button andar4;
        private System.Windows.Forms.Button Subir;
        private System.Windows.Forms.Button SD3;
        private System.Windows.Forms.Button SD1;
        private System.Windows.Forms.Button SD2;
        private System.Windows.Forms.Button Descer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox descendo;
        private System.Windows.Forms.PictureBox subindo;
        private System.Windows.Forms.Button br4;
    }
}


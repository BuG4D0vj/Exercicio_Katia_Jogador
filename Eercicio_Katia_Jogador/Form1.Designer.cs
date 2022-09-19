namespace Eercicio_Katia_Jogador
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
			this.btnGravar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtIdade = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPeso = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNumCamisa = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGravar
			// 
			this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGravar.Location = new System.Drawing.Point(548, 3);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(226, 67);
			this.btnGravar.TabIndex = 0;
			this.btnGravar.Text = "Gravar";
			this.btnGravar.UseVisualStyleBackColor = true;
			this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(57, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(168, 44);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(317, 22);
			this.txtNome.TabIndex = 3;
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPesquisar.Location = new System.Drawing.Point(548, 76);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(226, 67);
			this.btnPesquisar.TabIndex = 4;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// txtIdade
			// 
			this.txtIdade.Location = new System.Drawing.Point(168, 99);
			this.txtIdade.Name = "txtIdade";
			this.txtIdade.Size = new System.Drawing.Size(317, 22);
			this.txtIdade.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(57, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Idade";
			// 
			// txtAltura
			// 
			this.txtAltura.Location = new System.Drawing.Point(168, 149);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(317, 22);
			this.txtAltura.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(57, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Altura";
			// 
			// txtPeso
			// 
			this.txtPeso.Location = new System.Drawing.Point(168, 196);
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(317, 22);
			this.txtPeso.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(57, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Peso";
			// 
			// txtNumCamisa
			// 
			this.txtNumCamisa.Location = new System.Drawing.Point(168, 295);
			this.txtNumCamisa.Name = "txtNumCamisa";
			this.txtNumCamisa.Size = new System.Drawing.Size(317, 22);
			this.txtNumCamisa.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(57, 295);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Nº Camisa";
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(168, 250);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(317, 22);
			this.txtTime.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(57, 252);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 20);
			this.label6.TabIndex = 13;
			this.label6.Text = "Time";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtNumCamisa);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPeso);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdade);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGravar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGravar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.TextBox txtIdade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPeso;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNumCamisa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.Label label6;
	}
}


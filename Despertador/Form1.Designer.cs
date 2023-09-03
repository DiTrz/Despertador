namespace DespertadorApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.despertadorLabel = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.criarDespertadorButton = new System.Windows.Forms.Button();
            this.segundoDespTextBox = new System.Windows.Forms.TextBox();
            this.minutoDespTextBox = new System.Windows.Forms.TextBox();
            this.horaDespTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.horarioLabel = new System.Windows.Forms.Label();
            this.segundoTextBox = new System.Windows.Forms.TextBox();
            this.criarHorarioButton = new System.Windows.Forms.Button();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.minutoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.verificarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.despertadorLabel);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.criarDespertadorButton);
            this.groupBox1.Controls.Add(this.segundoDespTextBox);
            this.groupBox1.Controls.Add(this.minutoDespTextBox);
            this.groupBox1.Controls.Add(this.horaDespTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(30, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Despertador";
            // 
            // despertadorLabel
            // 
            this.despertadorLabel.AutoSize = true;
            this.despertadorLabel.Location = new System.Drawing.Point(97, 266);
            this.despertadorLabel.Name = "despertadorLabel";
            this.despertadorLabel.Size = new System.Drawing.Size(0, 13);
            this.despertadorLabel.TabIndex = 8;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(18, 219);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(182, 20);
            this.descricaoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição";
            // 
            // criarDespertadorButton
            // 
            this.criarDespertadorButton.Location = new System.Drawing.Point(77, 293);
            this.criarDespertadorButton.Name = "criarDespertadorButton";
            this.criarDespertadorButton.Size = new System.Drawing.Size(75, 23);
            this.criarDespertadorButton.TabIndex = 2;
            this.criarDespertadorButton.Text = "Criar";
            this.criarDespertadorButton.UseVisualStyleBackColor = true;
            this.criarDespertadorButton.Click += new System.EventHandler(this.criarDespertadorButton_Click);
            // 
            // segundoDespTextBox
            // 
            this.segundoDespTextBox.Location = new System.Drawing.Point(18, 162);
            this.segundoDespTextBox.Name = "segundoDespTextBox";
            this.segundoDespTextBox.Size = new System.Drawing.Size(91, 20);
            this.segundoDespTextBox.TabIndex = 5;
            // 
            // minutoDespTextBox
            // 
            this.minutoDespTextBox.Location = new System.Drawing.Point(18, 103);
            this.minutoDespTextBox.Name = "minutoDespTextBox";
            this.minutoDespTextBox.Size = new System.Drawing.Size(91, 20);
            this.minutoDespTextBox.TabIndex = 4;
            // 
            // horaDespTextBox
            // 
            this.horaDespTextBox.Location = new System.Drawing.Point(18, 41);
            this.horaDespTextBox.Name = "horaDespTextBox";
            this.horaDespTextBox.Size = new System.Drawing.Size(91, 20);
            this.horaDespTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minuto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Hora";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.horarioLabel);
            this.groupBox2.Controls.Add(this.segundoTextBox);
            this.groupBox2.Controls.Add(this.criarHorarioButton);
            this.groupBox2.Controls.Add(this.horaTextBox);
            this.groupBox2.Controls.Add(this.minutoTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(328, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hora";
            // 
            // horarioLabel
            // 
            this.horarioLabel.AutoSize = true;
            this.horarioLabel.Location = new System.Drawing.Point(122, 266);
            this.horarioLabel.Name = "horarioLabel";
            this.horarioLabel.Size = new System.Drawing.Size(0, 13);
            this.horarioLabel.TabIndex = 14;
            // 
            // segundoTextBox
            // 
            this.segundoTextBox.Location = new System.Drawing.Point(16, 162);
            this.segundoTextBox.Name = "segundoTextBox";
            this.segundoTextBox.Size = new System.Drawing.Size(91, 20);
            this.segundoTextBox.TabIndex = 13;
            // 
            // criarHorarioButton
            // 
            this.criarHorarioButton.Location = new System.Drawing.Point(105, 293);
            this.criarHorarioButton.Name = "criarHorarioButton";
            this.criarHorarioButton.Size = new System.Drawing.Size(75, 23);
            this.criarHorarioButton.TabIndex = 3;
            this.criarHorarioButton.Text = "Criar";
            this.criarHorarioButton.UseVisualStyleBackColor = true;
            this.criarHorarioButton.Click += new System.EventHandler(this.criarHorarioButton_Click);
            // 
            // horaTextBox
            // 
            this.horaTextBox.Location = new System.Drawing.Point(16, 41);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(91, 20);
            this.horaTextBox.TabIndex = 11;
            // 
            // minutoTextBox
            // 
            this.minutoTextBox.Location = new System.Drawing.Point(16, 103);
            this.minutoTextBox.Name = "minutoTextBox";
            this.minutoTextBox.Size = new System.Drawing.Size(91, 20);
            this.minutoTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Hora";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Minuto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Segundo";
            // 
            // verificarButton
            // 
            this.verificarButton.Location = new System.Drawing.Point(240, 406);
            this.verificarButton.Name = "verificarButton";
            this.verificarButton.Size = new System.Drawing.Size(117, 29);
            this.verificarButton.TabIndex = 4;
            this.verificarButton.Text = "Analisar";
            this.verificarButton.UseVisualStyleBackColor = true;
            this.verificarButton.Click += new System.EventHandler(this.verificarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 456);
            this.Controls.Add(this.verificarButton);
            this.Controls.Add(this.groupBox2);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox minutoDespTextBox;
        private System.Windows.Forms.TextBox horaDespTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox segundoDespTextBox;
        private System.Windows.Forms.TextBox segundoTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.TextBox minutoTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button criarDespertadorButton;
        private System.Windows.Forms.Button criarHorarioButton;
        private System.Windows.Forms.Button verificarButton;
        private System.Windows.Forms.Label horarioLabel;
        private System.Windows.Forms.Label despertadorLabel;
    }
}


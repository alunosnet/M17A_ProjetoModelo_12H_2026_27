namespace M17A_ProjetoModelo_12H_2026_27.Livros
{
    partial class f_livros
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_data_entrada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.ckb_disponivel = new System.Windows.Forms.CheckBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(136, 31);
            this.txt_isbn.MaxLength = 20;
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(176, 20);
            this.txt_isbn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Título";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(136, 71);
            this.txt_titulo.MaxLength = 30;
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(176, 20);
            this.txt_titulo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Autor";
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(136, 111);
            this.txt_autor.MaxLength = 40;
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(176, 20);
            this.txt_autor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Manual Escolar",
            "Romance",
            "BD",
            "Ação",
            "Outros"});
            this.cmb_tipo.Location = new System.Drawing.Point(136, 151);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(192, 21);
            this.cmb_tipo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data Entrada";
            // 
            // dtp_data_entrada
            // 
            this.dtp_data_entrada.Location = new System.Drawing.Point(136, 192);
            this.dtp_data_entrada.Name = "dtp_data_entrada";
            this.dtp_data_entrada.Size = new System.Drawing.Size(199, 20);
            this.dtp_data_entrada.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Estado";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(136, 236);
            this.txt_estado.MaxLength = 50;
            this.txt_estado.Multiline = true;
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(210, 51);
            this.txt_estado.TabIndex = 1;
            // 
            // ckb_disponivel
            // 
            this.ckb_disponivel.AutoSize = true;
            this.ckb_disponivel.Checked = true;
            this.ckb_disponivel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_disponivel.Location = new System.Drawing.Point(136, 293);
            this.ckb_disponivel.Name = "ckb_disponivel";
            this.ckb_disponivel.Size = new System.Drawing.Size(77, 17);
            this.ckb_disponivel.TabIndex = 4;
            this.ckb_disponivel.Text = "Disponível";
            this.ckb_disponivel.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(45, 313);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(300, 34);
            this.btn_adicionar.TabIndex = 5;
            this.btn_adicionar.Text = "Adicionar";
            this.toolTip1.SetToolTip(this.btn_adicionar, "Adiciona um livro novo à base de dados.");
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // f_livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 357);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.ckb_disponivel);
            this.Controls.Add(this.dtp_data_entrada);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "f_livros";
            this.Text = "Livros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_data_entrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.CheckBox ckb_disponivel;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
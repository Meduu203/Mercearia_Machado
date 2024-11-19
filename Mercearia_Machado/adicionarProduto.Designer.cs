namespace Mercearia_Machado
{
    partial class adicionarProduto
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodprod = new System.Windows.Forms.TextBox();
            this.txtNomeproduto = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardapioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbSetorprod = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.btnPesquisaCod = new System.Windows.Forms.Button();
            this.btnAtualizarProd = new System.Windows.Forms.Button();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição do Produto:";
            // 
            // txtCodprod
            // 
            this.txtCodprod.Enabled = false;
            this.txtCodprod.Location = new System.Drawing.Point(66, 91);
            this.txtCodprod.Name = "txtCodprod";
            this.txtCodprod.Size = new System.Drawing.Size(79, 20);
            this.txtCodprod.TabIndex = 6;
            // 
            // txtNomeproduto
            // 
            this.txtNomeproduto.Location = new System.Drawing.Point(215, 91);
            this.txtNomeproduto.Name = "txtNomeproduto";
            this.txtNomeproduto.Size = new System.Drawing.Size(471, 20);
            this.txtNomeproduto.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.cardapioToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosDoDiaToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // pedidosDoDiaToolStripMenuItem
            // 
            this.pedidosDoDiaToolStripMenuItem.Name = "pedidosDoDiaToolStripMenuItem";
            this.pedidosDoDiaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pedidosDoDiaToolStripMenuItem.Text = "Pedidos do dia";
            // 
            // cardapioToolStripMenuItem
            // 
            this.cardapioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosProdutosToolStripMenuItem,
            this.adicionarProdutoToolStripMenuItem,
            this.editarProdutoToolStripMenuItem});
            this.cardapioToolStripMenuItem.Name = "cardapioToolStripMenuItem";
            this.cardapioToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cardapioToolStripMenuItem.Text = "Cardapio";
            // 
            // todosProdutosToolStripMenuItem
            // 
            this.todosProdutosToolStripMenuItem.Name = "todosProdutosToolStripMenuItem";
            this.todosProdutosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.todosProdutosToolStripMenuItem.Text = "Todos Produtos";
            // 
            // adicionarProdutoToolStripMenuItem
            // 
            this.adicionarProdutoToolStripMenuItem.Name = "adicionarProdutoToolStripMenuItem";
            this.adicionarProdutoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.adicionarProdutoToolStripMenuItem.Text = "Adicionar Produto";
            this.adicionarProdutoToolStripMenuItem.Click += new System.EventHandler(this.adicionarProdutoToolStripMenuItem_Click);
            // 
            // editarProdutoToolStripMenuItem
            // 
            this.editarProdutoToolStripMenuItem.Name = "editarProdutoToolStripMenuItem";
            this.editarProdutoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editarProdutoToolStripMenuItem.Text = "Editar Produto";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sairToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(36, 157);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(142, 160);
            this.pictureBoxImagem.TabIndex = 9;
            this.pictureBoxImagem.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(236, 370);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(317, 370);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "PESQUISAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(493, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(215, 306);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 14;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(215, 181);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(471, 89);
            this.txtDescricao.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Imagem do produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Setor:";
            // 
            // cbbSetorprod
            // 
            this.cbbSetorprod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSetorprod.FormattingEnabled = true;
            this.cbbSetorprod.Items.AddRange(new object[] {
            "Porções",
            "Bebidas"});
            this.cbbSetorprod.Location = new System.Drawing.Point(262, 121);
            this.cbbSetorprod.Name = "cbbSetorprod";
            this.cbbSetorprod.Size = new System.Drawing.Size(104, 21);
            this.cbbSetorprod.TabIndex = 22;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(412, 370);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.Text = "NOVO +";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarImagem.Location = new System.Drawing.Point(36, 317);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(142, 23);
            this.btnCarregarImagem.TabIndex = 24;
            this.btnCarregarImagem.Text = "Adicionar Imagem";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnPesquisaCod
            // 
            this.btnPesquisaCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaCod.Location = new System.Drawing.Point(66, 112);
            this.btnPesquisaCod.Name = "btnPesquisaCod";
            this.btnPesquisaCod.Size = new System.Drawing.Size(79, 23);
            this.btnPesquisaCod.TabIndex = 25;
            this.btnPesquisaCod.Text = "Procurar";
            this.btnPesquisaCod.UseVisualStyleBackColor = true;
            this.btnPesquisaCod.Visible = false;
            this.btnPesquisaCod.Click += new System.EventHandler(this.btnPesquisaCod_Click);
            // 
            // btnAtualizarProd
            // 
            this.btnAtualizarProd.Enabled = false;
            this.btnAtualizarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarProd.Location = new System.Drawing.Point(147, 370);
            this.btnAtualizarProd.Name = "btnAtualizarProd";
            this.btnAtualizarProd.Size = new System.Drawing.Size(164, 23);
            this.btnAtualizarProd.TabIndex = 26;
            this.btnAtualizarProd.Text = "SALVAR ALTERAÇÕES";
            this.btnAtualizarProd.UseVisualStyleBackColor = true;
            this.btnAtualizarProd.Visible = false;
            this.btnAtualizarProd.Click += new System.EventHandler(this.btnAtualizarProd_Click);
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.Location = new System.Drawing.Point(221, 370);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(89, 23);
            this.btnEditarProd.TabIndex = 27;
            this.btnEditarProd.Text = "EDITAR";
            this.btnEditarProd.UseVisualStyleBackColor = true;
            this.btnEditarProd.Visible = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(215, 327);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 13);
            this.lblValor.TabIndex = 28;
            this.lblValor.Text = "ex: 5.50";
            this.lblValor.Visible = false;
            // 
            // adicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.btnAtualizarProd);
            this.Controls.Add(this.btnPesquisaCod);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.cbbSetorprod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.txtNomeproduto);
            this.Controls.Add(this.txtCodprod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adicionarProduto";
            this.Text = "adicionarProduto";
            this.Load += new System.EventHandler(this.adicionarProduto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodprod;
        private System.Windows.Forms.TextBox txtNomeproduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardapioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosProdutosToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbSetorprod;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnPesquisaCod;
        private System.Windows.Forms.Button btnAtualizarProd;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.Label lblValor;
    }
}

namespace SistemaHotel
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChekInOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóspedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServiçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaESaídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadroDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.pnlRigtht = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlRigtht.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuProdutos,
            this.MenuMovimentacoes,
            this.MenuReservas,
            this.MenuChekInOut,
            this.MenuRelatorios,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.hóspedesToolStripMenuItem,
            this.quartosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.MenuCadastros.Image = ((System.Drawing.Image)(resources.GetObject("MenuCadastros.Image")));
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(87, 20);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProdutoToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.MenuProdutos.Image = ((System.Drawing.Image)(resources.GetObject("MenuProdutos.Image")));
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(83, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuChekInOut
            // 
            this.MenuChekInOut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoServiçoToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.MenuChekInOut.Image = ((System.Drawing.Image)(resources.GetObject("MenuChekInOut.Image")));
            this.MenuChekInOut.Name = "MenuChekInOut";
            this.MenuChekInOut.Size = new System.Drawing.Size(106, 20);
            this.MenuChekInOut.Text = "Check In/Out";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.novoServiçoToolStripMenuItem1,
            this.entradaESaídasToolStripMenuItem});
            this.MenuMovimentacoes.Image = ((System.Drawing.Image)(resources.GetObject("MenuMovimentacoes.Image")));
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(120, 20);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // MenuReservas
            // 
            this.MenuReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaReservaToolStripMenuItem,
            this.quadroDeReservasToolStripMenuItem,
            this.consultarReservasToolStripMenuItem});
            this.MenuReservas.Image = ((System.Drawing.Image)(resources.GetObject("MenuReservas.Image")));
            this.MenuReservas.Name = "MenuReservas";
            this.MenuReservas.Size = new System.Drawing.Size(80, 20);
            this.MenuReservas.Text = "Reservas";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("MenuRelatorios.Image")));
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(87, 20);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // MenuSair
            // 
            this.MenuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logautToolStripMenuItem});
            this.MenuSair.Image = ((System.Drawing.Image)(resources.GetObject("MenuSair.Image")));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(54, 20);
            this.MenuSair.Text = "Sair";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // hóspedesToolStripMenuItem
            // 
            this.hóspedesToolStripMenuItem.Name = "hóspedesToolStripMenuItem";
            this.hóspedesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hóspedesToolStripMenuItem.Text = "Hóspedes";
            // 
            // quartosToolStripMenuItem
            // 
            this.quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            this.quartosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quartosToolStripMenuItem.Text = "Quartos";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoProdutoToolStripMenuItem.Text = "Novo Produto";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // novoServiçoToolStripMenuItem
            // 
            this.novoServiçoToolStripMenuItem.Name = "novoServiçoToolStripMenuItem";
            this.novoServiçoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoServiçoToolStripMenuItem.Text = "Check In";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaVendaToolStripMenuItem.Text = "Nova Venda";
            // 
            // novoServiçoToolStripMenuItem1
            // 
            this.novoServiçoToolStripMenuItem1.Name = "novoServiçoToolStripMenuItem1";
            this.novoServiçoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.novoServiçoToolStripMenuItem1.Text = "Novo Serviço";
            // 
            // entradaESaídasToolStripMenuItem
            // 
            this.entradaESaídasToolStripMenuItem.Name = "entradaESaídasToolStripMenuItem";
            this.entradaESaídasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entradaESaídasToolStripMenuItem.Text = "Entrada e Saídas";
            // 
            // novaReservaToolStripMenuItem
            // 
            this.novaReservaToolStripMenuItem.Name = "novaReservaToolStripMenuItem";
            this.novaReservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaReservaToolStripMenuItem.Text = "Nova Reserva";
            // 
            // quadroDeReservasToolStripMenuItem
            // 
            this.quadroDeReservasToolStripMenuItem.Name = "quadroDeReservasToolStripMenuItem";
            this.quadroDeReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quadroDeReservasToolStripMenuItem.Text = "Quadro de Reservas";
            // 
            // consultarReservasToolStripMenuItem
            // 
            this.consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            this.consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarReservasToolStripMenuItem.Text = "Consultar Reservas";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            // 
            // logautToolStripMenuItem
            // 
            this.logautToolStripMenuItem.Name = "logautToolStripMenuItem";
            this.logautToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logautToolStripMenuItem.Text = "Logout";
            this.logautToolStripMenuItem.Click += new System.EventHandler(this.logautToolStripMenuItem_Click);
            // 
            // pnlTopo
            // 
            this.pnlTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlTopo.Location = new System.Drawing.Point(0, 27);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(619, 75);
            this.pnlTopo.TabIndex = 1;
            // 
            // pnlRigtht
            // 
            this.pnlRigtht.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRigtht.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlRigtht.Controls.Add(this.label2);
            this.pnlRigtht.Controls.Add(this.label1);
            this.pnlRigtht.Location = new System.Drawing.Point(615, 27);
            this.pnlRigtht.Name = "pnlRigtht";
            this.pnlRigtht.Size = new System.Drawing.Size(193, 425);
            this.pnlRigtht.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora:";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRigtht);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Hotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.Resize += new System.EventHandler(this.FrmMenu_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRigtht.ResumeLayout(false);
            this.pnlRigtht.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuChekInOut;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuReservas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóspedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoServiçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradaESaídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadroDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logautToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel pnlRigtht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
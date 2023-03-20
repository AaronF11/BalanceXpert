namespace BalanceXpert
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.MtcMain = new MaterialSkin.Controls.MaterialTabControl();
            this.TpUs = new System.Windows.Forms.TabPage();
            this.PnlUsContainer = new System.Windows.Forms.Panel();
            this.MsUs = new System.Windows.Forms.MenuStrip();
            this.MTsmiInfo = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.MTsmiRoster = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.TpClients = new System.Windows.Forms.TabPage();
            this.PnlClientsContainer = new System.Windows.Forms.Panel();
            this.MsClients = new System.Windows.Forms.MenuStrip();
            this.MTsmiPf = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.MTsmiPm = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.TpServices = new System.Windows.Forms.TabPage();
            this.PnlServicesContainer = new System.Windows.Forms.Panel();
            this.MsServices = new System.Windows.Forms.MenuStrip();
            this.MTsmiAdd = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.MTsmiView = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.TpTransactions = new System.Windows.Forms.TabPage();
            this.PnlTransactionsContainer = new System.Windows.Forms.Panel();
            this.MsTransactions = new System.Windows.Forms.MenuStrip();
            this.MTsmiSale = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.MTsmiBuy = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.TpStatus = new System.Windows.Forms.TabPage();
            this.PnlStatusContainer = new System.Windows.Forms.Panel();
            this.MsStatus = new System.Windows.Forms.MenuStrip();
            this.MTsmiBalance = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.MTsmiStatus = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.MTsmiServices = new System.Windows.Forms.ToolStripMenuItem();
            this.MTsmiEquation = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.MtcMain.SuspendLayout();
            this.TpUs.SuspendLayout();
            this.MsUs.SuspendLayout();
            this.TpClients.SuspendLayout();
            this.MsClients.SuspendLayout();
            this.TpServices.SuspendLayout();
            this.MsServices.SuspendLayout();
            this.TpTransactions.SuspendLayout();
            this.MsTransactions.SuspendLayout();
            this.TpStatus.SuspendLayout();
            this.MsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "About.png");
            this.Images.Images.SetKeyName(1, "Balance.png");
            this.Images.Images.SetKeyName(2, "Buy.png");
            this.Images.Images.SetKeyName(3, "Clients.png");
            this.Images.Images.SetKeyName(4, "Company.png");
            this.Images.Images.SetKeyName(5, "Logo.ico");
            this.Images.Images.SetKeyName(6, "math.png");
            this.Images.Images.SetKeyName(7, "Person.png");
            this.Images.Images.SetKeyName(8, "Sale.png");
            this.Images.Images.SetKeyName(9, "Services.png");
            this.Images.Images.SetKeyName(10, "Status.png");
            this.Images.Images.SetKeyName(11, "Status_2.png");
            this.Images.Images.SetKeyName(12, "SVA.png");
            this.Images.Images.SetKeyName(13, "Transaction.png");
            this.Images.Images.SetKeyName(14, "Wallet.png");
            this.Images.Images.SetKeyName(15, "Company_2.png");
            this.Images.Images.SetKeyName(16, "Services_2.png");
            this.Images.Images.SetKeyName(17, "Status_2.1.png");
            this.Images.Images.SetKeyName(18, "Transaction_2.png");
            this.Images.Images.SetKeyName(19, "Clients_2.png");
            // 
            // MtcMain
            // 
            this.MtcMain.Controls.Add(this.TpUs);
            this.MtcMain.Controls.Add(this.TpClients);
            this.MtcMain.Controls.Add(this.TpServices);
            this.MtcMain.Controls.Add(this.TpTransactions);
            this.MtcMain.Controls.Add(this.TpStatus);
            this.MtcMain.Depth = 0;
            this.MtcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MtcMain.ImageList = this.Images;
            this.MtcMain.Location = new System.Drawing.Point(3, 64);
            this.MtcMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.MtcMain.Multiline = true;
            this.MtcMain.Name = "MtcMain";
            this.MtcMain.SelectedIndex = 0;
            this.MtcMain.Size = new System.Drawing.Size(994, 483);
            this.MtcMain.TabIndex = 0;
            // 
            // TpUs
            // 
            this.TpUs.BackColor = System.Drawing.Color.White;
            this.TpUs.Controls.Add(this.PnlUsContainer);
            this.TpUs.Controls.Add(this.MsUs);
            this.TpUs.ImageKey = "Company_2.png";
            this.TpUs.Location = new System.Drawing.Point(4, 39);
            this.TpUs.Name = "TpUs";
            this.TpUs.Padding = new System.Windows.Forms.Padding(3);
            this.TpUs.Size = new System.Drawing.Size(986, 440);
            this.TpUs.TabIndex = 0;
            this.TpUs.Text = "Nosotros";
            // 
            // PnlUsContainer
            // 
            this.PnlUsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlUsContainer.Location = new System.Drawing.Point(3, 3);
            this.PnlUsContainer.Name = "PnlUsContainer";
            this.PnlUsContainer.Size = new System.Drawing.Size(980, 398);
            this.PnlUsContainer.TabIndex = 1;
            // 
            // MsUs
            // 
            this.MsUs.BackColor = System.Drawing.Color.Transparent;
            this.MsUs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MsUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsUs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MsUs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MTsmiInfo,
            this.MTsmiRoster});
            this.MsUs.Location = new System.Drawing.Point(3, 401);
            this.MsUs.Name = "MsUs";
            this.MsUs.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MsUs.Size = new System.Drawing.Size(980, 36);
            this.MsUs.TabIndex = 0;
            this.MsUs.Text = "menuStrip1";
            // 
            // MTsmiInfo
            // 
            this.MTsmiInfo.AutoSize = false;
            this.MTsmiInfo.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiInfo.Image")));
            this.MTsmiInfo.Name = "MTsmiInfo";
            this.MTsmiInfo.Size = new System.Drawing.Size(128, 32);
            this.MTsmiInfo.Text = "Información";
            // 
            // MTsmiRoster
            // 
            this.MTsmiRoster.AutoSize = false;
            this.MTsmiRoster.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiRoster.Image")));
            this.MTsmiRoster.Name = "MTsmiRoster";
            this.MTsmiRoster.Size = new System.Drawing.Size(128, 32);
            this.MTsmiRoster.Text = "Nómina";
            // 
            // TpClients
            // 
            this.TpClients.Controls.Add(this.PnlClientsContainer);
            this.TpClients.Controls.Add(this.MsClients);
            this.TpClients.ImageKey = "Clients_2.png";
            this.TpClients.Location = new System.Drawing.Point(4, 39);
            this.TpClients.Name = "TpClients";
            this.TpClients.Padding = new System.Windows.Forms.Padding(3);
            this.TpClients.Size = new System.Drawing.Size(986, 440);
            this.TpClients.TabIndex = 1;
            this.TpClients.Text = "Clientes";
            this.TpClients.UseVisualStyleBackColor = true;
            // 
            // PnlClientsContainer
            // 
            this.PnlClientsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClientsContainer.Location = new System.Drawing.Point(3, 3);
            this.PnlClientsContainer.Name = "PnlClientsContainer";
            this.PnlClientsContainer.Size = new System.Drawing.Size(980, 398);
            this.PnlClientsContainer.TabIndex = 3;
            // 
            // MsClients
            // 
            this.MsClients.BackColor = System.Drawing.Color.Transparent;
            this.MsClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MsClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsClients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MsClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MTsmiPf,
            this.MTsmiPm});
            this.MsClients.Location = new System.Drawing.Point(3, 401);
            this.MsClients.Name = "MsClients";
            this.MsClients.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MsClients.Size = new System.Drawing.Size(980, 36);
            this.MsClients.TabIndex = 2;
            this.MsClients.Text = "menuStrip1";
            // 
            // MTsmiPf
            // 
            this.MTsmiPf.AutoSize = false;
            this.MTsmiPf.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiPf.Image")));
            this.MTsmiPf.Name = "MTsmiPf";
            this.MTsmiPf.Size = new System.Drawing.Size(128, 32);
            this.MTsmiPf.Text = "Persona Fisica";
            // 
            // MTsmiPm
            // 
            this.MTsmiPm.AutoSize = false;
            this.MTsmiPm.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiPm.Image")));
            this.MTsmiPm.Name = "MTsmiPm";
            this.MTsmiPm.Size = new System.Drawing.Size(128, 32);
            this.MTsmiPm.Text = "Persona Moral";
            // 
            // TpServices
            // 
            this.TpServices.Controls.Add(this.PnlServicesContainer);
            this.TpServices.Controls.Add(this.MsServices);
            this.TpServices.ImageKey = "Services_2.png";
            this.TpServices.Location = new System.Drawing.Point(4, 39);
            this.TpServices.Name = "TpServices";
            this.TpServices.Size = new System.Drawing.Size(986, 440);
            this.TpServices.TabIndex = 5;
            this.TpServices.Text = "Servicios";
            this.TpServices.UseVisualStyleBackColor = true;
            // 
            // PnlServicesContainer
            // 
            this.PnlServicesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlServicesContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlServicesContainer.Name = "PnlServicesContainer";
            this.PnlServicesContainer.Size = new System.Drawing.Size(986, 404);
            this.PnlServicesContainer.TabIndex = 3;
            // 
            // MsServices
            // 
            this.MsServices.BackColor = System.Drawing.Color.Transparent;
            this.MsServices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MsServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsServices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MTsmiAdd,
            this.MTsmiView});
            this.MsServices.Location = new System.Drawing.Point(0, 404);
            this.MsServices.Name = "MsServices";
            this.MsServices.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MsServices.Size = new System.Drawing.Size(986, 36);
            this.MsServices.TabIndex = 2;
            this.MsServices.Text = "menuStrip1";
            // 
            // MTsmiAdd
            // 
            this.MTsmiAdd.AutoSize = false;
            this.MTsmiAdd.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiAdd.Image")));
            this.MTsmiAdd.Name = "MTsmiAdd";
            this.MTsmiAdd.Size = new System.Drawing.Size(152, 32);
            this.MTsmiAdd.Text = "Agregar servicio";
            // 
            // MTsmiView
            // 
            this.MTsmiView.AutoSize = false;
            this.MTsmiView.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiView.Image")));
            this.MTsmiView.Name = "MTsmiView";
            this.MTsmiView.Size = new System.Drawing.Size(128, 32);
            this.MTsmiView.Text = "Ver servicios";
            // 
            // TpTransactions
            // 
            this.TpTransactions.Controls.Add(this.PnlTransactionsContainer);
            this.TpTransactions.Controls.Add(this.MsTransactions);
            this.TpTransactions.ImageKey = "Transaction_2.png";
            this.TpTransactions.Location = new System.Drawing.Point(4, 39);
            this.TpTransactions.Name = "TpTransactions";
            this.TpTransactions.Size = new System.Drawing.Size(986, 440);
            this.TpTransactions.TabIndex = 2;
            this.TpTransactions.Text = "Transacciones";
            this.TpTransactions.UseVisualStyleBackColor = true;
            // 
            // PnlTransactionsContainer
            // 
            this.PnlTransactionsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTransactionsContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlTransactionsContainer.Name = "PnlTransactionsContainer";
            this.PnlTransactionsContainer.Size = new System.Drawing.Size(986, 404);
            this.PnlTransactionsContainer.TabIndex = 3;
            // 
            // MsTransactions
            // 
            this.MsTransactions.BackColor = System.Drawing.Color.Transparent;
            this.MsTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MsTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsTransactions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MsTransactions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MTsmiSale,
            this.MTsmiBuy,
            this.MTsmiServices});
            this.MsTransactions.Location = new System.Drawing.Point(0, 404);
            this.MsTransactions.Name = "MsTransactions";
            this.MsTransactions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MsTransactions.Size = new System.Drawing.Size(986, 36);
            this.MsTransactions.TabIndex = 2;
            this.MsTransactions.Text = "menuStrip1";
            // 
            // MTsmiSale
            // 
            this.MTsmiSale.AutoSize = false;
            this.MTsmiSale.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiSale.Image")));
            this.MTsmiSale.Name = "MTsmiSale";
            this.MTsmiSale.Size = new System.Drawing.Size(128, 32);
            this.MTsmiSale.Text = "Ventas";
            // 
            // MTsmiBuy
            // 
            this.MTsmiBuy.AutoSize = false;
            this.MTsmiBuy.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiBuy.Image")));
            this.MTsmiBuy.Name = "MTsmiBuy";
            this.MTsmiBuy.Size = new System.Drawing.Size(128, 32);
            this.MTsmiBuy.Text = "Compras";
            // 
            // TpStatus
            // 
            this.TpStatus.Controls.Add(this.PnlStatusContainer);
            this.TpStatus.Controls.Add(this.MsStatus);
            this.TpStatus.ImageKey = "Status_2.1.png";
            this.TpStatus.Location = new System.Drawing.Point(4, 39);
            this.TpStatus.Name = "TpStatus";
            this.TpStatus.Size = new System.Drawing.Size(986, 440);
            this.TpStatus.TabIndex = 3;
            this.TpStatus.Text = "Estado Financiero";
            this.TpStatus.UseVisualStyleBackColor = true;
            // 
            // PnlStatusContainer
            // 
            this.PnlStatusContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlStatusContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlStatusContainer.Name = "PnlStatusContainer";
            this.PnlStatusContainer.Size = new System.Drawing.Size(986, 404);
            this.PnlStatusContainer.TabIndex = 3;
            // 
            // MsStatus
            // 
            this.MsStatus.BackColor = System.Drawing.Color.Transparent;
            this.MsStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MTsmiBalance,
            this.MTsmiStatus,
            this.MTsmiEquation});
            this.MsStatus.Location = new System.Drawing.Point(0, 404);
            this.MsStatus.Name = "MsStatus";
            this.MsStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MsStatus.Size = new System.Drawing.Size(986, 36);
            this.MsStatus.TabIndex = 2;
            this.MsStatus.Text = "menuStrip1";
            // 
            // MTsmiBalance
            // 
            this.MTsmiBalance.AutoSize = false;
            this.MTsmiBalance.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiBalance.Image")));
            this.MTsmiBalance.Name = "MTsmiBalance";
            this.MTsmiBalance.Size = new System.Drawing.Size(128, 32);
            this.MTsmiBalance.Text = "Balance";
            // 
            // MTsmiStatus
            // 
            this.MTsmiStatus.AutoSize = false;
            this.MTsmiStatus.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiStatus.Image")));
            this.MTsmiStatus.Name = "MTsmiStatus";
            this.MTsmiStatus.Size = new System.Drawing.Size(128, 32);
            this.MTsmiStatus.Text = "Estado";
            // 
            // MTsmiServices
            // 
            this.MTsmiServices.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiServices.Image")));
            this.MTsmiServices.Name = "MTsmiServices";
            this.MTsmiServices.Size = new System.Drawing.Size(103, 32);
            this.MTsmiServices.Text = "Servicios";
            // 
            // MTsmiEquation
            // 
            this.MTsmiEquation.AutoSize = false;
            this.MTsmiEquation.Image = ((System.Drawing.Image)(resources.GetObject("MTsmiEquation.Image")));
            this.MTsmiEquation.Name = "MTsmiEquation";
            this.MTsmiEquation.Size = new System.Drawing.Size(128, 32);
            this.MTsmiEquation.Text = "Ecuación";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.MtcMain);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.MtcMain;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MsUs;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BalanceXpert";
            this.MtcMain.ResumeLayout(false);
            this.TpUs.ResumeLayout(false);
            this.TpUs.PerformLayout();
            this.MsUs.ResumeLayout(false);
            this.MsUs.PerformLayout();
            this.TpClients.ResumeLayout(false);
            this.TpClients.PerformLayout();
            this.MsClients.ResumeLayout(false);
            this.MsClients.PerformLayout();
            this.TpServices.ResumeLayout(false);
            this.TpServices.PerformLayout();
            this.MsServices.ResumeLayout(false);
            this.MsServices.PerformLayout();
            this.TpTransactions.ResumeLayout(false);
            this.TpTransactions.PerformLayout();
            this.MsTransactions.ResumeLayout(false);
            this.MsTransactions.PerformLayout();
            this.TpStatus.ResumeLayout(false);
            this.TpStatus.PerformLayout();
            this.MsStatus.ResumeLayout(false);
            this.MsStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList Images;
        private MaterialSkin.Controls.MaterialTabControl MtcMain;
        private System.Windows.Forms.TabPage TpUs;
        private System.Windows.Forms.TabPage TpClients;
        private System.Windows.Forms.TabPage TpTransactions;
        private System.Windows.Forms.TabPage TpStatus;
        private System.Windows.Forms.TabPage TpServices;
        private System.Windows.Forms.MenuStrip MsUs;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiInfo;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiRoster;
        private System.Windows.Forms.Panel PnlUsContainer;
        private System.Windows.Forms.Panel PnlServicesContainer;
        private System.Windows.Forms.Panel PnlTransactionsContainer;
        private System.Windows.Forms.MenuStrip MsTransactions;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiSale;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiBuy;
        private System.Windows.Forms.Panel PnlClientsContainer;
        private System.Windows.Forms.MenuStrip MsClients;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiPf;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiPm;
        private System.Windows.Forms.Panel PnlStatusContainer;
        private System.Windows.Forms.MenuStrip MsStatus;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiBalance;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiStatus;
        private System.Windows.Forms.MenuStrip MsServices;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiAdd;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiView;
        private System.Windows.Forms.ToolStripMenuItem MTsmiServices;
        private MaterialSkin.Controls.MaterialToolStripMenuItem MTsmiEquation;
    }
}


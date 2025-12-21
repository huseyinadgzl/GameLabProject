namespace GameLabProject
{
    partial class MainScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.btnProfile = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuggest = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSteamID = new DevExpress.XtraEditors.TextEdit();
            this.btnListGame = new DevExpress.XtraEditors.SimpleButton();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSteamID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 426);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(800, 24);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLibrary,
            this.btnProfile,
            this.btnSuggest});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 158);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnLibrary
            // 
            this.btnLibrary.Caption = "Kütüphanem";
            this.btnLibrary.Id = 1;
            this.btnLibrary.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLibrary.ImageOptions.SvgImage")));
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLibrary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLibrary_ItemClick);
            // 
            // btnProfile
            // 
            this.btnProfile.Caption = "Profil";
            this.btnProfile.Id = 2;
            this.btnProfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.ImageOptions.Image")));
            this.btnProfile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.ImageOptions.LargeImage")));
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnProfile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProfile_ItemClick);
            // 
            // btnSuggest
            // 
            this.btnSuggest.Caption = "Ne Oynasam?";
            this.btnSuggest.Id = 3;
            this.btnSuggest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuggest.ImageOptions.Image")));
            this.btnSuggest.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuggest.ImageOptions.LargeImage")));
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSuggest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuggest_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kütüphane";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLibrary);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProfile);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSuggest);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Controls.Add(this.navigationPage3);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 158);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(800, 268);
            this.navigationFrame1.TabIndex = 2;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.gridControl1);
            this.navigationPage1.Controls.Add(this.panelControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(800, 268);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 60);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 208);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // navigationPage2
            // 
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(800, 268);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(800, 268);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnListGame);
            this.panelControl1.Controls.Add(this.txtSteamID);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 60);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SteamID:";
            // 
            // txtSteamID
            // 
            this.txtSteamID.Location = new System.Drawing.Point(81, 21);
            this.txtSteamID.MenuManager = this.ribbonControl1;
            this.txtSteamID.Name = "txtSteamID";
            this.txtSteamID.Size = new System.Drawing.Size(100, 20);
            this.txtSteamID.TabIndex = 1;
            // 
            // btnListGame
            // 
            this.btnListGame.Location = new System.Drawing.Point(201, 18);
            this.btnListGame.Name = "btnListGame";
            this.btnListGame.Size = new System.Drawing.Size(75, 23);
            this.btnListGame.TabIndex = 2;
            this.btnListGame.Text = "Oyunları Getir";
            this.btnListGame.Click += new System.EventHandler(this.btnListGame_Click);
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainScreenForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "MainScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSteamID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnLibrary;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnProfile;
        private DevExpress.XtraBars.BarButtonItem btnSuggest;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSteamID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnListGame;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}
﻿namespace MyPhotos
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.ctxMenuPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImageScale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImageStrech = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImageActual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNext = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPixelData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhotoProps = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlbumPros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttAlbumPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.flybyProvider = new Manning.MyPhotoControls.FlybyTextProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.ctxMenuPhoto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPhoto.ContextMenuStrip = this.ctxMenuPhoto;
            this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPhoto.Location = new System.Drawing.Point(0, 24);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(285, 236);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 1;
            this.pbxPhoto.TabStop = false;
            // 
            // ctxMenuPhoto
            // 
            this.ctxMenuPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImage,
            this.toolStripSeparator1,
            this.mnuNext,
            this.mnuPrevious,
            this.toolStripSeparator7,
            this.mnuPixelData,
            this.mnuPhotoProps,
            this.mnuAlbumPros});
            this.ctxMenuPhoto.Name = "ctxMenuPhoto";
            this.ctxMenuPhoto.OwnerItem = this.mnuView;
            this.ctxMenuPhoto.Size = new System.Drawing.Size(176, 148);
            this.ctxMenuPhoto.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenuPhoto_Opening);
            // 
            // mnuImage
            // 
            this.mnuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImageScale,
            this.mnuImageStrech,
            this.mnuImageActual});
            this.flybyProvider.SetFlybyText(this.mnuImage, null);
            this.mnuImage.Name = "mnuImage";
            this.mnuImage.Size = new System.Drawing.Size(175, 22);
            this.mnuImage.Text = "&Image";
            this.mnuImage.DropDownOpening += new System.EventHandler(this.mnuImage_DropDownOpening);
            this.mnuImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuImage_DropDownItemClicked);
            // 
            // mnuImageScale
            // 
            this.mnuImageScale.Checked = true;
            this.mnuImageScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flybyProvider.SetFlybyText(this.mnuImageScale, null);
            this.mnuImageScale.Name = "mnuImageScale";
            this.mnuImageScale.Size = new System.Drawing.Size(137, 22);
            this.mnuImageScale.Tag = "Zoom";
            this.mnuImageScale.Text = "&Scale to Fit";
            // 
            // mnuImageStrech
            // 
            this.flybyProvider.SetFlybyText(this.mnuImageStrech, null);
            this.mnuImageStrech.Name = "mnuImageStrech";
            this.mnuImageStrech.Size = new System.Drawing.Size(137, 22);
            this.mnuImageStrech.Tag = " StretchImage ";
            this.mnuImageStrech.Text = "S&trech to Fit";
            // 
            // mnuImageActual
            // 
            this.flybyProvider.SetFlybyText(this.mnuImageActual, null);
            this.mnuImageActual.Name = "mnuImageActual";
            this.mnuImageActual.Size = new System.Drawing.Size(137, 22);
            this.mnuImageActual.Tag = "Normal";
            this.mnuImageActual.Text = "&Actual Siza";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuNext
            // 
            this.flybyProvider.SetFlybyText(this.mnuNext, null);
            this.mnuNext.Name = "mnuNext";
            this.mnuNext.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mnuNext.Size = new System.Drawing.Size(175, 22);
            this.mnuNext.Text = "&Next";
            this.mnuNext.Click += new System.EventHandler(this.mnuNext_Click);
            // 
            // mnuPrevious
            // 
            this.flybyProvider.SetFlybyText(this.mnuPrevious, null);
            this.mnuPrevious.Name = "mnuPrevious";
            this.mnuPrevious.Size = new System.Drawing.Size(175, 22);
            this.mnuPrevious.Text = "&Previous";
            this.mnuPrevious.Click += new System.EventHandler(this.mnuPrevious_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(172, 6);
            // 
            // mnuPixelData
            // 
            this.flybyProvider.SetFlybyText(this.mnuPixelData, null);
            this.mnuPixelData.Name = "mnuPixelData";
            this.mnuPixelData.Size = new System.Drawing.Size(175, 22);
            this.mnuPixelData.Text = "Pi&xel Data...";
            this.mnuPixelData.Click += new System.EventHandler(this.mnuPixelData_Click);
            // 
            // mnuPhotoProps
            // 
            this.flybyProvider.SetFlybyText(this.mnuPhotoProps, null);
            this.mnuPhotoProps.Name = "mnuPhotoProps";
            this.mnuPhotoProps.Size = new System.Drawing.Size(175, 22);
            this.mnuPhotoProps.Text = "Phot&o Properties...";
            this.mnuPhotoProps.Click += new System.EventHandler(this.mnuPhotoProps_Click);
            // 
            // mnuAlbumPros
            // 
            this.flybyProvider.SetFlybyText(this.mnuAlbumPros, null);
            this.mnuAlbumPros.Name = "mnuAlbumPros";
            this.mnuAlbumPros.Size = new System.Drawing.Size(175, 22);
            this.mnuAlbumPros.Text = "Albu&m Properties...";
            this.mnuAlbumPros.Click += new System.EventHandler(this.mnuAlbumPros_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDown = this.ctxMenuPhoto;
            this.flybyProvider.SetFlybyText(this.mnuView, null);
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "&View";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(285, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.toolStripSeparator2,
            this.mnuFilePrint,
            this.mnuFilePrintPreview,
            this.toolStripSeparator3,
            this.mnuFileExit});
            this.flybyProvider.SetFlybyText(this.mnuFile, "The File menu ");
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.flybyProvider.SetFlybyText(this.mnuFileNew, null);
            this.mnuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileNew.Image")));
            this.mnuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(152, 22);
            this.mnuFileNew.Text = "&New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.flybyProvider.SetFlybyText(this.openToolStripMenuItem, null);
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileSave
            // 
            this.flybyProvider.SetFlybyText(this.mnuFileSave, "Save the current Album");
            this.mnuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileSave.Image")));
            this.mnuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSave.Text = "&Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.flybyProvider.SetFlybyText(this.mnuFileSaveAs, null);
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSaveAs.Text = "Save &As";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFilePrint
            // 
            this.flybyProvider.SetFlybyText(this.mnuFilePrint, null);
            this.mnuFilePrint.Image = ((System.Drawing.Image)(resources.GetObject("mnuFilePrint.Image")));
            this.mnuFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuFilePrint.Size = new System.Drawing.Size(152, 22);
            this.mnuFilePrint.Text = "&Print";
            // 
            // mnuFilePrintPreview
            // 
            this.flybyProvider.SetFlybyText(this.mnuFilePrintPreview, null);
            this.mnuFilePrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("mnuFilePrintPreview.Image")));
            this.mnuFilePrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFilePrintPreview.Name = "mnuFilePrintPreview";
            this.mnuFilePrintPreview.Size = new System.Drawing.Size(152, 22);
            this.mnuFilePrintPreview.Text = "Print Pre&view";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileExit
            // 
            this.flybyProvider.SetFlybyText(this.mnuFileExit, null);
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileLoad_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.mnuEditCut,
            this.mnuEditCopy,
            this.mnuEditPaste,
            this.toolStripSeparator5,
            this.mnuEditAdd,
            this.mnuEditRemove});
            this.flybyProvider.SetFlybyText(this.mnuEdit, null);
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuEditCut
            // 
            this.flybyProvider.SetFlybyText(this.mnuEditCut, null);
            this.mnuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditCut.Image")));
            this.mnuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEditCut.Name = "mnuEditCut";
            this.mnuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuEditCut.Size = new System.Drawing.Size(170, 22);
            this.mnuEditCut.Text = "Cu&t";
            // 
            // mnuEditCopy
            // 
            this.flybyProvider.SetFlybyText(this.mnuEditCopy, null);
            this.mnuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditCopy.Image")));
            this.mnuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEditCopy.Name = "mnuEditCopy";
            this.mnuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuEditCopy.Size = new System.Drawing.Size(170, 22);
            this.mnuEditCopy.Text = "&Copy";
            // 
            // mnuEditPaste
            // 
            this.flybyProvider.SetFlybyText(this.mnuEditPaste, null);
            this.mnuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditPaste.Image")));
            this.mnuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuEditPaste.Name = "mnuEditPaste";
            this.mnuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuEditPaste.Size = new System.Drawing.Size(170, 22);
            this.mnuEditPaste.Text = "&Paste";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuEditAdd
            // 
            this.flybyProvider.SetFlybyText(this.mnuEditAdd, null);
            this.mnuEditAdd.Name = "mnuEditAdd";
            this.mnuEditAdd.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.mnuEditAdd.Size = new System.Drawing.Size(170, 22);
            this.mnuEditAdd.Text = "A&dd";
            this.mnuEditAdd.Click += new System.EventHandler(this.mnuEditAdd_Click);
            // 
            // mnuEditRemove
            // 
            this.flybyProvider.SetFlybyText(this.mnuEditRemove, null);
            this.mnuEditRemove.Name = "mnuEditRemove";
            this.mnuEditRemove.Size = new System.Drawing.Size(170, 22);
            this.mnuEditRemove.Text = "Remo&ve";
            this.mnuEditRemove.Click += new System.EventHandler(this.mnuEditRemove_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.mnuHelpAbout});
            this.flybyProvider.SetFlybyText(this.mnuHelp, null);
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(113, 6);
            // 
            // mnuHelpAbout
            // 
            this.flybyProvider.SetFlybyText(this.mnuHelpAbout, null);
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuHelpAbout.Text = "&About...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttInfo,
            this.sttImageSize,
            this.sttAlbumPos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 236);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(285, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttInfo
            // 
            this.sttInfo.AutoSize = false;
            this.sttInfo.Name = "sttInfo";
            this.sttInfo.Size = new System.Drawing.Size(200, 19);
            this.sttInfo.Spring = true;
            this.sttInfo.Text = "Desc";
            this.sttInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sttImageSize
            // 
            this.sttImageSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sttImageSize.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sttImageSize.Name = "sttImageSize";
            this.sttImageSize.Size = new System.Drawing.Size(42, 19);
            this.sttImageSize.Text = "W x H";
            // 
            // sttAlbumPos
            // 
            this.sttAlbumPos.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sttAlbumPos.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.sttAlbumPos.Name = "sttAlbumPos";
            this.sttAlbumPos.Size = new System.Drawing.Size(28, 19);
            this.sttAlbumPos.Text = "1/1";
            // 
            // flybyProvider
            // 
            this.flybyProvider.StatusLabel = this.sttInfo;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 260);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MyPhotos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ctxMenuPhoto.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip ctxMenuPhoto;
        private System.Windows.Forms.ToolStripMenuItem mnuImage;
        private System.Windows.Forms.ToolStripMenuItem mnuImageScale;
        private System.Windows.Forms.ToolStripMenuItem mnuImageStrech;
        private System.Windows.Forms.ToolStripMenuItem mnuImageActual;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttInfo;
        private System.Windows.Forms.ToolStripStatusLabel sttImageSize;
        private System.Windows.Forms.ToolStripStatusLabel sttAlbumPos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuNext;
        private System.Windows.Forms.ToolStripMenuItem mnuPrevious;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnuPixelData;
        private System.Windows.Forms.ToolStripMenuItem mnuPhotoProps;
        private System.Windows.Forms.ToolStripMenuItem mnuAlbumPros;
        private Manning.MyPhotoControls.FlybyTextProvider flybyProvider;
    }
}


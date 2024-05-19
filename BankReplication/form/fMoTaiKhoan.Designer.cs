﻿using BankReplication.utils;
namespace BankReplication.form

{
    partial class formMoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMoTaiKhoan));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolBar = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.toolBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnCheDoDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheDoChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.sidePanel = new DevExpress.Utils.Layout.TablePanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ngayMoTKTxt = new DevExpress.XtraEditors.DateEdit();
            this.taiKhoanBds = new BankReplication.utils.BindingSourceExtends(this.components);
            this.khachHangBds = new System.Windows.Forms.BindingSource(this.components);
            this.moTKDS = new BankReplication.MoTKDS();
            this.soTKTxt = new DevExpress.XtraEditors.TextEdit();
            this.maCNTxt = new DevExpress.XtraEditors.TextEdit();
            this.soDuTxt = new DevExpress.XtraEditors.TextEdit();
            this.CMNDTxt = new DevExpress.XtraEditors.TextEdit();
            this.fBtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.fBtnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gvTaiKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khachHangTableAdapter = new BankReplication.MoTKDSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new BankReplication.MoTKDSTableAdapters.TableAdapterManager();
            this.taiKhoanTableAdapter = new BankReplication.MoTKDSTableAdapters.TaiKhoanTableAdapter();
            this.gDChuyenTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gDChuyenTienTableAdapter = new BankReplication.MoTKDSTableAdapters.GDChuyenTienTableAdapter();
            this.gDChuyenTienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gDGuiRutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gDGuiRutTableAdapter = new BankReplication.MoTKDSTableAdapters.GDGuiRutTableAdapter();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMoTKTxt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMoTKTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moTKDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTKTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCNTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDuTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMNDTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDChuyenTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDChuyenTienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDGuiRutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BarName = "Main menu";
            this.toolBar.DockCol = 0;
            this.toolBar.DockRow = 0;
            this.toolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.toolBar.FloatLocation = new System.Drawing.Point(40, 296);
            this.toolBar.OptionsBar.MultiLine = true;
            this.toolBar.OptionsBar.UseWholeRow = true;
            this.toolBar.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 34);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(1918, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 1013);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1918, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 34);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 979);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1918, 34);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 979);
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.FloatLocation = new System.Drawing.Point(100, 269);
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 13;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Enabled = false;
            this.btnLuu.Id = 2;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 0);
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 11;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá tài khoản";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 0);
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm tài khoản";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 0);
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // toolBarManager
            // 
            this.toolBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.toolBarManager.DockControls.Add(this.barDockControlTop);
            this.toolBarManager.DockControls.Add(this.barDockControlBottom);
            this.toolBarManager.DockControls.Add(this.barDockControlLeft);
            this.toolBarManager.DockControls.Add(this.barDockControlRight);
            this.toolBarManager.Form = this;
            this.toolBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnLuu,
            this.btnUndo,
            this.btnReload,
            this.btnCHUYENCHINHANH,
            this.btnExit,
            this.btnThemChiTietDonDatHang,
            this.btnMENU,
            this.btnCheDoDonDatHang,
            this.btnCheDoChiTietDonDatHang,
            this.btnSua,
            this.btnRedo,
            this.btnHuy});
            this.toolBarManager.MainMenu = this.bar2;
            this.toolBarManager.MaxItemId = 15;
            this.toolBarManager.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(69, 227);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRedo),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Làm Mới";
            this.btnReload.Enabled = false;
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Id = 12;
            this.btnRedo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRedo.ImageOptions.SvgImage")));
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedo_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 7;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.toolBarManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(1918, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1013);
            this.barDockControlBottom.Manager = this.toolBarManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1918, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.toolBarManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 979);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1918, 34);
            this.barDockControlRight.Manager = this.toolBarManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 979);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 5;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // btnThemChiTietDonDatHang
            // 
            this.btnThemChiTietDonDatHang.Caption = "Thêm Chi Tiết Đơn Đặt Hàng";
            this.btnThemChiTietDonDatHang.Id = 7;
            this.btnThemChiTietDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemChiTietDonDatHang.ImageOptions.SvgImage")));
            this.btnThemChiTietDonDatHang.Name = "btnThemChiTietDonDatHang";
            // 
            // btnMENU
            // 
            this.btnMENU.Caption = "Chọn Chế Độ";
            this.btnMENU.Id = 8;
            this.btnMENU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMENU.ImageOptions.SvgImage")));
            this.btnMENU.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoDonDatHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheDoChiTietDonDatHang)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnCheDoDonDatHang
            // 
            this.btnCheDoDonDatHang.Caption = "Đơn Đặt Hàng";
            this.btnCheDoDonDatHang.Id = 9;
            this.btnCheDoDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCheDoDonDatHang.ImageOptions.SvgImage")));
            this.btnCheDoDonDatHang.Name = "btnCheDoDonDatHang";
            // 
            // btnCheDoChiTietDonDatHang
            // 
            this.btnCheDoChiTietDonDatHang.Caption = "Chi Tiết Đơn Đặt Hàng";
            this.btnCheDoChiTietDonDatHang.Id = 10;
            this.btnCheDoChiTietDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCheDoChiTietDonDatHang.ImageOptions.SvgImage")));
            this.btnCheDoChiTietDonDatHang.Name = "btnCheDoChiTietDonDatHang";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Làm Mới";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.8F)});
            this.tablePanel1.Controls.Add(this.groupControl2);
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 34);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 16.66669F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1918, 979);
            this.tablePanel1.TabIndex = 12;
            // 
            // groupControl2
            // 
            this.tablePanel1.SetColumn(this.groupControl2, 1);
            this.groupControl2.Controls.Add(this.sidePanel);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(904, 20);
            this.groupControl2.Name = "groupControl2";
            this.tablePanel1.SetRow(this.groupControl2, 1);
            this.groupControl2.Size = new System.Drawing.Size(1011, 956);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Tài khoản theo khách hàng";
            // 
            // sidePanel
            // 
            this.sidePanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.sidePanel.Controls.Add(this.dataLayoutControl1);
            this.sidePanel.Controls.Add(this.gcTaiKhoan);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel.Location = new System.Drawing.Point(2, 34);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 418F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.sidePanel.Size = new System.Drawing.Size(1007, 920);
            this.sidePanel.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.sidePanel.SetColumn(this.dataLayoutControl1, 0);
            this.dataLayoutControl1.Controls.Add(this.ngayMoTKTxt);
            this.dataLayoutControl1.Controls.Add(this.soTKTxt);
            this.dataLayoutControl1.Controls.Add(this.maCNTxt);
            this.dataLayoutControl1.Controls.Add(this.soDuTxt);
            this.dataLayoutControl1.Controls.Add(this.CMNDTxt);
            this.dataLayoutControl1.Controls.Add(this.fBtnLuu);
            this.dataLayoutControl1.Controls.Add(this.fBtnHuy);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 421);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(630, 0, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.sidePanel.SetRow(this.dataLayoutControl1, 1);
            this.dataLayoutControl1.Size = new System.Drawing.Size(1001, 496);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ngayMoTKTxt
            // 
            this.ngayMoTKTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBds, "NGAYMOTK", true));
            this.ngayMoTKTxt.EditValue = null;
            this.ngayMoTKTxt.Location = new System.Drawing.Point(115, 140);
            this.ngayMoTKTxt.MenuManager = this.barManager1;
            this.ngayMoTKTxt.Name = "ngayMoTKTxt";
            this.ngayMoTKTxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayMoTKTxt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayMoTKTxt.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.ngayMoTKTxt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ngayMoTKTxt.Size = new System.Drawing.Size(874, 28);
            this.ngayMoTKTxt.StyleController = this.dataLayoutControl1;
            this.ngayMoTKTxt.TabIndex = 5;
            // 
            // taiKhoanBds
            // 
            this.taiKhoanBds.DataMember = "FK_TaiKhoan_KhachHang";
            this.taiKhoanBds.DataSource = this.khachHangBds;
            // 
            // khachHangBds
            // 
            this.khachHangBds.DataMember = "KhachHang";
            this.khachHangBds.DataSource = this.moTKDS;
            // 
            // moTKDS
            // 
            this.moTKDS.DataSetName = "MoTKDS";
            this.moTKDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soTKTxt
            // 
            this.soTKTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBds, "SOTK", true));
            this.soTKTxt.Location = new System.Drawing.Point(115, 12);
            this.soTKTxt.MenuManager = this.barManager1;
            this.soTKTxt.Name = "soTKTxt";
            this.soTKTxt.Properties.MaxLength = 9;
            this.soTKTxt.Size = new System.Drawing.Size(874, 28);
            this.soTKTxt.StyleController = this.dataLayoutControl1;
            this.soTKTxt.TabIndex = 1;
            this.soTKTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // maCNTxt
            // 
            this.maCNTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBds, "MACN", true));
            this.maCNTxt.Enabled = false;
            this.maCNTxt.Location = new System.Drawing.Point(115, 108);
            this.maCNTxt.MenuManager = this.barManager1;
            this.maCNTxt.Name = "maCNTxt";
            this.maCNTxt.Size = new System.Drawing.Size(874, 28);
            this.maCNTxt.StyleController = this.dataLayoutControl1;
            this.maCNTxt.TabIndex = 4;
            // 
            // soDuTxt
            // 
            this.soDuTxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBds, "SODU", true));
            this.soDuTxt.Location = new System.Drawing.Point(115, 76);
            this.soDuTxt.MenuManager = this.barManager1;
            this.soDuTxt.Name = "soDuTxt";
            this.soDuTxt.Properties.DisplayFormat.FormatString = "n0";
            this.soDuTxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.soDuTxt.Properties.EditFormat.FormatString = "n0";
            this.soDuTxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.soDuTxt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.soDuTxt.Size = new System.Drawing.Size(874, 28);
            this.soDuTxt.StyleController = this.dataLayoutControl1;
            this.soDuTxt.TabIndex = 3;
            this.soDuTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // CMNDTxt
            // 
            this.CMNDTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taiKhoanBds, "CMND", true));
            this.CMNDTxt.Enabled = false;
            this.CMNDTxt.Location = new System.Drawing.Point(115, 44);
            this.CMNDTxt.MenuManager = this.barManager1;
            this.CMNDTxt.Name = "CMNDTxt";
            this.CMNDTxt.Size = new System.Drawing.Size(874, 28);
            this.CMNDTxt.StyleController = this.dataLayoutControl1;
            this.CMNDTxt.TabIndex = 2;
            this.CMNDTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputFields_KeyDown);
            // 
            // fBtnLuu
            // 
            this.fBtnLuu.Location = new System.Drawing.Point(12, 172);
            this.fBtnLuu.Name = "fBtnLuu";
            this.fBtnLuu.Size = new System.Drawing.Size(486, 32);
            this.fBtnLuu.StyleController = this.dataLayoutControl1;
            this.fBtnLuu.TabIndex = 6;
            this.fBtnLuu.Text = "Lưu";
            this.fBtnLuu.Click += new System.EventHandler(this.fBtnLuu_Click);
            // 
            // fBtnHuy
            // 
            this.fBtnHuy.Location = new System.Drawing.Point(502, 172);
            this.fBtnHuy.Name = "fBtnHuy";
            this.fBtnHuy.Size = new System.Drawing.Size(487, 32);
            this.fBtnHuy.StyleController = this.dataLayoutControl1;
            this.fBtnHuy.TabIndex = 7;
            this.fBtnHuy.Text = "Hủy";
            this.fBtnHuy.Click += new System.EventHandler(this.fBtnHuy_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1001, 496);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CMNDTxt;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(981, 32);
            this.layoutControlItem3.Text = "CMND:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(100, 19);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.soDuTxt;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(981, 32);
            this.layoutControlItem4.Text = "Số dư:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(100, 19);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.maCNTxt;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(981, 32);
            this.layoutControlItem5.Text = "Mã chi nhánh:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(100, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.soTKTxt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(981, 32);
            this.layoutControlItem2.Text = "Số tài khoản:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(100, 19);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ngayMoTKTxt;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(981, 32);
            this.layoutControlItem7.Text = "Ngày mở:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(100, 19);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.fBtnHuy;
            this.layoutControlItem8.Location = new System.Drawing.Point(490, 160);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(491, 316);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.fBtnLuu;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(490, 316);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // gcTaiKhoan
            // 
            this.sidePanel.SetColumn(this.gcTaiKhoan, 0);
            this.gcTaiKhoan.DataSource = this.taiKhoanBds;
            this.gcTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "FK_TaiKhoan_GD_GuiRut";
            gridLevelNode2.RelationName = "TaiKhoan_GDChuyenTien";
            gridLevelNode3.RelationName = "TaiKhoan_GDNhanTien";
            this.gcTaiKhoan.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.gcTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.gcTaiKhoan.MainView = this.gvTaiKhoan;
            this.gcTaiKhoan.MenuManager = this.barManager1;
            this.gcTaiKhoan.Name = "gcTaiKhoan";
            this.sidePanel.SetRow(this.gcTaiKhoan, 0);
            this.gcTaiKhoan.Size = new System.Drawing.Size(1001, 412);
            this.gcTaiKhoan.TabIndex = 0;
            this.gcTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTaiKhoan});
            // 
            // gvTaiKhoan
            // 
            this.gvTaiKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.gridColumn1,
            this.colSODU,
            this.gridColumn2,
            this.colNGAYMOTK});
            this.gvTaiKhoan.DetailHeight = 349;
            this.gvTaiKhoan.FixedLineWidth = 1;
            this.gvTaiKhoan.GridControl = this.gcTaiKhoan;
            this.gvTaiKhoan.Name = "gvTaiKhoan";
            this.gvTaiKhoan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTaiKhoan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTaiKhoan.OptionsBehavior.Editable = false;
            this.gvTaiKhoan.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvTaiKhoan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNGAYMOTK, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvTaiKhoan.DoubleClick += new System.EventHandler(this.gvTaiKhoan_DoubleClick);
            this.gvTaiKhoan.LostFocus += new System.EventHandler(this.gvTaiKhoan_LostFocus);
            this.gvTaiKhoan.GotFocus += new System.EventHandler(this.gvTaiKhoan_GotFocus);
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 30;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 112;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CMND";
            this.gridColumn1.FieldName = "CMND";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 112;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số dư";
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 30;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã chi nhánh";
            this.gridColumn2.FieldName = "MACN";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 112;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày mở";
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 30;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 112;
            // 
            // groupControl1
            // 
            this.tablePanel1.SetColumn(this.groupControl1, 0);
            this.groupControl1.Controls.Add(this.gcKhachHang);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 20);
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 1);
            this.groupControl1.Size = new System.Drawing.Size(895, 956);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Khách hàng";
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.DataSource = this.khachHangBds;
            this.gcKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhachHang.Location = new System.Drawing.Point(2, 34);
            this.gcKhachHang.MainView = this.gvKhachHang;
            this.gcKhachHang.MenuManager = this.barManager1;
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Size = new System.Drawing.Size(891, 920);
            this.gcKhachHang.TabIndex = 0;
            this.gcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhachHang});
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gvKhachHang.DetailHeight = 349;
            this.gvKhachHang.FixedLineWidth = 1;
            this.gvKhachHang.GridControl = this.gcKhachHang;
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvKhachHang.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvKhachHang.OptionsBehavior.Editable = false;
            this.gvKhachHang.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvKhachHang_FocusedRowChanged);
            this.gvKhachHang.DoubleClick += new System.EventHandler(this.gvKhachHang_DoubleClick);
            // 
            // colCMND
            // 
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 30;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 112;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Width = 112;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Width = 112;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày cấp";
            this.colNGAYCAP.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 30;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 3;
            this.colNGAYCAP.Width = 112;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 30;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 4;
            this.colSODT.Width = 112;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 30;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 5;
            this.colMACN.Width = 112;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = BankReplication.MoTKDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // gDChuyenTienBindingSource
            // 
            this.gDChuyenTienBindingSource.DataMember = "TaiKhoan_GDChuyenTien";
            this.gDChuyenTienBindingSource.DataSource = this.taiKhoanBds;
            // 
            // gDChuyenTienTableAdapter
            // 
            this.gDChuyenTienTableAdapter.ClearBeforeFill = true;
            // 
            // gDChuyenTienBindingSource1
            // 
            this.gDChuyenTienBindingSource1.DataMember = "TaiKhoan_GDNhanTien";
            this.gDChuyenTienBindingSource1.DataSource = this.taiKhoanBds;
            // 
            // gDGuiRutBindingSource
            // 
            this.gDGuiRutBindingSource.DataMember = "FK_TaiKhoan_GD_GuiRut";
            this.gDGuiRutBindingSource.DataSource = this.taiKhoanBds;
            // 
            // gDGuiRutTableAdapter
            // 
            this.gDGuiRutTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 562);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(994, 25);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // formMoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1033);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formMoTaiKhoan";
            this.Text = "Mở tài khoản ngân hàng";
            this.Load += new System.EventHandler(this.formMoTaiKhoan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formMoTaiKhoan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ngayMoTKTxt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayMoTKTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moTKDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soTKTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCNTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDuTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMNDTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDChuyenTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDChuyenTienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDGuiRutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar toolBar;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager toolBarManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnThemChiTietDonDatHang;
        public DevExpress.XtraBars.BarSubItem btnMENU;
        private DevExpress.XtraBars.BarButtonItem btnCheDoDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnCheDoChiTietDonDatHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource khachHangBds;
        private MoTKDS moTKDS;
        private MoTKDSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private MoTKDSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachHang;
        private MoTKDSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private BindingSourceExtends taiKhoanBds;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.Utils.Layout.TablePanel sidePanel;
        private DevExpress.XtraGrid.GridControl gcTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTaiKhoan;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit maCNTxt;
        private DevExpress.XtraEditors.TextEdit soDuTxt;
        private DevExpress.XtraEditors.TextEdit CMNDTxt;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit soTKTxt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource gDChuyenTienBindingSource;
        private MoTKDSTableAdapters.GDChuyenTienTableAdapter gDChuyenTienTableAdapter;
        private System.Windows.Forms.BindingSource gDChuyenTienBindingSource1;
        private System.Windows.Forms.BindingSource gDGuiRutBindingSource;
        private MoTKDSTableAdapters.GDGuiRutTableAdapter gDGuiRutTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraEditors.DateEdit ngayMoTKTxt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton fBtnLuu;
        private DevExpress.XtraEditors.SimpleButton fBtnHuy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
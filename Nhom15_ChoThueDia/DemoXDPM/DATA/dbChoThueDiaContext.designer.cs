﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbChoThueDia")]
	public partial class dbChoThueDiaContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttbDiaCD(tbDiaCD instance);
    partial void UpdatetbDiaCD(tbDiaCD instance);
    partial void DeletetbDiaCD(tbDiaCD instance);
    partial void InserttbKhachHang(tbKhachHang instance);
    partial void UpdatetbKhachHang(tbKhachHang instance);
    partial void DeletetbKhachHang(tbKhachHang instance);
    partial void InserttbLapPhieuThue(tbLapPhieuThue instance);
    partial void UpdatetbLapPhieuThue(tbLapPhieuThue instance);
    partial void DeletetbLapPhieuThue(tbLapPhieuThue instance);
    partial void InserttbLoaiDia(tbLoaiDia instance);
    partial void UpdatetbLoaiDia(tbLoaiDia instance);
    partial void DeletetbLoaiDia(tbLoaiDia instance);
    partial void InserttbThongTinDatTruoc(tbThongTinDatTruoc instance);
    partial void UpdatetbThongTinDatTruoc(tbThongTinDatTruoc instance);
    partial void DeletetbThongTinDatTruoc(tbThongTinDatTruoc instance);
    partial void InserttbTieuDe(tbTieuDe instance);
    partial void UpdatetbTieuDe(tbTieuDe instance);
    partial void DeletetbTieuDe(tbTieuDe instance);
    #endregion
		
		public dbChoThueDiaContextDataContext() : 
				base(global::DATA.Properties.Settings.Default.dbChoThueDiaConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public dbChoThueDiaContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbChoThueDiaContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbChoThueDiaContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbChoThueDiaContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbDiaCD> tbDiaCDs
		{
			get
			{
				return this.GetTable<tbDiaCD>();
			}
		}
		
		public System.Data.Linq.Table<tbKhachHang> tbKhachHangs
		{
			get
			{
				return this.GetTable<tbKhachHang>();
			}
		}
		
		public System.Data.Linq.Table<tbLapPhieuThue> tbLapPhieuThues
		{
			get
			{
				return this.GetTable<tbLapPhieuThue>();
			}
		}
		
		public System.Data.Linq.Table<tbLoaiDia> tbLoaiDias
		{
			get
			{
				return this.GetTable<tbLoaiDia>();
			}
		}
		
		public System.Data.Linq.Table<tbThongTinDatTruoc> tbThongTinDatTruocs
		{
			get
			{
				return this.GetTable<tbThongTinDatTruoc>();
			}
		}
		
		public System.Data.Linq.Table<tbTieuDe> tbTieuDes
		{
			get
			{
				return this.GetTable<tbTieuDe>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbDiaCD")]
	public partial class tbDiaCD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDiaCD;
		
		private string _TinhTrangDia;
		
		private string _MaTieuDe;
		
		private EntitySet<tbLapPhieuThue> _tbLapPhieuThues;
		
		private EntityRef<tbTieuDe> _tbTieuDe;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDiaCDChanging(string value);
    partial void OnMaDiaCDChanged();
    partial void OnTinhTrangDiaChanging(string value);
    partial void OnTinhTrangDiaChanged();
    partial void OnMaTieuDeChanging(string value);
    partial void OnMaTieuDeChanged();
    #endregion
		
		public tbDiaCD()
		{
			this._tbLapPhieuThues = new EntitySet<tbLapPhieuThue>(new Action<tbLapPhieuThue>(this.attach_tbLapPhieuThues), new Action<tbLapPhieuThue>(this.detach_tbLapPhieuThues));
			this._tbTieuDe = default(EntityRef<tbTieuDe>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDiaCD", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDiaCD
		{
			get
			{
				return this._MaDiaCD;
			}
			set
			{
				if ((this._MaDiaCD != value))
				{
					this.OnMaDiaCDChanging(value);
					this.SendPropertyChanging();
					this._MaDiaCD = value;
					this.SendPropertyChanged("MaDiaCD");
					this.OnMaDiaCDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrangDia", DbType="NVarChar(50)")]
		public string TinhTrangDia
		{
			get
			{
				return this._TinhTrangDia;
			}
			set
			{
				if ((this._TinhTrangDia != value))
				{
					this.OnTinhTrangDiaChanging(value);
					this.SendPropertyChanging();
					this._TinhTrangDia = value;
					this.SendPropertyChanged("TinhTrangDia");
					this.OnTinhTrangDiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTieuDe", DbType="NVarChar(50)")]
		public string MaTieuDe
		{
			get
			{
				return this._MaTieuDe;
			}
			set
			{
				if ((this._MaTieuDe != value))
				{
					if (this._tbTieuDe.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaTieuDeChanging(value);
					this.SendPropertyChanging();
					this._MaTieuDe = value;
					this.SendPropertyChanged("MaTieuDe");
					this.OnMaTieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbDiaCD_tbLapPhieuThue", Storage="_tbLapPhieuThues", ThisKey="MaDiaCD", OtherKey="MaDiaCD")]
		public EntitySet<tbLapPhieuThue> tbLapPhieuThues
		{
			get
			{
				return this._tbLapPhieuThues;
			}
			set
			{
				this._tbLapPhieuThues.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbTieuDe_tbDiaCD", Storage="_tbTieuDe", ThisKey="MaTieuDe", OtherKey="MaTieuDe", IsForeignKey=true, DeleteRule="CASCADE")]
		public tbTieuDe tbTieuDe
		{
			get
			{
				return this._tbTieuDe.Entity;
			}
			set
			{
				tbTieuDe previousValue = this._tbTieuDe.Entity;
				if (((previousValue != value) 
							|| (this._tbTieuDe.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbTieuDe.Entity = null;
						previousValue.tbDiaCDs.Remove(this);
					}
					this._tbTieuDe.Entity = value;
					if ((value != null))
					{
						value.tbDiaCDs.Add(this);
						this._MaTieuDe = value.MaTieuDe;
					}
					else
					{
						this._MaTieuDe = default(string);
					}
					this.SendPropertyChanged("tbTieuDe");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tbLapPhieuThues(tbLapPhieuThue entity)
		{
			this.SendPropertyChanging();
			entity.tbDiaCD = this;
		}
		
		private void detach_tbLapPhieuThues(tbLapPhieuThue entity)
		{
			this.SendPropertyChanging();
			entity.tbDiaCD = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbKhachHang")]
	public partial class tbKhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhachHang;
		
		private string _TenKH;
		
		private string _DiaChi;
		
		private string _SoDienThoai;
		
		private System.Nullable<decimal> _PhiPhat;
		
		private EntitySet<tbLapPhieuThue> _tbLapPhieuThues;
		
		private EntitySet<tbThongTinDatTruoc> _tbThongTinDatTruocs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachHangChanging(string value);
    partial void OnMaKhachHangChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    partial void OnPhiPhatChanging(System.Nullable<decimal> value);
    partial void OnPhiPhatChanged();
    #endregion
		
		public tbKhachHang()
		{
			this._tbLapPhieuThues = new EntitySet<tbLapPhieuThue>(new Action<tbLapPhieuThue>(this.attach_tbLapPhieuThues), new Action<tbLapPhieuThue>(this.detach_tbLapPhieuThues));
			this._tbThongTinDatTruocs = new EntitySet<tbThongTinDatTruoc>(new Action<tbThongTinDatTruoc>(this.attach_tbThongTinDatTruocs), new Action<tbThongTinDatTruoc>(this.detach_tbThongTinDatTruocs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(50)")]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="NVarChar(50)")]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhiPhat", DbType="Money")]
		public System.Nullable<decimal> PhiPhat
		{
			get
			{
				return this._PhiPhat;
			}
			set
			{
				if ((this._PhiPhat != value))
				{
					this.OnPhiPhatChanging(value);
					this.SendPropertyChanging();
					this._PhiPhat = value;
					this.SendPropertyChanged("PhiPhat");
					this.OnPhiPhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbKhachHang_tbLapPhieuThue", Storage="_tbLapPhieuThues", ThisKey="MaKhachHang", OtherKey="MaKhachHang")]
		public EntitySet<tbLapPhieuThue> tbLapPhieuThues
		{
			get
			{
				return this._tbLapPhieuThues;
			}
			set
			{
				this._tbLapPhieuThues.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbKhachHang_tbThongTinDatTruoc", Storage="_tbThongTinDatTruocs", ThisKey="MaKhachHang", OtherKey="MaKhachHang")]
		public EntitySet<tbThongTinDatTruoc> tbThongTinDatTruocs
		{
			get
			{
				return this._tbThongTinDatTruocs;
			}
			set
			{
				this._tbThongTinDatTruocs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tbLapPhieuThues(tbLapPhieuThue entity)
		{
			this.SendPropertyChanging();
			entity.tbKhachHang = this;
		}
		
		private void detach_tbLapPhieuThues(tbLapPhieuThue entity)
		{
			this.SendPropertyChanging();
			entity.tbKhachHang = null;
		}
		
		private void attach_tbThongTinDatTruocs(tbThongTinDatTruoc entity)
		{
			this.SendPropertyChanging();
			entity.tbKhachHang = this;
		}
		
		private void detach_tbThongTinDatTruocs(tbThongTinDatTruoc entity)
		{
			this.SendPropertyChanging();
			entity.tbKhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbLapPhieuThue")]
	public partial class tbLapPhieuThue : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaPhieuThue;
		
		private string _MaKhachHang;
		
		private System.Nullable<System.DateTime> _NgayThueDia;
		
		private System.Nullable<System.DateTime> _NgayPhaiTra;
		
		private System.Nullable<decimal> _GiaDiaThue;
		
		private System.Nullable<System.DateTime> _NgayTraDia;
		
		private System.Nullable<decimal> _PhiPhat;
		
		private System.Nullable<bool> _KiemTraPhiPhat;
		
		private string _MaDiaCD;
		
		private EntityRef<tbDiaCD> _tbDiaCD;
		
		private EntityRef<tbKhachHang> _tbKhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaPhieuThueChanging(string value);
    partial void OnMaPhieuThueChanged();
    partial void OnMaKhachHangChanging(string value);
    partial void OnMaKhachHangChanged();
    partial void OnNgayThueDiaChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayThueDiaChanged();
    partial void OnNgayPhaiTraChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayPhaiTraChanged();
    partial void OnGiaDiaThueChanging(System.Nullable<decimal> value);
    partial void OnGiaDiaThueChanged();
    partial void OnNgayTraDiaChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayTraDiaChanged();
    partial void OnPhiPhatChanging(System.Nullable<decimal> value);
    partial void OnPhiPhatChanged();
    partial void OnKiemTraPhiPhatChanging(System.Nullable<bool> value);
    partial void OnKiemTraPhiPhatChanged();
    partial void OnMaDiaCDChanging(string value);
    partial void OnMaDiaCDChanged();
    #endregion
		
		public tbLapPhieuThue()
		{
			this._tbDiaCD = default(EntityRef<tbDiaCD>);
			this._tbKhachHang = default(EntityRef<tbKhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaPhieuThue", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaPhieuThue
		{
			get
			{
				return this._MaPhieuThue;
			}
			set
			{
				if ((this._MaPhieuThue != value))
				{
					this.OnMaPhieuThueChanging(value);
					this.SendPropertyChanging();
					this._MaPhieuThue = value;
					this.SendPropertyChanged("MaPhieuThue");
					this.OnMaPhieuThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="NVarChar(50)")]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					if (this._tbKhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayThueDia", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayThueDia
		{
			get
			{
				return this._NgayThueDia;
			}
			set
			{
				if ((this._NgayThueDia != value))
				{
					this.OnNgayThueDiaChanging(value);
					this.SendPropertyChanging();
					this._NgayThueDia = value;
					this.SendPropertyChanged("NgayThueDia");
					this.OnNgayThueDiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayPhaiTra", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayPhaiTra
		{
			get
			{
				return this._NgayPhaiTra;
			}
			set
			{
				if ((this._NgayPhaiTra != value))
				{
					this.OnNgayPhaiTraChanging(value);
					this.SendPropertyChanging();
					this._NgayPhaiTra = value;
					this.SendPropertyChanged("NgayPhaiTra");
					this.OnNgayPhaiTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaDiaThue", DbType="Money")]
		public System.Nullable<decimal> GiaDiaThue
		{
			get
			{
				return this._GiaDiaThue;
			}
			set
			{
				if ((this._GiaDiaThue != value))
				{
					this.OnGiaDiaThueChanging(value);
					this.SendPropertyChanging();
					this._GiaDiaThue = value;
					this.SendPropertyChanged("GiaDiaThue");
					this.OnGiaDiaThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTraDia", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayTraDia
		{
			get
			{
				return this._NgayTraDia;
			}
			set
			{
				if ((this._NgayTraDia != value))
				{
					this.OnNgayTraDiaChanging(value);
					this.SendPropertyChanging();
					this._NgayTraDia = value;
					this.SendPropertyChanged("NgayTraDia");
					this.OnNgayTraDiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhiPhat", DbType="Money")]
		public System.Nullable<decimal> PhiPhat
		{
			get
			{
				return this._PhiPhat;
			}
			set
			{
				if ((this._PhiPhat != value))
				{
					this.OnPhiPhatChanging(value);
					this.SendPropertyChanging();
					this._PhiPhat = value;
					this.SendPropertyChanged("PhiPhat");
					this.OnPhiPhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KiemTraPhiPhat", DbType="Bit")]
		public System.Nullable<bool> KiemTraPhiPhat
		{
			get
			{
				return this._KiemTraPhiPhat;
			}
			set
			{
				if ((this._KiemTraPhiPhat != value))
				{
					this.OnKiemTraPhiPhatChanging(value);
					this.SendPropertyChanging();
					this._KiemTraPhiPhat = value;
					this.SendPropertyChanged("KiemTraPhiPhat");
					this.OnKiemTraPhiPhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDiaCD", DbType="NVarChar(50)")]
		public string MaDiaCD
		{
			get
			{
				return this._MaDiaCD;
			}
			set
			{
				if ((this._MaDiaCD != value))
				{
					if (this._tbDiaCD.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDiaCDChanging(value);
					this.SendPropertyChanging();
					this._MaDiaCD = value;
					this.SendPropertyChanged("MaDiaCD");
					this.OnMaDiaCDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbDiaCD_tbLapPhieuThue", Storage="_tbDiaCD", ThisKey="MaDiaCD", OtherKey="MaDiaCD", IsForeignKey=true, DeleteRule="CASCADE")]
		public tbDiaCD tbDiaCD
		{
			get
			{
				return this._tbDiaCD.Entity;
			}
			set
			{
				tbDiaCD previousValue = this._tbDiaCD.Entity;
				if (((previousValue != value) 
							|| (this._tbDiaCD.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbDiaCD.Entity = null;
						previousValue.tbLapPhieuThues.Remove(this);
					}
					this._tbDiaCD.Entity = value;
					if ((value != null))
					{
						value.tbLapPhieuThues.Add(this);
						this._MaDiaCD = value.MaDiaCD;
					}
					else
					{
						this._MaDiaCD = default(string);
					}
					this.SendPropertyChanged("tbDiaCD");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbKhachHang_tbLapPhieuThue", Storage="_tbKhachHang", ThisKey="MaKhachHang", OtherKey="MaKhachHang", IsForeignKey=true, DeleteRule="CASCADE")]
		public tbKhachHang tbKhachHang
		{
			get
			{
				return this._tbKhachHang.Entity;
			}
			set
			{
				tbKhachHang previousValue = this._tbKhachHang.Entity;
				if (((previousValue != value) 
							|| (this._tbKhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbKhachHang.Entity = null;
						previousValue.tbLapPhieuThues.Remove(this);
					}
					this._tbKhachHang.Entity = value;
					if ((value != null))
					{
						value.tbLapPhieuThues.Add(this);
						this._MaKhachHang = value.MaKhachHang;
					}
					else
					{
						this._MaKhachHang = default(string);
					}
					this.SendPropertyChanged("tbKhachHang");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbLoaiDia")]
	public partial class tbLoaiDia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLoai;
		
		private string _TenLoai;
		
		private System.Nullable<int> _ThoiGianThue;
		
		private System.Nullable<decimal> _Gia;
		
		private System.Nullable<decimal> _PhiPhat;
		
		private EntitySet<tbTieuDe> _tbTieuDes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiChanging(string value);
    partial void OnMaLoaiChanged();
    partial void OnTenLoaiChanging(string value);
    partial void OnTenLoaiChanged();
    partial void OnThoiGianThueChanging(System.Nullable<int> value);
    partial void OnThoiGianThueChanged();
    partial void OnGiaChanging(System.Nullable<decimal> value);
    partial void OnGiaChanged();
    partial void OnPhiPhatChanging(System.Nullable<decimal> value);
    partial void OnPhiPhatChanged();
    #endregion
		
		public tbLoaiDia()
		{
			this._tbTieuDes = new EntitySet<tbTieuDe>(new Action<tbTieuDe>(this.attach_tbTieuDes), new Action<tbTieuDe>(this.detach_tbTieuDes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(50)")]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this.OnTenLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenLoai = value;
					this.SendPropertyChanged("TenLoai");
					this.OnTenLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThoiGianThue", DbType="Int")]
		public System.Nullable<int> ThoiGianThue
		{
			get
			{
				return this._ThoiGianThue;
			}
			set
			{
				if ((this._ThoiGianThue != value))
				{
					this.OnThoiGianThueChanging(value);
					this.SendPropertyChanging();
					this._ThoiGianThue = value;
					this.SendPropertyChanged("ThoiGianThue");
					this.OnThoiGianThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Money")]
		public System.Nullable<decimal> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhiPhat", DbType="Money")]
		public System.Nullable<decimal> PhiPhat
		{
			get
			{
				return this._PhiPhat;
			}
			set
			{
				if ((this._PhiPhat != value))
				{
					this.OnPhiPhatChanging(value);
					this.SendPropertyChanging();
					this._PhiPhat = value;
					this.SendPropertyChanged("PhiPhat");
					this.OnPhiPhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbLoaiDia_tbTieuDe", Storage="_tbTieuDes", ThisKey="MaLoai", OtherKey="MaLoai")]
		public EntitySet<tbTieuDe> tbTieuDes
		{
			get
			{
				return this._tbTieuDes;
			}
			set
			{
				this._tbTieuDes.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tbTieuDes(tbTieuDe entity)
		{
			this.SendPropertyChanging();
			entity.tbLoaiDia = this;
		}
		
		private void detach_tbTieuDes(tbTieuDe entity)
		{
			this.SendPropertyChanging();
			entity.tbLoaiDia = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbThongTinDatTruoc")]
	public partial class tbThongTinDatTruoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDatDia;
		
		private string _MaKhachHang;
		
		private System.Nullable<System.DateTime> _NgayDatDia;
		
		private string _MaTieuDe;
		
		private string _MaDiaTam;
		
		private EntityRef<tbKhachHang> _tbKhachHang;
		
		private EntityRef<tbTieuDe> _tbTieuDe;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDatDiaChanging(string value);
    partial void OnMaDatDiaChanged();
    partial void OnMaKhachHangChanging(string value);
    partial void OnMaKhachHangChanged();
    partial void OnNgayDatDiaChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDatDiaChanged();
    partial void OnMaTieuDeChanging(string value);
    partial void OnMaTieuDeChanged();
    partial void OnMaDiaTamChanging(string value);
    partial void OnMaDiaTamChanged();
    #endregion
		
		public tbThongTinDatTruoc()
		{
			this._tbKhachHang = default(EntityRef<tbKhachHang>);
			this._tbTieuDe = default(EntityRef<tbTieuDe>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDatDia", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDatDia
		{
			get
			{
				return this._MaDatDia;
			}
			set
			{
				if ((this._MaDatDia != value))
				{
					this.OnMaDatDiaChanging(value);
					this.SendPropertyChanging();
					this._MaDatDia = value;
					this.SendPropertyChanged("MaDatDia");
					this.OnMaDatDiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="NVarChar(50)")]
		public string MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					if (this._tbKhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDatDia", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDatDia
		{
			get
			{
				return this._NgayDatDia;
			}
			set
			{
				if ((this._NgayDatDia != value))
				{
					this.OnNgayDatDiaChanging(value);
					this.SendPropertyChanging();
					this._NgayDatDia = value;
					this.SendPropertyChanged("NgayDatDia");
					this.OnNgayDatDiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTieuDe", DbType="NVarChar(50)")]
		public string MaTieuDe
		{
			get
			{
				return this._MaTieuDe;
			}
			set
			{
				if ((this._MaTieuDe != value))
				{
					if (this._tbTieuDe.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaTieuDeChanging(value);
					this.SendPropertyChanging();
					this._MaTieuDe = value;
					this.SendPropertyChanged("MaTieuDe");
					this.OnMaTieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDiaTam", DbType="NVarChar(50)")]
		public string MaDiaTam
		{
			get
			{
				return this._MaDiaTam;
			}
			set
			{
				if ((this._MaDiaTam != value))
				{
					this.OnMaDiaTamChanging(value);
					this.SendPropertyChanging();
					this._MaDiaTam = value;
					this.SendPropertyChanged("MaDiaTam");
					this.OnMaDiaTamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbKhachHang_tbThongTinDatTruoc", Storage="_tbKhachHang", ThisKey="MaKhachHang", OtherKey="MaKhachHang", IsForeignKey=true, DeleteRule="CASCADE")]
		public tbKhachHang tbKhachHang
		{
			get
			{
				return this._tbKhachHang.Entity;
			}
			set
			{
				tbKhachHang previousValue = this._tbKhachHang.Entity;
				if (((previousValue != value) 
							|| (this._tbKhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbKhachHang.Entity = null;
						previousValue.tbThongTinDatTruocs.Remove(this);
					}
					this._tbKhachHang.Entity = value;
					if ((value != null))
					{
						value.tbThongTinDatTruocs.Add(this);
						this._MaKhachHang = value.MaKhachHang;
					}
					else
					{
						this._MaKhachHang = default(string);
					}
					this.SendPropertyChanged("tbKhachHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbTieuDe_tbThongTinDatTruoc", Storage="_tbTieuDe", ThisKey="MaTieuDe", OtherKey="MaTieuDe", IsForeignKey=true, DeleteRule="CASCADE")]
		public tbTieuDe tbTieuDe
		{
			get
			{
				return this._tbTieuDe.Entity;
			}
			set
			{
				tbTieuDe previousValue = this._tbTieuDe.Entity;
				if (((previousValue != value) 
							|| (this._tbTieuDe.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbTieuDe.Entity = null;
						previousValue.tbThongTinDatTruocs.Remove(this);
					}
					this._tbTieuDe.Entity = value;
					if ((value != null))
					{
						value.tbThongTinDatTruocs.Add(this);
						this._MaTieuDe = value.MaTieuDe;
					}
					else
					{
						this._MaTieuDe = default(string);
					}
					this.SendPropertyChanged("tbTieuDe");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbTieuDe")]
	public partial class tbTieuDe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaTieuDe;
		
		private string _TenTieuDe;
		
		private string _MoTa;
		
		private string _MaLoai;
		
		private EntitySet<tbDiaCD> _tbDiaCDs;
		
		private EntitySet<tbThongTinDatTruoc> _tbThongTinDatTruocs;
		
		private EntityRef<tbLoaiDia> _tbLoaiDia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTieuDeChanging(string value);
    partial void OnMaTieuDeChanged();
    partial void OnTenTieuDeChanging(string value);
    partial void OnTenTieuDeChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnMaLoaiChanging(string value);
    partial void OnMaLoaiChanged();
    #endregion
		
		public tbTieuDe()
		{
			this._tbDiaCDs = new EntitySet<tbDiaCD>(new Action<tbDiaCD>(this.attach_tbDiaCDs), new Action<tbDiaCD>(this.detach_tbDiaCDs));
			this._tbThongTinDatTruocs = new EntitySet<tbThongTinDatTruoc>(new Action<tbThongTinDatTruoc>(this.attach_tbThongTinDatTruocs), new Action<tbThongTinDatTruoc>(this.detach_tbThongTinDatTruocs));
			this._tbLoaiDia = default(EntityRef<tbLoaiDia>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTieuDe", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaTieuDe
		{
			get
			{
				return this._MaTieuDe;
			}
			set
			{
				if ((this._MaTieuDe != value))
				{
					this.OnMaTieuDeChanging(value);
					this.SendPropertyChanging();
					this._MaTieuDe = value;
					this.SendPropertyChanged("MaTieuDe");
					this.OnMaTieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTieuDe", DbType="NVarChar(MAX)")]
		public string TenTieuDe
		{
			get
			{
				return this._TenTieuDe;
			}
			set
			{
				if ((this._TenTieuDe != value))
				{
					this.OnTenTieuDeChanging(value);
					this.SendPropertyChanging();
					this._TenTieuDe = value;
					this.SendPropertyChanged("TenTieuDe");
					this.OnTenTieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(50)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="NVarChar(50)")]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					if (this._tbLoaiDia.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbTieuDe_tbDiaCD", Storage="_tbDiaCDs", ThisKey="MaTieuDe", OtherKey="MaTieuDe")]
		public EntitySet<tbDiaCD> tbDiaCDs
		{
			get
			{
				return this._tbDiaCDs;
			}
			set
			{
				this._tbDiaCDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbTieuDe_tbThongTinDatTruoc", Storage="_tbThongTinDatTruocs", ThisKey="MaTieuDe", OtherKey="MaTieuDe")]
		public EntitySet<tbThongTinDatTruoc> tbThongTinDatTruocs
		{
			get
			{
				return this._tbThongTinDatTruocs;
			}
			set
			{
				this._tbThongTinDatTruocs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbLoaiDia_tbTieuDe", Storage="_tbLoaiDia", ThisKey="MaLoai", OtherKey="MaLoai", IsForeignKey=true, DeleteRule="CASCADE")]
		public tbLoaiDia tbLoaiDia
		{
			get
			{
				return this._tbLoaiDia.Entity;
			}
			set
			{
				tbLoaiDia previousValue = this._tbLoaiDia.Entity;
				if (((previousValue != value) 
							|| (this._tbLoaiDia.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbLoaiDia.Entity = null;
						previousValue.tbTieuDes.Remove(this);
					}
					this._tbLoaiDia.Entity = value;
					if ((value != null))
					{
						value.tbTieuDes.Add(this);
						this._MaLoai = value.MaLoai;
					}
					else
					{
						this._MaLoai = default(string);
					}
					this.SendPropertyChanged("tbLoaiDia");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tbDiaCDs(tbDiaCD entity)
		{
			this.SendPropertyChanging();
			entity.tbTieuDe = this;
		}
		
		private void detach_tbDiaCDs(tbDiaCD entity)
		{
			this.SendPropertyChanging();
			entity.tbTieuDe = null;
		}
		
		private void attach_tbThongTinDatTruocs(tbThongTinDatTruoc entity)
		{
			this.SendPropertyChanging();
			entity.tbTieuDe = this;
		}
		
		private void detach_tbThongTinDatTruocs(tbThongTinDatTruoc entity)
		{
			this.SendPropertyChanging();
			entity.tbTieuDe = null;
		}
	}
}
#pragma warning restore 1591
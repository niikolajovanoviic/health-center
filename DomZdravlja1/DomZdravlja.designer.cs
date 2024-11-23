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

namespace DomZdravlja1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DomZdravlja")]
	public partial class DomZdravljaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFirme(Firme instance);
    partial void UpdateFirme(Firme instance);
    partial void DeleteFirme(Firme instance);
    partial void InsertPacijenti(Pacijenti instance);
    partial void UpdatePacijenti(Pacijenti instance);
    partial void DeletePacijenti(Pacijenti instance);
    partial void InsertPaketi(Paketi instance);
    partial void UpdatePaketi(Paketi instance);
    partial void DeletePaketi(Paketi instance);
    #endregion
		
		public DomZdravljaDataContext() : 
				base(global::DomZdravlja1.Properties.Settings.Default.DomZdravljaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DomZdravljaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DomZdravljaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DomZdravljaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DomZdravljaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Firme> Firmes
		{
			get
			{
				return this.GetTable<Firme>();
			}
		}
		
		public System.Data.Linq.Table<Pacijenti> Pacijentis
		{
			get
			{
				return this.GetTable<Pacijenti>();
			}
		}
		
		public System.Data.Linq.Table<Paketi> Paketis
		{
			get
			{
				return this.GetTable<Paketi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Firme")]
	public partial class Firme : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FirmaID;
		
		private string _Naziv;
		
		private string _Sediste;
		
		private EntitySet<Paketi> _Paketis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFirmaIDChanging(int value);
    partial void OnFirmaIDChanged();
    partial void OnNazivChanging(string value);
    partial void OnNazivChanged();
    partial void OnSedisteChanging(string value);
    partial void OnSedisteChanged();
    #endregion
		
		public Firme()
		{
			this._Paketis = new EntitySet<Paketi>(new Action<Paketi>(this.attach_Paketis), new Action<Paketi>(this.detach_Paketis));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirmaID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int FirmaID
		{
			get
			{
				return this._FirmaID;
			}
			set
			{
				if ((this._FirmaID != value))
				{
					this.OnFirmaIDChanging(value);
					this.SendPropertyChanging();
					this._FirmaID = value;
					this.SendPropertyChanged("FirmaID");
					this.OnFirmaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naziv", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Naziv
		{
			get
			{
				return this._Naziv;
			}
			set
			{
				if ((this._Naziv != value))
				{
					this.OnNazivChanging(value);
					this.SendPropertyChanging();
					this._Naziv = value;
					this.SendPropertyChanged("Naziv");
					this.OnNazivChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sediste", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Sediste
		{
			get
			{
				return this._Sediste;
			}
			set
			{
				if ((this._Sediste != value))
				{
					this.OnSedisteChanging(value);
					this.SendPropertyChanging();
					this._Sediste = value;
					this.SendPropertyChanged("Sediste");
					this.OnSedisteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Firme_Paketi", Storage="_Paketis", ThisKey="FirmaID", OtherKey="FirmaID")]
		public EntitySet<Paketi> Paketis
		{
			get
			{
				return this._Paketis;
			}
			set
			{
				this._Paketis.Assign(value);
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
		
		private void attach_Paketis(Paketi entity)
		{
			this.SendPropertyChanging();
			entity.Firme = this;
		}
		
		private void detach_Paketis(Paketi entity)
		{
			this.SendPropertyChanging();
			entity.Firme = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pacijenti")]
	public partial class Pacijenti : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PacijentID;
		
		private string _Ime;
		
		private string _Prezime;
		
		private System.DateTime _DatumIzmene;
		
		private System.Nullable<int> _Popust;
		
		private int _PaketID;
		
		private EntityRef<Paketi> _Paketi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPacijentIDChanging(int value);
    partial void OnPacijentIDChanged();
    partial void OnImeChanging(string value);
    partial void OnImeChanged();
    partial void OnPrezimeChanging(string value);
    partial void OnPrezimeChanged();
    partial void OnDatumIzmeneChanging(System.DateTime value);
    partial void OnDatumIzmeneChanged();
    partial void OnPopustChanging(System.Nullable<int> value);
    partial void OnPopustChanged();
    partial void OnPaketIDChanging(int value);
    partial void OnPaketIDChanged();
    #endregion
		
		public Pacijenti()
		{
			this._Paketi = default(EntityRef<Paketi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PacijentID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PacijentID
		{
			get
			{
				return this._PacijentID;
			}
			set
			{
				if ((this._PacijentID != value))
				{
					this.OnPacijentIDChanging(value);
					this.SendPropertyChanging();
					this._PacijentID = value;
					this.SendPropertyChanged("PacijentID");
					this.OnPacijentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ime", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string Ime
		{
			get
			{
				return this._Ime;
			}
			set
			{
				if ((this._Ime != value))
				{
					this.OnImeChanging(value);
					this.SendPropertyChanging();
					this._Ime = value;
					this.SendPropertyChanged("Ime");
					this.OnImeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prezime", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Prezime
		{
			get
			{
				return this._Prezime;
			}
			set
			{
				if ((this._Prezime != value))
				{
					this.OnPrezimeChanging(value);
					this.SendPropertyChanging();
					this._Prezime = value;
					this.SendPropertyChanged("Prezime");
					this.OnPrezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatumIzmene", DbType="Date NOT NULL")]
		public System.DateTime DatumIzmene
		{
			get
			{
				return this._DatumIzmene;
			}
			set
			{
				if ((this._DatumIzmene != value))
				{
					this.OnDatumIzmeneChanging(value);
					this.SendPropertyChanging();
					this._DatumIzmene = value;
					this.SendPropertyChanged("DatumIzmene");
					this.OnDatumIzmeneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Popust", DbType="Int")]
		public System.Nullable<int> Popust
		{
			get
			{
				return this._Popust;
			}
			set
			{
				if ((this._Popust != value))
				{
					this.OnPopustChanging(value);
					this.SendPropertyChanging();
					this._Popust = value;
					this.SendPropertyChanged("Popust");
					this.OnPopustChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaketID", DbType="Int NOT NULL")]
		public int PaketID
		{
			get
			{
				return this._PaketID;
			}
			set
			{
				if ((this._PaketID != value))
				{
					if (this._Paketi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPaketIDChanging(value);
					this.SendPropertyChanging();
					this._PaketID = value;
					this.SendPropertyChanged("PaketID");
					this.OnPaketIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Paketi_Pacijenti", Storage="_Paketi", ThisKey="PaketID", OtherKey="PaketID", IsForeignKey=true)]
		public Paketi Paketi
		{
			get
			{
				return this._Paketi.Entity;
			}
			set
			{
				Paketi previousValue = this._Paketi.Entity;
				if (((previousValue != value) 
							|| (this._Paketi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Paketi.Entity = null;
						previousValue.Pacijentis.Remove(this);
					}
					this._Paketi.Entity = value;
					if ((value != null))
					{
						value.Pacijentis.Add(this);
						this._PaketID = value.PaketID;
					}
					else
					{
						this._PaketID = default(int);
					}
					this.SendPropertyChanged("Paketi");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Paketi")]
	public partial class Paketi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PaketID;
		
		private string _Naziv;
		
		private float _Cena;
		
		private int _FirmaID;
		
		private EntitySet<Pacijenti> _Pacijentis;
		
		private EntityRef<Firme> _Firme;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPaketIDChanging(int value);
    partial void OnPaketIDChanged();
    partial void OnNazivChanging(string value);
    partial void OnNazivChanged();
    partial void OnCenaChanging(float value);
    partial void OnCenaChanged();
    partial void OnFirmaIDChanging(int value);
    partial void OnFirmaIDChanged();
    #endregion
		
		public Paketi()
		{
			this._Pacijentis = new EntitySet<Pacijenti>(new Action<Pacijenti>(this.attach_Pacijentis), new Action<Pacijenti>(this.detach_Pacijentis));
			this._Firme = default(EntityRef<Firme>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaketID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PaketID
		{
			get
			{
				return this._PaketID;
			}
			set
			{
				if ((this._PaketID != value))
				{
					this.OnPaketIDChanging(value);
					this.SendPropertyChanging();
					this._PaketID = value;
					this.SendPropertyChanged("PaketID");
					this.OnPaketIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naziv", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Naziv
		{
			get
			{
				return this._Naziv;
			}
			set
			{
				if ((this._Naziv != value))
				{
					this.OnNazivChanging(value);
					this.SendPropertyChanging();
					this._Naziv = value;
					this.SendPropertyChanged("Naziv");
					this.OnNazivChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cena", DbType="Real NOT NULL")]
		public float Cena
		{
			get
			{
				return this._Cena;
			}
			set
			{
				if ((this._Cena != value))
				{
					this.OnCenaChanging(value);
					this.SendPropertyChanging();
					this._Cena = value;
					this.SendPropertyChanged("Cena");
					this.OnCenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirmaID", DbType="Int NOT NULL")]
		public int FirmaID
		{
			get
			{
				return this._FirmaID;
			}
			set
			{
				if ((this._FirmaID != value))
				{
					if (this._Firme.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFirmaIDChanging(value);
					this.SendPropertyChanging();
					this._FirmaID = value;
					this.SendPropertyChanged("FirmaID");
					this.OnFirmaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Paketi_Pacijenti", Storage="_Pacijentis", ThisKey="PaketID", OtherKey="PaketID")]
		public EntitySet<Pacijenti> Pacijentis
		{
			get
			{
				return this._Pacijentis;
			}
			set
			{
				this._Pacijentis.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Firme_Paketi", Storage="_Firme", ThisKey="FirmaID", OtherKey="FirmaID", IsForeignKey=true)]
		public Firme Firme
		{
			get
			{
				return this._Firme.Entity;
			}
			set
			{
				Firme previousValue = this._Firme.Entity;
				if (((previousValue != value) 
							|| (this._Firme.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Firme.Entity = null;
						previousValue.Paketis.Remove(this);
					}
					this._Firme.Entity = value;
					if ((value != null))
					{
						value.Paketis.Add(this);
						this._FirmaID = value.FirmaID;
					}
					else
					{
						this._FirmaID = default(int);
					}
					this.SendPropertyChanged("Firme");
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
		
		private void attach_Pacijentis(Pacijenti entity)
		{
			this.SendPropertyChanging();
			entity.Paketi = this;
		}
		
		private void detach_Pacijentis(Pacijenti entity)
		{
			this.SendPropertyChanging();
			entity.Paketi = null;
		}
	}
}
#pragma warning restore 1591
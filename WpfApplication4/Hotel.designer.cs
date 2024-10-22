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

namespace WpfApplication4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hotel")]
	public partial class HotelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHotel(Hotel instance);
    partial void UpdateHotel(Hotel instance);
    partial void DeleteHotel(Hotel instance);
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    #endregion
		
		public HotelDataContext() : 
				base(global::WpfApplication4.Properties.Settings.Default.HotelConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HotelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Hotel> Hotels
		{
			get
			{
				return this.GetTable<Hotel>();
			}
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hotel")]
	public partial class Hotel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Hotel_Id;
		
		private string _Hotel_Name;
		
		private System.Nullable<int> _Ratings;
		
		private string _Destination;
		
		private string _Image;
		
		private EntitySet<Room> _Rooms;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHotel_IdChanging(int value);
    partial void OnHotel_IdChanged();
    partial void OnHotel_NameChanging(string value);
    partial void OnHotel_NameChanged();
    partial void OnRatingsChanging(System.Nullable<int> value);
    partial void OnRatingsChanged();
    partial void OnDestinationChanging(string value);
    partial void OnDestinationChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    #endregion
		
		public Hotel()
		{
			this._Rooms = new EntitySet<Room>(new Action<Room>(this.attach_Rooms), new Action<Room>(this.detach_Rooms));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hotel_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Hotel_Id
		{
			get
			{
				return this._Hotel_Id;
			}
			set
			{
				if ((this._Hotel_Id != value))
				{
					this.OnHotel_IdChanging(value);
					this.SendPropertyChanging();
					this._Hotel_Id = value;
					this.SendPropertyChanged("Hotel_Id");
					this.OnHotel_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hotel_Name", DbType="VarChar(50)")]
		public string Hotel_Name
		{
			get
			{
				return this._Hotel_Name;
			}
			set
			{
				if ((this._Hotel_Name != value))
				{
					this.OnHotel_NameChanging(value);
					this.SendPropertyChanging();
					this._Hotel_Name = value;
					this.SendPropertyChanged("Hotel_Name");
					this.OnHotel_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ratings", DbType="Int")]
		public System.Nullable<int> Ratings
		{
			get
			{
				return this._Ratings;
			}
			set
			{
				if ((this._Ratings != value))
				{
					this.OnRatingsChanging(value);
					this.SendPropertyChanging();
					this._Ratings = value;
					this.SendPropertyChanged("Ratings");
					this.OnRatingsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Destination", DbType="VarChar(50)")]
		public string Destination
		{
			get
			{
				return this._Destination;
			}
			set
			{
				if ((this._Destination != value))
				{
					this.OnDestinationChanging(value);
					this.SendPropertyChanging();
					this._Destination = value;
					this.SendPropertyChanged("Destination");
					this.OnDestinationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(200)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hotel_Room", Storage="_Rooms", ThisKey="Hotel_Id", OtherKey="Hotel")]
		public EntitySet<Room> Rooms
		{
			get
			{
				return this._Rooms;
			}
			set
			{
				this._Rooms.Assign(value);
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
		
		private void attach_Rooms(Room entity)
		{
			this.SendPropertyChanging();
			entity.Hotel1 = this;
		}
		
		private void detach_Rooms(Room entity)
		{
			this.SendPropertyChanging();
			entity.Hotel1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rooms")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Room_Id;
		
		private string _Category;
		
		private System.Nullable<double> _Price;
		
		private string _Description;
		
		private string _Image;
		
		private int _Hotel;
		
		private EntityRef<Hotel> _Hotel1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoom_IdChanging(int value);
    partial void OnRoom_IdChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnPriceChanging(System.Nullable<double> value);
    partial void OnPriceChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnHotelChanging(int value);
    partial void OnHotelChanged();
    #endregion
		
		public Room()
		{
			this._Hotel1 = default(EntityRef<Hotel>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Room_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Room_Id
		{
			get
			{
				return this._Room_Id;
			}
			set
			{
				if ((this._Room_Id != value))
				{
					this.OnRoom_IdChanging(value);
					this.SendPropertyChanging();
					this._Room_Id = value;
					this.SendPropertyChanged("Room_Id");
					this.OnRoom_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(50)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float")]
		public System.Nullable<double> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(150)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="VarChar(200)")]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if ((this._Image != value))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._Image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hotel", DbType="Int NOT NULL")]
		public int Hotel
		{
			get
			{
				return this._Hotel;
			}
			set
			{
				if ((this._Hotel != value))
				{
					if (this._Hotel1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnHotelChanging(value);
					this.SendPropertyChanging();
					this._Hotel = value;
					this.SendPropertyChanged("Hotel");
					this.OnHotelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hotel_Room", Storage="_Hotel1", ThisKey="Hotel", OtherKey="Hotel_Id", IsForeignKey=true)]
		public Hotel Hotel1
		{
			get
			{
				return this._Hotel1.Entity;
			}
			set
			{
				Hotel previousValue = this._Hotel1.Entity;
				if (((previousValue != value) 
							|| (this._Hotel1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Hotel1.Entity = null;
						previousValue.Rooms.Remove(this);
					}
					this._Hotel1.Entity = value;
					if ((value != null))
					{
						value.Rooms.Add(this);
						this._Hotel = value.Hotel_Id;
					}
					else
					{
						this._Hotel = default(int);
					}
					this.SendPropertyChanged("Hotel1");
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
}
#pragma warning restore 1591

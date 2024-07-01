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

namespace HotelManagementSystem
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class PaymentsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPayment(Payment instance);
    partial void UpdatePayment(Payment instance);
    partial void DeletePayment(Payment instance);
    #endregion
		
		public PaymentsDataContext() : 
				base(global::HotelManagementSystem.Properties.Settings.Default.Database1ConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public PaymentsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PaymentsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PaymentsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PaymentsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Payment> Payments
		{
			get
			{
				return this.GetTable<Payment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Payment")]
	public partial class Payment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PaymentId;
		
		private System.Nullable<int> _BookingId;
		
		private System.Nullable<decimal> _Amount;
		
		private System.Nullable<System.DateTime> _PaymentDate;
		
		private string _PaymentMethod;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPaymentIdChanging(int value);
    partial void OnPaymentIdChanged();
    partial void OnBookingIdChanging(System.Nullable<int> value);
    partial void OnBookingIdChanged();
    partial void OnAmountChanging(System.Nullable<decimal> value);
    partial void OnAmountChanged();
    partial void OnPaymentDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPaymentDateChanged();
    partial void OnPaymentMethodChanging(string value);
    partial void OnPaymentMethodChanged();
    #endregion
		
		public Payment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PaymentId
		{
			get
			{
				return this._PaymentId;
			}
			set
			{
				if ((this._PaymentId != value))
				{
					this.OnPaymentIdChanging(value);
					this.SendPropertyChanging();
					this._PaymentId = value;
					this.SendPropertyChanged("PaymentId");
					this.OnPaymentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingId", DbType="Int")]
		public System.Nullable<int> BookingId
		{
			get
			{
				return this._BookingId;
			}
			set
			{
				if ((this._BookingId != value))
				{
					this.OnBookingIdChanging(value);
					this.SendPropertyChanging();
					this._BookingId = value;
					this.SendPropertyChanged("BookingId");
					this.OnBookingIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentDate", DbType="Date")]
		public System.Nullable<System.DateTime> PaymentDate
		{
			get
			{
				return this._PaymentDate;
			}
			set
			{
				if ((this._PaymentDate != value))
				{
					this.OnPaymentDateChanging(value);
					this.SendPropertyChanging();
					this._PaymentDate = value;
					this.SendPropertyChanged("PaymentDate");
					this.OnPaymentDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentMethod", DbType="VarChar(50)")]
		public string PaymentMethod
		{
			get
			{
				return this._PaymentMethod;
			}
			set
			{
				if ((this._PaymentMethod != value))
				{
					this.OnPaymentMethodChanging(value);
					this.SendPropertyChanging();
					this._PaymentMethod = value;
					this.SendPropertyChanged("PaymentMethod");
					this.OnPaymentMethodChanged();
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

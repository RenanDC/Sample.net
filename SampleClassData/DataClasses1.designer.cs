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

namespace SampleClassData
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SampleDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCidade(Cidade instance);
    partial void UpdateCidade(Cidade instance);
    partial void DeleteCidade(Cidade instance);
    partial void InsertPessoaTB(PessoaTB instance);
    partial void UpdatePessoaTB(PessoaTB instance);
    partial void DeletePessoaTB(PessoaTB instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::SampleClassData.Properties.Settings.Default.SampleDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cidade> Cidades
		{
			get
			{
				return this.GetTable<Cidade>();
			}
		}
		
		public System.Data.Linq.Table<PessoaTB> PessoaTBs
		{
			get
			{
				return this.GetTable<PessoaTB>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cidades")]
	public partial class Cidade : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CidadeId;
		
		private string _Descricao;
		
		private string _Sigla;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCidadeIdChanging(int value);
    partial void OnCidadeIdChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnSiglaChanging(string value);
    partial void OnSiglaChanged();
    #endregion
		
		public Cidade()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CidadeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CidadeId
		{
			get
			{
				return this._CidadeId;
			}
			set
			{
				if ((this._CidadeId != value))
				{
					this.OnCidadeIdChanging(value);
					this.SendPropertyChanging();
					this._CidadeId = value;
					this.SendPropertyChanged("CidadeId");
					this.OnCidadeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descricao", DbType="VarChar(100)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sigla", DbType="Char(2)")]
		public string Sigla
		{
			get
			{
				return this._Sigla;
			}
			set
			{
				if ((this._Sigla != value))
				{
					this.OnSiglaChanging(value);
					this.SendPropertyChanging();
					this._Sigla = value;
					this.SendPropertyChanged("Sigla");
					this.OnSiglaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PessoaTB")]
	public partial class PessoaTB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PessoaId;
		
		private string _Nome;
		
		private string _Telefone;
		
		private string _Obs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPessoaIdChanging(int value);
    partial void OnPessoaIdChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnTelefoneChanging(string value);
    partial void OnTelefoneChanged();
    partial void OnObsChanging(string value);
    partial void OnObsChanged();
    #endregion
		
		public PessoaTB()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PessoaId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PessoaId
		{
			get
			{
				return this._PessoaId;
			}
			set
			{
				if ((this._PessoaId != value))
				{
					this.OnPessoaIdChanging(value);
					this.SendPropertyChanging();
					this._PessoaId = value;
					this.SendPropertyChanged("PessoaId");
					this.OnPessoaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(300)")]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefone", DbType="VarChar(20)")]
		public string Telefone
		{
			get
			{
				return this._Telefone;
			}
			set
			{
				if ((this._Telefone != value))
				{
					this.OnTelefoneChanging(value);
					this.SendPropertyChanging();
					this._Telefone = value;
					this.SendPropertyChanged("Telefone");
					this.OnTelefoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Obs", DbType="VarChar(500)")]
		public string Obs
		{
			get
			{
				return this._Obs;
			}
			set
			{
				if ((this._Obs != value))
				{
					this.OnObsChanging(value);
					this.SendPropertyChanging();
					this._Obs = value;
					this.SendPropertyChanged("Obs");
					this.OnObsChanged();
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

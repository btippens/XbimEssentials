// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ActorResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPerson
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPerson : IPersistEntity, IfcActorSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
		IfcIdentifier? @Identification { get; }
		IfcLabel? @FamilyName { get; }
		IfcLabel? @GivenName { get; }
		IEnumerable<IfcLabel> @MiddleNames { get; }
		IEnumerable<IfcLabel> @PrefixTitles { get; }
		IEnumerable<IfcLabel> @SuffixTitles { get; }
		IEnumerable<IIfcActorRole> @Roles { get; }
		IEnumerable<IIfcAddress> @Addresses { get; }
		IEnumerable<IIfcPersonAndOrganization> @EngagedIn {  get; }
	
	}
}

namespace Xbim.Ifc4.ActorResource
{
	[IndexedClass]
	[ExpressType("IfcPerson", 805)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPerson : INotifyPropertyChanged, IInstantiableEntity, IIfcPerson, IEqualityComparer<@IfcPerson>, IEquatable<@IfcPerson>
	{
		#region IIfcPerson explicit implementation
		IfcIdentifier? IIfcPerson.Identification { get { return @Identification; } }	
		IfcLabel? IIfcPerson.FamilyName { get { return @FamilyName; } }	
		IfcLabel? IIfcPerson.GivenName { get { return @GivenName; } }	
		IEnumerable<IfcLabel> IIfcPerson.MiddleNames { get { return @MiddleNames; } }	
		IEnumerable<IfcLabel> IIfcPerson.PrefixTitles { get { return @PrefixTitles; } }	
		IEnumerable<IfcLabel> IIfcPerson.SuffixTitles { get { return @SuffixTitles; } }	
		IEnumerable<IIfcActorRole> IIfcPerson.Roles { get { return @Roles; } }	
		IEnumerable<IIfcAddress> IIfcPerson.Addresses { get { return @Addresses; } }	
		 
		IEnumerable<IIfcPersonAndOrganization> IIfcPerson.EngagedIn {  get { return @EngagedIn; } }
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPerson(IModel model) 		{ 
			Model = model; 
			_middleNames = new OptionalItemSet<IfcLabel>( this, 0 );
			_prefixTitles = new OptionalItemSet<IfcLabel>( this, 0 );
			_suffixTitles = new OptionalItemSet<IfcLabel>( this, 0 );
			_roles = new OptionalItemSet<IfcActorRole>( this, 0 );
			_addresses = new OptionalItemSet<IfcAddress>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcLabel? _familyName;
		private IfcLabel? _givenName;
		private OptionalItemSet<IfcLabel> _middleNames;
		private OptionalItemSet<IfcLabel> _prefixTitles;
		private OptionalItemSet<IfcLabel> _suffixTitles;
		private OptionalItemSet<IfcActorRole> _roles;
		private OptionalItemSet<IfcAddress> _addresses;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _identification;
				((IPersistEntity)this).Activate(false);
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLabel? @FamilyName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _familyName;
				((IPersistEntity)this).Activate(false);
				return _familyName;
			} 
			set
			{
				SetValue( v =>  _familyName = v, _familyName, value,  "FamilyName");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLabel? @GivenName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _givenName;
				((IPersistEntity)this).Activate(false);
				return _givenName;
			} 
			set
			{
				SetValue( v =>  _givenName = v, _givenName, value,  "GivenName");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 4)]
		public OptionalItemSet<IfcLabel> @MiddleNames 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _middleNames;
				((IPersistEntity)this).Activate(false);
				return _middleNames;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 5)]
		public OptionalItemSet<IfcLabel> @PrefixTitles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _prefixTitles;
				((IPersistEntity)this).Activate(false);
				return _prefixTitles;
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 6)]
		public OptionalItemSet<IfcLabel> @SuffixTitles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _suffixTitles;
				((IPersistEntity)this).Activate(false);
				return _suffixTitles;
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 7)]
		public OptionalItemSet<IfcActorRole> @Roles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _roles;
				((IPersistEntity)this).Activate(false);
				return _roles;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 8)]
		public OptionalItemSet<IfcAddress> @Addresses 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _addresses;
				((IPersistEntity)this).Activate(false);
				return _addresses;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ThePerson")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 9)]
		public IEnumerable<IfcPersonAndOrganization> @EngagedIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPersonAndOrganization>(e => (e.ThePerson as IfcPerson) == this);
			} 
		}
		#endregion

		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_identification = value.StringVal;
					return;
				case 1: 
					_familyName = value.StringVal;
					return;
				case 2: 
					_givenName = value.StringVal;
					return;
				case 3: 
					if (_middleNames == null) _middleNames = new OptionalItemSet<IfcLabel>( this );
					_middleNames.InternalAdd(value.StringVal);
					return;
				case 4: 
					if (_prefixTitles == null) _prefixTitles = new OptionalItemSet<IfcLabel>( this );
					_prefixTitles.InternalAdd(value.StringVal);
					return;
				case 5: 
					if (_suffixTitles == null) _suffixTitles = new OptionalItemSet<IfcLabel>( this );
					_suffixTitles.InternalAdd(value.StringVal);
					return;
				case 6: 
					if (_roles == null) _roles = new OptionalItemSet<IfcActorRole>( this );
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
					return;
				case 7: 
					if (_addresses == null) _addresses = new OptionalItemSet<IfcAddress>( this );
					_addresses.InternalAdd((IfcAddress)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*IdentifiablePerson:	IdentifiablePerson : EXISTS(Identification) OR EXISTS(FamilyName) OR EXISTS(GivenName);*/
		/*ValidSetOfNames:	ValidSetOfNames : NOT EXISTS(MiddleNames) OR EXISTS(FamilyName) OR EXISTS(GivenName);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPerson other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPerson
            var root = (@IfcPerson)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPerson left, @IfcPerson right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPerson left, @IfcPerson right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPerson x, @IfcPerson y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPerson obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
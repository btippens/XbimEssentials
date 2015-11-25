// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcContext
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcContext : IIfcObjectDefinition
	{
		IfcLabel? @ObjectType { get; }
		IfcLabel? @LongName { get; }
		IfcLabel? @Phase { get; }
		IEnumerable<IIfcRepresentationContext> @RepresentationContexts { get; }
		IIfcUnitAssignment @UnitsInContext { get; }
		IEnumerable<IIfcRelDefinesByProperties> @IsDefinedBy {  get; }
		IEnumerable<IIfcRelDeclares> @Declares {  get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcContext", 532)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcContext : IfcObjectDefinition, IIfcContext, IEqualityComparer<@IfcContext>, IEquatable<@IfcContext>
	{
		#region IIfcContext explicit implementation
		IfcLabel? IIfcContext.ObjectType { get { return @ObjectType; } }	
		IfcLabel? IIfcContext.LongName { get { return @LongName; } }	
		IfcLabel? IIfcContext.Phase { get { return @Phase; } }	
		IEnumerable<IIfcRepresentationContext> IIfcContext.RepresentationContexts { get { return @RepresentationContexts; } }	
		IIfcUnitAssignment IIfcContext.UnitsInContext { get { return @UnitsInContext; } }	
		 
		IEnumerable<IIfcRelDefinesByProperties> IIfcContext.IsDefinedBy {  get { return @IsDefinedBy; } }
		IEnumerable<IIfcRelDeclares> IIfcContext.Declares {  get { return @Declares; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcContext(IModel model) : base(model) 		{ 
			Model = model; 
			_representationContexts = new OptionalItemSet<IfcRepresentationContext>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcLabel? _objectType;
		private IfcLabel? _longName;
		private IfcLabel? _phase;
		private OptionalItemSet<IfcRepresentationContext> _representationContexts;
		private IfcUnitAssignment _unitsInContext;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcLabel? @ObjectType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _objectType;
				((IPersistEntity)this).Activate(false);
				return _objectType;
			} 
			set
			{
				SetValue( v =>  _objectType = v, _objectType, value,  "ObjectType");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public IfcLabel? @LongName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longName;
				((IPersistEntity)this).Activate(false);
				return _longName;
			} 
			set
			{
				SetValue( v =>  _longName = v, _longName, value,  "LongName");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public IfcLabel? @Phase 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _phase;
				((IPersistEntity)this).Activate(false);
				return _phase;
			} 
			set
			{
				SetValue( v =>  _phase = v, _phase, value,  "Phase");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 15)]
		public OptionalItemSet<IfcRepresentationContext> @RepresentationContexts 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _representationContexts;
				((IPersistEntity)this).Activate(false);
				return _representationContexts;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 16)]
		public IfcUnitAssignment @UnitsInContext 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unitsInContext;
				((IPersistEntity)this).Activate(false);
				return _unitsInContext;
			} 
			set
			{
				SetValue( v =>  _unitsInContext = v, _unitsInContext, value,  "UnitsInContext");
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 17)]
		public IEnumerable<IfcRelDefinesByProperties> @IsDefinedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefinesByProperties>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		[InverseProperty("RelatingContext")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 18)]
		public IEnumerable<IfcRelDeclares> @Declares 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDeclares>(e => (e.RelatingContext as IfcContext) == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_objectType = value.StringVal;
					return;
				case 5: 
					_longName = value.StringVal;
					return;
				case 6: 
					_phase = value.StringVal;
					return;
				case 7: 
					if (_representationContexts == null) _representationContexts = new OptionalItemSet<IfcRepresentationContext>( this );
					_representationContexts.InternalAdd((IfcRepresentationContext)value.EntityVal);
					return;
				case 8: 
					_unitsInContext = (IfcUnitAssignment)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcContext other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcContext
            var root = (@IfcContext)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcContext left, @IfcContext right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcContext left, @IfcContext right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcContext x, @IfcContext y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcContext obj)
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
// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcTendon : IIfcTendon
	{
		Xbim.Ifc4.StructuralElementsDomain.IfcTendonTypeEnum? IIfcTendon.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.StructuralElementsDomain.IfcTendonTypeEnum.STRAND:
						return Xbim.Ifc4.StructuralElementsDomain.IfcTendonTypeEnum.STRAND;
					
					case Xbim.Ifc2x3.StructuralElementsDomain.IfcTendonTypeEnum.WIRE:
						return Xbim.Ifc4.StructuralElementsDomain.IfcTendonTypeEnum.WIRE;
					
					case Xbim.Ifc2x3.StructuralElementsDomain.IfcTendonTypeEnum.BAR:
						return Xbim.Ifc4.StructuralElementsDomain.IfcTendonTypeEnum.BAR;
					
					case Xbim.Ifc2x3.StructuralElementsDomain.IfcTendonTypeEnum.COATED:
						return Xbim.Ifc4.StructuralElementsDomain.IfcTendonTypeEnum.COATED;
					
					case Xbim.Ifc2x3.StructuralElementsDomain.IfcTendonTypeEnum.USERDEFINED:
						return Xbim.Ifc4.StructuralElementsDomain.IfcTendonTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.StructuralElementsDomain.IfcTendonTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.StructuralElementsDomain.IfcTendonTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcTendon.NominalDiameter 
		{ 
			get
			{
				return new Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)NominalDiameter);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcAreaMeasure? IIfcTendon.CrossSectionArea 
		{ 
			get
			{
				return new Xbim.Ifc4.MeasureResource.IfcAreaMeasure((double)CrossSectionArea);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcForceMeasure? IIfcTendon.TensionForce 
		{ 
			get
			{
				if (TensionForce == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcForceMeasure((double)TensionForce);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPressureMeasure? IIfcTendon.PreStress 
		{ 
			get
			{
				if (PreStress == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcPressureMeasure((double)PreStress);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcTendon.FrictionCoefficient 
		{ 
			get
			{
				if (FrictionCoefficient == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)FrictionCoefficient);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcTendon.AnchorageSlip 
		{ 
			get
			{
				if (AnchorageSlip == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)AnchorageSlip);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcTendon.MinCurvatureRadius 
		{ 
			get
			{
				if (MinCurvatureRadius == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)MinCurvatureRadius);
			} 
		}
	}
}
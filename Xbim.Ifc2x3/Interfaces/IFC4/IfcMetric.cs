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
namespace Xbim.Ifc2x3.ConstraintResource
{
	public partial class @IfcMetric : IIfcMetric
	{
		Ifc4.Interfaces.IfcBenchmarkEnum IIfcMetric.Benchmark 
		{ 
			get
			{
				switch (Benchmark)
				{
					case IfcBenchmarkEnum.GREATERTHAN:
						return Ifc4.Interfaces.IfcBenchmarkEnum.GREATERTHAN;
					
					case IfcBenchmarkEnum.GREATERTHANOREQUALTO:
						return Ifc4.Interfaces.IfcBenchmarkEnum.GREATERTHANOREQUALTO;
					
					case IfcBenchmarkEnum.LESSTHAN:
						return Ifc4.Interfaces.IfcBenchmarkEnum.LESSTHAN;
					
					case IfcBenchmarkEnum.LESSTHANOREQUALTO:
						return Ifc4.Interfaces.IfcBenchmarkEnum.LESSTHANOREQUALTO;
					
					case IfcBenchmarkEnum.EQUALTO:
						return Ifc4.Interfaces.IfcBenchmarkEnum.EQUALTO;
					
					case IfcBenchmarkEnum.NOTEQUALTO:
						return Ifc4.Interfaces.IfcBenchmarkEnum.NOTEQUALTO;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				throw new System.NotImplementedException();
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcMetric.ValueSource 
		{ 
			get
			{
				if (!ValueSource.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ValueSource.Value);
			} 
			set
			{
				ValueSource = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		private  IIfcMetricValueSelect _dataValue4;

		IIfcMetricValueSelect IIfcMetric.DataValue 
		{ 
			get
			{
				if (_dataValue4 != null) return _dataValue4;
				if (DataValue == null) return null;
				var ifccalendardate = DataValue as DateTimeResource.IfcCalendarDate;
				if (ifccalendardate != null) 
					//## Handle entity IfcCalendarDate which is not a part of the target select interface IIfcMetricValueSelect in property DataValue
                    return new Ifc4.DateTimeResource.IfcDate(ifccalendardate.ToISODateTimeString());
					//##
				var ifclocaltime = DataValue as DateTimeResource.IfcLocalTime;
				if (ifclocaltime != null) 
					//## Handle entity IfcLocalTime which is not a part of the target select interface IIfcMetricValueSelect in property DataValue
                    return new Ifc4.DateTimeResource.IfcTime(ifclocaltime.ToISODateTimeString());
					//##
				var ifcdateandtime = DataValue as DateTimeResource.IfcDateAndTime;
				if (ifcdateandtime != null) 
					//## Handle entity IfcDateAndTime which is not a part of the target select interface IIfcMetricValueSelect in property DataValue
                    return new Ifc4.DateTimeResource.IfcDateTime(ifcdateandtime.ToISODateTimeString());
					//##
				var ifcmeasurewithunit = DataValue as MeasureResource.IfcMeasureWithUnit;
				if (ifcmeasurewithunit != null) 
					return ifcmeasurewithunit;
				var ifctable = DataValue as UtilityResource.IfcTable;
				if (ifctable != null) 
					return ifctable;
				if (DataValue is MeasureResource.IfcText) 
					return new Ifc4.MeasureResource.IfcText((MeasureResource.IfcText)DataValue);
				var ifctimeseries = DataValue as TimeSeriesResource.IfcTimeSeries;
				if (ifctimeseries != null) 
					return ifctimeseries;
				var ifccostvalue = DataValue as CostResource.IfcCostValue;
				if (ifccostvalue != null) 
					return ifccostvalue;
				return null;
			} 
			set
			{
				if (value == null)
				{
					DataValue = null;
					return;
				}	
				var ifcappliedvalue = value as CostResource.IfcAppliedValue;
				if (ifcappliedvalue != null) 
				{
					//## Handle setting of entity IfcAppliedValue which is not a part of the target select interface IIfcMetricValueSelect in property DataValue
					//TODO: Handle setting of entity IfcAppliedValue which is not a part of the target select interface IIfcMetricValueSelect in property DataValue
					throw new System.NotImplementedException();
					//##
				}
				var ifcmeasurewithunit = value as MeasureResource.IfcMeasureWithUnit;
				if (ifcmeasurewithunit != null) 
				{
					DataValue = ifcmeasurewithunit;
					return;
				}
				var ifctable = value as UtilityResource.IfcTable;
				if (ifctable != null) 
				{
					DataValue = ifctable;
					return;
				}
				var ifctimeseries = value as TimeSeriesResource.IfcTimeSeries;
				if (ifctimeseries != null) 
				{
					DataValue = ifctimeseries;
					return;
				}
				if (value is Ifc4.MeasureResource.IfcAbsorbedDoseMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcAccelerationMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcAngularVelocityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcAreaDensityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcCurvatureMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcDoseEquivalentMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcDynamicViscosityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcElectricCapacitanceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcElectricChargeMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcElectricConductanceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcElectricResistanceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcElectricVoltageMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcEnergyMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcForceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcFrequencyMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcHeatFluxDensityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcHeatingValueMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcIlluminanceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcInductanceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcIntegerCountRateMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcIonConcentrationMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcIsothermalMoistureCapacityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcKinematicViscosityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLinearForceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLinearMomentMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLinearStiffnessMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLinearVelocityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLuminousFluxMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLuminousIntensityDistributionMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMagneticFluxDensityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMagneticFluxMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMassDensityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMassFlowRateMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMassPerLengthMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfElasticityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMoistureDiffusivityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMolecularWeightMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMomentOfInertiaMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMonetaryMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPHMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPlanarForceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPowerMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPressureMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcRadioActivityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcRotationalFrequencyMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcRotationalMassMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcRotationalStiffnessMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcSectionModulusMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcSectionalAreaIntegralMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcShearModulusMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcSoundPowerLevelMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcSoundPowerMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcSoundPressureLevelMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcSoundPressureMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcSpecificHeatCapacityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcTemperatureGradientMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcTemperatureRateOfChangeMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcThermalAdmittanceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcThermalConductivityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcThermalExpansionCoefficientMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcThermalResistanceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcThermalTransmittanceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcTorqueMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcVaporPermeabilityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcVolumetricFlowRateMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcWarpingConstantMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcWarpingMomentMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcAmountOfSubstanceMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcAreaMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcComplexNumber) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcContextDependentMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcCountMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcDescriptiveMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcElectricCurrentMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLengthMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLuminousIntensityMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcMassMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcNonNegativeLengthMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcNormalisedRatioMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcNumericMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcParameterValue) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPlaneAngleMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPositiveLengthMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPositiveRatioMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcRatioMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcSolidAngleMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcTimeMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcVolumeMeasure) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcBoolean) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.DateTimeResource.IfcDate) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.DateTimeResource.IfcDateTime) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.DateTimeResource.IfcDuration) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcIdentifier) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcInteger) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLabel) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcLogical) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcPositiveInteger) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcReal) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcText) 
				{
					DataValue = new MeasureResource.IfcText((Ifc4.MeasureResource.IfcText)value);
					if (_dataValue4 != null)
						SetValue(v => _dataValue4 = v, _dataValue4, null, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.DateTimeResource.IfcTime) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				if (value is Ifc4.DateTimeResource.IfcTimeStamp) 
				{
					if (DataValue != null)
						DataValue = null;
					SetValue(v => _dataValue4 = v, _dataValue4, value, "DataValue", byte.MaxValue);
					return;
				}
				
			}
		}

		private  IIfcReference _referencePath;

		IIfcReference IIfcMetric.ReferencePath 
		{ 
			get
			{
				return _referencePath;
			} 
			set
			{
				SetValue(v => _referencePath = v, _referencePath, value, "ReferencePath", byte.MaxValue);
				
			}
		}
	//## Custom code
	//##
	}
}
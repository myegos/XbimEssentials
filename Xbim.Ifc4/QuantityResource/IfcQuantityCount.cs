// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.QuantityResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcQuantityCount
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcQuantityCount : IIfcPhysicalSimpleQuantity
	{
		IfcCountMeasure @CountValue { get;  set; }
		IfcLabel? @Formula { get;  set; }
	
	}
}

namespace Xbim.Ifc4.QuantityResource
{
	[ExpressType("IfcQuantityCount", 457)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityCount : IfcPhysicalSimpleQuantity, IInstantiableEntity, IIfcQuantityCount, IContainsEntityReferences, IEquatable<@IfcQuantityCount>
	{
		#region IIfcQuantityCount explicit implementation
		IfcCountMeasure IIfcQuantityCount.CountValue { 
 
			get { return @CountValue; } 
			set { CountValue = value;}
		}	
		IfcLabel? IIfcQuantityCount.Formula { 
 
			get { return @Formula; } 
			set { Formula = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityCount(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCountMeasure _countValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcCountMeasure @CountValue 
		{ 
			get 
			{
				if(_activated) return _countValue;
				Activate();
				return _countValue;
			} 
			set
			{
				SetValue( v =>  _countValue = v, _countValue, value,  "CountValue", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcLabel? @Formula 
		{ 
			get 
			{
				if(_activated) return _formula;
				Activate();
				return _formula;
			} 
			set
			{
				SetValue( v =>  _formula = v, _formula, value,  "Formula", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_countValue = value.NumberVal;
					return;
				case 4: 
					_formula = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityCount other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
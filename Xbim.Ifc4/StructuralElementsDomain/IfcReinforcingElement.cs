// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.SharedComponentElements;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.StructuralElementsDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcReinforcingElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcReinforcingElement : IIfcElementComponent
	{
		IfcLabel? @SteelGrade { get;  set; }
	
	}
}

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IfcReinforcingElement", 262)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcReinforcingElement : IfcElementComponent, IIfcReinforcingElement, IEquatable<@IfcReinforcingElement>
	{
		#region IIfcReinforcingElement explicit implementation
		IfcLabel? IIfcReinforcingElement.SteelGrade { 
 
			get { return @SteelGrade; } 
			set { SteelGrade = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcReinforcingElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _steelGrade;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 33)]
		public IfcLabel? @SteelGrade 
		{ 
			get 
			{
				if(_activated) return _steelGrade;
				Activate();
				return _steelGrade;
			} 
			set
			{
				SetValue( v =>  _steelGrade = v, _steelGrade, value,  "SteelGrade", 9);
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
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_steelGrade = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcReinforcingElement other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
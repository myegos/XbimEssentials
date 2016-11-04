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
using Xbim.Ifc4.StructuralLoadResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadConfiguration
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadConfiguration : IIfcStructuralLoad
	{
		IItemSet<IIfcStructuralLoadOrResult> @Values { get; }
		IItemSet<IItemSet<IfcLengthMeasure>> @Locations { get; }
	
	}
}

namespace Xbim.Ifc4.StructuralLoadResource
{
	[ExpressType("IfcStructuralLoadConfiguration", 1282)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadConfiguration : IfcStructuralLoad, IInstantiableEntity, IIfcStructuralLoadConfiguration, IContainsEntityReferences, IEquatable<@IfcStructuralLoadConfiguration>
	{
		#region IIfcStructuralLoadConfiguration explicit implementation
		IItemSet<IIfcStructuralLoadOrResult> IIfcStructuralLoadConfiguration.Values { 
			get { return new Common.Collections.ProxyItemSet<IfcStructuralLoadOrResult, IIfcStructuralLoadOrResult>( @Values); } 
		}	
		IItemSet<IItemSet<IfcLengthMeasure>> IIfcStructuralLoadConfiguration.Locations { 
			get { return @Locations; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadConfiguration(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_values = new ItemSet<IfcStructuralLoadOrResult>( this, 0,  2);
			_locations = new OptionalItemSet<IItemSet<IfcLengthMeasure>>( this, 0,  3);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcStructuralLoadOrResult> _values;
		private readonly OptionalItemSet<IItemSet<IfcLengthMeasure>> _locations;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 2)]
		public IItemSet<IfcStructuralLoadOrResult> @Values 
		{ 
			get 
			{
				if(_activated) return _values;
				Activate();
				return _values;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, 1, 2, 3)]
		public IOptionalItemSet<IItemSet<IfcLengthMeasure>> @Locations 
		{ 
			get 
			{
				if(_activated) return _locations;
				Activate();
				return _locations;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_values.InternalAdd((IfcStructuralLoadOrResult)value.EntityVal);
					return;
				case 2: 
					((ItemSet<IfcLengthMeasure>)_locations
						.InternalGetAt(nestedIndex[0]) )
						.InternalAdd((IfcLengthMeasure)(value.RealVal));
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadConfiguration other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Values)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.CostResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedFacilitiesElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAsset
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAsset : IIfcGroup
	{
		IfcIdentifier @AssetID { get;  set; }
		IIfcCostValue @OriginalValue { get;  set; }
		IIfcCostValue @CurrentValue { get;  set; }
		IIfcCostValue @TotalReplacementCost { get;  set; }
		IIfcActorSelect @Owner { get;  set; }
		IIfcActorSelect @User { get;  set; }
		IIfcPerson @ResponsiblePerson { get;  set; }
		IIfcCalendarDate @IncorporationDate { get;  set; }
		IIfcCostValue @DepreciatedValue { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[ExpressType("IfcAsset", 767)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAsset : IfcGroup, IInstantiableEntity, IIfcAsset, IContainsEntityReferences, IEquatable<@IfcAsset>
	{
		#region IIfcAsset explicit implementation
		IfcIdentifier IIfcAsset.AssetID { 
 
			get { return @AssetID; } 
			set { AssetID = value;}
		}	
		IIfcCostValue IIfcAsset.OriginalValue { 
 
 
			get { return @OriginalValue; } 
			set { OriginalValue = value as IfcCostValue;}
		}	
		IIfcCostValue IIfcAsset.CurrentValue { 
 
 
			get { return @CurrentValue; } 
			set { CurrentValue = value as IfcCostValue;}
		}	
		IIfcCostValue IIfcAsset.TotalReplacementCost { 
 
 
			get { return @TotalReplacementCost; } 
			set { TotalReplacementCost = value as IfcCostValue;}
		}	
		IIfcActorSelect IIfcAsset.Owner { 
 
 
			get { return @Owner; } 
			set { Owner = value as IfcActorSelect;}
		}	
		IIfcActorSelect IIfcAsset.User { 
 
 
			get { return @User; } 
			set { User = value as IfcActorSelect;}
		}	
		IIfcPerson IIfcAsset.ResponsiblePerson { 
 
 
			get { return @ResponsiblePerson; } 
			set { ResponsiblePerson = value as IfcPerson;}
		}	
		IIfcCalendarDate IIfcAsset.IncorporationDate { 
 
 
			get { return @IncorporationDate; } 
			set { IncorporationDate = value as IfcCalendarDate;}
		}	
		IIfcCostValue IIfcAsset.DepreciatedValue { 
 
 
			get { return @DepreciatedValue; } 
			set { DepreciatedValue = value as IfcCostValue;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAsset(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcIdentifier _assetID;
		private IfcCostValue _originalValue;
		private IfcCostValue _currentValue;
		private IfcCostValue _totalReplacementCost;
		private IfcActorSelect _owner;
		private IfcActorSelect _user;
		private IfcPerson _responsiblePerson;
		private IfcCalendarDate _incorporationDate;
		private IfcCostValue _depreciatedValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcIdentifier @AssetID 
		{ 
			get 
			{
				if(_activated) return _assetID;
				Activate();
				return _assetID;
			} 
			set
			{
				SetValue( v =>  _assetID = v, _assetID, value,  "AssetID", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 13)]
		public IfcCostValue @OriginalValue 
		{ 
			get 
			{
				if(_activated) return _originalValue;
				Activate();
				return _originalValue;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _originalValue = v, _originalValue, value,  "OriginalValue", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 14)]
		public IfcCostValue @CurrentValue 
		{ 
			get 
			{
				if(_activated) return _currentValue;
				Activate();
				return _currentValue;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _currentValue = v, _currentValue, value,  "CurrentValue", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 15)]
		public IfcCostValue @TotalReplacementCost 
		{ 
			get 
			{
				if(_activated) return _totalReplacementCost;
				Activate();
				return _totalReplacementCost;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _totalReplacementCost = v, _totalReplacementCost, value,  "TotalReplacementCost", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 16)]
		public IfcActorSelect @Owner 
		{ 
			get 
			{
				if(_activated) return _owner;
				Activate();
				return _owner;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _owner = v, _owner, value,  "Owner", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 17)]
		public IfcActorSelect @User 
		{ 
			get 
			{
				if(_activated) return _user;
				Activate();
				return _user;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _user = v, _user, value,  "User", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 18)]
		public IfcPerson @ResponsiblePerson 
		{ 
			get 
			{
				if(_activated) return _responsiblePerson;
				Activate();
				return _responsiblePerson;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _responsiblePerson = v, _responsiblePerson, value,  "ResponsiblePerson", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 19)]
		public IfcCalendarDate @IncorporationDate 
		{ 
			get 
			{
				if(_activated) return _incorporationDate;
				Activate();
				return _incorporationDate;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _incorporationDate = v, _incorporationDate, value,  "IncorporationDate", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public IfcCostValue @DepreciatedValue 
		{ 
			get 
			{
				if(_activated) return _depreciatedValue;
				Activate();
				return _depreciatedValue;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _depreciatedValue = v, _depreciatedValue, value,  "DepreciatedValue", 14);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_assetID = value.StringVal;
					return;
				case 6: 
					_originalValue = (IfcCostValue)(value.EntityVal);
					return;
				case 7: 
					_currentValue = (IfcCostValue)(value.EntityVal);
					return;
				case 8: 
					_totalReplacementCost = (IfcCostValue)(value.EntityVal);
					return;
				case 9: 
					_owner = (IfcActorSelect)(value.EntityVal);
					return;
				case 10: 
					_user = (IfcActorSelect)(value.EntityVal);
					return;
				case 11: 
					_responsiblePerson = (IfcPerson)(value.EntityVal);
					return;
				case 12: 
					_incorporationDate = (IfcCalendarDate)(value.EntityVal);
					return;
				case 13: 
					_depreciatedValue = (IfcCostValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAsset other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@OriginalValue != null)
					yield return @OriginalValue;
				if (@CurrentValue != null)
					yield return @CurrentValue;
				if (@TotalReplacementCost != null)
					yield return @TotalReplacementCost;
				if (@Owner != null)
					yield return @Owner;
				if (@User != null)
					yield return @User;
				if (@ResponsiblePerson != null)
					yield return @ResponsiblePerson;
				if (@IncorporationDate != null)
					yield return @IncorporationDate;
				if (@DepreciatedValue != null)
					yield return @DepreciatedValue;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
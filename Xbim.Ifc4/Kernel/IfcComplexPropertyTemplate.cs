// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcComplexPropertyTemplate
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcComplexPropertyTemplate : IIfcPropertyTemplate
	{
		IfcLabel? @UsageName { get;  set; }
		IfcComplexPropertyTemplateTypeEnum? @TemplateType { get;  set; }
		IItemSet<IIfcPropertyTemplate> @HasPropertyTemplates { get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcComplexPropertyTemplate", 1129)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcComplexPropertyTemplate : IfcPropertyTemplate, IInstantiableEntity, IIfcComplexPropertyTemplate, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcComplexPropertyTemplate>
	{
		#region IIfcComplexPropertyTemplate explicit implementation
		IfcLabel? IIfcComplexPropertyTemplate.UsageName { 
 
			get { return @UsageName; } 
			set { UsageName = value;}
		}	
		IfcComplexPropertyTemplateTypeEnum? IIfcComplexPropertyTemplate.TemplateType { 
 
			get { return @TemplateType; } 
			set { TemplateType = value;}
		}	
		IItemSet<IIfcPropertyTemplate> IIfcComplexPropertyTemplate.HasPropertyTemplates { 
			get { return new Common.Collections.ProxyItemSet<IfcPropertyTemplate, IIfcPropertyTemplate>( @HasPropertyTemplates); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcComplexPropertyTemplate(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_hasPropertyTemplates = new OptionalItemSet<IfcPropertyTemplate>( this, 0,  7);
		}

		#region Explicit attribute fields
		private IfcLabel? _usageName;
		private IfcComplexPropertyTemplateTypeEnum? _templateType;
		private readonly OptionalItemSet<IfcPropertyTemplate> _hasPropertyTemplates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcLabel? @UsageName 
		{ 
			get 
			{
				if(_activated) return _usageName;
				Activate();
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 10)]
		public IfcComplexPropertyTemplateTypeEnum? @TemplateType 
		{ 
			get 
			{
				if(_activated) return _templateType;
				Activate();
				return _templateType;
			} 
			set
			{
				SetValue( v =>  _templateType = v, _templateType, value,  "TemplateType", 6);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 11)]
		public IOptionalItemSet<IfcPropertyTemplate> @HasPropertyTemplates 
		{ 
			get 
			{
				if(_activated) return _hasPropertyTemplates;
				Activate();
				return _hasPropertyTemplates;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_usageName = value.StringVal;
					return;
				case 5: 
                    _templateType = (IfcComplexPropertyTemplateTypeEnum) System.Enum.Parse(typeof (IfcComplexPropertyTemplateTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					_hasPropertyTemplates.InternalAdd((IfcPropertyTemplate)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcComplexPropertyTemplate other)
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
				foreach(var entity in @HasPropertyTemplates)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasPropertyTemplates)
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
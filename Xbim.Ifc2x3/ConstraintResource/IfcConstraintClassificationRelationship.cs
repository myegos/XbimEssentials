// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConstraintClassificationRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConstraintClassificationRelationship : IPersistEntity
	{
		IIfcConstraint @ClassifiedConstraint { get;  set; }
		IItemSet<IIfcClassificationNotationSelect> @RelatedClassifications { get; }
	
	}
}

namespace Xbim.Ifc2x3.ConstraintResource
{
	[ExpressType("IfcConstraintClassificationRelationship", 274)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConstraintClassificationRelationship : PersistEntity, IInstantiableEntity, IIfcConstraintClassificationRelationship, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcConstraintClassificationRelationship>
	{
		#region IIfcConstraintClassificationRelationship explicit implementation
		IIfcConstraint IIfcConstraintClassificationRelationship.ClassifiedConstraint { 
 
 
			get { return @ClassifiedConstraint; } 
			set { ClassifiedConstraint = value as IfcConstraint;}
		}	
		IItemSet<IIfcClassificationNotationSelect> IIfcConstraintClassificationRelationship.RelatedClassifications { 
			get { return new Common.Collections.ProxyItemSet<IfcClassificationNotationSelect, IIfcClassificationNotationSelect>( @RelatedClassifications); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstraintClassificationRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedClassifications = new ItemSet<IfcClassificationNotationSelect>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcConstraint _classifiedConstraint;
		private readonly ItemSet<IfcClassificationNotationSelect> _relatedClassifications;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 1)]
		public IfcConstraint @ClassifiedConstraint 
		{ 
			get 
			{
				if(_activated) return _classifiedConstraint;
				Activate();
				return _classifiedConstraint;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _classifiedConstraint = v, _classifiedConstraint, value,  "ClassifiedConstraint", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 2)]
		public IItemSet<IfcClassificationNotationSelect> @RelatedClassifications 
		{ 
			get 
			{
				if(_activated) return _relatedClassifications;
				Activate();
				return _relatedClassifications;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_classifiedConstraint = (IfcConstraint)(value.EntityVal);
					return;
				case 1: 
					_relatedClassifications.InternalAdd((IfcClassificationNotationSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstraintClassificationRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ClassifiedConstraint != null)
					yield return @ClassifiedConstraint;
				foreach(var entity in @RelatedClassifications)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ClassifiedConstraint != null)
					yield return @ClassifiedConstraint;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
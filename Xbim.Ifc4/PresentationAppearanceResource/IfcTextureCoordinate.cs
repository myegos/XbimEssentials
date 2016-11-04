// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextureCoordinate
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextureCoordinate : IIfcPresentationItem
	{
		IItemSet<IIfcSurfaceTexture> @Maps { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcTextureCoordinate", 732)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTextureCoordinate : IfcPresentationItem, IIfcTextureCoordinate, IEquatable<@IfcTextureCoordinate>
	{
		#region IIfcTextureCoordinate explicit implementation
		IItemSet<IIfcSurfaceTexture> IIfcTextureCoordinate.Maps { 
			get { return new Common.Collections.ProxyItemSet<IfcSurfaceTexture, IIfcSurfaceTexture>( @Maps); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureCoordinate(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_maps = new ItemSet<IfcSurfaceTexture>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcSurfaceTexture> _maps;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 1)]
		public IItemSet<IfcSurfaceTexture> @Maps 
		{ 
			get 
			{
				if(_activated) return _maps;
				Activate();
				return _maps;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_maps.InternalAdd((IfcSurfaceTexture)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextureCoordinate other)
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
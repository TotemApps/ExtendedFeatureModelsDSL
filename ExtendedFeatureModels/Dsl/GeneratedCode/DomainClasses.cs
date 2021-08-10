﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace jsoto0025.SplModeling.ExtendedFeatureModels
{
	/// <summary>
	/// DomainClass FeatureModel
	/// The root in which all other elements are embedded. Appears as a diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModel.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModel.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("17da9d7d-9274-4d7c-b7ef-4486e7d0dae6")]
	public partial class FeatureModel : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// FeatureModel domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x17da9d7d, 0x9274, 0x4d7c, 0xb7, 0xef, 0x44, 0x86, 0xe7, 0xd0, 0xda, 0xe6);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public FeatureModel(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public FeatureModel(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Elements opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Elements.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Feature> Elements
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Feature>, Feature>(global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.FeatureModelDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = this.Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature sourceFeature1 = sourceElement as global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature;
			if (sourceFeature1 != null)
			{
				// Create link for path FeatureModelHasElements.Elements
				this.Elements.Add(sourceFeature1);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature sourceFeature1 = sourceElement as global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature;
			if (sourceFeature1 != null)
			{
				// Delete link for path FeatureModelHasElements.Elements
				
				foreach (DslModeling::ElementLink link in global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.GetLinks((global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModel)this, sourceFeature1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.FeatureModelDomainRoleId, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.ElementDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace jsoto0025.SplModeling.ExtendedFeatureModels
{
	/// <summary>
	/// DomainClass Feature
	/// Elements embedded in the model. Appear as boxes on the diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.Feature.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.Feature.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel))]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Name = {namePropertyStorage})")]
	[DslModeling::DomainObjectId("2851087b-0a0e-4f72-9e52-00bc96cb66db")]
	public partial class Feature : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Feature domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x2851087b, 0x0a0e, 0x4f72, 0x9e, 0x52, 0x00, 0xbc, 0x96, 0xcb, 0x66, 0xdb);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Feature(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Feature(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x162df1d4, 0xbffb, 0x4b42, 0x9f, 0xa0, 0x88, 0xde, 0x8b, 0xbb, 0x4c, 0x96);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for jsoto0025.SplModeling.ExtendedFeatureModels.Feature.Name
		/// </summary>
		[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.Feature/Name.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.Feature/Name.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("162df1d4-bffb-4b42-9fa0-88de8bbb4c96")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Feature.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<Feature, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Feature.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Feature.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(Feature element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Feature element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Root domain property code
		
		/// <summary>
		/// Root domain property Id.
		/// </summary>
		public static readonly global::System.Guid RootDomainPropertyId = new global::System.Guid(0x8a896153, 0xb6f1, 0x478b, 0xa4, 0xc9, 0x21, 0xc4, 0x68, 0xf9, 0x66, 0xe5);
		
		/// <summary>
		/// Storage for Root
		/// </summary>
		private global::System.Boolean rootPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of Root domain property.
		/// Description for jsoto0025.SplModeling.ExtendedFeatureModels.Feature.Root
		/// </summary>
		[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.Feature/Root.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.Feature/Root.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("8a896153-b6f1-478b-a4c9-21c468f966e5")]
		public global::System.Boolean Root
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return rootPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				RootPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Feature.Root domain property.
		/// </summary>
		internal sealed partial class RootPropertyHandler : DslModeling::DomainPropertyValueHandler<Feature, global::System.Boolean>
		{
			private RootPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Feature.Root domain property value handler.
			/// </summary>
			public static readonly RootPropertyHandler Instance = new RootPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Feature.Root domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return RootDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Feature element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.rootPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Feature element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.rootPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Selected domain property code
		
		/// <summary>
		/// Selected domain property Id.
		/// </summary>
		public static readonly global::System.Guid SelectedDomainPropertyId = new global::System.Guid(0x4f41fddc, 0xa8d9, 0x49a0, 0xa3, 0x73, 0x07, 0x63, 0xa2, 0x6a, 0x0f, 0xea);
		
		/// <summary>
		/// Storage for Selected
		/// </summary>
		private global::System.Boolean selectedPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of Selected domain property.
		/// Description for jsoto0025.SplModeling.ExtendedFeatureModels.Feature.Selected
		/// </summary>
		[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.Feature/Selected.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.Feature/Selected.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("4f41fddc-a8d9-49a0-a373-0763a26a0fea")]
		public global::System.Boolean Selected
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return selectedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SelectedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Feature.Selected domain property.
		/// </summary>
		internal sealed partial class SelectedPropertyHandler : DslModeling::DomainPropertyValueHandler<Feature, global::System.Boolean>
		{
			private SelectedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Feature.Selected domain property value handler.
			/// </summary>
			public static readonly SelectedPropertyHandler Instance = new SelectedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Feature.Selected domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SelectedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(Feature element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.selectedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Feature element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.selectedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region FeatureModel opposite domain role accessor
		/// <summary>
		/// Gets or sets FeatureModel.
		/// </summary>
		public virtual FeatureModel FeatureModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.ElementDomainRoleId) as FeatureModel;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.ElementDomainRoleId, value);
			}
		}
		#endregion
		#region Targets opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Targets.
		/// Description for
		/// jsoto0025.SplModeling.ExtendedFeatureModels.ExampleRelationship.Target
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Feature> Targets
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Feature>, Feature>(global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets.SourceDomainRoleId);
			}
		}
		#endregion
		#region Sources opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Sources.
		/// Description for
		/// jsoto0025.SplModeling.ExtendedFeatureModels.ExampleRelationship.Source
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Feature> Sources
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Feature>, Feature>(global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets.TargetDomainRoleId);
			}
		}
		#endregion
	}
}

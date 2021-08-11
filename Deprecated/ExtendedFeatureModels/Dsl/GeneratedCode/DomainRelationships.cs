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
	/// DomainRelationship FeatureModelHasElements
	/// Embedding relationship between the Model and Elements
	/// </summary>
	[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("77b84cc2-a136-4453-9ef3-ce1c79414763")]
	public partial class FeatureModelHasElements : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// FeatureModelHasElements domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x77b84cc2, 0xa136, 0x4453, 0x9e, 0xf3, 0xce, 0x1c, 0x79, 0x41, 0x47, 0x63);
	
				
		/// <summary>
		/// Constructor
		/// Creates a FeatureModelHasElements link in the same Partition as the given FeatureModel
		/// </summary>
		/// <param name="source">FeatureModel to use as the source of the relationship.</param>
		/// <param name="target">Feature to use as the target of the relationship.</param>
		public FeatureModelHasElements(FeatureModel source, Feature target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(FeatureModelHasElements.FeatureModelDomainRoleId, source), new DslModeling::RoleAssignment(FeatureModelHasElements.ElementDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FeatureModelHasElements(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FeatureModelHasElements(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FeatureModelHasElements(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FeatureModelHasElements(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region FeatureModel domain role code
		
		/// <summary>
		/// FeatureModel domain role Id.
		/// </summary>
		public static readonly global::System.Guid FeatureModelDomainRoleId = new global::System.Guid(0xebc5605d, 0x12cc, 0x4511, 0x80, 0x6a, 0x54, 0xac, 0xf9, 0x4c, 0x12, 0x30);
		
		/// <summary>
		/// DomainRole FeatureModel
		/// </summary>
		[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements/FeatureModel.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements/FeatureModel.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Elements", PropertyDisplayNameKey="jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements/FeatureModel.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("ebc5605d-12cc-4511-806a-54acf94c1230")]
		public virtual FeatureModel FeatureModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (FeatureModel)DslModeling::DomainRoleInfo.GetRolePlayer(this, FeatureModelDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, FeatureModelDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access FeatureModel of a Feature
		/// <summary>
		/// Gets FeatureModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static FeatureModel GetFeatureModel(Feature element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, ElementDomainRoleId) as FeatureModel;
		}
		
		/// <summary>
		/// Sets FeatureModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetFeatureModel(Feature element, FeatureModel newFeatureModel)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, ElementDomainRoleId, newFeatureModel);
		}
		#endregion
		#region Element domain role code
		
		/// <summary>
		/// Element domain role Id.
		/// </summary>
		public static readonly global::System.Guid ElementDomainRoleId = new global::System.Guid(0x616870ce, 0x947d, 0x44b1, 0xbe, 0xba, 0x86, 0xc5, 0x6a, 0xaf, 0x92, 0xe5);
		
		/// <summary>
		/// DomainRole Element
		/// </summary>
		[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements/Element.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements/Element.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "FeatureModel", PropertyDisplayNameKey="jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements/Element.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("616870ce-947d-44b1-beba-86c56aaf92e5")]
		public virtual Feature Element
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Feature)DslModeling::DomainRoleInfo.GetRolePlayer(this, ElementDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ElementDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Elements of a FeatureModel
		/// <summary>
		/// Gets a list of Elements.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<Feature> GetElements(FeatureModel element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<Feature>, Feature>(element, FeatureModelDomainRoleId);
		}
		#endregion
		#region FeatureModel link accessor
		/// <summary>
		/// Get the list of FeatureModelHasElements links to a FeatureModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements> GetLinksToElements ( global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModel featureModelInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements>(featureModelInstance, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.FeatureModelDomainRoleId);
		}
		#endregion
		#region Element link accessor
		/// <summary>
		/// Get the FeatureModelHasElements link to a Feature.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements GetLinkToFeatureModel (global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature elementInstance)
		{
			global::System.Collections.Generic.IList<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements>(elementInstance, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.ElementDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Element not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region FeatureModelHasElements instance accessors
		
		/// <summary>
		/// Get any FeatureModelHasElements links between a given FeatureModel and a Feature.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements> GetLinks( global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModel source, global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature target )
		{
			global::System.Collections.Generic.List<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements> outLinks = new global::System.Collections.Generic.List<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements>();
			global::System.Collections.Generic.IList<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements>(source, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.FeatureModelDomainRoleId);
			foreach ( global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one FeatureModelHasElements link between a given FeatureModeland a Feature.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements GetLink( global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModel source, global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature target )
		{
			global::System.Collections.Generic.IList<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements>(source, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements.FeatureModelDomainRoleId);
			foreach ( global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace jsoto0025.SplModeling.ExtendedFeatureModels
{
	/// <summary>
	/// DomainRelationship FeatureReferencesTargets
	/// Reference relationship between Elements.
	/// </summary>
	[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship()]
	[DslModeling::DomainObjectId("2b82ead4-1f7a-40d7-9fd9-7d5ff53ba244")]
	public partial class FeatureReferencesTargets : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// FeatureReferencesTargets domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x2b82ead4, 0x1f7a, 0x40d7, 0x9f, 0xd9, 0x7d, 0x5f, 0xf5, 0x3b, 0xa2, 0x44);
	
				
		/// <summary>
		/// Constructor
		/// Creates a FeatureReferencesTargets link in the same Partition as the given Feature
		/// </summary>
		/// <param name="source">Feature to use as the source of the relationship.</param>
		/// <param name="target">Feature to use as the target of the relationship.</param>
		public FeatureReferencesTargets(Feature source, Feature target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(FeatureReferencesTargets.SourceDomainRoleId, source), new DslModeling::RoleAssignment(FeatureReferencesTargets.TargetDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FeatureReferencesTargets(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FeatureReferencesTargets(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FeatureReferencesTargets(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FeatureReferencesTargets(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Source domain role code
		
		/// <summary>
		/// Source domain role Id.
		/// </summary>
		public static readonly global::System.Guid SourceDomainRoleId = new global::System.Guid(0x611ba003, 0x5df0, 0x4b91, 0xb3, 0x40, 0xb4, 0x06, 0x05, 0x4f, 0x76, 0x55);
		
		/// <summary>
		/// DomainRole Source
		/// Description for
		/// jsoto0025.SplModeling.ExtendedFeatureModels.ExampleRelationship.Target
		/// </summary>
		[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets/Source.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets/Source.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Targets", PropertyDisplayNameKey="jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets/Source.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("611ba003-5df0-4b91-b340-b406054f7655")]
		public virtual Feature Source
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Feature)DslModeling::DomainRoleInfo.GetRolePlayer(this, SourceDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, SourceDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Sources of a Feature
		/// <summary>
		/// Gets a list of Sources.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<Feature> GetSources(Feature element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<Feature>, Feature>(element, TargetDomainRoleId);
		}
		#endregion
		#region Target domain role code
		
		/// <summary>
		/// Target domain role Id.
		/// </summary>
		public static readonly global::System.Guid TargetDomainRoleId = new global::System.Guid(0x1ded0dc1, 0x4127, 0x4aef, 0xb2, 0xa7, 0x36, 0x77, 0xdb, 0x85, 0x6f, 0xc0);
		
		/// <summary>
		/// DomainRole Target
		/// Description for
		/// jsoto0025.SplModeling.ExtendedFeatureModels.ExampleRelationship.Source
		/// </summary>
		[DslDesign::DisplayNameResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets/Target.DisplayName", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets/Target.Description", typeof(global::jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDomainModel), "jsoto0025.SplModeling.ExtendedFeatureModels.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "Sources", PropertyDisplayNameKey="jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets/Target.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("1ded0dc1-4127-4aef-b2a7-3677db856fc0")]
		public virtual Feature Target
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Feature)DslModeling::DomainRoleInfo.GetRolePlayer(this, TargetDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TargetDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Targets of a Feature
		/// <summary>
		/// Gets a list of Targets.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<Feature> GetTargets(Feature element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<Feature>, Feature>(element, SourceDomainRoleId);
		}
		#endregion
		#region Source link accessor
		/// <summary>
		/// Get the list of FeatureReferencesTargets links to a Feature.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets> GetLinksToTargets ( global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature sourceInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets>(sourceInstance, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets.SourceDomainRoleId);
		}
		#endregion
		#region Target link accessor
		/// <summary>
		/// Get the list of FeatureReferencesTargets links to a Feature.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets> GetLinksToSources ( global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature targetInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets>(targetInstance, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets.TargetDomainRoleId);
		}
		#endregion
		#region FeatureReferencesTargets instance accessors
		
		/// <summary>
		/// Get any FeatureReferencesTargets links between a given Feature and a Feature.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets> GetLinks( global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature source, global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature target )
		{
			global::System.Collections.Generic.List<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets> outLinks = new global::System.Collections.Generic.List<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets>();
			global::System.Collections.Generic.IList<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets> links = DslModeling::DomainRoleInfo.GetElementLinks<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets>(source, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets.SourceDomainRoleId);
			foreach ( global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets link in links )
			{
				if ( target.Equals(link.Target) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one FeatureReferencesTargets link between a given Featureand a Feature.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets GetLink( global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature source, global::jsoto0025.SplModeling.ExtendedFeatureModels.Feature target )
		{
			global::System.Collections.Generic.IList<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets> links = DslModeling::DomainRoleInfo.GetElementLinks<global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets>(source, global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets.SourceDomainRoleId);
			foreach ( global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureReferencesTargets link in links )
			{
				if ( target.Equals(link.Target) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
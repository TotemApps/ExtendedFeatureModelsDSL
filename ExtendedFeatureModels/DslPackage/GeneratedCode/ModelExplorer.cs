﻿//------------------------------------------------------------------------------
// <auto-generated>
//	 This code was generated by a tool.
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace jsoto0025.SplModeling.ExtendedFeatureModels
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	internal partial class ExtendedFeatureModelsExplorer : ExtendedFeatureModelsExplorerBase
	{
		/// <summary>
		/// Constructs a new ExtendedFeatureModelsExplorer.
		/// </summary>
		public ExtendedFeatureModelsExplorer(global::System.IServiceProvider serviceProvider)
			: base(serviceProvider)
		{
		}
	}
	
	/// <summary>
	/// Control hosted in the ExtendedFeatureModelsExplorerToolWindow.
	/// </summary>
	internal abstract class ExtendedFeatureModelsExplorerBase : DslShell::ModelExplorerTreeContainer
	{
		/// <summary>
		/// Constructs a new ExtendedFeatureModelsExplorerBase.
		/// </summary>
		protected ExtendedFeatureModelsExplorerBase(global::System.IServiceProvider serviceProvider) : base(serviceProvider)
		{
			
		}
	
	
	
		/// <summary>
		/// Create IElementVisitor
		/// </summary>
		/// <returns>IElementVisitor</returns>
		protected override DslModeling::IElementVisitor CreateElementVisitor()
		{
			return new DslShell::ExplorerElementVisitor(this);
		}
	
		/// <summary>
		/// Specifies the context menu that should be shown for the model explorer.
		///</summary>
		protected override global::System.ComponentModel.Design.CommandID ContextMenuCommandId
		{
			get
			{
				return Constants.ExtendedFeatureModelsExplorerMenu;
			}
		}
		
		/// <summary>
		/// Returns the root elements domain class Id. The is the very top level tree node in the TreeView
		///</summary>
		protected override global::System.Guid RootElementDomainClassId
		{
			get { return global::jsoto0025.SplModeling.ExtendedFeatureModels.FeatureModel.DomainClassId; }
		}
		
		/// <summary>
		/// Returns the root elements to be displayed in the explorer.
		///</summary>
		protected override global::System.Collections.IList FindRootElements(DslModeling::Store store)
		{
			return store.ElementDirectory.FindElements( this.RootElementDomainClassId);
		}
	}
}
	



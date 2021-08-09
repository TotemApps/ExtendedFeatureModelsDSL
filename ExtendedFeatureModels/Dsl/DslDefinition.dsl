<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="277ca3f0-2605-4259-9b38-af0c37b33ba2" Description="Description for jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModels" Name="ExtendedFeatureModels" DisplayName="ExtendedFeatureModels" Namespace="jsoto0025.SplModeling.ExtendedFeatureModels" ProductName="SplModeling" CompanyName="jsoto0025" PackageGuid="8d70c3ad-35d9-4915-b68e-fcc543f64efa" PackageNamespace="jsoto0025.SplModeling.ExtendedFeatureModels" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="17da9d7d-9274-4d7c-b7ef-4486e7d0dae6" Description="The root in which all other elements are embedded. Appears as a diagram." Name="FeatureModel" DisplayName="Feature Model" Namespace="jsoto0025.SplModeling.ExtendedFeatureModels">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Notes>Creates an embedding link when an element is dropped onto a model. </Notes>
          <Index>
            <DomainClassMoniker Name="Feature" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>FeatureModelHasElements.Elements</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="2851087b-0a0e-4f72-9e52-00bc96cb66db" Description="Elements embedded in the model. Appear as boxes on the diagram." Name="Feature" DisplayName="Feature" Namespace="jsoto0025.SplModeling.ExtendedFeatureModels">
      <Properties>
        <DomainProperty Id="162df1d4-bffb-4b42-9fa0-88de8bbb4c96" Description="Description for jsoto0025.SplModeling.ExtendedFeatureModels.Feature.Name" Name="Name" DisplayName="Name" DefaultValue="" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="8a896153-b6f1-478b-a4c9-21c468f966e5" Description="Description for jsoto0025.SplModeling.ExtendedFeatureModels.Feature.Is Root" Name="IsRoot" DisplayName="Is Root" DefaultValue="False">
          <Notes>Indicates if the Feature is the root of the model</Notes>
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="4f41fddc-a8d9-49a0-a373-0763a26a0fea" Description="Description for jsoto0025.SplModeling.ExtendedFeatureModels.Feature.Selected" Name="Selected" DisplayName="Selected" DefaultValue="">
          <Type>
            <ExternalTypeMoniker Name="/System/Boolean" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="77b84cc2-a136-4453-9ef3-ce1c79414763" Description="Embedding relationship between the Model and Elements" Name="FeatureModelHasElements" DisplayName="Feature Model Has Elements" Namespace="jsoto0025.SplModeling.ExtendedFeatureModels" IsEmbedding="true">
      <Source>
        <DomainRole Id="ebc5605d-12cc-4511-806a-54acf94c1230" Description="" Name="FeatureModel" DisplayName="Feature Model" PropertyName="Elements" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Elements">
          <RolePlayer>
            <DomainClassMoniker Name="FeatureModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="616870ce-947d-44b1-beba-86c56aaf92e5" Description="" Name="Element" DisplayName="Element" PropertyName="FeatureModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Feature Model">
          <RolePlayer>
            <DomainClassMoniker Name="Feature" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="2b82ead4-1f7a-40d7-9fd9-7d5ff53ba244" Description="Reference relationship between Elements." Name="FeatureReferencesTargets" DisplayName="Feature References Targets" Namespace="jsoto0025.SplModeling.ExtendedFeatureModels">
      <Source>
        <DomainRole Id="611ba003-5df0-4b91-b340-b406054f7655" Description="Description for jsoto0025.SplModeling.ExtendedFeatureModels.ExampleRelationship.Target" Name="Source" DisplayName="Source" PropertyName="Targets" PropertyDisplayName="Targets">
          <RolePlayer>
            <DomainClassMoniker Name="Feature" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="1ded0dc1-4127-4aef-b2a7-3677db856fc0" Description="Description for jsoto0025.SplModeling.ExtendedFeatureModels.ExampleRelationship.Source" Name="Target" DisplayName="Target" PropertyName="Sources" PropertyDisplayName="Sources">
          <RolePlayer>
            <DomainClassMoniker Name="Feature" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
  </Types>
  <Shapes>
    <GeometryShape Id="2729ba7b-8fee-4601-8824-4ecd89afbf5e" Description="Shape used to represent ExampleElements on a Diagram." Name="FeatureShape" DisplayName="Feature" Namespace="jsoto0025.SplModeling.ExtendedFeatureModels" FixedTooltipText="Feature" FillColor="242, 239, 229" OutlineColor="113, 111, 110" InitialWidth="2" InitialHeight="0.75" OutlineThickness="0.01" Geometry="Rectangle">
      <Notes>The shape has a text decorator used to display the Name property of the mapped ExampleElement.</Notes>
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <IconDecorator Name="SelectedDecorator" DisplayName="Selected Decorator" DefaultIcon="D:\datos\Creative Cloud Files\VariamosExtended\Feature Models\32w\SelectedIcon.png" />
      </ShapeHasDecorators>
    </GeometryShape>
  </Shapes>
  <Connectors>
    <Connector Id="a17331ca-2130-4ee4-8443-fe53f5c4554b" Description="Connector between the ExampleShapes. Represents ExampleRelationships on the Diagram." Name="FeatureConnector" DisplayName="Feature Connector" Namespace="jsoto0025.SplModeling.ExtendedFeatureModels" FixedTooltipText="Feature Connector" Color="113, 111, 110" TargetEndStyle="EmptyArrow" Thickness="0.01" RoutingStyle="Straight" />
  </Connectors>
  <XmlSerializationBehavior Name="ExtendedFeatureModelsSerializationBehavior" Namespace="jsoto0025.SplModeling.ExtendedFeatureModels">
    <ClassData>
      <XmlClassData TypeName="FeatureModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="featureModelMoniker" ElementName="featureModel" MonikerTypeName="FeatureModelMoniker">
        <DomainClassMoniker Name="FeatureModel" />
        <ElementData>
          <XmlRelationshipData RoleElementName="elements">
            <DomainRelationshipMoniker Name="FeatureModelHasElements" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Feature" MonikerAttributeName="name" SerializeId="true" MonikerElementName="featureMoniker" ElementName="feature" MonikerTypeName="FeatureMoniker">
        <DomainClassMoniker Name="Feature" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="Feature/Name" />
          </XmlPropertyData>
          <XmlRelationshipData RoleElementName="targets">
            <DomainRelationshipMoniker Name="FeatureReferencesTargets" />
          </XmlRelationshipData>
          <XmlPropertyData XmlName="isRoot">
            <DomainPropertyMoniker Name="Feature/IsRoot" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="selected">
            <DomainPropertyMoniker Name="Feature/Selected" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="FeatureModelHasElements" MonikerAttributeName="" SerializeId="true" MonikerElementName="featureModelHasElementsMoniker" ElementName="featureModelHasElements" MonikerTypeName="FeatureModelHasElementsMoniker">
        <DomainRelationshipMoniker Name="FeatureModelHasElements" />
      </XmlClassData>
      <XmlClassData TypeName="FeatureReferencesTargets" MonikerAttributeName="" SerializeId="true" MonikerElementName="featureReferencesTargetsMoniker" ElementName="featureReferencesTargets" MonikerTypeName="FeatureReferencesTargetsMoniker">
        <DomainRelationshipMoniker Name="FeatureReferencesTargets" />
      </XmlClassData>
      <XmlClassData TypeName="FeatureShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="featureShapeMoniker" ElementName="featureShape" MonikerTypeName="FeatureShapeMoniker">
        <GeometryShapeMoniker Name="FeatureShape" />
      </XmlClassData>
      <XmlClassData TypeName="FeatureConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="featureConnectorMoniker" ElementName="featureConnector" MonikerTypeName="FeatureConnectorMoniker">
        <ConnectorMoniker Name="FeatureConnector" />
      </XmlClassData>
      <XmlClassData TypeName="ExtendedFeatureModelsDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="extendedFeatureModelsDiagramMoniker" ElementName="extendedFeatureModelsDiagram" MonikerTypeName="ExtendedFeatureModelsDiagramMoniker">
        <DiagramMoniker Name="ExtendedFeatureModelsDiagram" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="ExtendedFeatureModelsExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="FeatureReferencesTargetsBuilder">
      <Notes>Provides for the creation of an ExampleRelationship by pointing at two ExampleElements.</Notes>
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="FeatureReferencesTargets" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Feature" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Feature" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="ff6521fb-205b-484d-885f-6680a3b7837f" Description="Description for jsoto0025.SplModeling.ExtendedFeatureModels.ExtendedFeatureModelsDiagram" Name="ExtendedFeatureModelsDiagram" DisplayName="Minimal Language Diagram" Namespace="jsoto0025.SplModeling.ExtendedFeatureModels">
    <Class>
      <DomainClassMoniker Name="FeatureModel" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Feature" />
        <ParentElementPath>
          <DomainPath>FeatureModelHasElements.FeatureModel/!FeatureModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="FeatureShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Feature/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <IconDecoratorMoniker Name="FeatureShape/SelectedDecorator" />
          <VisibilityPropertyPath>
            <DomainPropertyMoniker Name="Feature/Selected" />
          </VisibilityPropertyPath>
        </DecoratorMap>
        <GeometryShapeMoniker Name="FeatureShape" />
      </ShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="FeatureConnector" />
        <DomainRelationshipMoniker Name="FeatureReferencesTargets" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="ExtendedFeatureModels" EditorGuid="db9e1501-c654-40e6-973a-45063ddc174d">
    <RootClass>
      <DomainClassMoniker Name="FeatureModel" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="ExtendedFeatureModelsSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="ExtendedFeatureModels">
      <ElementTool Name="FeatureElement" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="Feature" Tooltip="Create an ExampleElement" HelpKeyword="CreateExampleClassF1Keyword">
        <DomainClassMoniker Name="Feature" />
      </ElementTool>
      <ConnectionTool Name="FeatureRelationship" ToolboxIcon="resources\exampleconnectortoolbitmap.bmp" Caption="Feature Relationship" Tooltip="Drag between ExampleElements to create an ExampleRelationship" HelpKeyword="ConnectExampleRelationF1Keyword">
        <ConnectionBuilderMoniker Name="ExtendedFeatureModels/FeatureReferencesTargetsBuilder" />
      </ConnectionTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="ExtendedFeatureModelsDiagram" />
  </Designer>
  <Explorer ExplorerGuid="51a19043-282b-4f9d-a7b9-d687e176fa7f" Title="ExtendedFeatureModels Explorer">
    <ExplorerBehaviorMoniker Name="ExtendedFeatureModels/ExtendedFeatureModelsExplorer" />
  </Explorer>
</Dsl>
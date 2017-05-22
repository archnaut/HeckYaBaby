﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by SpecFlow (http://www.specflow.org/).
'     SpecFlow Version:2.1.0.0
'     SpecFlow Generator Version:2.0.0.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
#Region "Designer generated code"
'#pragma warning disable
Imports TechTalk.SpecFlow

Namespace Tests.Acceptance
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0"),  _
     System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Partial Public Class BrowseProfilesFeature
        Implements Xunit.IClassFixture(Of BrowseProfilesFeature.FixtureData), System.IDisposable
        
        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner
        
#ExternalSource("BrowseProfiles.feature",1)
#End ExternalSource
        
        Public Sub New()
            MyBase.New
            Me.TestInitialize
        End Sub
        
        Public Shared Sub FeatureSetup()
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner
            Dim featureInfo As TechTalk.SpecFlow.FeatureInfo = New TechTalk.SpecFlow.FeatureInfo(New System.Globalization.CultureInfo("en-US"), "BrowseProfiles", ""&Global.Microsoft.VisualBasic.ChrW(9)&"In order to ensure Profiles accuracy"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"As a HeckYaBaby Administrator"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(9)&"I want to"& _ 
                    " be create, read, update and delete Profiles ", ProgrammingLanguage.VB, CType(Nothing,String()))
            testRunner.OnFeatureStart(featureInfo)
        End Sub
        
        Public Shared Sub FeatureTearDown()
            testRunner.OnFeatureEnd
            testRunner = Nothing
        End Sub
        
        Public Overridable Sub TestInitialize()
        End Sub
        
        Public Overridable Sub ScenarioTearDown()
            testRunner.OnScenarioEnd
        End Sub
        
        Public Overridable Sub ScenarioSetup(ByVal scenarioInfo As TechTalk.SpecFlow.ScenarioInfo)
            testRunner.OnScenarioStart(scenarioInfo)
        End Sub
        
        Public Overridable Sub ScenarioCleanup()
            testRunner.CollectScenarioErrors
        End Sub
        
        Sub System_IDisposable_Dispose() Implements System.IDisposable.Dispose
            Me.ScenarioTearDown
        End Sub
        
        <Xunit.FactAttribute(DisplayName:="Browse Profile"),  _
         Xunit.TraitAttribute("FeatureTitle", "BrowseProfiles"),  _
         Xunit.TraitAttribute("Description", "Browse Profile"),  _
         Xunit.TraitAttribute("Category", "mytag")>  _
        Public Overridable Sub BrowseProfile()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Browse Profile", New String() {"mytag"})
#ExternalSource("BrowseProfiles.feature",7)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("BrowseProfiles.feature",8)
 testRunner.Given("an existing 100 Profiles", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("BrowseProfiles.feature",9)
 testRunner.When("I open the Profile console", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("BrowseProfiles.feature",10)
 testRunner.Then("I will be present 10 pages of Profiles", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
#ExternalSource("BrowseProfiles.feature",11)
 testRunner.And("each page will have 10 profiles", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
            Dim table1 As TechTalk.SpecFlow.Table = New TechTalk.SpecFlow.Table(New String() {"Property"})
            table1.AddRow(New String() {"Name"})
            table1.AddRow(New String() {"Address"})
            table1.AddRow(New String() {"Phone Number"})
            table1.AddRow(New String() {"Date of Birth"})
            table1.AddRow(New String() {"Number of Friends"})
#ExternalSource("BrowseProfiles.feature",12)
 testRunner.And("each Profile will have", CType(Nothing,String), table1, "And ")
#End ExternalSource
#ExternalSource("BrowseProfiles.feature",19)
 testRunner.And("I can add Profiles", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("BrowseProfiles.feature",20)
 testRunner.And("I can edit Profiles", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("BrowseProfiles.feature",21)
 testRunner.And("I can delete Profiles", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0"),  _
         System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
        Public Class FixtureData
            Implements System.IDisposable
            
            Public Sub New()
                MyBase.New
                BrowseProfilesFeature.FeatureSetup
            End Sub
            
            Sub System_IDisposable_Dispose() Implements System.IDisposable.Dispose
                BrowseProfilesFeature.FeatureTearDown
            End Sub
        End Class
    End Class
End Namespace
'#pragma warning restore
#End Region

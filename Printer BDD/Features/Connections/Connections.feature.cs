﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Printer_BDD.Features.Connections
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Connections", Description="\tThis file tests the Printer\'s connections", SourceFile="Features\\Connections\\Connections.feature", SourceLine=0)]
    public partial class ConnectionsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Connections.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Connections", "Connections", "\tThis file tests the Printer\'s connections", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void PrintASheetUsingDifferentConnections(string connection, string action, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "NF004",
                    "NF",
                    "Connections",
                    "TC-0001"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("connection", connection);
            argumentsOfScenario.Add("action", action);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Print a sheet using different connections", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
 testRunner.Given("the Printer is ready for use", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.And(string.Format("the Printer is connected through {0}", connection), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.When("the user sends a print job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then(string.Format("the sheet {0} be printed", action), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Print a sheet using different connections, USB", new string[] {
                "NF004",
                "NF",
                "Connections",
                "TC-0001"}, SourceLine=15)]
        public virtual void PrintASheetUsingDifferentConnections_USB()
        {
#line 8
this.PrintASheetUsingDifferentConnections("USB", "should", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Print a sheet using different connections, Network", new string[] {
                "NF004",
                "NF",
                "Connections",
                "TC-0001"}, SourceLine=15)]
        public virtual void PrintASheetUsingDifferentConnections_Network()
        {
#line 8
this.PrintASheetUsingDifferentConnections("Network", "should", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Print a sheet using different connections, Wireless", new string[] {
                "NF004",
                "NF",
                "Connections",
                "TC-0001"}, SourceLine=15)]
        public virtual void PrintASheetUsingDifferentConnections_Wireless()
        {
#line 8
this.PrintASheetUsingDifferentConnections("Wireless", "should", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Print a sheet using different connections, no connection", new string[] {
                "NF004",
                "NF",
                "Connections",
                "TC-0001"}, SourceLine=15)]
        public virtual void PrintASheetUsingDifferentConnections_NoConnection()
        {
#line 8
this.PrintASheetUsingDifferentConnections("no connection", "should not", ((string[])(null)));
#line hidden
        }
        
        public virtual void PrintASheetUsingPcsConnectedInAWiredNetwork(string connection, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RF002",
                    "RF",
                    "Connections",
                    "TC-0004"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("connection", connection);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Print a sheet using pcs connected in a wired network", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 26
 testRunner.Given("the Printer is ready for use", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 27
 testRunner.And(string.Format("the Printer is connected through {0}", connection), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.When("the user1 sends a print job from pc1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.And("the user2 sends a print job from pc2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.Then("both jobs should be printed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Print a sheet using pcs connected in a wired network, Network", new string[] {
                "RF002",
                "RF",
                "Connections",
                "TC-0004"}, SourceLine=33)]
        public virtual void PrintASheetUsingPcsConnectedInAWiredNetwork_Network()
        {
#line 25
this.PrintASheetUsingPcsConnectedInAWiredNetwork("Network", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Print a sheet using pcs connected in a wired network, Wireless", new string[] {
                "RF002",
                "RF",
                "Connections",
                "TC-0004"}, SourceLine=33)]
        public virtual void PrintASheetUsingPcsConnectedInAWiredNetwork_Wireless()
        {
#line 25
this.PrintASheetUsingPcsConnectedInAWiredNetwork("Wireless", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion

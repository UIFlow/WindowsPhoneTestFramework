// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18033
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitConverter.Spec
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Beyond Distance and Temperature")]
    public partial class BeyondDistanceAndTemperatureFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "OtherConversions.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Beyond Distance and Temperature", "In order to use the converter appliction\r\nAs a WP7 user\r\nI want to convert Speed," +
                    " Time, Volume, Angle, Weight, Area", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change to Speed")]
        public virtual void ICanChangeToSpeed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can change to Speed", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("my app is clean installed and running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.And("I see the control \"textBlockCategory\" has value \"LENGTH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("I press the control \"btnKeypadKey2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("I press the control \"btnKeypadKey4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "textBlockCategory",
                        "LENGTH"});
            table1.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Inches"});
            table1.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Feet"});
            table1.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table1.AddRow(new string[] {
                        "textBlockResultValue",
                        "2"});
#line 12
 testRunner.And("I see the values", ((string)(null)), table1, "And ");
#line 19
 testRunner.Then("I press the control \"btnConversions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.Then("I wait for the control \"pivot\" to appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("I tap in the middle of the control \"From:Units_Speed_MilesPerHour\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.Then("I tap in the middle of the control \"To:Units_Speed_KilometerPerHour\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.Then("I press the control \"buttonDone\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "textBlockCategory",
                        "SPEED"});
            table2.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table2.AddRow(new string[] {
                        "textBlockResultValue",
                        "38.624256"});
            table2.AddRow(new string[] {
                        "textBlockInputUnit",
                        "MPH"});
            table2.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Km/H"});
#line 35
 testRunner.And("I see the values", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change to Time")]
        public virtual void ICanChangeToTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can change to Time", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
 testRunner.Given("my app is clean installed and running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.And("I see the control \"textBlockCategory\" has value \"LENGTH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.Then("I press the control \"btnKeypadKey2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("I press the control \"btnKeypadKey4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "textBlockCategory",
                        "LENGTH"});
            table3.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Inches"});
            table3.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Feet"});
            table3.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table3.AddRow(new string[] {
                        "textBlockResultValue",
                        "2"});
#line 50
 testRunner.And("I see the values", ((string)(null)), table3, "And ");
#line 57
 testRunner.Then("I press the control \"btnConversions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.Then("I wait for the control \"pivot\" to appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.Then("I tap in the middle of the control \"From:Units_Time_Hours\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.Then("I tap in the middle of the control \"To:Units_Time_Seconds\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
 testRunner.Then("I press the control \"buttonDone\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "textBlockCategory",
                        "TIME"});
            table4.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table4.AddRow(new string[] {
                        "textBlockResultValue",
                        "86400"});
            table4.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Hours"});
            table4.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Seconds"});
#line 76
 testRunner.And("I see the values", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change to Volume")]
        public virtual void ICanChangeToVolume()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can change to Volume", ((string[])(null)));
#line 85
this.ScenarioSetup(scenarioInfo);
#line 86
 testRunner.Given("my app is clean installed and running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 87
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.And("I see the control \"textBlockCategory\" has value \"LENGTH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.Then("I press the control \"btnKeypadKey2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.And("I press the control \"btnKeypadKey4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "textBlockCategory",
                        "LENGTH"});
            table5.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Inches"});
            table5.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Feet"});
            table5.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table5.AddRow(new string[] {
                        "textBlockResultValue",
                        "2"});
#line 91
 testRunner.And("I see the values", ((string)(null)), table5, "And ");
#line 98
 testRunner.Then("I press the control \"btnConversions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.Then("I wait for the control \"pivot\" to appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.Then("I tap in the middle of the control \"From:Units_Volume_Quarts\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
 testRunner.Then("I tap in the middle of the control \"To:Units_Volume_Liters\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 116
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
 testRunner.Then("I press the control \"buttonDone\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "textBlockCategory",
                        "VOLUME"});
            table6.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table6.AddRow(new string[] {
                        "textBlockResultValue",
                        "22.71247068"});
            table6.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Quarts"});
            table6.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Liters"});
#line 120
 testRunner.And("I see the values", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change to Angle")]
        public virtual void ICanChangeToAngle()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can change to Angle", ((string[])(null)));
#line 129
this.ScenarioSetup(scenarioInfo);
#line 130
 testRunner.Given("my app is clean installed and running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 131
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.And("I see the control \"textBlockCategory\" has value \"LENGTH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.Then("I press the control \"btnKeypadKey2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.And("I press the control \"btnKeypadKey4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "textBlockCategory",
                        "LENGTH"});
            table7.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Inches"});
            table7.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Feet"});
            table7.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table7.AddRow(new string[] {
                        "textBlockResultValue",
                        "2"});
#line 135
 testRunner.And("I see the values", ((string)(null)), table7, "And ");
#line 142
 testRunner.Then("I press the control \"btnConversions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 143
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 145
 testRunner.Then("I wait for the control \"pivot\" to appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 148
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 149
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 152
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 154
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 156
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 157
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 159
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 161
 testRunner.Then("I tap in the middle of the control \"From:Units_Angle_Radians\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
 testRunner.Then("I tap in the middle of the control \"To:Units_Angle_Degrees\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 164
 testRunner.Then("I press the control \"buttonDone\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 165
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 166
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table8.AddRow(new string[] {
                        "textBlockCategory",
                        "ANGLE"});
            table8.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table8.AddRow(new string[] {
                        "textBlockResultValue",
                        "1375.098708"});
            table8.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Radians"});
            table8.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Degrees"});
#line 167
 testRunner.And("I see the values", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change to Weight")]
        public virtual void ICanChangeToWeight()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can change to Weight", ((string[])(null)));
#line 177
this.ScenarioSetup(scenarioInfo);
#line 178
 testRunner.Given("my app is clean installed and running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 179
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 180
 testRunner.And("I see the control \"textBlockCategory\" has value \"LENGTH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.Then("I press the control \"btnKeypadKey2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 182
 testRunner.And("I press the control \"btnKeypadKey4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table9.AddRow(new string[] {
                        "textBlockCategory",
                        "LENGTH"});
            table9.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Inches"});
            table9.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Feet"});
            table9.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table9.AddRow(new string[] {
                        "textBlockResultValue",
                        "2"});
#line 183
 testRunner.And("I see the values", ((string)(null)), table9, "And ");
#line 190
 testRunner.Then("I press the control \"btnConversions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 191
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 192
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 193
 testRunner.Then("I wait for the control \"pivot\" to appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 194
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 195
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 196
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 197
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 198
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 200
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 201
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 202
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 203
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 204
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 205
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 206
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 207
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 208
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 209
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 210
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 211
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 212
 testRunner.Then("I tap in the middle of the control \"From:Units_Weight_MetricTons\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 213
 testRunner.Then("I tap in the middle of the control \"To:Units_Weight_Grams\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 214
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 215
 testRunner.Then("I press the control \"buttonDone\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 216
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 217
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table10.AddRow(new string[] {
                        "textBlockCategory",
                        "WEIGHT"});
            table10.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table10.AddRow(new string[] {
                        "textBlockResultValue",
                        "24000000.02"});
            table10.AddRow(new string[] {
                        "textBlockInputUnit",
                        "MTons"});
            table10.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Grams"});
#line 219
 testRunner.And("I see the values", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change to Area")]
        public virtual void ICanChangeToArea()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can change to Area", ((string[])(null)));
#line 227
this.ScenarioSetup(scenarioInfo);
#line 228
 testRunner.Given("my app is clean installed and running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 229
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 230
 testRunner.And("I see the control \"textBlockCategory\" has value \"LENGTH\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 231
 testRunner.Then("I press the control \"btnKeypadKey2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 232
 testRunner.And("I press the control \"btnKeypadKey4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table11.AddRow(new string[] {
                        "textBlockCategory",
                        "LENGTH"});
            table11.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Inches"});
            table11.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Feet"});
            table11.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table11.AddRow(new string[] {
                        "textBlockResultValue",
                        "2"});
#line 233
 testRunner.And("I see the values", ((string)(null)), table11, "And ");
#line 240
 testRunner.Then("I press the control \"btnConversions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 241
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 242
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 243
 testRunner.Then("I wait for the control \"pivot\" to appear", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 244
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 245
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 246
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 247
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 248
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 249
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 250
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 251
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 252
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 253
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 254
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 255
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 256
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 257
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 258
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 259
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 260
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 261
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 262
 testRunner.Then("I move the pivot right", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 263
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 264
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 265
 testRunner.Then("I tap in the middle of the control \"From:Units_Area_Acre\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 266
 testRunner.Then("I tap in the middle of the control \"To:Units_Area_SqMeter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 267
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 268
 testRunner.Then("I press the control \"buttonDone\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 269
 testRunner.Then("I wait 1 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 270
 testRunner.Then("take a picture", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table12.AddRow(new string[] {
                        "textBlockCategory",
                        "AREA"});
            table12.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table12.AddRow(new string[] {
                        "textBlockResultValue",
                        "97124.55443"});
            table12.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Acre"});
            table12.AddRow(new string[] {
                        "textBlockResultUnit",
                        "SqM"});
#line 272
 testRunner.And("I see the values", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using Serilog.Core;
using TechTalk.SpecFlow;


namespace ComprehensiveSpecflow.Hooks
{
    [Binding]
    public sealed class TideHooks
    {

        public static IWebDriver driver;
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static LoggingLevelSwitch loggingLevel;
        [BeforeScenario]
        public void OpenBrowser(ScenarioContext scenariocontext)
        {
            scenario = feature.CreateNode<Scenario>(scenariocontext.ScenarioInfo.Title);
            driver = new ChromeDriver();
            Serilog.Log.Information("selecting scenario {0} to run", scenariocontext.ScenarioInfo.Title);

        }
        [BeforeFeature]
        public static void FeatureBrowser(FeatureContext featurecontext)
        {
            feature = extents.CreateTest<Feature>(featurecontext.FeatureInfo.Title);
            Serilog.Log.Information("selecting Feature file {0} to run", featurecontext.FeatureInfo.Title);

        }
        [BeforeTestRun]
        public static void generateReport()
        {
            var htmlreport = new ExtentHtmlReporter(@"C:\Users\mindc1may214\source\repos\ComprehensiveSpecflow\report.html");
            htmlreport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extents = new ExtentReports();
            extents.AttachReporter(htmlreport);
            LoggingLevelSwitch loggingLevel = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration()
                                .MinimumLevel.ControlledBy(levelSwitch: loggingLevel)
                                .WriteTo.File(@"C:\Users\mindc1may214\source\repos\ComprehensiveSpecflow\logger.Log",
                                outputTemplate: "{TimeStamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message} {NewLine}",
                                rollingInterval: RollingInterval.Day).CreateLogger();

        }
        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenariocontext)
        {
            if (scenariocontext.TestError == null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            }
            if (scenariocontext.TestError != null)
            {
                
                Log.Error("Test step failed" + scenariocontext.TestError.Message);

                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
            }
        }
        [AfterTestRun]
        public static void CloseExtentReport()
        {
            extents.Flush();
        }

        [AfterScenario]
        public static void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
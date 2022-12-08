using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using BoDi;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using SpecFlowTestProject.Configuration;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Edge;
using WDSE;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;

[assembly:Parallelizable(ParallelScope.Fixtures)]
namespace SpecFlowTestProject.Hooks
{
    [Binding]
    public class Hooks1
    {
        public IWebDriver driver;
        public IObjectContainer objectcontainer;
        public ConfigurationAppsetting config;
        public static string filePath = Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "specflow.json";

        public Hooks1(IObjectContainer objectcontainer, ConfigurationAppsetting config)
        {
            this.objectcontainer = objectcontainer;
            this.config = config;
        }

        [BeforeScenario]
        public void FirstBeforeScenario()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(filePath);

            IConfigurationRoot configurationRoot = builder.Build();
            configurationRoot.Bind(config);

            if (config.BrowserType.ToLower() == "chrome") {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                objectcontainer.RegisterInstanceAs(driver);
            }
            else if (config.BrowserType.ToLower() == "firefox")
            {
                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
                objectcontainer.RegisterInstanceAs(driver);
            }
            else if(config.BrowserType.ToLower() == "edge")
            {
                driver = new EdgeDriver();
                driver.Manage().Window.Maximize();
                objectcontainer.RegisterInstanceAs(driver);
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //string timespan = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".png";
            //string methodName = NUnit.Framework.TestContext.CurrentContext.Test.Name;
            //VerticalCombineDecorator verticalCombineDecorator = new VerticalCombineDecorator(new ScreenshotMaker());
            //driver.TakeScreenshot(verticalCombineDecorator).ToMagickImage().Write("C:/Users/ksuresh/OneDrive - Sopra Steria/Pictures/Selenium Screenshot/" + methodName + timespan, ImageMagick.MagickFormat.Png);
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
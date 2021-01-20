// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class Test1Test
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        //driver = new EdgeDriver(".\\");
        driver = new FirefoxDriver(".\\");
        //driver = new InternetExplorerDriver();
        //driver = new ChromeDriver(".\\Driver");
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void test1()
    {
        driver.Navigate().GoToUrl("https://rapo-crp.sandbox.operations.dynamics.com/?cmp=DAT&mi=DefaultDashboard");
        driver.FindElement(By.Id("i0116")).SendKeys("tong.lianfang@cn.ricoh.com");
        try
        {
            Thread.Sleep(1000);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        driver.FindElement(By.Id("idSIButton9")).Click();
        try
        {
            Thread.Sleep(5000);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        driver.FindElement(By.CssSelector(".idp:nth-child(3)")).Click();
        try
        {
            Thread.Sleep(1000);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        driver.FindElement(By.Id("passwordInput")).SendKeys("lucysdk@1234");
        try
        {
            Thread.Sleep(1000);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        driver.FindElement(By.Id("submitButton")).Click();
        try
        {
            Thread.Sleep(3000);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        driver.FindElement(By.Id("idBtn_Back")).Click();
        try
        {
            Thread.Sleep(4000);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        driver.FindElement(By.Id("defaultdashboard_1_HcmRecruitmentWorkspace_text")).Click();
        try
        {
            Thread.Sleep(4000);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        driver.FindElement(By.Id("HcmRecruitmentWorkspace_2_NewRecrutingProject")).Click();
        try
        {
            Thread.Sleep(4000);
        }
        catch (Exception e)
        {
            Console.WriteLine("{0} Exception caught.", e);
        }
        driver.FindElement(By.Id("HRMRecruitingTable_4_RecruitmentProjectDetails_hrmRecruitingId_input")).SendKeys("Recruit3");
        driver.FindElement(By.Id("HRMRecruitingTable_4_RecruitmentProjectDetails_description_input")).SendKeys("test for recruitment");
        driver.FindElement(By.Id("HRMRecruitingTable_4_RecruitmentProjectDetails_Recruiter_DirPerson_FK_Name_input")).SendKeys("Tony Madigan");
        driver.FindElement(By.Id("HRMRecruitingTable_4_Organization_Department_Name_input")).SendKeys("Board Members");
        driver.FindElement(By.Id("HRMRecruitingTable_4_Organization_Job_JobId_input")).SendKeys("VP of Operations");

        driver.FindElement(By.Id("HRMRecruitingTable_4_Organization_qty_input")).Clear();
        driver.FindElement(By.Id("HRMRecruitingTable_4_Organization_qty_input")).SendKeys("1");

        driver.FindElement(By.Id("HRMRecruitingTable_4_ContactPersons_HiringManager_DirPerson_FK_Name_input")).SendKeys("Ted Howard");
        driver.FindElement(By.Id("HRMRecruitingTable_4_ContactPersons_AlternateWorkerContact_DirPerson_FK_Name_input")).SendKeys("Pierre Hezi");
        driver.FindElement(By.Id("HRMRecruitingTable_4_Dates_RequisitionApprovalDate_input")).SendKeys("1/18/2021");

        driver.FindElement(By.Id("HRMRecruitingTable_4_Dates_startDate_input")).Clear();
        driver.FindElement(By.Id("HRMRecruitingTable_4_Dates_startDate_input")).SendKeys("1/18/2021");

        driver.FindElement(By.Id("HRMRecruitingTable_4_Dates_finalDate_input")).Clear();
        driver.FindElement(By.Id("HRMRecruitingTable_4_Dates_finalDate_input")).SendKeys("1/29/2021");

        driver.FindElement(By.Id("HRMRecruitingTable_4_Dates_endDate_input")).Clear();
        driver.FindElement(By.Id("HRMRecruitingTable_4_Dates_endDate_input")).SendKeys("2/26/2021");

        driver.FindElement(By.Id("HRMRecruitingTable_4_Dates_EstimatedStartDate_input")).SendKeys("1/19/2021");

        driver.FindElement(By.Id("HRMRecruitingTable_4_SystemDefinedSaveButton")).Click();
        driver.FindElement(By.Id("HRMRecruitingTable_4_MenuButton_label")).Click();
        driver.FindElement(By.Id("HRMRecruitingTable_4_ctrlStatusStarted")).Click();

    }
}









//using NUnit.Framework;

//namespace Tests
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//        }

//        [Test]
//        public void Test1()
//        {
//            Assert.Pass();
//        }
//    }
//}

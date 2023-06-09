﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

public class SuiteTests { }

// 9 Mandatory Test Cases
[TestFixture]
public class MandatorySuiteTests
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;

    [SetUp]
    public void SetUp()
    {
        driver = new FirefoxDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }

    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void CarInsuranceQuote_AllValidInputs_VerifyAge25_DrivingExperience3_Accidents0()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("25"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("3"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("0"));
        }
    }

    [Test]
    public void CarInsuranceQuote_AllValidInputs_VerifyAge25_DrivingExperience3_Accidents4()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("25"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("3"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("4"));
        }
    }

    [Test]
    public void CarInsuranceQuote_AllValidInputs_VerifyAge35_DrivingExperience10_Accidents2()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("35"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("10"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("2"));
        }
    }

    [Test]
    public void CarInsuranceQuote_AgeOmittedRestAllValid_VerifyAgeError_DrivingExperience5_Accidents0()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));

        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("5"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("0"));
        }
    }

    [Test]
    public void CarInsuranceQuote_AtFaultAccidentsOmittedRestAllValid_VerifyAge37_DrivingExperience8_AccidentError()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).SendKeys("8");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("37"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("8"));
        }

        //Assert
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
    }

    [Test]
    public void CarInsuranceQuote_InvalidEmailAdressRestAllValid_VerifyAge28_DrivingExperience3_Accidents0_EmailError()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatkagmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));

        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("28"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("3"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("0"));
        }
    }

    [Test]
    public void CarInsuranceQuote_InvalidPhoneNumberRestAllValid_VerifyAge27_DrivingExperience3_Accidents0_PhoneNumberError()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("2269623970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));

        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("27"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("3"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("0"));
        }
    }

    [Test]
    public void CarInsuranceQuote_InvalidPostalCodeRestAllValid_VerifyAge35_DrivingExperience17_Accidents1_PostalCodeError()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));

        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("35"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("17"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("1"));
        }
    }

    [Test]
    public void CarInsuranceQuote_YearsOfDrivingOmittedRestAllValid_VerifyAge45_DrivingExperienceError_Accidents0()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("45"));
        }

        //Assert
        Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));

        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("0"));
        }
    }
}

// 6 Custom Test Cases
[TestFixture]
public class CustomSuiteTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;

    [SetUp]
    public void SetUp()
    {
        driver = new FirefoxDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }

    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void CarInsuranceQuote_OmittedPostalCodeRestAllValid_VerifyAge30_DrivingExperience17_Accidents1_PostalCodeError()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("30");
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code is required"));

        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("30"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("17"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("1"));
        }
    }

    [Test]
    public void CarInsuranceQuote_OmittedPhoneNumberRestAllValid_VerifyAge27_DrivingExperience5_Accidents0_PhoneNumberError()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number is required"));

        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("27"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("5"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("0"));
        }
    }

    [Test]
    public void CarInsuranceQuote_OmittedEmailAdressRestAllValid_VerifyAge28_DrivingExperience3_Accidents2_EmailError()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("email address is required"));

        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("28"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("3"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("2"));
        }
    }

    [Test]
    public void CarInsuranceQuote_AgeOutOfBoundsRestAllValid_VerifyAgeError_DrivingExperience5_Accidents2()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("12");
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();

        //Assert
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 16."));

        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("5"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("2"));
        }
    }

    [Test]
    public void CarInsuranceQuoteAt_FaultAccidentsNegativeRestAllValid_VerifyAge37_DrivingExperience4_AccidentsError()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("lastName")).SendKeys("Latka");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).SendKeys("4");
        driver.FindElement(By.Id("accidents")).SendKeys("-1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("37"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("4"));
        }

        //Assert
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Please enter a value greater than or equal to 0."));
    }

    [Test]
    public void CarInsuranceQuote_LastNameOmittedRestAllValid_VerifyAge45_Experience18_Accidents1_LastNameError()
    {
        //Arrange
        driver.Navigate().GoToUrl("http://localhost/prog2070a03/");
        driver.Manage().Window.Size = new System.Drawing.Size(810, 958);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.Id("firstName")).Click();
        driver.FindElement(By.Id("firstName")).SendKeys("Sebastian");
        driver.FindElement(By.Id("address")).SendKeys("29 Inverness Dr.");
        driver.FindElement(By.Id("city")).Click();
        driver.FindElement(By.Id("city")).SendKeys("Guelph");
        driver.FindElement(By.Id("postalCode")).Click();
        driver.FindElement(By.Id("postalCode")).SendKeys("N1E 3M1");
        driver.FindElement(By.Id("phone")).SendKeys("226-962-3970");
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("email")).SendKeys("sebastianlatka4@gmail.com");

        //Act
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("experience")).SendKeys("18");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("45"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("18"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");

            //Assert
            Assert.That(value, Is.EqualTo("1"));
        }

        //Assert
        Assert.That(driver.FindElement(By.Id("lastName-error")).Text, Is.EqualTo("Last Name is required"));
    }
}

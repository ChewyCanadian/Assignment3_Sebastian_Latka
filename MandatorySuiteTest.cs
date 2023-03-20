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
[TestFixture]
public class MandatorySuiteTest
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
    public void carInsuranceQuoteAllValidInputsVerifyAge25DrivingExperience3Accidents0()
    {
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
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("25"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("3"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("0"));
        }
    }
    [Test]
    public void carInsuranceQuoteAllValidInputsVerifyAge25DrivingExperience3Accidents4()
    {
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
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("25");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("4");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("25"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("3"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("4"));
        }
    }
    [Test]
    public void carInsuranceQuoteAllValidInputsVerifyAge35DrivingExperience10Accidents2()
    {
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
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("10");
        driver.FindElement(By.Id("accidents")).SendKeys("2");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("35"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("10"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("2"));
        }
    }
    [Test]
    public void carInsuranceQuoteAgeOmittedRestAllValidDrivingExperience5Accidents0()
    {
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
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("experience")).SendKeys("5");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("age-error")).Text, Is.EqualTo("Age (>=16) is required"));
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("5"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("0"));
        }
    }
    [Test]
    public void carInsuranceQuoteAtFaultAccidentsOmittedRestAllValidAge37DrivingExperience8()
    {
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
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("37");
        driver.FindElement(By.Id("experience")).SendKeys("8");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("37"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("8"));
        }
        Assert.That(driver.FindElement(By.Id("accidents-error")).Text, Is.EqualTo("Number of accidents is required"));
    }
    [Test]
    public void carInsuranceQuoteInvalidEmailAdressRestAllValidVerifyAge28DrivingExperience3Accidents0()
    {
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
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("28");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("28"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("3"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("0"));
        }
    }
    [Test]
    public void carInsuranceQuoteInvalidPhoneNumberRestAllValidVerifyAge27DrivingExperience3Accidents0()
    {
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
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("27");
        driver.FindElement(By.Id("experience")).SendKeys("3");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("27"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("3"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("0"));
        }
    }
    [Test]
    public void carInsuranceQuoteInvalidPostalCodeRestAllValidVerifyAge35DrivingExperience17Accidents1()
    {
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
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("35");
        driver.FindElement(By.Id("experience")).SendKeys("17");
        driver.FindElement(By.Id("accidents")).SendKeys("1");
        driver.FindElement(By.Id("btnSubmit")).Click();
        Assert.That(driver.FindElement(By.Id("postalCode-error")).Text, Is.EqualTo("Postal Code must follow the pattern A1A 1A1"));
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("35"));
        }
        {
            string value = driver.FindElement(By.Id("experience")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("17"));
        }
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("1"));
        }
    }
    [Test]
    public void carInsuranceQuoteYearsOfDrivingOmittedRestAllValidAge45Accidents0()
    {
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
        driver.FindElement(By.Id("age")).Click();
        driver.FindElement(By.Id("age")).SendKeys("45");
        driver.FindElement(By.Id("accidents")).SendKeys("0");
        driver.FindElement(By.Id("btnSubmit")).Click();
        {
            string value = driver.FindElement(By.Id("age")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("45"));
        }
        Assert.That(driver.FindElement(By.Id("experience-error")).Text, Is.EqualTo("Years of experience is required"));
        {
            string value = driver.FindElement(By.Id("accidents")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("0"));
        }
    }
}

﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.UI;
using System.Diagnostics;
using FakeHost;

namespace JoymonOnline.IntegrationTests
{
    [TestClass]
    public class Joymononline_Changelog :IntegrationTest
    {
        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the 
        ///current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        
        [HostType("ASP.NET")]
        [UrlToTest(Common.BaseUrl + "changelog.aspx")]
        public void WhenChangeLogPageIsRequested_TitleShouldBeProper()
        {
            Page page = TestContext.RequestedPage;
            Assert.IsTrue(page.Title.Equals("Joymononline | Changelog"));
        }
        [TestMethod]
        public void WhenChangeLogPageIsRequested_ShouldReturnWithProperTitle()
        {
            using (var browser = new Browser())
            {
                var result = browser.Get("/changelog.aspx");
                Assert.IsTrue(result.ResponseText.Contains("Joymon Online | Changelog"), "Default page is wrong");
            }
        }
    }
}

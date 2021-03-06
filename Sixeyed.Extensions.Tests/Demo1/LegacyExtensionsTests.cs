﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo1;

namespace Sixeyed.Extensions.Tests.Demo1
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class LegacyExtensionsTests
    {
        public LegacyExtensionsTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ToLegacyFormat_C20()
        {
            var dateTime = new DateTime(1020, 12, 31);
            Assert.AreEqual("0201231", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyFormat_C21()
        {
            var dateTime = new DateTime(2013, 10, 31);
            Assert.AreEqual("1131031", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyName()
        {
            var name = "Elton Stoneman";
            Assert.AreEqual("STONEMAN, ELTON", name.ToLegacyFormat());
        }

    }
}

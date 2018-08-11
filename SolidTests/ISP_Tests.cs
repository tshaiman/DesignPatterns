using InterfaceSegregation.Configuration1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTests
{

    [TestClass]
    public class AboutPageShould1
    {
        [TestMethod]
        public void DisplayApplicationName()
        {
            var aboutPage = new AboutPage(); // -- hard to TEST!  Need app.config set up just so.
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("Interface Segregation By Tomer Shaiman", output);
        }
    }

    [TestClass]
    public class AboutPageShould2
    {
        [TestMethod]
        public void DisplayApplicationNameFromFile()
        {
            // still works via file
            var aboutPage = new AboutPage(); // -- hard to TEST!  Need app.config set up just so.
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("Interface Segregation By Tomer Shaiman", output);
        }

        class Settings : IConfigurationSettings
        {
            public string ApplicationName
            {
                get { return "TEST APP NAME"; }
            }

            public string AuthorName
            {
                get { return "TEST AUTHOR NAME"; }
            }
            #region Not Implemented
            public int CacheDuration
            {
                get { throw new NotImplementedException(); }
            }

            public string DatabaseServerName
            {
                get { throw new NotImplementedException(); }
            }

            public string DatabaseName
            {
                get { throw new NotImplementedException(); }
            }

            public string DatabaseUserName
            {
                get { throw new NotImplementedException(); }
            }

            public string DatabasePassword
            {
                get { throw new NotImplementedException(); }
            }

            public string WebServiceBaseUri
            {
                get { throw new NotImplementedException(); }
            }
            #endregion
        }

        [TestMethod]
        public void DisplayApplicationNameNoFile()
        {
            // make it  works without app.config
            var aboutPage = new AboutPage();
            var textWriter = new StringWriter();
            aboutPage.Render(textWriter);

            var output = textWriter.ToString();

            Assert.AreEqual("TEST APP NAME By TEST AUTHOR NAME", output);
        }
    }
}

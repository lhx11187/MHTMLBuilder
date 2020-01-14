using System;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;

namespace MHTMLBuilder.Tests
{
    public class CoreUnitTests
    {
        private Builder MHTMLBuilder = new Builder();
        private String URL = "https://www.google.com";
        private String fileLocation = @"C:\temp\test.mht";

        [SetUp]
        public void Setup()
        {
            MHTMLBuilder.BrowserIdString = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.132 Safari/537.36";
        }

        [Test]
        public void SavePageArchive()
        {
            String path = String.Empty;

            try
            {
                path = MHTMLBuilder.SavePageArchive(fileLocation, Builder.FileStorage.DiskPermanent, URL);
                Assert.IsTrue(File.Exists(path));

            }
            catch (CustomException.BuilderInvalidFileNameException e)
            {
                Assert.Fail(e.CustomMessage);
            }
            catch (CustomException.BuilderDownLoadHTMLException e)
            {
                Assert.Fail(e.CustomMessage);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
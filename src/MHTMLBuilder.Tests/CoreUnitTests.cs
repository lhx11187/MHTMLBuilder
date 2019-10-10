using System;
using System.IO;
using NUnit.Framework;

namespace MHTMLBuilder.Tests
{
    public class CoreUnitTests
    {
        private Builder MHTMLBuilder = new Builder();
        private String URL = "https://www.google.com";
        private String fileLocation = "/tmp/test.mht";

        [SetUp]
        public void Setup()
        {
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
                Console.WriteLine("BuilderInvalidFileNameException is " + e.CustomMessage);
            }
            catch (CustomException.BuilderDownLoadHTMLException e)
            {
                Console.WriteLine("BuilderDownLoadHTMLException " + e.CustomMessage);
            }

            Assert.Pass();
        }
    }
}
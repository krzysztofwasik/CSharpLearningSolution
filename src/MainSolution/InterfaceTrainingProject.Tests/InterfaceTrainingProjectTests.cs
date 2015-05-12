using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InterfaceTrainingProject;
using InterfaceTrainingProject.Data.Test;
using System.IO;

namespace InterfaceTrainingProject.Tests
{
    [TestFixture]
    public class InterfaceTrainingProjectTests
    {
        /// <summary>
        /// This name in not following naming convention for NUnit framework
        /// </summary>
        [Test]
        public void DisplayFullList()
        {
            var testRepo = new TestUserRepository();
            var app = new HandyDandyApplication(testRepo);
            var data = string.Empty;

            using (var writer = new StringWriter())
            {
                app.DisplayUsers(writer);
                data = writer.ToString();
            }

            var lines = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            Assert.True(lines.Length == 3);

        }
    }
}

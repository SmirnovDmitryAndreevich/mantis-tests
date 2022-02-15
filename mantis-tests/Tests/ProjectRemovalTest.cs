﻿using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace mantis_tests
{
    [TestFixture]
    public class ProjectRemovalTests : TestBase
    {
        public static Random rnd = new Random();

        [Test]
        public void ProjectRemovalTest()
        {
            AccountData account = new AccountData("administrator", "root");

            ProjectData project = new ProjectData()
            {
                Name = $"TestToRemove {rnd.Next(0, 9999)}",
                Description = "Create Test Automatically",
            };

            application.Login.Login(account);
            application.Project.IsProjectPresent(project, account);

            application.Navigate.OpenProjectMenu();
            List<ProjectData> oldData = application.Project.GetProjectList(account);
            ProjectData projectToRemove = oldData[0];

            application.Project.Remove(account);

            List<ProjectData> newData = application.Project.GetProjectList(account);

            Assert.AreEqual(oldData.Count - 1, newData.Count);

            oldData.Remove(projectToRemove);

            oldData.Sort();
            newData.Sort();

            Assert.AreEqual(oldData, newData);
        }
    }
}
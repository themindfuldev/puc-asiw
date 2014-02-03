using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Domain.Model;
using Core.Domain.Repositories;
using Core;

namespace NHibernate101.Tests
{
    [TestClass]
    public class RepositoriesTest
    {


        public RepositoriesTest()
        {
        }

        private TestContext testContextInstance;

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


        [TestInitialize()]
        public void CreateRepositories()
        {
        }


        [TestMethod]
        [DeploymentItem("hibernate.cfg.xml")]
        public void CanCreateCategory()
        {


            Pessoa x = new Pessoa();
            x.Nome = "antonio";
       
            Factory.Save(x);


        }

        [TestMethod]
        [DeploymentItem("hibernate.cfg.xml")]
        public void CanCreatePost()
        {


        }
    }
}
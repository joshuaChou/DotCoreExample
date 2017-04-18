using System;
using Xunit;
using CoreMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace CoreMVC.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HomeController home = new HomeController();
            ViewResult result = home.About() as ViewResult;
            ViewDataDictionary data = result.ViewData;
            Assert.Equal("Your application description page.",data["Message"]);
        }
    }
}

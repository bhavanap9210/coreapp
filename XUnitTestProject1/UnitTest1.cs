using CoreApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var c = new HomeController();
            var res = c.Index();
            Assert.IsType(typeof(IActionResult), res);
        }
    }
}

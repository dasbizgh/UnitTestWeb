using System;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers;
using Xunit;

namespace Tests
{
    public class ControllerTests
    {
        [Fact]
        public void VerifyIndexViewType()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}

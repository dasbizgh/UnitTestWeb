using System;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers;
using Web.Models;
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

        [Fact]
        public void VerifyDetailsReturnsProduct()
        {
            var controller = new HomeController();
            var result = Assert.IsType<ViewResult>(controller.Details(1));
            var model = Assert.IsType<Product>(result.Model);
            Assert.Equal(2, model.ID);
        }
    }
}

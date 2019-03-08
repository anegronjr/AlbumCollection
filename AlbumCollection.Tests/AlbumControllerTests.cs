using AlbumCollection.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new AlbumController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

    }
}

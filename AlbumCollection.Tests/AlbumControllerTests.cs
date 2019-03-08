using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumControllerTests
    {
        AlbumController underTest;
        IAlbumRepository repo;

        public AlbumControllerTests()
        {
            repo = Substitute.For<IAlbumRepository>();
            underTest = new AlbumController(repo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Sets_Model_To_All_Albums()
        {
            var expectedModel = new List<Album>();
            repo.GetAll().Returns(expectedModel);
            var actualModel = underTest.Index().Model;

            Assert.Equal(expectedModel, actualModel);
        }

        [Fact]
        public void Details_Sets_Model_To_Correct_Album()
        {
            var expectedId = 1;
            var expectedModel = new Album();
            repo.GetById(expectedId).Returns(expectedModel);
            var actualModel = underTest.Details(expectedId).Model;

            Assert.Equal(expectedModel, actualModel);
        }
    }
}

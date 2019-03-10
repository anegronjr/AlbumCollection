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
    public class SongControllerTests
    {
        SongController underTest;
        ISongRepository repo;

        public SongControllerTests()
        {
            repo = Substitute.For<ISongRepository>();
            underTest = new SongController(repo);
        }

        [Fact]
        public void HttpGet_Create_Sets_Model_To_New_Song()
        {
            var expectedId = 1;
            var result = underTest.Create(expectedId).Model;

            Assert.IsType<Song>(result);
        }
    }
}

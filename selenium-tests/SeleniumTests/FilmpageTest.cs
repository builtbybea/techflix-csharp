using System;
using System.Reflection.Metadata;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class FilmpageTest
    {
        [Test]

        public void TestFilmPageLoadsAllData()
        {
            using var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:3000/films/299534");

            var filmPage = driver.FindElementByTestId("film-title");

            filmPage.Text.Should().Be("Avengers: Endgame");
        }

    }
}
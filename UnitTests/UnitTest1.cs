using HWUT.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        ProductModel model = new ProductModel();

        [TestMethod]
        public void Method_Condition_Configuration_Should_Result()
        {
            // Arrange
            
            // Act

            // Assert
        }
        [TestMethod]
        public void DefaultAverageRating_CreatingProduct_ShouldReturn5()
        {
            // Arrange
            int test = 5;
            int avg;
            // Act

            avg = model.AverageRating();


            // Assert

            Assert.AreEqual(test, avg);

        }
        [TestMethod]
        public void Id_WhenSettingID_IdSet()
        {

            string id = "123";

            model.Id = id;

            Assert.AreEqual(id, model.Id);
        }
        [TestMethod]
        public void Maker_SettingMaker_MakerSet()
        {
            //Arrange

            string maker = "defaultmaker";

            //Act
            model.Maker = maker;

            //Assert
            Assert.AreEqual(maker, model.Maker);
        }
        [TestMethod]
        public void Url_SettingUrl_UrlSet()
        {
            //Arrange

            string url = "www.testurl.com";

            //Act
            model.Url = url;

            //Assert
            Assert.AreEqual(url, model.Url);

        }
        [TestMethod]
        public void Image_SettingImage_Imageset()
        {
            //Arrange
            string image = "test_image";

            //Act
            model.Image = image;

            //Assert
            Assert.AreEqual(image, model.Image);
        }
        [TestMethod]
        public void Title_SettingTitle_TitleIsSet()
        {
            //Arrange
            string title = "Test Title";

            //Act
            model.Title = title;

            //Assert
            Assert.AreEqual(title, model.Title);

        }
        [TestMethod]
        public void Description_SettingDiscription_DescriptionisEqualToStringDescrption()
        {
            //Arrange
            string description = "This is my description";

            //Act
            model.Description = description;

            //Assert
            Assert.AreEqual(description, model.Description);

        }
        [TestMethod]
        public void Date_SettingTheDate_DateIsSet()
        {
            //Arrange
            var date = new DateTime(2008, 5, 1, 8, 30, 52);

            //Act
            model.Date = date;

            //Assert
            Assert.AreEqual(date, model.Date);
        }
        [TestMethod]
        public void Sequence_SettingTheSequence_SequenceEqualsStringSeq()
        {
            //Arrange
            string seq = "SE23";

            //Act
            model.Sequence = seq;

            //Assert
            Assert.AreEqual(seq, model.Sequence);
        }
        [TestMethod]
        public void Email_SettingTheEmail_EmailEqualsStringEmail()
        {
            // Arrange
            string email = "test@abc.com";

            // Act
            model.Email = email;

            // Assert
            Assert.AreEqual(email, model.Email);
        }
        [TestMethod]
        public void Logsitics_SettingLogistics_LogisticsShouldMatchStringLog()
        {
            // Arrange
            string log = "logs234!";
            // Act
            model.Logistics = log;

            // Assert
            Assert.AreEqual(log, model.Logistics);
        }
        [TestMethod]
        public void Ratings_RatingsSet()
        {
            // Arrange
            int[] rate = { 1, 2, 5 };

            // Act
            model.Ratings = rate;

            // Assert
            Assert.AreEqual(rate, model.Ratings);
        }

    }
}
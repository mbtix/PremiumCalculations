using CoreWebApplication.Controllers;
using CoreWebApplication.Model;
using CoreWebApplication.Services;
using NUnit.Framework;


namespace PremiumCalculationTests
{
    [TestFixture]
    public class PremiumService_IsPremiumCalculated
    {
        private IPremiumBAL _premiumBAL;
        [SetUp]
        public void SetUp()
        {
            _premiumBAL = new PremiumBAL();
        }

       
        [Test]
        public void Controller_PremiumCalculation_ShouldReturnPremium_GreaterThanZero()
        {
            //Arrange
            var controller = new PremiumCalculationController(_premiumBAL);
            var premiumVM = new PremiumVM();
            premiumVM.Age = 35;
            premiumVM.DeathInsured = 2000;
            premiumVM.FullName = "TestUser";
            premiumVM.Occupation = "WCL";

            //Act
            var response = controller.Post(premiumVM);

            //Assert
            Assert.IsNotNull(response);
            Assert.Greater(response, 0);

        }


        [Test]
        public void Controller_PremiumCalculation_IfAgeIsZero_ShouldReturnPremiumAsZero()
        {
            //Arrange
            var controller = new PremiumCalculationController(_premiumBAL);
          
            var premiumVM = new PremiumVM();
            premiumVM.Age = 0;
            premiumVM.DeathInsured = 2000;
            premiumVM.FullName = "TestUser";
            premiumVM.Occupation = "WCL";

            //Act
            var response = controller.Post(premiumVM);

            //Assert
            Assert.AreEqual(response, 0);


        }

        [Test]
        public void Controller_PremiumCalculation_IfDeathAssuredIsZero_ShouldReturnPremiumAsZero()
        {
            //Arrange
            var controller = new PremiumCalculationController(_premiumBAL);
           
            var premiumVM = new PremiumVM();
            premiumVM.Age = 25;
            premiumVM.DeathInsured = 0;
            premiumVM.FullName = "TestUser";
            premiumVM.Occupation = "WCL";

            //Act
            var response = controller.Post(premiumVM);

            //Assert
            Assert.AreEqual(response, 0);


        }

        [Test]
        public void Controller_PremiumCalculation_IfOccuptionIsEmpty_ShouldReturnPremiumAsZero()
        {
            //Arrange
            var controller = new PremiumCalculationController(_premiumBAL);

            var premiumVM = new PremiumVM();
            premiumVM.Age = 25;
            premiumVM.DeathInsured = 10000;
            premiumVM.FullName = "TestUser";
            premiumVM.Occupation = "";

            //Act
            var response = controller.Post(premiumVM);

            //Assert
            Assert.AreEqual(response, 0);


        }

    }
}
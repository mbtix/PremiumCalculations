using CoreWebApplication.Controllers;
using CoreWebApplication.Services;
using NUnit.Framework;


namespace PremiumCalculationTesting
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
        public void IsPrimiumCalculatedValueGreaterThanZero()
        {
            //Arrange
            var premiumVM = new PremiumVM();
            premiumVM.Age = 35;
            premiumVM.DeathAssured = 2000;
            premiumVM.FullName = "TestUser";
            premiumVM.Occupation = "WCL";
            premiumVM.DOB = new System.DateTime();
            //Act
            var result = _premiumBAL.CalculatePremium(premiumVM);
            //Assert
            Assert.Greater(result, 0);
        }

    }
}
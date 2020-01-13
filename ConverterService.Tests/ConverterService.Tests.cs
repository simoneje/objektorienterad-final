using System;
using NUnit.Framework;
using Service;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private ConverterService service = new ConverterService();
        
        [Test]
        public void Test_CalculateAmps()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.CalculateAmps(230, 1000), Is.EqualTo(0.23f).Within(0.005));
                Assert.That(service.CalculateAmps(22, 150), Is.EqualTo(0.1466f).Within(0.005));
                Assert.That(service.CalculateAmps(12, 0.55f), Is.EqualTo(21.8181f).Within(0.0005));
            });
        }

        [Test]
        public void Test_CalculateResistance()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.CalculateResistance(230, 10), Is.EqualTo(23));
                Assert.That(service.CalculateResistance(230, 16), Is.EqualTo(14.375).Within(0.005));
                Assert.That(service.CalculateResistance(230, 24), Is.EqualTo(9.58333).Within(0.005));
                Assert.That(service.CalculateResistance(400, 36), Is.EqualTo(11.11111).Within(0.005));
            });
        }

        [Test]
        public void Test_CalculateVoltage()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.CalculateVoltage(10, 0.5f), Is.EqualTo(5.0f).Within(0.005));
                Assert.That(service.CalculateVoltage(24, 2.5f), Is.EqualTo(60f).Within(0.005));
                Assert.That(service.CalculateVoltage(40, 0.05f), Is.EqualTo(2.0f).Within(0.005));
            });
        }

        [Test]
        public void Test_CalculateRadiusFromArea()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.CalculateRadiusFromArea(0), Is.EqualTo(0).Within(0.005));
                Assert.That(service.CalculateRadiusFromArea(24), Is.EqualTo(5.52790 / 2).Within(0.005));
                Assert.That(service.CalculateRadiusFromArea(88), Is.EqualTo(10.5851 / 2).Within(0.005));
                Assert.That(service.CalculateRadiusFromArea(120), Is.EqualTo(12.360774 / 2).Within(0.005));
                Assert.That(service.CalculateRadiusFromArea(2.245f), Is.EqualTo(1.69068706 / 2).Within(0.005));
            });
        }

        [Test]
        public void Test_CalculateDiameter()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.CalculateDiameterFromArea(0), Is.EqualTo(0).Within(0.005));
                Assert.That(service.CalculateDiameterFromArea(24), Is.EqualTo(5.52790).Within(0.005));
                Assert.That(service.CalculateDiameterFromArea(88), Is.EqualTo(10.5851).Within(0.005));
                Assert.That(service.CalculateDiameterFromArea(120), Is.EqualTo(12.360774).Within(0.005));
                Assert.That(service.CalculateDiameterFromArea(2.245f), Is.EqualTo(1.69068706).Within(0.005));
            });
        }

        [Test]
        public void Test_ConvertFromLiterToGallon()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.ConvertFromLiterToGallon(1), Is.EqualTo(0.264172047).Within(0.005));
                Assert.That(service.ConvertFromLiterToGallon(20), Is.EqualTo(5.28344107).Within(0.005));
                Assert.That(service.ConvertFromLiterToGallon(15), Is.EqualTo(3.96258068f).Within(0.005));
                Assert.That(service.ConvertFromLiterToGallon(3), Is.EqualTo(0.792516112f).Within(0.005));
                Assert.That(service.ConvertFromLiterToGallon(24.42f), Is.EqualTo(6.45108128f).Within(0.005));
            });
        }

        [Test]
        public void Test_ConvertFromGallonToLiter()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.ConvertFromGallonToLiter(1), Is.EqualTo(3.78541178).Within(0.005f));
                Assert.That(service.ConvertFromGallonToLiter(20), Is.EqualTo(75.7082367).Within(0.005f));
                Assert.That(service.ConvertFromGallonToLiter(0.1f), Is.EqualTo(0.378541178).Within(0.005f));
            });
        }

        [Test]
        public void Test_CalculateTravelTime()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.CalculateTravelTime(80, 120), Is.EqualTo(1.5).Within(0.005f));
                Assert.That(service.CalculateTravelTime(120, 0), Is.EqualTo(0).Within(0.005f));
                Assert.That(service.CalculateTravelTime(55, 230), Is.EqualTo(4.181818).Within(0.005f));
            });
        }

        [Test]
        public void Test_ConvertCelciusToFahrenheit()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.ConvertCelciusToFahrenheit(0), Is.EqualTo(32));
                Assert.That(service.ConvertCelciusToFahrenheit(20), Is.EqualTo(68).Within(0.0005f));
                Assert.That(service.ConvertCelciusToFahrenheit(-5), Is.EqualTo(23).Within(0.0005f));
                Assert.That(service.ConvertCelciusToFahrenheit(-28), Is.EqualTo(-18.4).Within(0.0005f));
                Assert.That(service.ConvertCelciusToFahrenheit(520.25f), Is.EqualTo(968.45).Within(0.0005f));
            });
        }

        [Test]
        public void Test_ConvertFahrenheitToCelcius()
        {
            Assert.Multiple(() =>
            {
                Assert.That(service.ConvertFahrenheitToCelcius(0), Is.EqualTo(-17.7777786f).Within(0.0005f));
                Assert.That(service.ConvertFahrenheitToCelcius(20), Is.EqualTo(-6.66666651f).Within(0.0005f));
                Assert.That(service.ConvertFahrenheitToCelcius(-5), Is.EqualTo(-20.5555553f).Within(0.0005f));
                Assert.That(service.ConvertFahrenheitToCelcius(-28), Is.EqualTo(-33.3333321f).Within(0.0005f));
                Assert.That(service.ConvertFahrenheitToCelcius(520.25f), Is.EqualTo(271.25f).Within(0.05f));
            });
        }

        [Test]
        public void Test_CalculateSpeed()
        {
            Assert.Multiple(() => {
                Assert.That(service.CalculateSpeed(1.5f, 44), Is.EqualTo(29.333334f).Within(0.05f));
                Assert.That(service.CalculateSpeed(4f, 7), Is.EqualTo(1.75f).Within(0.05f));
                Assert.That(service.CalculateSpeed(23f, 45), Is.EqualTo(1.95652175f).Within(0.05f));
                Assert.That(service.CalculateSpeed(22f, 280), Is.EqualTo(12.727273f).Within(0.05f));
            });          
        }

        [Test]
        public void Test_CalculateTraveledDistance()
        {
            Assert.Multiple(() => {
                Assert.That(service.CalculateTraveledDistance(100, 1.4f), Is.EqualTo(140.0f).Within(0.05f));
                Assert.That(service.CalculateTraveledDistance(50, 0.5f), Is.EqualTo(25.0f).Within(0.05f));
                Assert.That(service.CalculateTraveledDistance(250, 0.2f), Is.EqualTo(50.0f).Within(0.05f));
                Assert.That(service.CalculateTraveledDistance(70, 1), Is.EqualTo(70.0f).Within(0.05f));
                Assert.That(service.CalculateTraveledDistance(70, 6), Is.EqualTo(420.0f).Within(0.05f));
            });          
            
        }

        [Test]
        public void Test_ConvertFromMinutesToHours()
        {
            Assert.Multiple(() => {
                Assert.That(service.ConvertFromMinutesToHours(60), Is.EqualTo(1));
                Assert.That(service.ConvertFromMinutesToHours(90), Is.EqualTo(1.5));
                Assert.That(service.ConvertFromMinutesToHours(30), Is.EqualTo(0.5));
                Assert.That(service.ConvertFromMinutesToHours(45), Is.EqualTo(0.75));
                Assert.That(service.ConvertFromMinutesToHours(120), Is.EqualTo(2));
                Assert.That(service.ConvertFromMinutesToHours(360), Is.EqualTo(6));
            });
        }
        
        [Test]
        public void Test_ConvertFromHoursToMinutes()
        {
            Assert.Multiple(() => {
                Assert.That(service.ConvertFromHoursToMinutes(1), Is.EqualTo(60));
                Assert.That(service.ConvertFromHoursToMinutes(1.5f), Is.EqualTo(90));
                Assert.That(service.ConvertFromHoursToMinutes(0.5f), Is.EqualTo(30));
                Assert.That(service.ConvertFromHoursToMinutes(0.75f), Is.EqualTo(45));
                Assert.That(service.ConvertFromHoursToMinutes(2), Is.EqualTo(120));
                Assert.That(service.ConvertFromHoursToMinutes(6), Is.EqualTo(360));
            });
        }
    }
}
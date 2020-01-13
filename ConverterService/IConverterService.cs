namespace Service
{
    public interface IConverterService
    {
        float CalculateAmps(float voltage, float resistance);
        float CalculateResistance(float voltage, float amps);
        float CalculateVoltage(float res, float amp);
        float CalculateRadiusFromArea(float area);
        float CalculateDiameterFromArea(float area);
        float ConvertFromLiterToGallon(float liter);
        float ConvertFromGallonToLiter(float gallon);
        float ConvertCelciusToFahrenheit(float celcius);
        float ConvertFahrenheitToCelcius(float fahrenheit);
        float CalculateTraveledDistance(float speed, float time);
        float CalculateTravelTime(float speed, float distance);
        float CalculateSpeed(float time, float distance);
        float ConvertFromHoursToMinutes(float hours);
        float ConvertFromMinutesToHours(float minutes);
    }
}

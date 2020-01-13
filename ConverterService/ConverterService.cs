
using System;
namespace Service
{
    public class ConverterService : IConverterService
    {
        public ConverterService()
        {
        }

        // 1 gallon = 3.78541178 liters     
        // 1 liter = 0.264172052 gallons   
        //Fahrenheit = Celsius * 9/5 + 32
        //Time = distance / speed
        //Ohm law says: amp = voltage / resistance
        //Radius = square root (area / pi)
        //Diameter = radius * 2

        public float CalculateAmps(float voltage, float resistance)
        {
            float amps = voltage / resistance;
            return amps;

        }

        public float CalculateResistance(float voltage, float amps)
        {
            float res = voltage / amps;
            return res;
        }

        public float CalculateDiameterFromArea(float area)
        {
            double diameter = 2 * Math.Sqrt(area / Math.PI);
            float floatDiameter = (float) diameter;



            return floatDiameter;
        }

        public float CalculateRadiusFromArea(float area)
        {
            double radius = 2 * Math.Sqrt(area / Math.PI) / 2;
            float floatRadius = (float) radius;

            return floatRadius;
        }
        public float CalculateTravelTime(float speed, float distance)
        {
            float time;

            time = distance / speed;

            return time;
        }
        public float CalculateTraveledDistance(float speed, float time)
        {
            float distance;
            distance = speed * time;

            return distance;
        }
        public float CalculateSpeed(float time, float distance)
        {
            float speed;
            speed = distance / time;
            return speed;
        }

        public float CalculateVoltage(float res, float amp)
        {
            float voltage = amp * res;
            return voltage;
        }

        public float ConvertCelciusToFahrenheit(float celcius)
        {
            float fahrenheit = (celcius * 9) / 5 + 32;

            return fahrenheit;
        }

        public float ConvertFahrenheitToCelcius(float fahrenheit)
        {
            float celcius = (fahrenheit - 32) * 5 / 9;

            return celcius;
        }

        public float ConvertFromGallonToLiter(float gallon)
        {
            float liter;
            liter = gallon * 3.78541178f;

            return liter;
        }

        public float ConvertFromLiterToGallon(float liter)
        {
            float gallon;
            gallon = liter * 0.264172052f;
            return gallon;
        }

        public float ConvertFromHoursToMinutes(float hours)
        {
            float minutes = hours * 60;
            return minutes;
        }

        public float ConvertFromMinutesToHours(float minutes)
        {
            float hours=minutes/60;
            return hours;
        }
    }
}
using System;
using System.Collections.Generic;

namespace AS3
{
    internal class Person
    {
        
        private string  name, gender;
        private DateTime bdate;
        private double height, weight;
        private string activityLevel;

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime BDate { get => bdate; set => bdate = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public string ActivityLevel { get => activityLevel; set => activityLevel = value; }

        public double BMI
        {
            get
            {
                if (height > 0)
                {
                    Math.Round(weight / (height * height));
                }
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{Name}, Gender: {Gender}, DOB: {BDate.ToShortDateString()}, Height: {Height} cm, Weight: {Weight} kg, Activity Level: {ActivityLevel}, BMI: {BMI:F2}";
        }

        public string BmiLevel
        {
            get
            {
                
                if (BMI < 18.5)
                {
                    return "Underweight";
                }
                else if (BMI >= 18.5 && BMI <= 24.9)
                {
                    return "Normal";
                }
                else if (BMI >= 25 && BMI <= 29.9)
                {
                    return "Overweight";
                }
                else if (BMI >= 30)
                {
                    return "Obesity";
                }
                else
                {
                    return "Invalid BMI";
                }
            }
        }
    }
}

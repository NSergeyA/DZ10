using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABWORK.LAB12
{
    internal class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.Real + num2.Real;
            double imaginary = num1.Imaginary + num2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            double real = num1.Real - num2.Real;
            double imaginary = num1.Imaginary - num2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }
        public static bool operator ==(ComplexNumber num1, ComplexNumber num2)
        {
            if (ReferenceEquals(num1, num2))
            { return true; }
            else if ((num1 is null) || (num2 is null))
            { return false; }
            else
            { return num1.Real == num2.Real && num1.Imaginary == num2.Imaginary; }
        }

        public static bool operator !=(ComplexNumber num1, ComplexNumber num2)
        {
            return !(num1 == num2);
        }
        public override string ToString()
        {
            return $"Реальная часть: {Real}, Мнимая часть: {Imaginary}";
        }
    }
}

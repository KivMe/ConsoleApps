using System;

namespace Ideal_Body_Measurements_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

                //arm size
            Console.Write("Enter your wrist size in cm:");
            var wristSize = double.Parse(Console.ReadLine());
            var armSizeProjected = (wristSize * 252) / 100;
            Console.WriteLine("Your perfect sized arm should be: " + armSizeProjected + "cm");
                //calf size
            Console.Write("Enter your ankle size in cm:");
            var ankleSize = double.Parse(Console.ReadLine());
            var calfSizeProjected = (ankleSize * 192) / 100;
            Console.WriteLine("Your perfect sized calf should be: " + calfSizeProjected + "cm");
                //neck size
            Console.Write("Enter your head size in cm:");
            var headSize = double.Parse(Console.ReadLine());
            var neckSizeProjected = (headSize * 79) / 100;
            Console.WriteLine("Your perfect sized neck should be: " + neckSizeProjected + "cm");
                //chest size
            Console.Write("Enter your pelvis size in cm:");
            var pelvisSize = double.Parse(Console.ReadLine());
            var chestSizeProjected = (pelvisSize * 148) / 100;
            Console.WriteLine("Your perfect sized chest should be: " + chestSizeProjected + "cm");
                //waist size
            var waistSizeProjected = (pelvisSize * 86) / 100;
            Console.WriteLine("Your perfect sized waist should be: " + waistSizeProjected + "cm");
                //thigh size
            Console.Write("Enter your knee size in cm:");
            var kneeSize = double.Parse(Console.ReadLine());
            var thighSizeProjected = (kneeSize * 175) / 100;
            Console.WriteLine("Your perfect sized thigh should be: " + thighSizeProjected + "cm");
        }
    }
}

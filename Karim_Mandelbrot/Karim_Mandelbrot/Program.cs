using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>

    /* Author: Nihal Karim
     * Purpose: to allow the user to set the start and end values of the coordinates
     * Restrictions: none
     */
    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord; // real & imaginary parts of N
            double realTemp, imagTemp, realTemp2, arg; // vars for temp info during computation
            int iterations; // records amt of iterations before the argument of N (arg) is 2+

            bool validInput = false;
            double imagCoordStartInput = 0;
            double imagCoordEndInput = 0;
            double realCoordStartInput = 0;
            double realCoordEndInput = 0;


            while (!validInput)
            {

                Console.WriteLine("Pick the start and end values of imagCoord and realCoord.");

                Console.WriteLine("The default imagCoord range is 1.2 to -1.2. Pick your imagCoord start value: ");
                imagCoordStartInput = Convert.ToDouble(Console.ReadLine());

                Console.Write("Now Pick your imagCoord end value: ");
                imagCoordEndInput = Convert.ToDouble(Console.ReadLine());


                Console.Write("The default realCoord range is -0.6 to 1.77. Pick your realCoord value: ");
                realCoordStartInput = Convert.ToDouble(Console.ReadLine());

                Console.Write("Now Pick your realCoord end value: ");
                realCoordEndInput = Convert.ToDouble(Console.ReadLine());

                if ((imagCoordStartInput > imagCoordEndInput) && (realCoordStartInput < realCoordEndInput))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input... imagCoord must start from a higher value than it ends, and realCoord must start from a lower value than it ends.");
                }
            }

            //to find increment divide the difference between start and end values by amt of cols or rows
            double imagCoordIncrement = (imagCoordStartInput - imagCoordEndInput) / 48;
            double realCoordIncrement = (realCoordEndInput - realCoordStartInput) / 80;

            for (imagCoord = imagCoordStartInput; imagCoord >= -imagCoordEndInput; imagCoord -= imagCoordIncrement)
            {
                for (realCoord = realCoordStartInput; realCoord <= realCoordEndInput; realCoord += realCoordIncrement)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);

                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }

                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}

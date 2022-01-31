//============================================================================
// SimplePend.cs defines a class for simulating a simple pendulum
//============================================================================
using System;

namespace Sim
{

    public class SimplePend
    {
        private double len = 1.1; // pendulum length
        private double g = 9.81; // gravitational field strength
        
        //--------------------------------------------------------------------
        //constructor
        //--------------------------------------------------------------------
        public SimplePend()
        {
            Console.WriteLine("Inside Constructor");
        }



        //--------------------------------------------------------------------
        //Getters and Setters
        //--------------------------------------------------------------------
        public double L
        {
            get {return(len);}

            set 
            {
                if(value > 0)
                    len = value;
            }
        }
        public double G
        {
            get {return(g);}

            set
            {
                if(value >= 0)
                    g = value;
            }
        }
    }

}
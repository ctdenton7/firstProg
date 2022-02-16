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
        int n = 2;              // number of states
        private double[] x;     // array of states
        private double[] f;     //right side of equation evaluated
        // private string m;       //type of integrator used, default RK4
        // private double[] sl;
        // private double xi;

        //--------------------------------------------------------------------
        //constructor
        //--------------------------------------------------------------------
        public SimplePend()
        {
            x = new double[n];
            f = new double[n];
            // m = "Euler";
            // sl = new double[4];
            x[0] = 1.0;
            x[1] = 0;
        }


        //--------------------------------------------------------------------
        // step: perform one integration step via Euler
        //--------------------------------------------------------------------

        public void step(double dt)
        {
            rhsFunc(x,f);
            
            // if(m == "Euler")
            // {
                for(int i=0;i<n;++i)
                {
                    x[i] = x[i] + f[i] * dt;
                }
            // }
            // else if(m == "RK4")
            // {
            //     for(int i=0;i<n;++i)
            //     {
            //         sl[0] = f[i];                           // KA
            //         xi = x[i] + sl[0] * 0.5 * dt;
            //         sl[1] = f[i]; //+0.5 * dt               // KB
            //         xi = x[i] + sl[1] * 0.5 * dt;
            //         sl[2] = f[i]; //+0.5 * dt               // KC
            //         xi= x[i] + sl[2] * dt;
            //         sl[3] = f[i];                           // KD
            //         x[i] = x[i] + (sl[0] + 2.0 * sl[1] + 2.0 * sl[2] + sl[3])/6.0 * dt;
            //     }
            // }
        }

        //--------------------------------------------------------------------
        // rhsFunc: function to calculate rhs of pendulum
        //--------------------------------------------------------------------
        public void rhsFunc(double[] st, double[] ff)
        {
            ff[0] = st[1];
            ff[1] = -g/len * Math.Sin(st[0]);
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
        public double theta 
        {
            get {return x[0];}

            set {value = x[0];}
        }
        public double thetaDot
        {
            get {return x[1];}

            set {value = x[1];}
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp_1
{
    class Cublisher
    {
        public event EventHandler AMillionMilesAway;

        public void Startertoo()
        {
            if (Console.ReadLine() == "Sing!")
            {
                AMillionMilesAway(this, null);
            }
        }
    }

    class Cubscribe
    {
        private void ComeBackAndStay(object sauce, EventArgs e)
        {

        }

        public void OwOUwU(Cublisher c)
        {
            c.AMillionMilesAway += ComeBackAndStay;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}

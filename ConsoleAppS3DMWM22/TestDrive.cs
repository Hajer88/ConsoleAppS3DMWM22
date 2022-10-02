using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppS3DMWM22
{
    public  class TestDrive
    {
        //Chaining contructor
        public int intensite;
        public string name;

        public TestDrive(int intensite,int vitesse, string name)
        {
            if (intensite >= 10) intensite = 10;
            this.intensite = intensite;
            this.name = name;
        }
        public TestDrive(int intensite, int vitesse):this(intensite,vitesse,"")
        {
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     abstract class BiatlonCalculation
    {
        int sec = 0;
        int point = 0;
        bool hit = false;
        public void Game()
        {
            Running(sec, point);
            Shooting(point, hit);
        }


        public abstract void Running(int sec, int point);

        public abstract void Shooting(int point, bool hit);
    }

    class ManCalculation : BiatlonCalculation
    {
        public override void Running(int sec, int point)
        {
            point -= 5;
            sec++;
        }

        public override void Shooting(int point, bool hit)
        {
            if (hit) { point += 100; }
        }
    }

    //class WomanCalculation : BiatlonCalculation
    //{

    //}

    //class ChildrenCalculation : BiatlonCalculation
    //{


    //}
}

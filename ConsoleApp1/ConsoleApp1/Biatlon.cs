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
        public int Game(int sec, int hitCount)
        {
            int res = 0;
            
            res+= Shooting(hitCount);
            res -= Running(sec);
            res = Check(res);
            return res;
        }


        public abstract int Running(int sec);

        public abstract int Shooting(int hitCount);
        public abstract int Check(int total);
    }

    class ManCalculation : BiatlonCalculation
    {
        public override int Check(int total)
        {
            return total;
        }

        public override int Running(int sec)
        {
            return sec*5;
        }

        public override int Shooting(int hitCount)
        {
            return hitCount *100;
        }
    }

    class WomanCalculation : BiatlonCalculation
    {
        public override int Check(int total)
        {
            return total;
        }

        public override int Running(int sec)
        {
            return sec * 4;
        }

        public override int Shooting(int hitCount)
        {
            return hitCount * 100;
        }
    }

    class ChildrenCalculation : BiatlonCalculation
    {
        public override int Check(int total)
        {
            return (total < 0) ? 0 : total;
        }

        public override int Running(int sec)
        {
            return sec * 2;
        }

        public override int Shooting(int hitCount)
        {
            return hitCount * 200;
        }
    }
}

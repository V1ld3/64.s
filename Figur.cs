using System;
using System.Collections.Generic;
using System.Text;

namespace _64.s
{
    class Figur
    {
        public float bredd;
        public float höjd;

        public Figur(float bredd, float höjd)
        {
            this.bredd = bredd;
            this.höjd = höjd;
        }
    }

    class Cirkel : Figur
    {
        public Cirkel(float bredd, float höjd) : base(bredd, höjd)
        {
        }

        public float BeräknaArea()
        {
            return bredd * (float)Math.PI;
        }

    }

    class Triangel : Figur
    {
        public Triangel(float bredd, float höjd) : base(bredd, höjd)
        {
        }
        public float BeräknaArea()
        {
            return bredd * höjd / 2;
        }

    }
    class Linje : Figur
    {
        public Linje(float bredd, float höjd) : base(bredd, höjd)
        {
        }

    }
}

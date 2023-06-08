using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoverianceEX
{
    public class Flower
    {
        public virtual string WhatsYourName()

        {

            return "I have many names and types.";

        }

    }

    class Jasmine : Flower

    {

        public override string WhatsYourName()

        {

            return "Jasmine";

        }

    }

    class Lily : Flower

    {

        public override string WhatsYourName()

        {

            return "Lily";

        }

    }

    class Lotus : Flower

    {

        public override string WhatsYourName()

        {

            return "Lotus";

        }

    }

    class Region

    {

        public virtual Flower YourNationalFlower()

        {

            return new Flower();

        }

    }

    class WestBengal : Region

    {

        public override Flower YourNationalFlower()

        {

            return new Jasmine();

        }

    }

    class Karnataka : Region

    {

        public override Flower YourNationalFlower()

        {

            return new Lotus();

        }

    }

    class AndhraPradesh : Region

    {

        public override Flower YourNationalFlower()

        {

            return new Lily();

        }
    }
}

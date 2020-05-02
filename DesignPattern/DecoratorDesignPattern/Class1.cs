using System;

namespace DecoratorDesignPattern
{

    public interface IWedding
    {
        string Title();
        double Budget();
    }

    public class TraditionalWedding : IWedding
    {
        public double Budget()
        {
            return 100000;
        }

        public string Title()
        {
            return " Traditional Weeding";
        }
    }

    public class DestinationWedding : IWedding
    {
        public double Budget()
        {
            return 700000;
        }

        public string Title()
        {
            return " Destination Weeding";
        }
    }

    public class WeddingDecorator : IWedding
    {
        IWedding wedding;

        protected string title = "undefined title";
        protected double budget = 0.0;
        public WeddingDecorator(IWedding wedding)
        {
            this.wedding = wedding;
        }
        public double Budget()
        {
            return wedding.Budget() + budget;
        }

        public string Title()
        {
            return string.Format("{0} with {1}", wedding.Title(), title);
        }
    }

    public class Jewellery : WeddingDecorator
    {
        public Jewellery(IWedding wedding)
            : base(wedding)
        {
            title = "Jewellery";
            budget = 500000;
        }
    }

    public class Orchestra : WeddingDecorator
    {
        public Orchestra(IWedding wedding)
            : base(wedding)
        {
            title = "Orchestra";
            budget = 200000;
        }
    }

    public class Theme : WeddingDecorator
    {
        public Theme(IWedding wedding)
            : base(wedding)
        {
            title = "Theme";
            budget = 100000;
        }
    }

}

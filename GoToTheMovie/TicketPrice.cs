namespace GoToTheMovie
{
    public class TicketPrice
    {
        public int thePrice;


        public TicketPrice(int thePrice)
        {
            this.thePrice = thePrice;
        }

        public int GetThePrice()
        {
            return thePrice;
        }

        public void SetThePrice(int thePrice)
        {
            this.thePrice = thePrice;
        }

    }
}


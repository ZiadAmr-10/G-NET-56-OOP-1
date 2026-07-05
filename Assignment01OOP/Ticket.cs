namespace Assignment01OOP
{
    internal class Ticket
    {
        public string MovieName;
        public TicketType Type;
        public SeatLocation Seat;
        private double Price;

       public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }
        public Ticket(string name) : this(name, TicketType.Standard,new SeatLocation('A', 1), 50)
        {
        
        }
        public double CalcTotal(double taxPercent)
        {
            return Price +(Price * taxPercent/100);
        }
        public void ApplyDiscount(ref double DiscountAmount)
        {
            if(DiscountAmount > 0 && DiscountAmount <= Price)
            {
                Price-=DiscountAmount;
                DiscountAmount = 0;
            } 
        }
        public void PrintTicket(double tax)
        {
            Console.WriteLine($"====Ticketinfo====\nMovie Name: {MovieName}\nType: {Type}\nSeat: {Seat}\n" +
                               $"Price: {Price}\nAmount After Tax ({tax}) : {CalcTotal(tax)}");
        }
        public void PrintTicketAfterDiscount(double tax, double DiscountBefore, double discountAfter) {
            Console.WriteLine($"=====After Discount=====\nDiscount Before : {DiscountBefore}\n" +
                              $"Discount After : {discountAfter}\nMovie Name: {MovieName}\nType: {Type}\nSeat: {Seat}\n" +
                              $"Price: {Price}  \n" +
                              $"Total After ({tax}): {CalcTotal(tax)}"); 
        }

    }
}

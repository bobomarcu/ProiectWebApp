namespace WebApplication1.Models
{
    public class Package
    {
        public int Id { get; set; }
        public  User Sender { get; set; }
        public  User Receiver { get; set; }
        public int Weight { get; set; }

    }
}

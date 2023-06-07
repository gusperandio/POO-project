using POO.SharedContext;

namespace POO.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
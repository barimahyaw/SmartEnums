namespace SmartEnums;

public abstract class CreditCard : Enumeration<CreditCard>
{ 
    public static readonly CreditCard Standard = new StandardCreditCard();
    public static readonly CreditCard Premium = new PremiumCreditCard();
    public static readonly CreditCard Platinum = new PlatinumCreditCard();

    private CreditCard(int value, string name)
       : base(value, name)
    {
    }

    public abstract double Discount { get; }

    public sealed class StandardCreditCard 
        : CreditCard
    {
        public StandardCreditCard() 
            : base(1, nameof(Standard))
        {
        }
        public override double Discount => 0.01;
    }

    public sealed class PremiumCreditCard 
        : CreditCard
    {
        public PremiumCreditCard()
            : base(2, nameof(Premium))
        {
        }
        public override double Discount => 0.02;
    }

    public sealed class PlatinumCreditCard : CreditCard
    {
        public PlatinumCreditCard() : base(3, nameof(Platinum))
        {
        }
        public override double Discount => 0.03;
    }
}
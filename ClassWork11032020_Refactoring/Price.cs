namespace ClassWork11032020_Refactoring
{
    abstract class Price
    {
        public abstract int GetPruceCode();
        public abstract double GetCharge(int daysRented);

        public virtual int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }
}
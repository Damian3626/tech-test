namespace AnyCompany.Helpers
{
    public static class OrderAmountHelper
    {
        public static double VATAmount(string Country)
        {
            return Country.ToUpper() == "UK" ? 0.2d : 0;
        }
        public static bool OrderAmountValid(double orderAmount)
        {
            return orderAmount > 0;
        }
    }
}

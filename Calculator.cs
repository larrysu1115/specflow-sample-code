using System;

namespace SpecFlowDemo
{
    public class Calculator
    {
        public string Sku { get; set; } = "";
        public int Amount { get; set; } = 0;

        public int CalculatePriceToPay()
        {
            int unitPrice = QueryUnitPriceBySku(this.Sku);
            int totalPrice = unitPrice * Amount;
            if (Sku.Contains("sale", StringComparison.InvariantCultureIgnoreCase))
                totalPrice = (int)(totalPrice * 0.5);
            return totalPrice;
        }

        private int QueryUnitPriceBySku(string sku)
        {
            if (sku.StartsWith("A"))
                return 100;
            if (sku.StartsWith("B"))
                return 200;

            throw new Exception($"Unknown product SKU: {Sku}");
        }
    }
}
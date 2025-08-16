namespace ThanachartApi.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal? PricePerUnit { get; set; }
        public int? Quantity { get; set; }
    }

    public class AddStock
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int? AddCount { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public class InteriorItem
    {
        private string _title = string.Empty;
        private decimal _price;
        private int _stockQuantity;

        public string ArticleNumber { get; set; } = string.Empty;
        public string color { get; set; } = string.Empty;

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Назва товару не може бути порожньою або містити лише пробіли.");
                }
                _title = value.Trim();
            }
        }
        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ціна товару не може бути від'ємною.");
                }
                _price = value;
            }
        }
        public int StockQuantity
        {
            get => _stockQuantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Кількість товару на складі не може бути від'ємною.");
                }
                _stockQuantity = value;
            }
        }
        public InteriorItem(string articleNumber, string title, decimal price, int stockQuantity, string color)
        {
            ArticleNumber = articleNumber;
            Title = title;
            Price = price;
            StockQuantity = stockQuantity;
            this.color = color;
        }
        public InteriorItem() { }
    }
}

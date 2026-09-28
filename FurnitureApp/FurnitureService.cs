using System;
using System.Collections.Generic;
using System.IO;

namespace FurnitureApp
{
    public class FurnitureService
    {
        
        private List<InteriorItem> _items = new List<InteriorItem>();

       
        public List<InteriorItem> Items
        {
            get { return _items; }
        }

       
        public void AddItem(InteriorItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Товар не може бути порожнім!");
            }
            _items.Add(item);
        }

        public bool RemoveItemByArticle(string article)
        {
            foreach (InteriorItem item in _items)
            {
                if (item.ArticleNumber == article)
                {
                    _items.Remove(item);
                    return true;
                }
            }
            return false;
        }
        
        public List<InteriorItem> SearchByTitle(string searchText)
        {
            List<InteriorItem> result = new List<InteriorItem>();

            foreach (InteriorItem item in _items)
            {
                
                if (item.Title.ToLower().Contains(searchText.ToLower()))
                {
                    result.Add(item);
                }
            }

            return result;
        }

       
        public List<InteriorItem> FilterByMaxPrice(decimal maxPrice)
        {
            List<InteriorItem> result = new List<InteriorItem>();

            foreach (InteriorItem item in _items)
            {
                if (item.Price <= maxPrice)
                {
                    result.Add(item);
                }
            }

            return result;
        }
        
        public void SaveToFile(string filePath)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (InteriorItem item in _items)
                {
                  
                    string line = item.ArticleNumber + ";" +
                                  item.Title + ";" +
                                  item.color + ";" +
                                  item.Price + ";" +
                                  item.StockQuantity;

                    writer.WriteLine(line);
                }
            }
        }

       
        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }

            _items.Clear(); 

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    
                    string[] parts = line.Split(';');

                    if (parts.Length == 5)
                    {
                        string article = parts[0];
                        string title = parts[1];
                        string color = parts[2];
                        decimal price = decimal.Parse(parts[3]);
                        int quantity = int.Parse(parts[4]);

                        
                        InteriorItem item = new InteriorItem(article, title, price, quantity, color);
                        _items.Add(item);
                    }
                }
            }
        }
    }
}
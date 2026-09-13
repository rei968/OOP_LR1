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
        // Метод 3: Пошук товарів за назвою (або частиною назви)
        public List<InteriorItem> SearchByTitle(string searchText)
        {
            List<InteriorItem> result = new List<InteriorItem>();

            foreach (InteriorItem item in _items)
            {
                // Перевіряємо, чи назва містить введений текст
                // ToLower() потрібен, щоб пошук не залежав від великих/малих літер
                if (item.Title.ToLower().Contains(searchText.ToLower()))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        // Метод 4: Фільтрація товарів за максимальною ціною
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
        // Метод 5: Збереження списку товарів у файл
        public void SaveToFile(string filePath)
        {
            // StreamWriter автоматично створить файл або перезапише старий
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (InteriorItem item in _items)
                {
                    // Формуємо рядок з розділювачем ';'
                    string line = item.ArticleNumber + ";" +
                                  item.Title + ";" +
                                  item.color + ";" +
                                  item.Price + ";" +
                                  item.StockQuantity;

                    writer.WriteLine(line);
                }
            }
        }

        // Метод 6: Завантаження списку товарів з файлу
        public void LoadFromFile(string filePath)
        {
            // Якщо файл ще не існує (перший запуск програми), нічого не робимо
            if (!File.Exists(filePath))
            {
                return;
            }

            _items.Clear(); // Очищаємо старий список перед завантаженням

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                // Читаємо файл до кінця, рядок за рядком
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Розбиваємо рядок на окремі частини за символом ';'
                    string[] parts = line.Split(';');

                    if (parts.Length == 5)
                    {
                        string article = parts[0];
                        string title = parts[1];
                        string color = parts[2];
                        decimal price = decimal.Parse(parts[3]);
                        int quantity = int.Parse(parts[4]);

                        // Створюємо об'єкт через наш конструктор з параметрами
                        InteriorItem item = new InteriorItem(article, title, price, quantity, color);
                        _items.Add(item);
                    }
                }
            }
        }
    }
}
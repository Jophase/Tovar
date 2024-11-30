// MainWindow.xaml.cs
using System.Collections.Generic;
using System.Windows;

namespace OnlineStore
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadProducts_Click(object sender, RoutedEventArgs e)
        {
            List<Product> products = new List<Product>
            {
                new Product("Ноутбук", 999.99m, "Ноутбук 2025 года ,ультра Max-ProVersions"),
                new Product("Смартфон", 499.99m, "Последние слово технологии"),
                new Product("чай", 299.99m, "Для работы ума полезно, особенно утром в 5 часов")
            };

            ProductListBox.Items.Clear();

            foreach (var product in products)
            {
                // Деконструкция объекта Product
                var (name, price, description) = product;
                ProductListBox.Items.Add($"{name} - {price:C} - {description}");
            }
        }
    }
}


using System.Linq;
using System.Windows;
using InventoryManager.Core;
using InventoryManager.Data;

namespace InventoryManager.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadInventoryData(); // Load products into the table when the app opens
        }

        // READ: Fetch all products from SQLite and display them in the DataGrid
        private void LoadInventoryData()
        {
            using (var db = new DatabaseContext())
            {
                ProductDataGrid.ItemsSource = db.Products.ToList();
            }
        }

        // CREATE: Add a sample product to the database when the button is clicked
        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                var sampleProduct = new Product
                {
                    Name = "Wireless Mouse",
                    SKU = "MS-9988",
                    Quantity = 25,
                    Price = 29.99m
                };

                db.Products.Add(sampleProduct);
                db.SaveChanges();
            }

            // Refresh the grid to show the newly added item
            LoadInventoryData();
        }

        // REFRESH: Manual reload button
        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            LoadInventoryData();
        }
    }
}
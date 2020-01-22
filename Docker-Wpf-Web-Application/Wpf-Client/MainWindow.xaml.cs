using Docker_Wpf_Web_Application.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>();
        String requestUrl = "https://localhost:44365/api";

        public DateTime SelectedDate

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        public async Task<IEnumerable<Car>> LoadCars()
        {
            var client = HttpClient.GetHttpClient();
            var response = await client.GetAsync(requestUrl + "/cars");
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var cars = JsonSerializer.Deserialize<Car[]>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return cars;
        }

        public async Task<IEnumerable<Car>> LoadCarsForDay(DateTime date)
        {
            var client = HttpClient.GetHttpClient();
            var response = await client.GetAsync(requestUrl + "/carsForDay/ " + date.ToString());
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var cars = JsonSerializer.Deserialize<Car[]>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return cars;
        }
    }
}

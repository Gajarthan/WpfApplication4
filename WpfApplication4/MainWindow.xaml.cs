    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
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

    namespace WpfApplication4
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
        {
            HotelDataContext db = new HotelDataContext();
            public MainWindow()
            {
                InitializeComponent();
                list1.ItemsSource = db.Hotels;
            }

            private void txt_name_TextChanged(object sender, TextChangedEventArgs e)
            {
                var q = from h in db.Hotels
                        where h.Hotel_Name.Contains(txt_name.Text)
                        select h;
                list1.ItemsSource = q;
            }

            private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                Hotel h = (Hotel)list1.SelectedItem;
                HotelDetails d = new HotelDetails(h);
                d.Show();
            }

        }
    }

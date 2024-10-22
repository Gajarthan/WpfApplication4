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
using System.Windows.Shapes;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for HotelDetails.xaml
    /// </summary>
    public partial class HotelDetails : Window
    {
        public HotelDetails(Hotel h)
        {
            InitializeComponent();
            txt_id.Text = h.Hotel_Id + "";
            txt_name.Text = h.Hotel_Name + "";
            txt_ratings.Text = h.Ratings + "";
            txt_description.Text = h.Destination + "";
            img.Source = new BitmapImage(new Uri(h.Image, UriKind.Absolute));

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int hid = int.Parse(txt_id.Text);
            RoomDetails r =new RoomDetails(hid);
            r.Show();
        }
    }
}

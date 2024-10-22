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
    /// Interaction logic for RoomDetails.xaml
    /// </summary>
    public partial class RoomDetails : Window
    {
        HotelDataContext db = new HotelDataContext();

        int hotel_id;

        public RoomDetails( int hid)
        {
            hotel_id = hid;

            InitializeComponent();

            list1.ItemsSource = from r in db.Rooms
                                where r.Hotel == hotel_id
                                select r;
        }

        private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            list1.ItemsSource = from r in db.Rooms
                                where r.Category.Contains(txt_search.Text) && r.Hotel == hotel_id
                                select r;
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Room r = (Room)list1.SelectedItem;
            if(r != null){
                txt_id.Text = r.Room_Id + "";
                txt_category.Text = r.Category + "";
                txt_price.Text = r.Price + "";
                txt_description.Text = r.Description + "";
  

            }
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            var id = (from r in db.Rooms select r.Room_Id).Max();
            Room r1 = new Room();
            r1.Room_Id = id + 1;
            r1.Category = txt_category.Text;
            r1.Price = float.Parse(txt_price.Text);
            r1.Description = txt_description.Text;
            r1.Hotel = hotel_id;

            db.Rooms.InsertOnSubmit(r1);
            db.SubmitChanges();

            MessageBox.Show("Room Add!!");

            list1.ItemsSource = from r in db.Rooms
                                where r.Hotel == hotel_id
                                select r;


        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            Room r1 = (from r in db.Rooms
                       where r.Room_Id == int.Parse(txt_id.Text)
                       select r).Single();


            r1.Category = txt_category.Text;
            r1.Price = float.Parse(txt_price.Text);
            r1.Description = txt_description.Text;
            r1.Hotel = hotel_id;

            db.SubmitChanges();

            MessageBox.Show("Room Update!!");

            list1.ItemsSource = from r in db.Rooms
                                where r.Hotel == hotel_id
                                select r;


        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Room r1 = (from r in db.Rooms
                       where r.Room_Id == int.Parse(txt_id.Text)
                       select r).Single();

            MessageBoxResult rr = MessageBox.Show("Delete : " + r1.Category, "Conformation", MessageBoxButton.OKCancel);

            if (rr == MessageBoxResult.OK)
            {
                db.Rooms.DeleteOnSubmit(r1);
                db.SubmitChanges();

                MessageBox.Show("Room Update!!");
                list1.ItemsSource = from r in db.Rooms
                                    where r.Hotel == hotel_id
                                    select r;

            }
        }
    }
}

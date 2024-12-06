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
using WpfCactusShow2.DB;

namespace WpfCactusShow2.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditCactus.xaml
    /// </summary>
    public partial class EditCactus : Page
    {
        private int _id;
        private int _id_ex;
        private Cactus _cactus;

        public EditCactus(int id, int id_ex)
        {
            _id = id;
            _id_ex = id_ex;
            InitializeComponent();
            
            cmbVid.ItemsSource = ConnectionDB.DB.Kind.ToList();
            cmbExhibition.ItemsSource = ConnectionDB.DB.Show.ToList();
            Cactus cactus = ConnectionDB.DB.Cactus.Where(cactus1 => cactus1.Id_cactus == _id).FirstOrDefault();
            txtOrigin.Text = cactus.Origin.ToString();
            txtAge.Text = cactus.Age.ToString();
            txtPrice.Text = cactus.Price.ToString();
            cmbExhibition.SelectedValue = ConnectionDB.DB.Show.Where(x => x.Id_show == _id_ex).FirstOrDefault();
            cmbVid.SelectedValue = ConnectionDB.DB.Kind.Where(x => x.Id_kind == cactus.Id_kind).FirstOrDefault();
            _cactus = cactus;
        }


        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }
        private void cmbVid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = cmbVid.SelectedItem as Kind;
            var vidd = (from vid in ConnectionDB.DB.Kind
                        where vid.Id_kind == p.Id_kind
                        select vid).FirstOrDefault();
            cmbVid.SelectedItem = vidd;
        }

        private void cmbExhibition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = cmbExhibition.SelectedItem as Show;
            var ex = (from Exhibition in ConnectionDB.DB.Show
                      where Exhibition.Id_show == p.Id_show
                      select Exhibition).FirstOrDefault();
            cmbVid.SelectedItem = ex;
        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            _cactus.Price = Convert.ToInt32(txtPrice.Text);
            _cactus.Age = Convert.ToInt32(txtAge.Text);
            _cactus.Origin = txtOrigin.Text;
            _cactus.Id_kind = ((Kind)cmbVid.SelectedItem).Id_kind;
            ConnectionDB.DB.SaveChanges();
            ConnectionDB.DB.Show_cactus.Add(new Show_cactus
            {
                Id_show = ((Show)cmbExhibition.SelectedItem).Id_show,
                Id_cactus = _cactus.Id_cactus,
            });
            ConnectionDB.DB.SaveChanges();
            NavigationService.Navigate(new ShowPage());
        }
    }
}

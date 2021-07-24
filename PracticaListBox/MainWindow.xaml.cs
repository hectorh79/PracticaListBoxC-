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

namespace PracticaListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Se inicializa una lista que contendra a los objetos poblaciones
            List<Poblaciones> listaPob = new List<Poblaciones>();

            //Se presenta el metodo Add para agregar información a la lista. Se debe instanciar cada grupo de la lista
            listaPob.Add(new Poblaciones() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17, DifTemp = 2 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Valencia", Poblacion2 = "Alicante", Temperatura1 = 19, Temperatura2 = 20, DifTemp = 1 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Malaga", Poblacion2 = "Bilbao", Temperatura1 = 20, Temperatura2 = 7, DifTemp = 13 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Sevilla", Poblacion2 = "Coruña", Temperatura1 = 22, Temperatura2 = 8, DifTemp = 14 });

            //Instrucción para ligar la lista, con la ListBox en XAML
            listaPoblaciones.ItemsSource = listaPob;
        }

        //Este codigo se genera de manera auotomatica al introducir en XAML en el objeto boton el metodo Click = Button_Click
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //La condición if es para evitar que el programa caiga si no se ha elegido un eleemnto de la lista
            if (listaPoblaciones.SelectedItem != null) { 
            MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " + (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " C " +
                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " C ");
            }
            else
            {
                MessageBox.Show("Selecciona primero un elemento de la lista");
            }
        }

        //Este codigo se genera de manera auotomatica al introducir en XAML en el objeto PreviewMousseDown
        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " + (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " C " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " C ");
            }
            else
            {
                MessageBox.Show("Selecciona primero un elemento de la lista");
            }
        }
    }

    public class Poblaciones
    {
        //Se crean los campos de clase que contendran los datos de poblacion y temperatura para su comparacion
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        //variable que almacenara las diferencias de temperatura y que liga a la "progress bar"
        public int DifTemp { get; set; }

    }
}

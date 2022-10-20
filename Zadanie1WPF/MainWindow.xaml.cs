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
using System.Text.RegularExpressions;


namespace Zadanie1WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            InitializeComponent();

        }
        public string PublicName { get; set; }

        public string PublicAge { get; set; }
       
        public string resulty = "0";

        public bool containsIntName { get; set; }

        public string imie { get; set; }
        public string wiek { get; set; }
        public int wiekInt { get; set; }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            imie = TextBoxName.Text;
            wiek = TextBoxWiek.Text;

            NameValidation(imie);
            AgeValidation(wiek);
            Validation(imie, wiek);

        }


        public void Validation(string imie, string wiek)
        {


            if (NameValidation(imie))
            {

                if (true)
                {

                    Alert.Text = $"Witaj {imie}!";

                    if (AgeValidation(wiek))
                    {

                        if (true && resulty == "1")
                        {

                            result.Text = "Użytkownik jest pełnoletni";


                        }
                        else if (resulty == "0")
                        {
                            result.Text = "Użytkownik nie jest pełnoletni";


                        }


                    }
                    else
                    {
                        TextBoxWiek.Clear();
                        result.Text = "Błędne dane(wiek)";


                    }

                }

            }
            else
            {

                TextBoxName.Clear();
                Alert.Text = "Niepoprawne dane(imie)";

            }


        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            AgeValidation(PublicAge);
            NameValidation(PublicName);
            Validation(PublicName, PublicAge);


        }



        public bool NameValidation(string imie)
        {




            Regex.Replace(imie, @"\s+", "");

            bool stringVal = imie.All(Char.IsLetter);
            bool containsIntName;

            containsIntName = imie.All(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
            if (containsIntName == false && stringVal == false)
            {

                return false;

            }

            return true;

        }

        public bool AgeValidation(string wiek)


        {

            wiek = TextBoxWiek.Text;




            try
            {

                wiekInt = Int16.Parse(wiek);



            }
            catch
            {


                return false;

            }
            if (wiekInt < 0 || wiekInt > 150)
            {

                return false;



            }

            else if (wiekInt >= 18)
            {

                resulty = "1";
            }
            else
            {
                if (wiekInt < 18)
                {
                    resulty = "0";


                }

                foreach (char c in wiek)
                {
                    if (wiek == "")
                    {
                        return false;

                    }
                    else if (c < '1' || c > '9')
                    {
                        return false;
                    }


                }

            }
            return true;
        }

        private void result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}


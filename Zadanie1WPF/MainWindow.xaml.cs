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

        public string name { get; set; }
        public string age { get; set; }
        public int ageInt { get; set; }



        private void Button_Click(object sender, RoutedEventArgs e)
        {



            NameValidation(name);
            AgeValidation(age);
            Validation(name, age);

        }


        public void Validation(string name, string age)
        {



            if (NameValidation(name))
            {

                if (true)
                {

                    Alert.Text = $"Witaj {name}!";

                    if (AgeValidation(age))
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
                        TextBoxAge.Clear();
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



        public bool NameValidation(string name)
        {

            Regex.Replace(name, @"\s+", "");

            bool stringVal = name.All(Char.IsLetter);
            bool containsIntName;

            containsIntName = name.All(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
            if (containsIntName == false && stringVal == false)
            {

                return false;

            }

            return true;

        }

        public bool AgeValidation(string age)
        {

            try
            {

                ageInt = Int16.Parse(age);



            }
            catch
            {


                return false;

            }
            if (ageInt < 0 || ageInt > 150)
            {

                return false;



            }

            else if (ageInt >= 18)
            {

                resulty = "1";
            }
            else
            {
                if (ageInt < 18)
                {
                    resulty = "0";


                }

                foreach (char c in age)
                {
                    if (age == "")
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


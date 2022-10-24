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

        private string _publicName = "";
        public string PublicName
        {
            get
            {
                return _publicName;
            }
            set
            {
                _publicName = value;
            }
        }

        private string _publicAge = "";
        public string PublicAge
        {
            get
            {
                return _publicAge;
            }
            set
            {
                _publicAge = value;
            }
        }

        public bool resulty = true;

        public bool containsIntName { get; set; }

        public bool nullName;

        public bool nullAge = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = TextBoxName.Text;
            string age = TextBoxAge.Text;

            NameValidation(name);
            AgeValidation(age);
            Validation(name, age);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AgeValidation(PublicAge);
            NameValidation(PublicName);
            Validation(PublicName, PublicAge);
        }

        public void Validation(string userName, string userAge)
        {



          
                if (!NameValidation(userName))
                {
                    Alert.Text = "Błędne dane(imie)";
                    Alert.Foreground = Brushes.Red;

                }
                else
                if (AgeValidation(userAge) == true)
                {


                    if (resulty)
                    {
                        Alert.Text = $"Witaj {userName}!";
                        result.Text = "Użytkownik jest pełnoletni";
                        result.Foreground = Brushes.Green;
                        Alert.Foreground = Brushes.Green;


                    }
                    else
                    {
                        Alert.Text = $"Witaj {userName}!";
                        result.Text = "Użytkownik nie jest pełnoletni";
                        Alert.Foreground = Brushes.Green;
                        result.Foreground = Brushes.Green;
                    }


                }


            
            else if (!AgeValidation(userAge))
            {

                Alert.Text = "Błędne dane(wiek)";
                Alert.Foreground = Brushes.Red;





            }
        }
            public bool NameValidation(string userName)
        {
            try
            {
                Regex.Replace(userName, @"\s+", "");

                bool stringVal = userName.All(Char.IsLetter);
                bool containsIntName;

                containsIntName = userName.All(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
                if (containsIntName == false && stringVal == false)
                {
                    return false;
                }
                else

                if (userName == "" || userName == " ")
                {
                    nullName = false;
                    return false;

                }
                nullName = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Validate age value
        public bool AgeValidation(string age)
        {
            int ageInt;




            if (!int.TryParse(age, out ageInt))
            {
                nullAge = false;


            }
            else
            {

                if (ageInt < 0 || ageInt > 150)
                {
                    foreach (char c in age)
                    {
                        if (age == "" || age == " ")
                        {


                            return false;
                        }
                        else if (c < '1' || c > '9')
                        {


                            return false;
                        }
                    }
                    return true;
                } else 
                if (ageInt >= 18)
                {
                    resulty = true;
                }
                else if (ageInt < 18)
                {

                    resulty = false;



                }




            }

            return false;





        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyGameApp
{
    public partial class MainPage : ContentPage
    {
        private int _currentNumber, _points;
        private Random _rnd;

        public MainPage()
        {
            InitializeComponent();
            _currentNumber = 0;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                _rnd = new Random();
                _points = 0;
                IntroLayout.IsVisible = false;
                MainLayout.IsVisible = true;
                ExtraLayout.IsVisible = true;
                DisplayAlert("Οδηγίες", "Αν αποτύχεις σε κάποιο γύρο, ξαναπροσπαθείς από την αρχή!", "OK");                
                DisplayAlert("Οδηγίες", "Στις 3 συνεχόμενες σωστές μαντεψιές κερδίζεις", "OK");                
                DisplayAlert("Οδηγίες", "Επέλεξε στη τύχη ένα από τα κουμπιά και αν πετυχαίνεις σωστά συνεχίζεις", "OK");
                _currentNumber = _rnd.Next(1, 4); // 0, 3
                Console.WriteLine(_currentNumber);
            }
            catch (Exception exception)
            {
                DisplayAlert("Button_OnClicked Error", exception.Message,"OK");
            }
        }

        private void Button1_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("AΡΙΘΜΟΣ:" + _currentNumber);
                if (_currentNumber == 1)
                {
                    _points++;
                    if (_points == 3)
                    {
                        DisplayAlert("ΚΩΛΕ", "ΕΚΑΝΕΣ 3 ΣΕΡΙ ΣΩΣΤΕΣ ΜΑΝΤΕΨΙΕΣ", "OK");
                        IntroLayout.IsVisible = true;
                        MainLayout.IsVisible = false;
                        _points = 0;
                    }
                    else
                    {                        
                        DisplayAlert("ΤΕΛΕΙΑ", "ΤΟ ΠΕΤΥΧΕΣ! ΣΥΝΕΧΙΣΕ ΑΚΌΜΑ " + (3 - _points) + " ΠΟΝΤΟΥΣ", "OK");
                        _currentNumber = _rnd.Next(1, 4); // 0,3
                    }
                }
                else
                {
                    DisplayAlert("ΛΑΘΟΣ", "ΔΕ ΤΟ ΒΡΗΚΕΣ, HTAN TO: "+ _currentNumber  + " ΦΤΟΥ ΚΑΙ ΑΠΟ ΤΗΝ ΑΡΧΗ", "OK");
                    _points = 0;
                    _currentNumber = _rnd.Next(1, 4);
                }
            }
            catch (Exception exception)
            {
                DisplayAlert("Button1_OnClicked Error", exception.Message, "OK");
            }            
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("AΡΙΘΜΟΣ:" + _currentNumber);
                if (_currentNumber == 2)
                {
                    _points++;
                    if (_points == 3)
                    {
                        DisplayAlert("ΚΩΛΕ", "ΕΚΑΝΕΣ 3 ΣΕΡΙ ΣΩΣΤΕΣ ΜΑΝΤΕΨΙΕΣ", "OK");
                        IntroLayout.IsVisible = true;
                        MainLayout.IsVisible = false;
                        _points = 0;
                    }
                    else
                    {                        
                        DisplayAlert("ΤΕΛΕΙΑ", "ΤΟ ΠΕΤΥΧΕΣ! ΣΥΝΕΧΙΣΕ ΑΚΌΜΑ " + (3 - _points) + " ΠΟΝΤΟΥΣ", "OK");
                        _currentNumber = _rnd.Next(1, 4);
                    }                  
                }
                else
                {
                    DisplayAlert("ΛΑΘΟΣ", "ΔΕ ΤΟ ΒΡΗΚΕΣ, HTAN TO: " + _currentNumber + " ΦΤΟΥ ΚΑΙ ΑΠΟ ΤΗΝ ΑΡΧΗ", "OK");
                    _points = 0;
                    _currentNumber = _rnd.Next(1, 4);  
                }
            }
            catch (Exception exception)
            {
                DisplayAlert("Button2_OnClicked Error", exception.Message, "OK");
            }            
        }

        private void Button3_OnClicked(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("AΡΙΘΜΟΣ:" + _currentNumber);
                if (_currentNumber == 3)
                {
                    _points++;
                    if (_points == 3)
                    {
                        DisplayAlert("ΚΩΛΕ", "ΕΚΑΝΕΣ 3 ΣΕΡΙ ΣΩΣΤΕΣ ΜΑΝΤΕΨΙΕΣ", "OK");
                        IntroLayout.IsVisible = true;
                        MainLayout.IsVisible = false;
                        _points = 0;
                    }
                    else
                    {                        
                        DisplayAlert("ΤΕΛΕΙΑ", "ΤΟ ΠΕΤΥΧΕΣ! ΣΥΝΕΧΙΣΕ ΑΚΌΜΑ "+ (3 - _points) +" ΠΟΝΤΟΥΣ", "OK");
                        _currentNumber = _rnd.Next(1, 4);
                    }
                }
                else
                {
                    _points = 0;
                    DisplayAlert("ΛΑΘΟΣ", "ΔΕ ΤΟ ΒΡΗΚΕΣ, HTAN TO: " + _currentNumber + " ΦΤΟΥ ΚΑΙ ΑΠΟ ΤΗΝ ΑΡΧΗ", "OK");
                    _currentNumber = _rnd.Next(1, 4);
                }
            }
            catch (Exception exception)
            {
                DisplayAlert("Button3_OnClicked Error", exception.Message, "OK");
            }            
        }

        private void ButtonQ_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("ΠΟΥΛΟ", "ΑΝΤΙΟ ΦΥΤΟ", "OK");
            Environment.Exit(0);
        }

        private void HelpButton_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Οδηγίες", "Αν αποτύχεις σε κάποιο γύρο, ξαναπροσπαθείς από την αρχή!", "OK");
            DisplayAlert("Οδηγίες", "Στις 3 συνεχόμενες σωστές μαντεψιές κερδίζεις", "OK");
            DisplayAlert("Οδηγίες", "Επέλεξε στη τύχη ένα από τα κουμπιά και αν πετυχαίνεις σωστά συνεχίζεις", "OK");
        }
    }
}

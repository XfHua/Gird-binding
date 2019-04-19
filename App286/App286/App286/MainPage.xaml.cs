using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App286
{

    public partial class MainPage : ContentPage
    {

        int a = 0;
        public PlayerDetails playermodel;
        public MainPage()
        {
            InitializeComponent();
  
            DisplayDetails();
        }

        public void DisplayDetails()
        {
            playermodel = new PlayerDetails();
            gridDisplay.BindingContext = playermodel;
            a++;
            playermodel.FullName = a.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayDetails();
        }
    }

    public class PlayerDetails : INotifyPropertyChanged
    {

        string fullname;

        public PlayerDetails( ) {
       
        }

        public string FullName
        {
            set
            {
                if (fullname != value)
                {
                    fullname = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("FullName"));
                    }
                }
            }
            get
            {
                return fullname;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

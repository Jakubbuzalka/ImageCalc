using System;
using System.Linq;
using System.Windows;



namespace BitwiseCalc
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resX = Convert.ToInt32(X1.Text);
                int resY = Convert.ToInt32(Y.Text);
                double colourDepth = Math.Log2(Convert.ToDouble(CD.Text));
                string unit = Unit.Text;
               
            
                string[] units = { "Kb", "Mb", "Gb", "B", "b" };

            
                if (!units.Contains(unit)) {
                    MessageBox.Show("Unit not supported"); 
                };
                double screen = resY * resX;

                switch (unit)
                {
                    case "Kb":
                        Outcome.Text = Math.Round((screen * colourDepth / 8 / 1024), 2).ToString()+ " " + unit;
                        break;
                    case "Mb":
                        Outcome.Text = Math.Round((screen * colourDepth / 8 / Math.Pow(1024, 2)), 3).ToString()+ " " + unit;
                        break;
                    case "B":
                        Outcome.Text = Math.Round((screen * colourDepth), 2).ToString() + " " + unit;
                        break;
                    case "b":
                        Outcome.Text = Math.Round((screen * colourDepth / 8 ), 2).ToString() + " " + unit;
                        break;
                    case "Gb":
                        Outcome.Text = Math.Round((screen * colourDepth / 8 / Math.Pow(1024, 2)), 3).ToString() + " " + unit;
                        break;
                }

            } catch(Exception)
            {
                MessageBox.Show("Type in correct numbers");
            }
            
            

        }



    }
}

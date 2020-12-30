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

namespace CalcHelperDesktop.Pages
{
    /// <summary>
    /// Interaction logic for TransitionCurves.xaml
    /// </summary>
    public partial class TransitionCurves : Page
    {
        public TransitionCurves()
        {
            InitializeComponent();
        }

        private void CalculateShiftParametrButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double TCLength = double.Parse(TransitionCurveLengthBox.Text.Replace(".", ","));
                double ArcRadius = double.Parse(CurveRadiusBox.Text.Replace(".", ","));

                double ShiftParameter = Calcs.TransitionCurves.ShiftForStraightToArc(TCLength, ArcRadius);
                double TCHalfLength = TCLength / 2;

                TransitionCurveShiftResult.Text = ShiftParameter.ToString();
                HalfTransitionCurveLengthResult.Text = TCHalfLength.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Podano nieprawidłowy format parametru!", "Error ocured!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił niespodziewany wyjątek!", "Error ocured!");
            }
        }
    }
}

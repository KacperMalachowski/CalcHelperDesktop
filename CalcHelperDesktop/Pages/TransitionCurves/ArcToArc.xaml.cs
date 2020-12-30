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

namespace CalcHelperDesktop.Pages.TransitionCurves
{
    /// <summary>
    /// Interaction logic for ArcToArc.xaml
    /// </summary>
    public partial class ArcToArc : UserControl
    {
        public ArcToArc()
        {
            InitializeComponent();
        }

        private void UpdateShiftParameter()
        {
            try
            {
                double TCLength = 0;
                double FirstArcRadius = 0;
                double SecondArcRadius = 0;
                if (TransitionCurveLengthBox.Text.Length > 0
                    && FirstCurveRadiusBox.Text.Length > 0
                    && SecondCurveRadiusBox.Text.Length > 0)
                {
                    TCLength = double.Parse(TransitionCurveLengthBox.Text.Replace(".", ","));
                    FirstArcRadius = double.Parse(FirstCurveRadiusBox.Text.Replace(".", ","));
                    SecondArcRadius = double.Parse(SecondCurveRadiusBox.Text.Replace(".", ","));
                }

                double ShiftParameter = Calcs.TransitionCurves.ShiftForArcToArc(TCLength, FirstArcRadius, SecondArcRadius);
                double HalfTCLength = TCLength / 2;

                TransitionCurveShiftResult.Text = ShiftParameter.ToString();
                HalfTransitionCurveLengthResult.Text = HalfTCLength.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Podano nieprawidłowy format parametru! {ex.Message}", "Error ocured!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił niespodziewany wyjątek! {ex.Message}", "Error ocured!");
            }
        }

        private void TransitionCurveLengthBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(this.IsInitialized) UpdateShiftParameter();
        }

        private void FirstCurveRadiusBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsInitialized) UpdateShiftParameter();
        }

        private void SecondCurveRadiusBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsInitialized) UpdateShiftParameter();
        }
    }
}

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
    /// Interaction logic for StraightToArc.xaml
    /// </summary>
    public partial class StraightToArc : UserControl
    {
        public StraightToArc()
        {
            InitializeComponent();
        }

        private void UpdateStraightToArcShiftParameter()
        {
            try
            {
                double TCLength = 0;
                double ArcRadius = 0;
                if (TransitionCurveLengthBox.Text.Length > 0 && CurveRadiusBox.Text.Length > 0)
                {
                    TCLength = double.Parse(TransitionCurveLengthBox.Text.Replace(".", ","));
                    ArcRadius = double.Parse(CurveRadiusBox.Text.Replace(".", ","));
                }

                double ShiftParameter = Calcs.TransitionCurves.ShiftForStraightToArc(TCLength, ArcRadius);
                double TCHalfLength = TCLength / 2;

                TransitionCurveShiftResult.Text = ShiftParameter.ToString();
                HalfTransitionCurveLengthResult.Text = TCHalfLength.ToString();
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
            if (this.IsInitialized) UpdateStraightToArcShiftParameter();
        }

        private void CurveRadiusBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsInitialized) UpdateStraightToArcShiftParameter();
        }
    }
}

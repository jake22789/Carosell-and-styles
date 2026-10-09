using Syncfusion.Maui.Toolkit.Charts;

namespace Carosell_and_styles.Pages.Controls
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.5;
        }
    }
}

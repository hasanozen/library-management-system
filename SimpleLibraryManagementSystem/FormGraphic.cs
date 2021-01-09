using System;
using System.Drawing;
using System.Windows.Forms;
using BL;
using ZedGraph;

namespace SimpleLibraryManagementSystem
{
    public partial class FormGraphic : Form
    {
        public FormGraphic()
        {
            InitializeComponent();
        }

        Flow flow;

        private void FormGraphic_Load(object sender, EventArgs e)
        {
            if (flow == null)
                flow = new Flow();

            DrawBookGraph();
        }

        private void DrawBookGraph()
        {
            int book = flow.List();
            int bookRent = flow.GetRented();

            GraphPane pane = zgc.GraphPane;
            
            zgc.IsEnableWheelZoom = true;
            pane.Title.Text = "Book Graph";

            string[] row = { "Rent Books", "Rent Ready Books", "All Books" };
            double[] bookNum = { bookRent, book - bookRent, book };

            pane.AddPieSlices(bookNum, new[] { "Rent Books", "Rent Ready Books", null });
            pane.Legend.IsVisible = true;

            LineItem line = pane.AddCurve(null, null, bookNum, Color.Purple);
            line.Line.Fill = new Fill(Color.Red, Color.White, Color.Blue);

            pane.XAxis.Scale.TextLabels = row;
            pane.XAxis.Type = AxisType.Text;

            pane.Chart.Fill = new Fill(Color.White, Color.FromArgb(242, 242, 242), 90f);
            pane.Fill = new Fill(Color.FromArgb(245, 245, 245));
            pane.Border.IsVisible = false;
            zgc.AxisChange();
        }
    }
}

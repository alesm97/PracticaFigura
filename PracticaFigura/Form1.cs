using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFigura
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// In the creation of the Form, we have to change the maximum of the decimal input objects
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            rectangleBase.Maximum = Decimal.MaxValue;
            rectangleHeight.Maximum = Decimal.MaxValue;
            triangleBase.Maximum = Decimal.MaxValue;
            triangleHeight.Maximum = Decimal.MaxValue;
            circleRadius.Maximum = Decimal.MaxValue;
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clicking in this button, we set the result of the rectangle operations.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();

            String resultArea = String.Format("Area: {0} m²", rectangle.Area((float)rectangleBase.Value, (float)rectangleHeight.Value));
            String resultPerimetre = String.Format("Perimetre: {0} m", rectangle.Perimetre((float)rectangleBase.Value, (float)rectangleHeight.Value));

            rectangleAreaText.Text = resultArea;
            rectanglePerimetreText.Text = resultPerimetre;


        }

        /// <summary>
        /// Clicking in this button, we set the result of the triangle operations.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void triangleButton_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();

            String resultArea = String.Format("Area: {0} m²", triangle.Area((float)triangleBase.Value, (float)triangleHeight.Value));
            String resultPerimetre = String.Format("Perimetre: {0} m", triangle.Perimetre((float)triangleBase.Value, (float)triangleHeight.Value));

            triangleAreaText.Text = resultArea;
            perimetreTriangleText.Text = resultPerimetre;
        }

        /// <summary>
        /// Clicking in this button, we set the result of the triangle operations.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void circleButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();

            String resultArea = String.Format("Area: {0} m²", circle.Area((float)circleRadius.Value));
            String resultPerimetre = String.Format("Perimetre: {0} m", circle.Perimetre((float)circleRadius.Value));

            circleAreaText.Text = resultArea;
            circlePerimetreText.Text = resultPerimetre;
        }

        /// <summary>
        /// When the input value changed, we have to checked if the values of base and height are higher than 0, if they are, enable the button. 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="events">event args</param>
        private void rectangleValueChanged(Object sender, EventArgs events)
        {
            if (rectangleBase.Value == 0 || rectangleHeight.Value == 0)
            {
                RectangleButton.Enabled = false;
            }
            else
            {
                RectangleButton.Enabled = true;
            }
        }

        /// <summary>
        /// When the input value changed, we have to checked if the values of base and height are higher than 0, if they are, enable the button.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void triangleValueChanged(object sender, EventArgs e)
        {
            if (triangleBase.Value == 0 || triangleHeight.Value == 0)
            {
                triangleButton.Enabled = false;
            }
            else
            {
                triangleButton.Enabled = true;
            }
        }

        /// <summary>
        /// When the input value changed, we have to checked if radius value is higher than 0, if it is, enable the button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void circleRadius_ValueChanged(object sender, EventArgs e)
        {
            if (circleRadius.Value == 0)
            {
                circleButton.Enabled = false;
            }
            else
            {
                circleButton.Enabled = true;
            }
        }
    }
}

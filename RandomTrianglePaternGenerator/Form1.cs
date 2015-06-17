using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTrianglePaternGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainColor = Color.Black;
            color2 = Color.Orange;
            color3 = Color.Red;
            color4 = Color.OrangeRed;
            color5 = Color.DarkOrange;
        }

        int panelWidth, panelHeight;
        Random randomInt = new Random();
        
        private void mouse_Click(object sender, MouseEventArgs e)
        {
            //Create graphics, set panelWidth and Height
            Graphics g = trianglePanel.CreateGraphics();
            panelWidth = trianglePanel.Width;
            panelHeight = trianglePanel.Height;

            setBlack(g, panelWidth, panelHeight);
            int startingX = 0;
            int startingY = 0;
            drawTriangle(g, startingX, startingY);

        }

        Color mainColor = System.Drawing.ColorTranslator.FromHtml("#361900");
        Color color2, color3, color4, color5;

        private void setBlack(Graphics g, int panelWidth, int panelHeight)
        {
            SolidBrush blackBrush = new SolidBrush(mainColor);
            g.FillRectangle(blackBrush, 0, 0, panelWidth, panelHeight);
        }

        private Color getRandomColor()
        {
            int colorNum = randomInt.Next(1, 6);
            Color brushColor;

            //if statements to select color
            #region
            if (colorNum == 1)
            {
                brushColor = mainColor;
            }
            else if (colorNum == 2)
            {
                brushColor = color2;
            }
            else if (colorNum == 3)
            {
                brushColor = color3;
            }
            else if (colorNum == 4)
            {
                brushColor = color4;
            }
            else if (colorNum == 5)
            {
                brushColor = color5;
            }
            else
            {
                brushColor = mainColor;
            }
            #endregion

            return brushColor;
        }

        private Point[] calculatePoints(int startingX, int startingY)
        {
            int randomPoint = randomInt.Next(1, 4);
            
            //Get random int, calculate points using startingX, startingY according to which number the random int returns
            #region
            if (randomPoint == 1)
            {
                Point[] trianglePoints = { new Point(startingX, startingY), new Point(startingX + 50, startingY), new Point(startingX, startingY + 50) };
                return trianglePoints;
            }
            else if (randomPoint == 2)
            {
                Point[] trianglePoints = { new Point(startingX, startingY), new Point(startingX + 50, startingY), new Point(startingX + 50, startingY + 50) };
                return trianglePoints;
            }
            else if (randomPoint == 3)
            {
                Point[] trianglePoints = { new Point(startingX, startingY), new Point(startingX, startingY + 50), new Point(startingX + 50, startingY + 50) };
                return trianglePoints;
            }
            else if (randomPoint == 4)
            {
                Point[] trianglePoints = { new Point(startingX, startingY + 50), new Point(startingX + 50, startingY), new Point(startingX + 50, startingY + 50) };
                return trianglePoints;
            }
            else
            {
                Point[] trianglePoints = { new Point(startingX, startingY), new Point(startingX, startingY), new Point(startingX, startingY) };
                return trianglePoints;
            }
            #endregion

        }

        private void drawTriangle(Graphics g, int startingX, int startingY)
        {
            for (startingX = 0; startingX < panelWidth; startingX = startingX + 0)
            {
                for (startingY = 0; startingY < panelHeight; startingY = startingY + 0)
                {
                    SolidBrush drawBrush = new SolidBrush(getRandomColor());
                    g.FillPolygon(drawBrush, calculatePoints(startingX, startingY));
                    startingY = startingY + 50;
                }
                SolidBrush drawBrush2 = new SolidBrush(getRandomColor());
                g.FillPolygon(drawBrush2, calculatePoints(startingX, startingY));
                startingX = startingX + 50;
            }
        }

        //Color pallet button clicks
        #region
        private void mainColorBtn_Click(object sender, EventArgs e)
        {
            DialogResult mainColorResult = mainColorDialog.ShowDialog();
            if (mainColorResult == DialogResult.OK)
            {
                mainColor = mainColorDialog.Color;
                mainColorPicBox.BackColor = mainColorDialog.Color;
            }
        }

        private void secondColorBtn_Click(object sender, EventArgs e)
        {
            DialogResult secondColorResult = secondColorDialog.ShowDialog();
            if (secondColorResult == DialogResult.OK)
            {
                color2 = secondColorDialog.Color;
                secondColorPicBox.BackColor = secondColorDialog.Color;
            }
        }

        private void thirdColorBtn_Click(object sender, EventArgs e)
        {
            DialogResult thirdColorResult = thirdColorDialog.ShowDialog();
            if (thirdColorResult == DialogResult.OK)
            {
                color3 = thirdColorDialog.Color;
                thirdColorPicBox.BackColor = thirdColorDialog.Color;
            }
        }

        private void fourthColorBtn_Click(object sender, EventArgs e)
        {
            DialogResult fourthColorResult = fourthColorDialog.ShowDialog();
            if (fourthColorResult == DialogResult.OK)
            {
                color4 = fourthColorDialog.Color;
                fourthColorPicBox.BackColor = fourthColorDialog.Color;
            }
        }

        private void fifthColorBtn_Click(object sender, EventArgs e)
        {
            DialogResult fifthColorResult = fifthColorDialog.ShowDialog();
            if (fifthColorResult == DialogResult.OK)
            {
                color5 = fifthColorDialog.Color;
                fifthColorPicBox.BackColor = fifthColorDialog.Color;
            }
        }
        #endregion

    }
}

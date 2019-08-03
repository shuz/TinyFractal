using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace TinyFractal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            txtRandomStep.Text = "1000";
            txtCurrentImage.Text = "0";
            txtImageCount.Text = "20";
            txtPoint.Text = new Point2D(0, 0).ToString();
            txtLine.Text = new Line2D(100, 380, 700, 380).ToString();
            txtRandomRatio.Text = "0.5";
        }

        private Bitmap randomBitmap;
        private Point2D randomTrace;
        private IFractal fractal;

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (randomBitmap != null)
            {
                e.Graphics.DrawImage(randomBitmap, 0, 0);
            }

            if (fractal != null)
            {
                if (fractal.Iteration != null)
                {
                    ChangeCurrentImage();
                    foreach (Line2D line in fractal.Iteration)
                    {
                        DrawLine(e.Graphics, line, Pens.Yellow);
                    }
                }
            }

            if (chkShowMappings.Checked && fractal != null)
            {
                if (fractal is RandomFractal)
                {
                    foreach (RandomFractal.MappingItem item in fractal as RandomFractal)
                    {
                        DrawFractal(e.Graphics, item.Fractal);
                    }
                }
                else
                if (fractal is Fractal)
                {
                    DrawFractal(e.Graphics, fractal as Fractal);
                }
            }
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            txtSelectedPoint.Text = string.Format("({0}, {1})", e.X, e.Y);
            Clipboard.SetText(txtSelectedPoint.Text);
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblPositionTip.Text = string.Format("({0}, {1})", e.X, e.Y);
        }

        private void DrawPoint(Point2D p, Color c)
        {
            if (p.X >= 0 && p.X < randomBitmap.Width - 1 &&
                p.Y >= 0 && p.Y < randomBitmap.Height - 1)
            {
                randomBitmap.SetPixel((int)(p.X + 0.5), (int)(p.Y + 0.5), c);
            }
        }

        private void DrawLine(Graphics g, Line2D l, Pen p)
        {
            if (l != null)
            {
                g.DrawLine(p, (float)l.Begin.X, (float)l.Begin.Y, (float)l.End.X, (float)l.End.Y);
            }
        }

        private void DrawMapper(Graphics g, SimilitudeMappingMaker mapper)
        {
            DrawLine(g, mapper.InitialLine, Pens.Green);
            DrawLine(g, mapper.MappingLine, Pens.Red);
        }

        private void DrawFractal(Graphics g, Fractal fractal)
        {
            foreach (IMappingMaker maker in fractal)
            {
                if (maker is SimilitudeMappingMaker)
                {
                    DrawMapper(g, maker as SimilitudeMappingMaker);
                }
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            if (fractal == null)
            {
                fractal = FractalParser.Parse(txtMappings.Text);
                
                if (fractal is RandomFractal)
                {
                    RandomFractal randomFractal = fractal as RandomFractal;

                    int imageCount = 4;
                    if (int.TryParse(txtImageCount.Text, out imageCount))
                    {
                        randomFractal.ImageCount = imageCount;
                    }
                }
            }

            if (fractal.Iteration == null)
            {
                List<Line2D> initial = new List<Line2D>();
                initial.Add(Line2D.Parse(txtLine.Text));
                fractal.Iteration = initial;
            }

            if (fractal.Iteration.Count <= 5000)
            {
                fractal.Iterate();
            }

            picCanvas.Invalidate();
        }

        private void btnStartRandom_Click(object sender, EventArgs e)
        {
            if (randomBitmap == null)
            {
                randomTrace = Point2D.Parse(txtPoint.Text);
                randomBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
                fractal = FractalParser.Parse(txtMappings.Text);
            }
            
            int step = int.Parse(txtRandomStep.Text);
            for (int i = 0; i < step; ++i)
            {
                randomTrace = fractal.RandomTrace(randomTrace);
                DrawPoint(randomTrace, Color.Blue);
            }
            picCanvas.Invalidate();
        }

        private void btnClearRandom_Click(object sender, EventArgs e)
        {
            randomBitmap = null;
            picCanvas.Invalidate();
        }

        private void btnClearNormal_Click(object sender, EventArgs e)
        {
            fractal = null;
            picCanvas.Invalidate();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            fractal = FractalParser.Parse(txtMappings.Text);

            if (fractal is RandomFractal)
            {
                RandomFractal randomFractal = fractal as RandomFractal;

                int imageCount = 4;
                if (int.TryParse(txtImageCount.Text, out imageCount))
                {
                    randomFractal.ImageCount = imageCount;
                }
            }
            picCanvas.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMappings.Clear();
            btnParse_Click(null, null);
            btnClearRandom_Click(null, null);
            btnClearNormal_Click(null, null);
        }

        private void chkShowMappings_CheckedChanged(object sender, EventArgs e)
        {
            picCanvas.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                using (Stream stream = openFileDialog1.OpenFile())
                using (StreamReader file = new StreamReader(stream))
                {
                    txtMappings.Text = file.ReadToEnd();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                using (Stream stream = saveFileDialog1.OpenFile())
                using (StreamWriter file = new StreamWriter(stream))
                {
                    file.Write(txtMappings.Text);
                }
            }
        }

        private void ChangeCurrentImage()
        {
            if (fractal != null && fractal is RandomFractal)
            {
                int currentImage = 0;
                if (int.TryParse(txtCurrentImage.Text, out currentImage))
                {
                    RandomFractal randomFractal = fractal as RandomFractal;
                    randomFractal.CurrentImage = currentImage;
                }
            }
        }

        private void txtCurrentImage_Leave(object sender, EventArgs e)
        {
            ChangeCurrentImage();
            picCanvas.Invalidate();
        }

        private void txtCurrentImage_TextChanged(object sender, EventArgs e)
        {
            ChangeCurrentImage();
            picCanvas.Invalidate();
        }

        private void btnRandomKoch_Click(object sender, EventArgs e)
        {
            this.fractal = new RandomKochCurve(double.Parse(txtRandomRatio.Text));
            picCanvas.Invalidate();
        }
    }
}
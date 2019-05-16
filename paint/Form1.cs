using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace paint
{
    public partial class Form1 : Form
    {
        private IActionRegister iationRegister;
        private IListOfTools ilistoftools;
        private SolidBrush myBrush;
        private Graphics myGraphics;
        private IPenTool myPen;
        private Point startXY = new Point(0, 0);

        private bool elipseUse = false;
        private bool penUse = false;
        private bool brushUse = false;
        private bool isDrawning = false;
        private bool rectangleUse = false;
        private bool filElipseUse = false;
        private bool filRectangle = false;
        private bool eraseUse = false;
        private Bitmap obrazek2;
        private Point pStart, pEnd;
        private List<Action<Graphics>> lista = new List<Action<Graphics>>();
        public int counter = 0;
        public Form1() 
        {
            InitializeComponent();
            InitializeObject(new ActionRegister());
        }

        public void InitializeObject(IActionRegister iationRegister) 
        {
            this.iationRegister = iationRegister;
            this.myPen = new PenTool(0, 0, colorPanel.BackColor);
            ilistoftools = new ListOfTools();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            initializeTools();
            
        }
        void initializeTools()
        {
            float widthBrush = int.Parse(nudTRackBar.Text);
            myBrush = new SolidBrush(colorPanel.BackColor);
            myGraphics =  canvasPicture.CreateGraphics();
           // myPen = new Pen(colorPanel.BackColor,widthBrush);
           
        }       
        private void colorPanel_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog1.Color;
                myBrush.Color = colorPanel.BackColor;
               // myPen.Color = colorPanel.BackColor;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            nudTRackBar.Text = trackBar1.Value.ToString();
        }

        private void nudTRackBar_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)nudTRackBar.Value;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            canvasPicture.BackColor = Color.White;
            myGraphics.Clear(Color.White);
        }
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            Image obrazek;
           
           o.Filter = "bitmapy |*.bmp";
           o.FilterIndex = 1;
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                obrazek = (Image)Image.FromFile(o.FileName).Clone();
                obrazek2 = new Bitmap(obrazek, canvasPicture.Width, canvasPicture.Height);
                canvasPicture.BackgroundImage = obrazek2;
                myGraphics.DrawImage(obrazek2, startXY);               
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            Bitmap bmp1 = getBmp();
           // Image img2;
           
            bmp1.RotateFlip(RotateFlipType.Rotate270FlipNone);
           
            
           bmp1.Save("d:\\cos2.bmp");
           /* OpenFileDialog o = new OpenFileDialog();
            string plik = "d:\\cos.bmp";*/
            //dziala ale nie wyswietla

           /* img2 = (Image)Image.FromFile(plik).Clone();
            obrazek2 = new Bitmap(img2, canvasPicture.Width, canvasPicture.Height);
            canvasPicture.BackgroundImage = obrazek2;
            int liczba3 = obrazek2.Width;
            int liczba4 = obrazek2.Height;
            int x = liczba3 - liczba1;
            int y = liczba4 - liczba2;
            Point newPoint = new Point(x, y);
            myGraphics.DrawImage(obrazek2, newPoint);  */

            myGraphics = Graphics.FromImage(bmp1);
            myGraphics.DrawImage(bmp1, startXY);
            obrazek2 = getBmp();
            myGraphics.Dispose();
            myGraphics = canvasPicture.CreateGraphics();
        }

        public Pen setSizeAndColor(IPenTool ipentool, int size, Color color)
        {
            return myPen.ChangeSize(myPen, (int)nudTRackBar.Value, colorPanel.BackColor);
        }

        private void canvasPicture_MouseUp(object sender, MouseEventArgs e)
        {
            pEnd = new Point(e.X, e.Y);

            if (ilistoftools.chooseActiveTool("Line"))
            {
               // myPen = new Pen(colorPanel.BackColor, (int)nudTRackBar.Value);
                var pen = setSizeAndColor(myPen, (int)nudTRackBar.Value, colorPanel.BackColor);
                myGraphics.DrawLine(pen,pStart,pEnd);
                iationRegister.SetElementToListOfActions(x => x.DrawLine(pen, pStart, pEnd));
            }
           
            if (ilistoftools.chooseActiveTool("Rectangle"))
            {
                // myPen = new Pen(colorPanel.BackColor, (int)nudTRackBar.Value);
                var pen = setSizeAndColor(myPen, (int)nudTRackBar.Value, colorPanel.BackColor);
                myGraphics.DrawRectangle(pen, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
                iationRegister.SetElementToListOfActions(x => x.DrawRectangle(new Pen(Color.White), pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y)));
            }
            if (ilistoftools.chooseActiveTool("Ellipse"))
            {
                //myPen = new Pen(colorPanel.BackColor, (int)nudTRackBar.Value);
                var pen = setSizeAndColor(myPen, (int)nudTRackBar.Value, colorPanel.BackColor);
                myGraphics.DrawEllipse(pen, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
                iationRegister.SetElementToListOfActions(x => x.DrawEllipse(new Pen(Color.White), pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y)));
            }
            if (ilistoftools.chooseActiveTool("FillEllipse"))
            {
                myBrush = new SolidBrush(colorPanel.BackColor);
                myGraphics.FillEllipse(myBrush, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
                iationRegister.SetElementToListOfActions(x => x.FillEllipse(new SolidBrush(Color.White), pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y)));
            }
            if (ilistoftools.chooseActiveTool("FillRectangle"))
            {
                
                myBrush = new SolidBrush(colorPanel.BackColor);
                myGraphics.FillRectangle(myBrush, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
                iationRegister.SetElementToListOfActions(x => x.FillRectangle(new SolidBrush(Color.White), pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y)));
            }
         
            obrazek2 = getBmp();
            isDrawning = false;
            myGraphics.Dispose();
            myGraphics = canvasPicture.CreateGraphics();
        }
        /// <summary>
        /// get bmp from the screen
        /// </summary>
        /// <returns></returns>
        Bitmap getBmp()
        {
            Bitmap bmp = new Bitmap(canvasPicture.Width, canvasPicture.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = canvasPicture.RectangleToScreen(canvasPicture.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, canvasPicture.Size);
            myGraphics = g;
            g.Dispose();
            return bmp;
        }
        private void canvasPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawning == true)
            {
                if (ilistoftools.chooseActiveTool("Brush"))
                {
                    myGraphics.FillEllipse(myBrush, e.X, e.Y, (int)nudTRackBar.Value, (int)nudTRackBar.Value);
                    iationRegister.SetElementToListOfActions(x => x.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, (int)nudTRackBar.Value, (int)nudTRackBar.Value)); 
                }
                if (ilistoftools.chooseActiveTool("Eraser"))
                {
                    myBrush = new SolidBrush(Color.White);
                    myGraphics.FillEllipse(myBrush, e.X, e.Y, (int)nudTRackBar.Value, (int)nudTRackBar.Value);
                    iationRegister.SetElementToListOfActions(x => x.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, (int)nudTRackBar.Value, (int)nudTRackBar.Value));
                }
                
            }
          //  obrazek2 = getBmp();
        }

        private void canvasPicture_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawning = true;
            pStart = new Point(e.X, e.Y);
            //canvasPanel.Invalidate();
        }
        //cofnij
        private void button9_Click(object sender, EventArgs e)
        {
           // int ost = 0;         
            myGraphics = canvasPicture.CreateGraphics();
            if (lista.Any())
            {
                
                counter = lista.Count - 1 ;
                if (counter >= 0)
                {
                    lista[counter].Invoke(myGraphics);
                    -- counter;
                    //lista[0].Invoke(myGraphics);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(canvasPicture.Width, canvasPicture.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = canvasPicture.RectangleToScreen(canvasPicture.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, canvasPicture.Size);
            myGraphics = g;
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.OpenWrite(s.FileName);
                }
                if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
            myGraphics = canvasPicture.CreateGraphics();
        }

        private void canvasPicture_Resize(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(canvasPicture.Width, canvasPicture.Height);

            // Set the size of the PictureBox control. 
            canvasPicture.Size = new System.Drawing.Size(canvasPicture.Width, canvasPicture.Height);

            //Set the SizeMode to center the image. 
            canvasPicture.SizeMode = PictureBoxSizeMode.CenterImage;

            // Set the border style to a three-dimensional border. 
            this.canvasPicture.BorderStyle = BorderStyle.Fixed3D;

            // Set the image property. 
            this.canvasPicture.Image = obrazek2;
            canvasPicture.SizeMode = PictureBoxSizeMode.StretchImage;
           
            myGraphics = canvasPicture.CreateGraphics();
        }
        

        private void tsbBrush_Click(object sender, EventArgs e)
        {
            ilistoftools.setActiveTool("Brush");
        }

        private void tsbLinia_Click(object sender, EventArgs e)
        {
            ilistoftools.setActiveTool("Line");
        }

        private void tsbKolo_Click(object sender, EventArgs e)
        {
            ilistoftools.setActiveTool("Ellipse");
        }

        private void tsbKoloCz_Click(object sender, EventArgs e)
        {
            ilistoftools.setActiveTool("FillEllipse");
        }

        private void tsbKwadrat_Click(object sender, EventArgs e)
        {
            ilistoftools.setActiveTool("Rectangle");
        }

        private void tsbKwadratCz_Click(object sender, EventArgs e)
        {
            ilistoftools.setActiveTool("FillRectangle");
        }
        private void tsbGumka_Click(object sender, EventArgs e)
        {
            ilistoftools.setActiveTool("Eraser");
        }
        /// <summary>
        /// print screen new 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ScreenCapture sc = new ScreenCapture();
            // capture entire screen, and save it to a file
            Image img = sc.CaptureScreen();
            // display image in a Picture control named imageDisplay
            this.canvasPicture.Image = img;
            // capture this window, and save it
            sc.CaptureWindowToFile(this.Handle, "d:\\temp2.gif", ImageFormat.Gif);

           var  obrazek = (Image)Image.FromFile("d:\\temp2.gif").Clone();
            obrazek2 = new Bitmap(obrazek, canvasPicture.Width, canvasPicture.Height);
            canvasPicture.BackgroundImage = obrazek2;
            myGraphics.DrawImage(obrazek2, startXY);

        }

       
    }
}

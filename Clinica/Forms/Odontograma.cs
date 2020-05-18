using Clinica.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Odontograma : Form
    {
        CapaGlobal.Clases.Messages mssg;
        public Odontograma()
        {
            mssg = new CapaGlobal.Clases.Messages();
            InitializeComponent();
        }
        int x;
        int y;
        int x2;
        int y2;
        int opcion = 0;
        List<Dibujar> lista = new List<Dibujar>();
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                switch (tipo)
                {
                    case 1:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 1;
                        break;
                    case 2:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 2;
                        break;
                    case 3:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 3;
                        break;
                    case 4:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 4;
                        break;
                    case 5:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 5;
                        break;
                    case 6:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 6;
                        break;
                    case 7:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 7;
                        break;
                    case 8:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 8;
                        break;
                    case 9:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 9;
                        break;
                    case 10:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 10;
                        break;
                    case 11:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 11;
                        break;
                    case 12:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 12;
                        break;
                    case 13:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 13;
                        break;
                    case 14:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 14;
                        break;
                    case 15:
                        x = e.X;
                        y = e.Y;
                        panel2.Invalidate();
                        opcion = 15;
                        break;
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }
        Image img;
        Graphics g;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                g = panel2.CreateGraphics();


                switch (opcion)
                {
                    case 1:

                        img = Image.FromFile(@"clase2.png");
                        g.DrawImage(img, x, y, 30, 30);

                        break;
                    case 2:

                        img = Image.FromFile(@"clase22.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 3:

                        img = Image.FromFile(@"clase3.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 4:

                        img = Image.FromFile(@"clase41.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 5:

                        img = Image.FromFile(@"clase5.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 6:

                        img = Image.FromFile(@"clase61.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 7:

                        img = Image.FromFile(@"protesis.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 8:

                        img = Image.FromFile(@"extraccion.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 9:

                        img = Image.FromFile(@"cirujiaCordal.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 10:

                        img = Image.FromFile(@"apiceptomia2.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 11:

                        img = Image.FromFile(@"endodoncias.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 12:

                        img = Image.FromFile(@"endoposte.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 13:

                        img = Image.FromFile(@"coronas.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 14:

                        img = Image.FromFile(@"periodontal.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                    case 15:

                        img = Image.FromFile(@"clase1.png");
                        g.DrawImage(img, x, y, 30, 30);
                        break;
                }

                foreach (Dibujar list in lista)
                {

                    g.DrawImage(list.ruta, list.x, list.y, 30, 30);
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        int tipo = 0;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                switch (tipo)
                {
                    case 1:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 1;
                        }
                        break;
                    case 2:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 2;
                        }
                        break;
                    case 3:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 3;
                        }
                        break;
                    case 4:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 4;
                        }
                        break;
                    case 5:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 5;
                        }
                        break;
                    case 6:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 6;
                        }
                        break;
                    case 7:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 7;
                        }
                        break;
                    case 8:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 8;
                        }
                        break;
                    case 9:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 9;
                        }
                        break;
                    case 10:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 10;
                        }
                        break;
                    case 11:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 11;
                        }
                        break;
                    case 12:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 12;
                        }
                        break;
                    case 13:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 13;
                        }
                        break;
                    case 14:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 14;
                        }
                        break;
                    case 15:
                        if (e.Button == MouseButtons.Left)
                        {

                            x = e.X;
                            y = e.Y;
                            panel2.Invalidate();
                            opcion = 15;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tipo = 1;
        }

 

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tipo = 2;
        }

        

        public void dibujar()
        {
            if (img != null)
            {
                Dibujar dibujo = new Dibujar();
                dibujo.ruta = img;
                dibujo.x = x;
                dibujo.y = y;
                lista.Add(dibujo);

            }
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dibujar();
        
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    panel2.BackgroundImage = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics objGraphics;
                Bitmap bmp;

                Rectangle rt;
                Point pnt;


                rt = this.ClientRectangle;
                pnt = this.PointToScreen(new Point(100, 100));

                bmp = new Bitmap(panel2.Width, panel2.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                try
                {
                    objGraphics = Graphics.FromImage(bmp);
                    objGraphics.CopyFromScreen(pnt.X +15, pnt.Y-25, 0, 50, rt.Size, CopyPixelOperation.SourceCopy);
                    objGraphics.Dispose();
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Images|*.png;*.bmp;*.jpg";
                    ImageFormat format = ImageFormat.Png;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        bmp.Save(dialog.FileName, ImageFormat.Jpeg);

                        bmp.Dispose();
                    }
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex)
            {
                mssg.showMessage(ex.Message, "error", "");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tipo = 3;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tipo = 15;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tipo = 4;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tipo = 5;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tipo = 6;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tipo = 7;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            tipo = 8;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            tipo = 9;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            tipo = 10;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            tipo = 11;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            tipo = 12;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            tipo = 13;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            tipo = 14;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
    }
}

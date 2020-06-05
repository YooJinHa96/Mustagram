using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustagram
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
          
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           // listView1.View = View.Details;

           // listView1.Columns.Add("Spacecraft", 300); ;
            //listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
          //  populate();

        }
        private void populate()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(50, 50);
         
            //Load IMGS FROM FILE
            String[] paths = { };
            paths = Directory.GetFiles("C:/Users/poop4/Documents/GitHub/Mustagram/Mustagram/Mustagram/imagetest");//server host? 넣기

            try
            {
                foreach (String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //BIND IMGS TO LISTVIEW
            //listView1.SmallImageList = imgs;
            //listView1.Items.Add("jusu", 0);
            //listView1.Items.Add("jusu2", 1);

        }
    }
}

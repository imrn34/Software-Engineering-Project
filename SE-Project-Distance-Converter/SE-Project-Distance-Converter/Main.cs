using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Project_Distance_Converter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            leftcom.SelectedIndex = 0;
            rightcom.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            this.BackColor = System.Drawing.Color.Gray;

            ComboBox leftcom = new ComboBox();
            leftcom.Height = 20;
            leftcom.Width = 120;
            leftcom.ForeColor = Color.Black;
            leftcom.Location = new Point(149, 60);
            leftcom.Items.Add("Milimeter (mm)");
            leftcom.Items.Add("Centimeter (cm)");
            leftcom.Items.Add("Meter (m)");
            leftcom.Items.Add("Kilometer (km)");
            this.Controls.Add(leftcom);


            ComboBox rightcom = new ComboBox();
            rightcom.Height = 20;
            rightcom.Width = 120;
            rightcom.ForeColor = Color.Black;
            rightcom.Location = new Point(285, 60);
            rightcom.Items.Add("Milimeter (mm)");
            rightcom.Items.Add("Centimeter (cm)");
            rightcom.Items.Add("Meter (m)");
            rightcom.Items.Add("Kilometer (km)");
            this.Controls.Add(rightcom);


            TextBox lefttext = new TextBox();
            lefttext.Height = 20;
            lefttext.Width = 120;
            lefttext.ForeColor = Color.Blue;
            lefttext.Location = new Point(149, 90);
            lefttext.Name = "lefttext";
            this.Controls.Add(lefttext);


            TextBox righttext = new TextBox();
            righttext.Height = 20;
            righttext.Width = 120;
            righttext.ForeColor = Color.Blue;
            righttext.Location = new Point(285, 90);
            this.Controls.Add(righttext);


            Button Btn = new Button();
            Btn.Text = " -  CONVERT  -  ";
            Btn.Height = 30;
            Btn.Width = 420;
            Btn.Name = "Btn";
            Btn.FlatStyle = FlatStyle.Flat;
            Btn.ForeColor = Color.Wheat;
            Btn.Location = new Point(0, 135);
            Btn.FlatAppearance.BorderSize = 0;
            this.Controls.Add(Btn);


            Label ext = new Label();
            ext.Text = "X";
            ext.Height = 30;
            ext.Width = 30;
            ext.FlatStyle = FlatStyle.Flat;
            ext.TextAlign = ContentAlignment.MiddleCenter;
            ext.BackColor = Color.Wheat;
            ext.ForeColor = Color.Black;
            ext.Location = new Point(380, 0);
            this.Controls.Add(ext);



            Label title1 = new Label();
            title1.Text = "-  DISTANCE CONVERTER  -";
            title1.Height = 30;
            title1.Width = 420;
            title1.TextAlign = ContentAlignment.MiddleCenter;
            title1.BackColor = Color.Wheat;
            title1.ForeColor = Color.Black;
            title1.Location = new Point(0, 0);
            this.Controls.Add(title1);


            Label dis = new Label();
            dis.Text = "    ||  DISTANCES  || ";
            dis.Height = 18;
            dis.Width = 110;
            dis.TextAlign = ContentAlignment.MiddleLeft;
            dis.BackColor = Color.White;
            dis.ForeColor = Color.Black;
            dis.Location = new Point(20, 61);
            this.Controls.Add(dis);


            Label val = new Label();
            val.Text = "    ||     VALUES     || ";
            val.Height = 18;
            val.Width = 110;
            val.TextAlign = ContentAlignment.MiddleLeft;
            val.BackColor = Color.White;
            val.ForeColor = Color.Black;
            val.Location = new Point(20, 91);
            this.Controls.Add(val);

        }
    }
}

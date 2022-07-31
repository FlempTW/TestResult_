using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace TestResult_
{

    public partial class UserControl1: UserControl
    {
        
        int times = 0;
        string current_path = "E:\\majong\\wanin_mahjongaitool-TestTool\\TestToolApp\\TestTool\\TestResult_\\Resources\\";
        //int house = 0;
        //string pong = "碰牌";
        //string zi_mo = "自摸";
        //string fang_qiang = "放槍";
        //string hu = "胡牌";
        //string chi = "吃";
        //string gang = "槓";
        //
        public UserControl1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {
            string s = time_textBox.Text.ToString();
            times = int.Parse(s);
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            ////////////////
            ///第一家自摸///
            ////////////////
            int result1 = 1;
            int pic1 = 1;
            string path1 = current_path + pic1.ToString() + ".png";
            result_lable1_1.Text = " 第一家自摸共 " + result1.ToString() + " 次";
            result_lable1_2.Text = " 共 "+ result1.ToString() + " 次";
            try
            {         
                pictureBox1.Image = Image.FromFile(path1);
                /*using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
                {
                    pictureBox1.Image = resxSet.GetObject("1.png", true);
                }*/
            }
            catch(Exception FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            ////////////////
            ///第一家胡牌///
            ////////////////
            int result2 = 2;
            int pic2 = 2;
            string path2 = current_path + pic2.ToString() + ".png";
            result_lable2_1.Text = " 第一家胡牌共 " + result2.ToString() + " 次";
            result_lable2_2.Text = " 共 " + result2.ToString() + " 次";
            try
            {
                pictureBox2.Image = Image.FromFile(path2);
            }
            catch (Exception FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            ////////////////
            ///第一家放槍///
            ////////////////
            int result3 = 3;
            int pic3 = 3;
            string path3 = current_path + pic3.ToString() + ".png";
            result_lable3_1.Text = " 第一家放槍共 " + result3.ToString() + " 次";
            result_lable3_2.Text = " 共 " + result3.ToString() + " 次";
            try
            {
                pictureBox3.Image = Image.FromFile(path3);
            }
            catch (Exception FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            ////////////////
            ///第二家自摸///
            ////////////////
            int result4 = 4;
            int pic4 = 4;
            string path4 = current_path + pic4.ToString() + ".png";
            result_lable4_1.Text = " 第二家自摸共 " + result4.ToString() + " 次";
            result_lable4_2.Text = " 共 " + result4.ToString() + " 次";
            try
            {
                pictureBox4.Image = Image.FromFile(path4);
            }
            catch (Exception FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            ////////////////
            ///第二家胡牌///
            ////////////////
            int result5 = 5;
            int pic5 = 5;
            string path5 = current_path + pic5.ToString() + ".png";
            result_lable5_1.Text = " 第二家胡牌共 " + result5.ToString() + " 次";
            result_lable5_2.Text = " 共 " + result5.ToString() + " 次";
            try
            {
                pictureBox5.Image = Image.FromFile(path5);
            }
            catch (Exception FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            ////////////////
            ///第二家放槍///
            ////////////////
            int result6 = 6;
            int pic6 = 6;
            string path6 = current_path + pic6.ToString() + ".png";
            result_lable6_1.Text = " 第二家放槍共 " + result6.ToString() + " 次";
            result_lable6_2.Text = " 共 " + result6.ToString() + " 次";
            try
            {
                pictureBox6.Image = Image.FromFile(path6);
            }
            catch (Exception FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            ////////////////
            ///第二家吃牌///
            ////////////////
            int result7 = 8;
            int result7_1 = 2;
            int result7_2 = 3;
            int result7_3 = 3;
            int pic7_1 = 9;
            int pic7_2 = 10;
            int pic7_3 = 11;
            int pic7_4 = 10;
            int pic7_5 = 11;
            int pic7_6 = 12;
            int pic7_7 = 10;
            int pic7_8 = 11;
            int pic7_9 = 12;
            string path7_1 = current_path + pic7_1.ToString() + ".png";
            string path7_2 = current_path + pic7_2.ToString() + ".png";
            string path7_3 = current_path + pic7_3.ToString() + ".png";
            string path7_4 = current_path + pic7_4.ToString() + ".png";
            string path7_5 = current_path + pic7_5.ToString() + ".png";
            string path7_6 = current_path + pic7_6.ToString() + ".png";
            string path7_7 = current_path + pic7_7.ToString() + ".png";
            string path7_8 = current_path + pic7_8.ToString() + ".png";
            string path7_9 = current_path + pic7_9.ToString() + ".png";
            result_lable7_1.Text = " 第二家胡牌共 " + result7.ToString() + " 次";
            result_lable7_2.Text = " 共 " + result7_1.ToString() + " 次";
            result_lable7_3.Text = " 共 " + result7_2.ToString() + " 次";
            result_lable7_4.Text = " 共 " + result7_3.ToString() + " 次";
            try
            {
                pictureBox7_1.Image = Image.FromFile(path7_1);
                pictureBox7_2.Image = Image.FromFile(path7_2);
                pictureBox7_3.Image = Image.FromFile(path7_3);
                pictureBox7_4.Image = Image.FromFile(path7_4);
                pictureBox7_5.Image = Image.FromFile(path7_5);
                pictureBox7_6.Image = Image.FromFile(path7_6);
                pictureBox7_7.Image = Image.FromFile(path7_7);
                pictureBox7_8.Image = Image.FromFile(path7_8);
                pictureBox7_9.Image = Image.FromFile(path7_9);
            }
            catch (Exception FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            ////////////////
            ///第二家碰牌///
            ////////////////
            int result8 = 8;
            int result8_1 = 5;
            int result8_2 = 3;
            int pic8_1 = 9;
            int pic8_2 = 10;
            string path8_1 = current_path + pic8_1.ToString() + ".png";
            string path8_2 = current_path + pic8_2.ToString() + ".png";
            result_lable8_1.Text = " 第二家胡牌共 " + result8.ToString() + " 次";
            result_lable8_2.Text = " 共 " + result8_1.ToString() + " 次";
            result_lable8_3.Text = " 共 " + result8_2.ToString() + " 次";
            try
            {
                pictureBox8_1.Image = Image.FromFile(path8_1);
                pictureBox8_2.Image = Image.FromFile(path8_2);
            }
            catch (Exception FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }
            ////////////////
            ///第二家槓牌///
            ////////////////
            int result9 = 8;
            int pic9 = 9;
            string path9= current_path + pic9.ToString() + ".png";
            result_lable9_1.Text = " 第二家胡牌共 " + result8.ToString() + " 次";
            result_lable9_2.Text = " 共 " + result8_1.ToString() + " 次";
            try
            {
                pictureBox9.Image = Image.FromFile(path9);
            }
            catch (Exception FileNotFoundException)
            {
                Console.WriteLine("FileNotFound");
            }

        }



        private void result_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void result_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void result_lable5_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void result_lable6_1_Click(object sender, EventArgs e)
        {

        }
    }
}

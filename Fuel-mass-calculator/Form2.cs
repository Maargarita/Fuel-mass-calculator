﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_mass_calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public double h, m1, tn;

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы увурены, что хотите закрыть программу?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Close();
        }

        public string c;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                h = Convert.ToDouble(TextBox_KPD.Text);
                m1 = Convert.ToDouble(TextBox_KG.Text);
                tn = Convert.ToDouble(TextBox_C.Text);
                c = ComboBox1.Text;
                if (h == 0)
                {
                    MessageBox.Show("Неверное значение.Деление на 0");
                }
                else
                {
                    int c1, tk, q;
                    string met;
                    double m2;
                    c1 = 0;
                    tk = 0;
                    met = " ";
                    h /= 100;
                    if (c == "al")
                    {
                        c1 = 920;
                        tk = 660;
                        met = " алюминия ";
                    }
                    if (c == "cu")
                    {
                        c1 = 400;
                        tk = 1083;
                        met = " меди ";
                    }
                    if (c == "zn")
                    {
                        c1 = 400;
                        tk = 420;
                        met = " цинка ";
                    }
                    if (c == "w")
                    {
                        c1 = 134;
                        tk = 3410;
                        met = " вольфрама ";
                    }
                    if (c == "au")
                    {
                        c1 = 130;
                        tk = 1063;
                        met = " золота ";
                    }
                    if (c == "k")
                    {
                        c1 = 741;
                        tk = 64;
                        met = " калия ";
                    }
                    if (c == "ca")
                    {
                        c1 = 624;
                        tk = 838;
                        met = " кальция ";
                    }
                    if (c == "co")
                    {
                        c1 = 414;
                        tk = 1495;
                        met = " кобальта ";
                    }
                    if (c == "li")
                    {
                        c1 = 3307;
                        tk = 181;
                        met = " лития ";
                    }
                    if (c == "mg")
                    {
                        c1 = 1047;
                        tk = 650;
                        met = " магния ";
                    }
                    if (c == "na")
                    {
                        c1 = 1235;
                        tk = 98;
                        met = " натрия ";
                    }
                    if (c == "ni")
                    {
                        c1 = 440;
                        tk = 1453;
                        met = " никеля ";
                    }
                    if (c == "sn")
                    {
                        c1 = 226;
                        tk = 232;
                        met = " олова ";
                    }
                    if (c == "pt")
                    {
                        c1 = 134;
                        tk = 1769;
                        met = " платины ";
                    }
                    if (c == "pb")
                    {
                        c1 = 130;
                        tk = 327;
                        met = " свинца ";
                    }
                    if (c == "ag")
                    {
                        c1 = 234;
                        tk = 961;
                        met = " серебра ";
                    }
                    if (c == "ti")
                    {
                        c1 = 527;
                        tk = 1668;
                        met = " титана ";
                    }
                    if (c == "cr")
                    {
                        c1 = 460;
                        tk = 768;
                        met = " хрома ";
                    }
                    if (c == "cs")
                    {
                        c1 = 218;
                        tk = 29;
                        met = " цезия ";
                    }
                    if (c == "zr")
                    {
                        c1 = 276;
                        tk = 1852;
                        met = " циркония ";
                    }
                    q = 29000000;
                    m2 = (c1 * m1 * (tk - tn)) / (h * q);

                    MessageBox.Show("Для расплавления  " + Convert.ToString(m1) + "кг" + met + "при КПД печи " + Convert.ToString(h * 100) + "%  и начальной \nтемпературе " + Convert.ToString(tn) + " градусов необходимо " + Convert.ToString(m2) + "кг коксованного угля");
                    TextBox_KPD.Clear();
                    TextBox_KG.Clear();
                    TextBox_C.Clear();
                    ComboBox1.Text = "";
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверное значение");
            }

        }
    }
}

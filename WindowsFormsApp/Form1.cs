﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Matriz m = new Matriz(2, 2);
            m.setValue(0, 0, 1);
            m.setValue(0, 1, 2);
            m.setValue(1, 0, 4);
            m.setValue(1, 1, 5);
            Console.WriteLine(m.getAllValues());

            Matriz m2 = new Matriz(2, 3);
            m2.setValue(0, 0, 1);
            m2.setValue(0, 1, 2);
            m2.setValue(0, 2, 2);
            m2.setValue(1, 0, 4);
            m2.setValue(1, 1, 5);
            m2.setValue(1, 2, 1);
            //Console.WriteLine(m2.getAllValues());

            Console.WriteLine(Matriz.escalar(2, m, "res").getAllValues());
        }
    }
}
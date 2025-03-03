﻿using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button btnCong;
        private Button btnTru;

        public Form1()
        {
            InitializeComponent();
            InitializeCalculator();
        }

        private void InitializeCalculator()
        {
            this.Text = "Tính Toán";
            this.Size = new System.Drawing.Size(300, 200);

            Label lblA = new Label() { Text = "Số A:", Top = 20, Left = 20 };
            txtA = new TextBox() { Top = 20, Left = 180, Width = 150 };

            Label lblB = new Label() { Text = "Số B:", Top = 60, Left = 20 };
            txtB = new TextBox() { Top = 60, Left = 180, Width = 150 };

            Label lblKetQua = new Label() { Text = "Kết Quả:", Top = 100, Left = 20 };
            txtKetQua = new TextBox() { Top = 100, Left = 180, Width = 150, ReadOnly = true };

            btnCong = new Button() { Text = "Cộng", Top = 140, Left = 300, Width = 150, Height = 50 };
            btnCong.Click += BtnCong_Click;

            btnTru = new Button() { Text = "Trừ", Top = 140, Left = 100, Width = 100, Height = 50 };
            btnTru.Click += btnTru_Click;

            this.Controls.Add(lblA);
            this.Controls.Add(txtA);
            this.Controls.Add(lblB);
            this.Controls.Add(txtB);
            this.Controls.Add(lblKetQua);
            this.Controls.Add(txtKetQua);
            this.Controls.Add(btnCong);
            this.Controls.Add(btnTru);
        }

        private void BtnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a + b;
            txtKetQua.Text = c.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a - b;
            txtKetQua.Text = c.ToString();
        }


    }
}


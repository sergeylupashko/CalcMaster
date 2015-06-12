using System;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace CalcMaster
{
    public partial class Form1 : Form
    {
        private readonly Random rnd;
        private int _good, _bad;

        private int Good
        {
            get { return _good; }
            set
            {
                _good = value;
                lblGood.Text = _good.ToString();
            }
        }

        private int Bad
        {
            get { return _bad; }
            set
            {
                _bad = value;
                lblBad.Text = _bad.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
            level.SelectedIndex = 0;
            rnd = new Random();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            oppanel.Visible = true;
            Good = 0;
            Bad = 0;
            Nextexpr();
            res.Select();
        }

        private void Nextexpr()
        {
            /*
             0. результат в пределах десятка
             1. результат в пределах 20
             2. одно из слагаемых однозначное, второе двузначное
             3. результат в пределах 100
             4. результат в пределах 200
             */
            int v1 = 0, v2 = 0;
            int o = (rnd.Next(2) == 0) ? 1 : -1;
            if (o == 1)
            {
                switch (level.SelectedIndex)
                {
                    case 0:
                        v1 = RandomValue.GetRandom(11);
                        v2 = RandomValue.GetRandom(11 - v1);
                        break;
                    case 1:
                        v1 = RandomValue.GetRandom(11);
                        v2 = RandomValue.GetRandom(11);
                        break;
                    case 2:
                        v1 = RandomValue.GetRandom(101);
                        v2 = RandomValue.GetRandom(11);
                        break;
                    case 3:
                        v1 = RandomValue.GetRandom(101);
                        v2 = RandomValue.GetRandom(101 - v1);
                        break;
                    case 4:
                        v1 = RandomValue.GetRandom(101);
                        v2 = RandomValue.GetRandom(101);
                        break;
                }
            }
            else
            {
                switch (level.SelectedIndex)
                {
                    case 0:
                        v1 = RandomValue.GetRandom(11);
                        v2 = RandomValue.GetRandom(v1 + 1);
                        break;
                    case 1:
                        v1 = RandomValue.GetRandom(21);
                        v2 = RandomValue.GetRandom(Math.Min(v1 + 1, 11));
                        break;
                    case 2:
                        v1 = RandomValue.GetRandom(101);
                        v2 = RandomValue.GetRandom(Math.Min(v1 + 1, 11));
                        break;
                    case 3:
                        v1 = RandomValue.GetRandom(101);
                        v2 = RandomValue.GetRandom(v1 + 1);
                        break;
                    case 4:
                        v1 = RandomValue.GetRandom(201);
                        v2 = RandomValue.GetRandom(Math.Min(v1 + 1, 101));
                        break;
                }
            }

            op1.Text = v1.ToString();
            op2.Text = v2.ToString();
            op.Text = (o == 1) ? "+" : "-";
            res.Text = "";
        }

        private void res_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0xD && res.Text != "")
            {
                int o = (op.Text == "+") ? 1 : -1;
                if (Convert.ToInt32(res.Text) == Convert.ToInt32(op1.Text) + Convert.ToInt32(op2.Text)*o) Good++;
                else Bad++;
                Nextexpr();
            }
        }
    }

    internal static class RandomValue
    {
        private static Int32 GetRandomInt()
        {
            byte[] randomBytes = new byte[4];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);
            Int32 randomInt = BitConverter.ToInt32(randomBytes, 0);
            return randomInt;
        }

        public static int GetRandom(int range)
        {
            int randInt32 = GetRandomInt();
            Random r = new Random(randInt32);
            int nextInt = r.Next(range);
            return nextInt;
        }
    }
}
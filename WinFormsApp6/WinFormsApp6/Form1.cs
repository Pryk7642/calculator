namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtstore.Text= txtstore.Text + ".";
            if (txtstore.Text == ".") txtstore.Text = string.Empty;

            
            Button btndot_Click = (Button)sender;
            if (btndot_Click.Text == ".")
            {
                if(!txtstore.Text.Contains("."))
                    txtstore.Text = txtstore.Text + btndot_Click.Text;
            }
            else
            {
                txtstore.Text = txtstore.Text + btndot_Click.Text;
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "0";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
            if (txtstore.Text == "0") txtstore.Text = string.Empty;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "1";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "2";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "3";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "4";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "5";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "6";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "7";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "8";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "9";
            this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresualt.Clear();
            txtstore.Clear();
        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
            txtstore.Clear();
        }

        float num;
        int count;

        private void btnmin_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + " - ";
                txtstore.Clear();
                count = 2;
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + " + ";
                txtstore.Clear();
                count = 1;
            }
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + " X ";
                txtstore.Clear();
                count = 3;
            }
        }

        private void btndevide_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + " / ";
                txtstore.Clear();
                count = 4;
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + " = " + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + " = " + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + " = " + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + " = " + ans;
                    txtstore.Text = ans.ToString();
                    break;

            }
            if (txtstore.Text != ".")
            {
                this.txtstore.Text = String.Format("{0:#,##0.############}", double.Parse(this.txtstore.Text));
            }

        }

        private void btnrd_Click(object sender, EventArgs e)
        {
            if (txtstore.Text.Length > 0)
                txtstore.Text = txtstore.Text.Remove(txtstore.Text.Length - 1, 1);
            if (txtstore.Text == string.Empty) txtstore.Text = "";
        }

        private void txtstore_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtresualt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
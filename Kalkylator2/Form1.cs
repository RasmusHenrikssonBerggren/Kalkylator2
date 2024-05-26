namespace Kalkylator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        int num3;
        string option; /*Låter användaren välja mellan "+", "-", "*" och "/"*/
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + "1";   /*Samarbete med textrutan "knapp 1": "1" syns på textrutan*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + "2"; /*Samma koncept som "button1": "2" syns på textrutan*/
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + btn3.Text; /*Annan variant som får "3" att synas på textrutan: "btn3.Text"*/
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSkärm.Text = txtSkärm.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+"; /*Adderar variablerna*/
            num1 = int.Parse(txtSkärm.Text); /*"num1" blir det första numret användaren väljer(0-9)*/
            num2 = int.Parse(txtSkärm.Text);

            txtSkärm.Clear(); /*Tar bort innehållet i textrutan när ett nytt nummer (num2) ska adderas*/
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtSkärm.Text);

            txtSkärm.Clear();
        }

        private void btnGånger_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtSkärm.Text);

            txtSkärm.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtSkärm.Text);

            txtSkärm.Clear();
        }

        private void btnLikamed_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtSkärm.Text);

            if (option == ("+")) /*Två varianter att skriva likamed på: "==" och ".Equals"*/
                result = num1 + num2 + num3;

            if (option == ("-"))
                result = num1 - num2 - num3;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            txtSkärm.Text = result + ""; /*Resultaten av beräkningen ges ut*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSkärm.Clear(); /*Alla variabler blir återställda, 0, när användaren trycker "Clear"*/
            result = (0);
            num1 = (0);
            num2 = (0);
            num3 = (0);
        }

        private void txtSkärm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
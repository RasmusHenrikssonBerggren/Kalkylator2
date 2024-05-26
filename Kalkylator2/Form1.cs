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
        string option; /*L�ter anv�ndaren v�lja mellan "+", "-", "*" och "/"*/
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + "1";   /*Samarbete med textrutan "knapp 1": "1" syns p� textrutan*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + "2"; /*Samma koncept som "button1": "2" syns p� textrutan*/
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + btn3.Text; /*Annan variant som f�r "3" att synas p� textrutan: "btn3.Text"*/
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSk�rm.Text = txtSk�rm.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+"; /*Adderar variablerna*/
            num1 = int.Parse(txtSk�rm.Text); /*"num1" blir det f�rsta numret anv�ndaren v�ljer(0-9)*/
            num2 = int.Parse(txtSk�rm.Text);

            txtSk�rm.Clear(); /*Tar bort inneh�llet i textrutan n�r ett nytt nummer (num2) ska adderas*/
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtSk�rm.Text);

            txtSk�rm.Clear();
        }

        private void btnG�nger_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtSk�rm.Text);

            txtSk�rm.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtSk�rm.Text);

            txtSk�rm.Clear();
        }

        private void btnLikamed_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtSk�rm.Text);

            if (option == ("+")) /*Tv� varianter att skriva likamed p�: "==" och ".Equals"*/
                result = num1 + num2 + num3;

            if (option == ("-"))
                result = num1 - num2 - num3;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            txtSk�rm.Text = result + ""; /*Resultaten av ber�kningen ges ut*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSk�rm.Clear(); /*Alla variabler blir �terst�llda, 0, n�r anv�ndaren trycker "Clear"*/
            result = (0);
            num1 = (0);
            num2 = (0);
            num3 = (0);
        }

        private void txtSk�rm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
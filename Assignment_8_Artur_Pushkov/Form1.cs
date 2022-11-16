namespace Assignment_8_Artur_Pushkov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader boys;
                string boyNames;
                boys = File.OpenText("BoyNames.txt");
                List<string> boyNameList = new List<string>();
                StreamReader girls;
                string girlNames;
                girls = File.OpenText("GirlNames.txt");
                List<string> girlNameList = new List<string>();

                boyNames = textBox1.Text;
                girlNames = textBox2.Text;

                while (!boys.EndOfStream)
                {
                    boyNameList.Add(boys.ReadLine());
                }
                while (!girls.EndOfStream)
                {
                    girlNameList.Add(girls.ReadLine());
                }

                int boysPosition = boyNameList.IndexOf(boyNames);
                int girlsPosition = girlNameList.IndexOf(girlNames);

                if (boysPosition != -1)
                {
                    MessageBox.Show("The boy name you entered is one of the most popular names.");
                }
                if (girlsPosition != -1)
                {
                    MessageBox.Show("The girl name you entered is one of the most popular names.");
                }
                else if (boysPosition == -1)
                {
                    MessageBox.Show("The boy name you have entered is NOT one of the most popular names.");
                }
                else if (girlsPosition == -1)
                {
                    MessageBox.Show("The girl name you have entered is NOT one of the most popular names.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
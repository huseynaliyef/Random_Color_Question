using System.Media;
using System.Windows.Forms;

namespace Random_Color_Question_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.get_question();
        }

        private void get_question()
        {
            Color1 c = new Color1();
            this.BackColor = c.change_color();
            List<string> values = new List<string>() { "Blue", "Black", "Red", "White", "Yellow" };

            Random rnd = new Random();
            var ran_duz = values.OrderBy(_ => rnd.Next()).ToList();
            for (int i = 0; i < ran_duz.Count; i++)
            {
                Color1.list2.Add(ran_duz[i]);
            }
            aVarianti.Text = "A) " + Color1.list2[0];
            bVarianti.Text = "B) " + Color1.list2[1];
            cVarianti.Text = "C) " + Color1.list2[2];
            dVarianti.Text = "D) " + Color1.list2[3];
            eVarianti.Text = "E) " + Color1.list2[4];
        }

        private void duymeler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (this.BackColor.Name.StartsWith(btn.Text.Split(' ')[1]))
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Random_Color_Question_App\Correct.wav");
                //player.Play();
                MessageBox.Show("Dogrudur.");
                System.Threading.Thread.Sleep(500);
                //Environment.Exit(0);
                Color1.list.Clear();
                Color1.list2.Clear();
                this.Form1_Load(null, null);
                
            }
            else
            {
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Random_Color_Question_App\Wrong.wav");
                //player.Play();
                MessageBox.Show("Yalnisdir!");
                System.Threading.Thread.Sleep(500);
                //Environment.Exit(0);
                Color1.list.Clear();
                Color1.list2.Clear();
                this.Form1_Load(null, null);
            }
        }
    }
    interface Super_Color1
    {
        public Color change_color();
    }
    class Color1 : Super_Color1
    {
        public static List<Color> list = new List<Color>();
        public static List<string> list2 = new List<string>();
        public Color1()
        {
            list.Add(Color.Yellow);          
            list.Add(Color.Blue);           
            list.Add(Color.Black);           
            list.Add(Color.Red);
            list.Add(Color.White);  
        }
        Random rnd = new Random();
        public Color change_color()
        {
            int rnd_clr_num = rnd.Next(0,5);            
            for (int i = 0; i < list.Count; i++)
            {
                if (i == rnd_clr_num)
                {
                    return list[i];
                }
            }
            return new Color();
        }
    }
}
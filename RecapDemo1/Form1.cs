using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form //: Form inheritance dir
    {
        public Form1() //constructor bloğu, class'ın ismiyle oluşturulmuş
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Dama Tahtası


            //uygulama açıldığında ilk çalışacak kod burasıdır
            //desing sayfasına konulan buton, bu bir class'tır
            //for döngüsüyle yapılabilinir
            //ancak bunda 64 tanesini üst üste yazacaktır
            //ve oluşturduğumuz referanslara ulaşamayacağız, nesneye erişim sıkıntı
            //for (int i = 1; i <= 64; i++)
            //{
            //    Button button = new Button();
            //    button.Width = 50;
            //    button.Height = 50;
            //    button.Text = "My button";
            //    this.Controls.Add(button);
            //}

            //daha profesyonel çalışmak için Array'lardan yararlanılır
            GenerateButtons();//yazıklarımızı bir method haline getirdik
            
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;//en üstten başlangıç | bunu tanımlatmamızın sebebi uzaklığı değiştirmek istersek kolaylık sağlasın diye
            int left = 0;//soldan başlangıç
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //GetUpperBound 0. boyutun en büyük alabileceği değer 7'dir | toplam 8 tane olduğu için 7'dir. 0'dan başlıyor
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50; //genişliği
                    buttons[i, j].Height = 50; //yüksekliği
                    buttons[i, j].Left = left; //soldan başlangıç uzaklığı
                    buttons[i, j].Top = top;//top'ı da tanımlatmak gerek yoksa çalışmaz
                    left += 50; //her seferinde koyduktan sonra 50 arttırarak buton yerleştir
                    //burada bir algoritma yazıyoruz, çünkü dama tahtasının bir karesi siyah diğeri beyaz şeklinde devam eder
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = System.Drawing.Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = System.Drawing.Color.White;
                    }


                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;//ilk top için değer 0, ikinci ve devamı için 50 arttır
                left = 0; //bununla satırı sonlandırmış oluyoruz
            }
        }
    }
}

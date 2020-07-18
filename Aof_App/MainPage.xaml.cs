using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Aof_App
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private double araSinav;
        private double finButSinav;
        private double ortalama;

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
            araSinav = (Convert.ToDouble(textBox1.Text) * 30) / 100;
            finButSinav = (Convert.ToDouble(textBox3.Text) * 70) / 100;
            ortalama = araSinav + finButSinav;

            textBlock12.Text = ortalama.ToString();

            if (ortalama > 49)
            { textBlock13.Text = "GEÇTİ"; }
            else
            { textBlock13.Text = "KALDI"; }

             
        }

        private int notAl;

        private double yirmiAlti;
        private double otuz;
        private double otuzAlti;

     
        private void button1_Click(object sender, RoutedEventArgs e)
        { 
            Dictionary<int,int> dic = new Dictionary<int,int>();
            dic.Add(0,71);
            dic.Add(1,71);
            dic.Add(2,70);
            dic.Add(3,70);
            dic.Add(4,69);
            dic.Add(5,69);
            dic.Add(6,69);
            dic.Add(7,68);
            dic.Add(8,68);
            dic.Add(9,67);
            dic.Add(10,67);
            dic.Add(11,66);
            dic.Add(12,66);
            dic.Add(13,66);
            dic.Add(14,65);
            dic.Add(15,65);
            dic.Add(16,64);
            dic.Add(17,64);
            dic.Add(18,63);
            dic.Add(19,63);
            dic.Add(20,63);
            dic.Add(21,62);
            dic.Add(22,62);
            dic.Add(23,61);
            dic.Add(24,61);
            dic.Add(25,60);
            dic.Add(26,60);
            dic.Add(27,60);
            dic.Add(28,59);
            dic.Add(29,59);
            dic.Add(30,58);
            dic.Add(31,58);
            dic.Add(32,57);
            dic.Add(33,57);
            dic.Add(34,57);
            dic.Add(35,56);
            dic.Add(36,56);
            dic.Add(37,55);
            dic.Add(38,55);
            dic.Add(39,54);
            dic.Add(40,54);
            dic.Add(41,54);
            dic.Add(42,53);
            dic.Add(43,53);
            dic.Add(44,52);
            dic.Add(45,52);
            dic.Add(46,51);
            dic.Add(47,51);
            dic.Add(48,51);
            dic.Add(49,50);
            dic.Add(50,50);
            dic.Add(51,49);
            dic.Add(52,49);
            dic.Add(53,48);
            dic.Add(54,48);
            dic.Add(55,48);
            dic.Add(56,47);
            dic.Add(57,47);
            dic.Add(58,46);
            dic.Add(59,46);
            dic.Add(60,45);
            dic.Add(61,45);
            dic.Add(62,45);
            dic.Add(63,44);
            dic.Add(64,44);
            dic.Add(65,43);
            dic.Add(66,43);
            dic.Add(67,42);
            dic.Add(68,42);
            dic.Add(69,42);
            dic.Add(70,41);
            dic.Add(71,41);
            dic.Add(72,40);
            dic.Add(73,40);
            dic.Add(74,39);
            dic.Add(75,39);
            dic.Add(76,39);
            dic.Add(77,38);
            dic.Add(78,38);
            dic.Add(79,37);
            dic.Add(80,37);
            dic.Add(81,36);
            dic.Add(82,36);
            dic.Add(83,36);
            dic.Add(84,35);
            dic.Add(85,35);
            dic.Add(86,34);
            dic.Add(87,34);
            dic.Add(88,33);
            dic.Add(89,33);
            dic.Add(90,33);
            dic.Add(91,32);
            dic.Add(92,32);
            dic.Add(93,31);
            dic.Add(94,31);
            dic.Add(95,30);
            dic.Add(96,30);
            dic.Add(97,30);
            dic.Add(98,29);
            dic.Add(99,29);
            dic.Add(100,28);

            notAl = Convert.ToInt32(textBox1.Text);
            
            List<int> list = new List<int>(dic.Keys);

            var gerekenNot = (from s in dic
                         where s.Key == notAl
                         select s.Value).SingleOrDefault();

            textBox2.Text = gerekenNot.ToString();

   //      MessageBox.Show( String.Format("{0:0.##}", 123.4567));   
            yirmiAlti = 100 / 26;
            textBlock7.Text = String.Format("{0:0.#}", (Convert.ToDouble(textBox2.Text) / yirmiAlti)) + " Doğru Yapmalısınız.";

            otuz = 100 / 30;
            textBlock8.Text = String.Format("{0:0.#}", (Convert.ToDouble(textBox2.Text) / otuz) +1) + " Doğru Yapmalısınız.";

            otuzAlti = 100 / 36;
            textBlock9.Text = String.Format("{0:0.#}", (Convert.ToDouble(textBox2.Text) / otuzAlti)) + " Doğru Yapmalısınız.";
         



         }
    }
}
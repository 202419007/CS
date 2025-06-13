using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class Form1: Form
    {

        List<Dog> dogs = new List<Dog>();
        List<Cat> cats = new List<Cat>();
        List<Animal> animals = new List<Animal>();


        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var color = (COLOR)random.Next((int)COLOR.END);
            dogs.Add(new Dog("개" + DateTime.Now.Ticks, color, 1));

            StringBuilder stringBuilder = new StringBuilder();
            foreach(var dog in dogs) {
                stringBuilder.Append(dog).Append("\r\n");
            }
            tbxResult.Text = stringBuilder.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var color = (COLOR)random.Next((int)COLOR.END);
            cats.Add( new Cat("묘" + DateTime.Now.Ticks, color));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var cat in cats) {
                stringBuilder.Append(cat).Append("\r\n");
            }
            tbxResult.Text = stringBuilder.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var color = (COLOR)(new Random().Next((int)COLOR.END));

            Animal animal;
            
            if(random.Next(2) == 0) {
                animal = new Dog("개" + DateTime.Now.Ticks, color, 1);
            } else {
                animal = new Cat("묘" + DateTime.Now.Ticks, color);
            }
            animals.Add(animal);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var ani in animals) {
                stringBuilder.Append(ani).Append("\r\n");
                if(ani is Dog) {
                    stringBuilder.Append(((Dog)ani).Bark(random.Next(1,5)));
                    stringBuilder.Append("\r\n");
                } else if (ani is Cat cat) {
                    stringBuilder.Append(cat.Meow(random.Next(1,4)));
                    stringBuilder.Append("\r\n");
                }
            }
            tbxResult.Text = stringBuilder.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
                
        private void button5_Click(object sender, EventArgs e)
        {
            var color = (COLOR)random.Next((int)COLOR.END);
            dogs.Add(new RobotDog("개" + DateTime.Now.Ticks, color, 1));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var dog in dogs) {
                if(dog is IRobot robotdog) {
                    stringBuilder.Append(dog).Append("\r\n");
                    stringBuilder.Append("배터리:"+ robotdog.BatteryLevel).Append("\r\n");
                }
            }
            tbxResult.Text = stringBuilder.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var color = (COLOR)random.Next((int)COLOR.END);
            animals.Add(new RobotBird("새" + DateTime.Now.Ticks, color));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var ani in animals) {
                if (ani is IRobot robotbird) {
                    stringBuilder.Append(ani).Append("\r\n");
                    stringBuilder.Append(robotbird).Append("\r\n");
                    stringBuilder.Append("배터리:" + robotbird.BatteryLevel).Append("\r\n");
                    stringBuilder.Append(((RobotBird)robotbird).Fly(random.Next(3, 10))).Append("\r\n");
                }
            }
            tbxResult.Text = stringBuilder.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dog d = new Dog("개1", COLOR.BLACK, 1);
            Animal a = new Dog("개2", COLOR.BLACK, 1);

            //추상클래스는 단독 인스턴스 생성 불가능
            //Animal c = new Animal("동3", COLOR.BLACK);
            //Dog b = new Animal("동4", COLOR.BLACK);

            d.Bark(3);

            //a.Bark(3);
            ((Dog)a).Bark(3);

            tbxResult.Text = $"{a.Level} {d.Level}\r\n";
            a.Eat();
            d.Eat(); //overriding
            tbxResult.Text += $"{a.Level} {d.Level}\r\n";
            a.Play();
            d.Play(); //hiding
            tbxResult.Text += $"{a.Level} {d.Level}\r\n";
        }
    }
}

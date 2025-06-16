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
    public partial class Form1 : Form
    {
        // Dog, Cat, Animal 객체들을 저장할 리스트 생성
        List<Dog> dogs = new List<Dog>();
        List<Cat> cats = new List<Cat>();
        List<Animal> animals = new List<Animal>();

        // 랜덤 객체 - 색상 및 난수 생성에 사용
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();  // 디자이너가 만든 UI 초기화
        }

        // button1 클릭 이벤트 - Dog 객체 추가
        private void button1_Click(object sender, EventArgs e)
        {
            // 랜덤 색상을 가져옴
            var color = (COLOR)random.Next((int)COLOR.END);

            // 새로운 Dog 생성 후 dogs 리스트에 추가
            dogs.Add(new Dog("개" + DateTime.Now.Ticks, color, 1));

            // 결과 출력용 문자열 빌더
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var dog in dogs) {
                stringBuilder.Append(dog).Append("\r\n");
            }

            // 텍스트박스에 출력
            tbxResult.Text = stringBuilder.ToString();
        }

        // button2 클릭 이벤트 - Cat 객체 추가
        private void button2_Click(object sender, EventArgs e)
        {
            var color = (COLOR)random.Next((int)COLOR.END);

            // 새로운 Cat 생성 후 cats 리스트에 추가
            cats.Add(new Cat("묘" + DateTime.Now.Ticks, color));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var cat in cats) {
                stringBuilder.Append(cat).Append("\r\n");
            }

            tbxResult.Text = stringBuilder.ToString();
        }

        // button3 클릭 이벤트 - Dog 또는 Cat 무작위로 추가 후 짖거나 야옹 출력
        private void button3_Click(object sender, EventArgs e)
        {
            var color = (COLOR)random.Next((int)COLOR.END);

            Animal animal;

            // 0이면 Dog, 1이면 Cat 생성
            if (random.Next(2) == 0) {
                animal = new Dog("개" + DateTime.Now.Ticks, color, 1);
            } else {
                animal = new Cat("묘" + DateTime.Now.Ticks, color);
            }

            animals.Add(animal);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var ani in animals) {
                stringBuilder.Append(ani).Append("\r\n");

                // 형변환 후 종에 맞는 울음 출력
                if (ani is Dog) {
                    stringBuilder.Append(((Dog)ani).Bark(random.Next(1, 5)));
                    stringBuilder.Append("\r\n");
                } else if (ani is Cat cat) {
                    stringBuilder.Append(cat.Meow(random.Next(1, 4)));
                    stringBuilder.Append("\r\n");
                }
            }

            tbxResult.Text = stringBuilder.ToString();
        }

        // button4 클릭 이벤트 - 비어 있음 (아직 기능 없음)
        private void button4_Click(object sender, EventArgs e)
        {
            // 비어있음
        }

        // button5 클릭 이벤트 - RobotDog 추가
        private void button5_Click(object sender, EventArgs e)
        {
            var color = (COLOR)random.Next((int)COLOR.END);

            // RobotDog을 Dog 리스트에 추가
            dogs.Add(new RobotDog("개" + DateTime.Now.Ticks, color, 1));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var dog in dogs) {
                if (dog is IRobot robotdog) {
                    stringBuilder.Append(dog).Append("\r\n");
                    // 로봇 인터페이스의 배터리 출력
                    stringBuilder.Append("배터리:" + robotdog.BatteryLevel).Append("\r\n");
                }
            }

            tbxResult.Text = stringBuilder.ToString();
        }

        // button6 클릭 이벤트 - RobotBird 추가
        private void button6_Click(object sender, EventArgs e)
        {
            var color = (COLOR)random.Next((int)COLOR.END);

            // RobotBird을 Animal 리스트에 추가
            animals.Add(new RobotBird("새" + DateTime.Now.Ticks, color));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var ani in animals) {
                if (ani is IRobot robotbird) {
                    stringBuilder.Append(ani).Append("\r\n");
                    stringBuilder.Append(robotbird).Append("\r\n");
                    stringBuilder.Append("배터리:" + robotbird.BatteryLevel).Append("\r\n");
                    // Fly 메서드 호출 결과 출력
                    stringBuilder.Append(((RobotBird)robotbird).Fly(random.Next(3, 10))).Append("\r\n");
                }
            }

            tbxResult.Text = stringBuilder.ToString();
        }

        // button7 클릭 이벤트 - 비어 있음 (아직 기능 없음)
        private void button7_Click(object sender, EventArgs e)
        {
            // 비어있음
        }

        // button8 클릭 이벤트 - 다형성과 오버라이딩/하이딩 확인용
        private void button8_Click(object sender, EventArgs e)
        {
            Dog d = new Dog("개1", COLOR.BLACK, 1);
            Animal a = new Dog("개2", COLOR.BLACK, 1);

            // 추상 클래스는 직접 생성 불가
            // Animal c = new Animal("동3", COLOR.BLACK);
            // Dog b = new Animal("동4", COLOR.BLACK);

            d.Bark(3);  // Dog의 Bark 호출

            // a는 Animal 타입이므로 직접 Bark 불가능
            ((Dog)a).Bark(3);  // 형변환 후 Bark 호출

            // a와 d의 Level 출력
            tbxResult.Text = $"{a.Level} {d.Level}\r\n";

            a.Eat(); // 오버라이딩 된 메서드 실행
            d.Eat(); // 오버라이딩 된 메서드 실행
            tbxResult.Text += $"{a.Level} {d.Level}\r\n";

            a.Play(); // 하이딩 된 메서드 실행 (Animal 버전)
            d.Play(); // 하이딩 된 메서드 실행 (Dog 버전)
            tbxResult.Text += $"{a.Level} {d.Level}\r\n";
        }
    }
}

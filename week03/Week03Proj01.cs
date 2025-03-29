using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Proj01
{
    //class 구성요소 : 값(변수) + 기능(메소드)
    public partial class FormWeek2 : Form
    {
        //멤버변수, 인스턴스변수
        //C#에서는 instance field라고 지칭
        TextBox[] arrTbxData = new TextBox[5];
        RadioButton[] radioButtons = null;
        List<CheckBox> checkBoxes = null;

        //생성자
        //(1)이름은 Class이름과 동일
        //(2)반환타입 표시하면 안됨
        //인스턴스 생성시 무조건 1번만 호출됨.(*)
        public FormWeek2()
        {
            InitializeComponent();

            /**************************************
            인스턴스 필드에 변수 선언 및 배열을 생성한 후 
            생성자에서 해당 배열에 값을 설정하는 형태
            **************************************/
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            /**************************************
            인스턴스 필드에 배열 변수만 선언한 후
            생성자에서 배열을 생성한 후 값을 설정하는 형태
            **************************************/
            radioButtons = new RadioButton[]{
                rbtAdd,
                rbtSub,
                rbtMul,
                rbtDiv,
            };

            /**************************************
            인스턴스 필드에 배열 변수만 선언한 후
            생성자에서 배열을 생성한 후 값을 설정하는 형태
            **************************************/
            checkBoxes = new List<CheckBox> {
                chkAdd,
                chkSub,
                chkMul,
                chkDiv,
            };

            /**************************************
            ComboBox에 Item 항목을 코드로 추가하는 예제
            디자이너 창에서 추가한 항목은 임의로 지웠음.
            **************************************/
            this.cmbBeverage.Items.Add("아메리카노");
            this.cmbBeverage.Items.Add("카페라떼");
            this.cmbBeverage.Items.Add("플랫화이트");
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            //배열의 가장 큰 특징 : 고정길이
            //배열생성시 사용할 길이(Length)를 정해놓고 시작해야 함.
            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 한다.
            //배열의 길이는 생성 변하지 않기 때문에
            //다른 배열의 길이로 사용해도 괜찮다.
            //배열 요소의 값은
            //struct는 struct의 기본값 (int는 0)
            //class는 null이 기본값
            //int[] arrIntData = new int[5];
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (arrTbxData[i].Text != null
                    && arrTbxData[i].Text != "") {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                } else {
                    //arrIntData[i] = 0; -> 과 동일함... 왜?
                }
            }

            int result = 0;
            if (rbtAdd.Checked) {
                for (int i = 0; i < arrIntData.Length; i++) {
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else {
                MessageBox.Show("연산을 선택하세요.");
                return; //메소드를 즉시 종료하고 호출한 곳으로 돌아간다.
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess02_Click(object sender, EventArgs e)
        {
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)) {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                } else {
                    //arrIntData[i] = 0;
                }
            }

            int result = 0;
            if (rbtAdd.Checked) {
                for (int i = 0; i < arrIntData.Length; i++) {
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else {
                MessageBox.Show("연산을 선택하세요.");
                return;
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess03_Click(object sender, EventArgs e)
        {
            //Array vs. List
            //고정길이 = 가변길이
            //Length = Count
            //공통점 : 요소 접근 방법 [index]
            //  string a = "11";
            //  int b = a.Length;
            //  a += "b"; //"11b"
            //  b = a.Length; // 3

            //Generic(일반화) 지원 자료형
            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)) {
                    /**************************************
                    List와 같이 가변길이를 갖는 경우는 아래와 같은 기능을 보통
                    포함하고 있음.
                    Add() 추가, Insert() 삽입, Remove(), RemoveAt() 삭제
                    **************************************/
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                } else {
                    //arrIntData[i] = 0;
                }
            }

            int result = 0;
            if (rbtAdd.Checked) {
                for (int i = 0; i < arrIntData.Count; i++) {
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else {
                MessageBox.Show("연산을 선택하세요.");
                return;
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess04_Click(object sender, EventArgs e)
        {
            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)) {
                    //Add()가 있다면 Insert() Remove()
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                } else {
                    //arrIntData[i] = 0; -> 과 동일함... 왜?
                }
            }

            /**************************************
            이 부분을 개별 체크 박스가 아닌 checkBoxes 인스턴스 필드를 통해서
            변경할 수 있도록 해볼 것
            ***************************************/
            if (!chkAdd.Checked
                && !chkSub.Checked
                && !chkMul.Checked
                && !chkDiv.Checked) {
                MessageBox.Show("연산을 선택하세요.");
                return; //메소드를 즉시 종료하고 호출한 곳으로 돌아간다.
            }

            int result = 0;
            string totalResult = "";

            if (chkAdd.Checked) {
                for (int i = 0; i < arrIntData.Count; i++) {
                    result += arrIntData[i];
                }

                totalResult += $"더하기:{result}";
                totalResult += Environment.NewLine;

            }
            if (chkSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result -= arrIntData[i];
                }

                totalResult += $"빼기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result *= arrIntData[i];
                }

                totalResult += $"곱하기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }


                totalResult += $"나누기:{result}";
                totalResult += Environment.NewLine;
            }

            lblResult.Text = totalResult.ToString();
        }

        private void btnProcess05_Click(object sender, EventArgs e)
        {

        }

        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            // RadioButton[] radioButtons  = new RadioButton[]{
            //     rbtAdd,
            //     rbtSub,
            //     rbtMul,
            //     rbtDiv,
            // };
            // 
            // List<CheckBox> checkBoxes=  new List<CheckBox> {
            //     chkAdd,
            //     chkSub,
            //     chkMul,
            //     chkDiv,
            // };

            var isEng = chkOption.Checked;
            string word;

            for (int i = 0; i < radioButtons.Length; i++) {
                switch (i) {
                    case 0:
                        word = isEng ? "Add" : "더하기";
                        break;
                    case 1:
                        word = isEng ? "Sub" : "빼기";
                        break;
                    case 2:
                        word = isEng ? "Mul" : "곱하기";
                        break;
                    case 3:
                        word = isEng ? "Div" : "나누기";
                        break;
                    default:
                        continue;
                        /**************************************
                        break를 쓰면 for가 아닌 switch를 빠져나가게 됨
                        return을 쓰면 메소드 자체가 종료되버림.
                        참고로 이런 경우 goto를 적절히 사용해도 됨.
                        **************************************/
                }
                radioButtons[i].Text = word;
                checkBoxes[i].Text = word;
            }
        }

        private void btnProcess06_Click(object sender, EventArgs e)
        {
            //Combox 미선택시 SelectedIndex == -1
            if (cmbBeverage.SelectedIndex < 0) {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            //cmbBeverage.Items.Length

            int price = 0;
            /**************************************            
            switch (cmbBeverage.Items[cmbBeverage.SelectedIndex].ToString()) {
            **************************************/
            switch (cmbBeverage.SelectedItem.ToString()) {
                case "아메리카노":
                    price = 2500;
                    break;
                case "카페라떼":
                    price = 3500;
                    break;
                case "플랫화이트":
                    price = 3800;
                    break;
                default:
                    return;
            }

            /**************************************
            가변타입.
            실제로 가변이 아님.
            오른쪽에 있는 값을 판단해서 변수의 자료형을 결정함.
            실행시간이 아닌 컴파일시간(즉, exe 만들기전에)에 결정됨.
            JS나 Python과는 다른 형태인 것을 반드시 숙지해야 함.
            **************************************/
            var iceoption = chkIce.Checked ? "아이스 " : "";
            var iceprice = chkIce.Checked ? 500 : 0;
            //iceprice = "100";

            lblResult.Text =
                $"{iceoption}{cmbBeverage.SelectedItem}: " +
                $"{price + iceprice}";
        }

        private void btnProcess07_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0) {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            int price = 0;
            switch (cmbBeverage.SelectedIndex) {
                case 0:
                    price = 2500;
                    break;
                case 1:
                    price = 3500;
                    break;
                case 2:
                    price = 3800;
                    break;
                default:
                    return;
            }

            var iceoption = chkIce.Checked ? "아이스 " : "";
            var iceprice = chkIce.Checked ? 500 : 0;

            lblResult.Text =
                $"{iceoption}{cmbBeverage.SelectedItem}: " +
                $"{price + iceprice}";
        }

        private void btnProcess08_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0) {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            /**************************************
            배열의 길이는 값이 변경되지 않는 것을 보장해야 한다.
            현재 이 메소드가 컴파일되는 시점에 Items의 Count는 계속 변동될 소지가 있다.
            그래서 3개인 것을 보장하지 못한다.
            그래서 문제를 발생시킨다.
            **************************************/
            //var prices = new int[cmbBeverage.Items.Count] {
            var prices = new int[] {
                2500,
                3500,
                3800,
            };


            /**************************************
            단, 배열 생성과 동시에 초기화 하지 않는 아래와 같은 코드는 성립한다.
            실행하는 순간에 Items의 Count를 가져와 배열을 생성한다.
            단. [3],[4] 인덱스에 접근하는 순간 프로그램은 exception발생한다.
            var prices = new int[cmbBeverage.Items.Count];
            prices[0] = 1;
            prices[1] = 1;
            prices[2] = 1;
            prices[3] = 1;
            prices[4] = 1;
            **************************************/

            int price;
            if (cmbBeverage.SelectedIndex < prices.Length) {
                price = prices[cmbBeverage.SelectedIndex];
            } else {
                return;
            }

            var iceoption = chkIce.Checked ? "아이스 " : "";
            var iceprice = chkIce.Checked ? 500 : 0;

            lblResult.Text =
                $"{iceoption}{cmbBeverage.SelectedItem}: " +
                $"{price + iceprice}";
        }
    }
}

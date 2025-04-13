using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04Homework
{
    public partial class FormManager : Form
    {
        //인스턴스 필드(변수), 멤버 변수
        Department[] departments;
        List<Professor> professors;
        Dictionary<string, Student> students;

        List<Grade> testGrades;
        TextBox[] tbxTestScores;

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣는다.
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[10];
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();

            // 학생정보
            for (int i = 1; i <= 4; i++)
                cmbYear.Items.Add(i);

            cmbClass.Items.AddRange(new object[] { "A", "B", "C" });
            cmbRegStatus.Items.AddRange(new object[] { "재학", "졸업", "휴학", "퇴학" });

            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[]
            {
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3,
                tbxTestScore4,
                tbxTestScore5,
                tbxTestScore6,
                tbxTestScore7,
                tbxTestScore8,
                tbxTestScore9,
            };
        }

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(tbxDepartmentCode.Text))
            {
                MessageBox.Show("학과코드를 입력하세요.");
                tbxDepartmentCode.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxDepartmentName.Text))
            {
                MessageBox.Show("학과이름을 입력하세요.");
                tbxDepartmentName.Focus();
                return;
            }

            int index = -1;
            for(int i=0; i< departments.Length; i++)
            {
                if (departments[i] == null)
                {
                    if (index < 0) { 
                        index = i;
                    }
                    //break;
                } else {
                    if (departments[i].Code == tbxDepartmentCode.Text)
                    {
                        MessageBox.Show("이미 존재하는 학과코드 입니다. 다른 코드를 입력하세요.");
                        tbxDepartmentCode.Focus();
                        return;
                    }
                }
            }
            if (index < 0)
            {
                MessageBox.Show("더 이상 학과정보를 입력할 수 없습니다.");
                return;
            }

            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);
            //lbxDepartment.Items.Add(dept.Code);
            //lbxDepartment.Items.Add(dept.Name);
            //lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 학과를 선택하세요.");
                return;
            }

            //is 연산자, 타입 확인용으로 사용.
            if (lbxDepartment.SelectedItem is Department)
            {
                var target = (Department)lbxDepartment.SelectedItem;
                for(int i=0; i < departments.Length; i++)
                {
                    if (departments[i] != null && departments[i] == target)
                    {
                        departments[i] = null;
                        break;
                    }
                }

                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);

                lbxDepartment.SelectedIndex = -1;
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbProfessorDepartment.Items.Add(department);
                        }
                    }

                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;

                case 2:
                    cmbDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbDepartment.Items.Add(department);
                        }
                    }

                    ClearStudentInfo();
                    break;

                case 3:
                    ClearTestScoreInfo();
                    break;

                default:
                    break;
            }
        }


        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index값 검사해서 진행여부 결정
            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                //(주의)실제로 메세지 띄우는 것은 좋지 않은 것으로 보인다.
                //MessageBox.Show("조회할 학과를 선택하세요.");
                return;
            }

            lbxProfessor.Items.Clear();

            //as 형변환 연산자.
            //형변환이 정상적이지 않으면 null 변환.
            var department = cmbProfessorDepartment.SelectedItem as Department;

            if (department != null)
            {
                foreach (var professor in professors)
                {
                    if (professor != null && professor.DepartmentCode == department.Code)
                    {
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("학과를 선택하세요.");
                cmbProfessorDepartment.Focus();
                return;
            }

            if (false == cmbProfessorDepartment.SelectedItem is Department dept)
            {
                MessageBox.Show("학과정보에 이상 발생");
                cmbProfessorDepartment.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxProfessorNumber.Text))
            {
                MessageBox.Show("교수번호를 입력하세요.");
                tbxProfessorNumber.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxProfessorName.Text))
            {
                MessageBox.Show("교수이름을 입력하세요.");
                tbxProfessorName.Focus();
                return;
            }

            for (int i=0; i<professors.Count; i++)
            {
                if (professors[i].Number == tbxProfessorNumber.Text)
                {
                    MessageBox.Show("이미 존재하는 교수번호입니다. 다른 번호를 입력하세요.");
                    tbxProfessorNumber.Focus();
                    return;
                }
            }

            Professor professor = new Professor();
            professor.DepartmentCode = dept.Code;
            professor.Number = tbxProfessorNumber.Text;
            professor.Name = tbxProfessorName.Text;

            professors.Add(professor);
            lbxProfessor.Items.Add(professor);
        }

        // 교수 정보 구현(삭제)
        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 교수를 선택하세요.");
                return;
            }

            //is 연산자, 타입 확인용으로 사용
            if (lbxProfessor.SelectedItem is Professor)
            {
                var target = (Professor)lbxProfessor.SelectedItem;

                for (int i=0; i < professors.Count; i++)
                {
                    if (professors[i] != null && professors[i] == target)
                    {
                        professors.RemoveAt(i);
                        break;
                    }
                }

                lbxProfessor.Items.Remove(target);
                lbxProfessor.SelectedIndex = -1;
            }
        }

        // 학생 정보 구현
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAdvisor.Items.Clear();

            if (cmbDepartment.SelectedIndex < 0)
                return;

            if (false == cmbDepartment.SelectedItem is Department dept)
                return;

            foreach (var professor in professors)
            {
                if (professor != null && professor.DepartmentCode == dept.Code)
                {
                    cmbAdvisor.Items.Add(professor);
                }
            }

            cmbAdvisor.SelectedIndex = -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearStudentInfo();
        }

        private void ClearStudentInfo()
        {
            tbxNumber.Text = "20";
            tbxName.Text = string.Empty;
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Text = string.Empty;
            tbxContact.Text = string.Empty;
        }

        Student selectedStudent = null;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                RegisterStudent();
            } else
            {
                UpdateStudet();  //call
            }
        }

        private void RegisterStudent()
        {
            var number = tbxNumber.Text.Trim();
            if (string.IsNullOrEmpty(number) || number.Length != 8)
            {
                MessageBox.Show("학번은 8자리여야 합니다.");
                tbxNumber.Focus();
                return;
            }

            var name = tbxName.Text.Trim();
            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                MessageBox.Show("이름은 최소 2글자여야 합니다.");
                tbxName.Focus();
                return;
            }

            if (true == students.ContainsKey(number))
            {
                tbxNumber.Focus();
                return;
            }

            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth;//, birthDay;
            if (int.TryParse(tbxBirthYear.Text, out birthYear))
            {
                if (birthYear < 1900 || birthYear > 9000)
                {
                    MessageBox.Show("유효한 생년(1900~9000)");
                    tbxBirthYear.Focus();
                    return;
                }
            } else
            {
                return;
            }

            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {
                if (birthMonth < 1 || birthMonth > 12)
                {
                    MessageBox.Show("유효한 월(1~12)");
                    tbxBirthMonth.Focus();
                    return;
                }
            }
            else
            {
                return;
            }

            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                if (birthDay < 1 || birthDay > 31)
                {
                    MessageBox.Show("유효한 일(1~31)");
                    tbxBirthDay.Focus();
                    return;
                }
            }
            else
            {
                return;
            }

            //현재시간 : DateTime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                student.DepartmentCode = null;
            } else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbAdvisor.SelectedItem as Professor).Name;
            }

            if (cmbYear.SelectedIndex < 0)
            {
                MessageBox.Show("학년을 선택하세요.");
                cmbYear.Focus();
                return;
            }
            else
            {
                student.Year = (int)cmbYear.SelectedItem;
            }

            if (cmbClass.SelectedIndex < 0)
            {
                MessageBox.Show("반을 선택하세요.");
                cmbClass.Focus();
                return;
            }
            else
            {
                student.Class = cmbClass.SelectedItem.ToString();
            }

            if (cmbRegStatus.SelectedIndex < 0)
            {
                MessageBox.Show("재적상태를 선택하세요.");
                cmbRegStatus.Focus();
                return;
            }
            else
            {
                student.RegStatus = cmbRegStatus.SelectedItem.ToString();
            }

            student.Address = tbxAddress.Text.Trim();
            student.Contact = tbxContact.Text.Trim();

            students[number] = student;  //딕셔너리에 데이터 추가방법 1
            //students.Add(number, student); //딕셔너리에 데이터 추가방법 2
            lbxDictionary.Items.Add(student);
        }

        private void UpdateStudet()  //define
        {
            string number = tbxNumber.Text.Trim();

            var name = tbxName.Text.Trim();
            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                MessageBox.Show("이름은 최소 2글자여야 합니다.");
                tbxName.Focus();
                return;
            }

            //if (true == students.ContainsKey(number))
            //{
            //    tbxNumber.Focus();
            //    return;
            //}

            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth;//, birthDay;
            if (int.TryParse(tbxBirthYear.Text, out birthYear))
            {
                if (birthYear < 1900 || birthYear > 9000)
                {
                    MessageBox.Show("유효한 생년(1900~9000)");
                    tbxBirthYear.Focus();
                    return;
                }
            }
            else
            {
                return;
            }

            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {
                if (birthMonth < 1 || birthMonth > 12)
                {
                    MessageBox.Show("유효한 월(1~12)");
                    tbxBirthMonth.Focus();
                    return;
                }
            }
            else
            {
                return;
            }

            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {
                if (birthDay < 1 || birthDay > 31)
                {
                    MessageBox.Show("유효한 일(1~31)");
                    tbxBirthDay.Focus();
                    return;
                }
            }
            else
            {
                return;
            }

            //현재시간 : DateTime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            if (cmbAdvisor.SelectedIndex < 0)
            {
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbAdvisor.SelectedItem as Professor).Name;
            }

            if (cmbYear.SelectedIndex < 0)
            {
                MessageBox.Show("학년을 선택하세요.");
                cmbYear.Focus();
                return;
            }
            else
            {
                student.Year = (int)cmbYear.SelectedItem;
            }

            if (cmbClass.SelectedIndex < 0)
            {
                MessageBox.Show("반을 선택하세요.");
                cmbClass.Focus();
                return;
            }
            else
            {
                student.Class = cmbClass.SelectedItem.ToString();
            }

            if (cmbRegStatus.SelectedIndex < 0)
            {
                MessageBox.Show("재적상태를 선택하세요.");
                cmbRegStatus.Focus();
                return;
            }
            else
            {
                student.RegStatus = cmbRegStatus.SelectedItem.ToString();
            }

            student.Address = tbxAddress.Text.Trim();
            student.Contact = tbxContact.Text.Trim();

            students[number] = student;  //딕셔너리에 데이터 추가방법 1
            //students.Add(number, student); //딕셔너리에 데이터 추가방법 2
            lbxDictionary.Items.Add(student);

            MessageBox.Show("수정완료");
            ClearStudentInfo();

            btnRegister.Text = "등록";
            selectedStudent = null;
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxDictionary.SelectedIndex < 0)
                return;

            selectedStudent = (lbxDictionary.SelectedItem as Student);
            
            btnNew_Click(sender, EventArgs.Empty);

            if (selectedStudent != null)
            {
                DisplaySelectedStudent(selectedStudent);
            }
        }

        private void DisplaySelectedStudent(Student student)
        {
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
            tbxBirthMonth.Text = student.BirthInfo.Month.ToString();
            tbxBirthDay.Text = student.BirthInfo.Day.ToString();

            for (int i=0; i < cmbDepartment.Items.Count; i++)
            {
                if ((cmbDepartment.Items[i] as Department).Code == student.DepartmentCode)
                {
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbAdvisor.Items.Count; i++)
            {
                if ((cmbAdvisor.Items[i] as Professor).Name == student.DepartmentCode)
                {
                    cmbAdvisor.SelectedIndex = i;
                    break;
                }
            }

            cmbYear.SelectedItem = student.Year;
            cmbClass.SelectedItem = student.Class;
            cmbRegStatus.SelectedItem = student.RegStatus;
            tbxAddress.Text = student.Address.ToString();
            tbxContact.Text = student.Contact.ToString();

            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            ClearTestScoreInfo();

            var number = tbxTestNumber.Text.Trim();
            if(string.IsNullOrEmpty(number))
            {
                MessageBox.Show("학번을 입력하세요.");
                return;
            }

            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text.Trim());

            if(selectedStudent == null)
            {
                MessageBox.Show("해당 학번의 학생이 없습니다.");
                return;
            }

            lblTestName.Text = selectedStudent.Name;
        }

        private void ClearTestScoreInfo()
        {
            foreach (var tbx in tbxTestScores)
            {
                tbx.Text = string.Empty;
            }

            //tbxTestNumber.Text = string.Empty;
            lblTestName.Text = string.Empty;
        }

        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number))
            {
                return students[number];
            } else
            {
                return null;
            }
        }
    }
}

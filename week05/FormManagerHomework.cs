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

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣는다.
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[10];
            professors = new List<Professor>();

            //(구현) 학생정보
            for (int i = 1; i <= 4; i++)
                cmbYear.Items.Add(i);

            cmbClass.Items.AddRange(new string[] { "A", "B", "C" });
            cmbRegStatus.Items.AddRange(new string[] { "재학", "졸업", "휴학", "퇴학" });
        }

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            // (구현) 학과코드가 비어있으면 메시지를 띄우고 포커스 이동한 후 종료한다.
            if (string.IsNullOrWhiteSpace(tbxDepartmentCode.Text))
            {
                MessageBox.Show("학과코드를 입력하세요.");
                tbxDepartmentCode.Focus();
                return;
            }
            // (구현) 학과이름이 비어있으면 메시지를 띄우고 포커스 이동한 후 종료한다.
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
                        //(구현) 동일한 코드는 사용이 불가능하다는 메시지 띄우고 포커스를 이동한다.
                        MessageBox.Show("이미 존재하는 학과코드 입니다. 다른 코드를 입력하세요.");
                        tbxDepartmentCode.Focus();
                        return;
                    }
                }
            }
            if (index < 0)
            {
                //(구현) 더 이상 신규 학과정보를 입력할 수 없을 때 메세지로 알린다.
                MessageBox.Show("더 이상 학과정보를 입력할 수 없습니다.");
                return;
            }

            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);
            //추후 아래 3문장은 지운다.
            lbxDepartment.Items.Add(dept.Code);
            lbxDepartment.Items.Add(dept.Name);
            lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0)
            {
                //(구현) 삭제할 학과를 선택하라는 메시지를 띄운다.
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

                    cmbDepartment.SelectedIndex = -1;
                    cmbAdvisor.Items.Clear();
                    break;

                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index값 검사해서 진행여부 결정
            //(구현) 조회할 학과를 선택하라는 메시지를 띄우고 종료한다.
            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("조회할 학과를 선택하세요.");
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

        // Fix the error by changing departments[i].Number to professors[i].Number in btnRegisterProfessor_Click method
        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxProfessorNumber.Text))
            {
                MessageBox.Show("교수번호를 입력하세요.");
                tbxProfessorNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxProfessorName.Text))
            {
                MessageBox.Show("교수이름을 입력하세요.");
                tbxProfessorName.Focus();
                return;
            }

            foreach (var professor in professors)
            {
                if (professor.Number == tbxProfessorNumber.Text)
                {
                    MessageBox.Show("이미 존재하는 교수번호입니다. 다른 번호를 입력하세요.");
                    tbxProfessorNumber.Focus();
                    return;
                }
            }

            Professor newProfessor = new Professor
            {
                Number = tbxProfessorNumber.Text,
                Name = tbxProfessorName.Text,
                DepartmentCode = (cmbProfessorDepartment.SelectedItem as Department)?.Code
            };

            professors.Add(newProfessor);
            lbxProfessor.Items.Add(newProfessor);

            if (cmbDepartment.SelectedItem != null)
            {
                cmbDepartment_SelectedIndexChanged(this, EventArgs.Empty);
            }
        }

        //(구현) 교수 정보 구현(삭제)
        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 교수를 선택하세요.");
                return;
            }

            if (lbxProfessor.SelectedItem is Professor professor)
            {
                professors.Remove(professor);
                lbxProfessor.Items.Remove(professor);
            }
        }

        //(구현) 학생 정보 구현
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var department = cmbDepartment.SelectedItem as Department;

            if (department != null)
            {
                foreach (var professor in professors)
                {
                    if (professor != null && professor.DepartmentCode == department.Code)
                    {
                        cmbAdvisor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbxNumber.Clear();
            tbxName.Clear();
            tbxBirthYear.Clear();
            tbxBirthMonth.Clear();
            tbxBirthDay.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.Items.Clear();
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Clear();
            tbxContact.Clear();
            tbxNumber.Focus();
        }

    }
}

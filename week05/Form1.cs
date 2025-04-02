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

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣는다.
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[10];
        }

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            int index = -1;
            for(int i=0; i< departments.Length; i++)
            {
                if (departments[i] ==null)
                {
                    if (index < 0) { 
                        index = i;
                    }
                    //break;
                } else {
                    if (departments[i].Code == tbxDepartmentCode.Text)
                    {
                        //메시지 띄우고
                        return;
                    }
                }
            }
            if (index < 0)
            {
                //메세지 띄우기.
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
                //메세지 띄우고
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
    }
}

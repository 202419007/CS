namespace Proj_FinacialLedger_202419007
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.YearControl = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tbxTargetAmount = new System.Windows.Forms.TextBox();
            this.TargetAmount = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpIncome = new System.Windows.Forms.GroupBox();
            this.btnIncomes = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxIncomesMoney = new System.Windows.Forms.TextBox();
            this.tbxIncomesContent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxIncomesDay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxIncomesMonth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxIncomesYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpExpenditure = new System.Windows.Forms.GroupBox();
            this.btnExpenditures = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxExpendituresMoney = new System.Windows.Forms.TextBox();
            this.tbxExpendituresContent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxExpendituresDay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxExpendituresMonth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxExpendituresYear = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.grpQuick = new System.Windows.Forms.GroupBox();
            this.btnQuickExpenditures = new System.Windows.Forms.Button();
            this.btnQuickIncomes = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tbxQuickMoney = new System.Windows.Forms.TextBox();
            this.tbxQuickContent = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbIncomes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbExpenditures = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbAll = new System.Windows.Forms.ListBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.YearControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpIncome.SuspendLayout();
            this.grpExpenditure.SuspendLayout();
            this.grpQuick.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // YearControl
            // 
            this.YearControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.YearControl.Controls.Add(this.btnLoad);
            this.YearControl.Controls.Add(this.btnSave);
            this.YearControl.Controls.Add(this.btnNew);
            this.YearControl.Controls.Add(this.tbxTargetAmount);
            this.YearControl.Controls.Add(this.TargetAmount);
            this.YearControl.Controls.Add(this.year);
            this.YearControl.Controls.Add(this.tbxYear);
            this.YearControl.Location = new System.Drawing.Point(21, 61);
            this.YearControl.Name = "YearControl";
            this.YearControl.Size = new System.Drawing.Size(422, 100);
            this.YearControl.TabIndex = 0;
            this.YearControl.TabStop = false;
            this.YearControl.Text = "연도 설정";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(314, 57);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 33);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(217, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "저장하기";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(217, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(186, 31);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "신규(초기화)";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbxTargetAmount
            // 
            this.tbxTargetAmount.Location = new System.Drawing.Point(67, 57);
            this.tbxTargetAmount.Name = "tbxTargetAmount";
            this.tbxTargetAmount.Size = new System.Drawing.Size(100, 21);
            this.tbxTargetAmount.TabIndex = 3;
            // 
            // TargetAmount
            // 
            this.TargetAmount.AutoSize = true;
            this.TargetAmount.Location = new System.Drawing.Point(16, 60);
            this.TargetAmount.Name = "TargetAmount";
            this.TargetAmount.Size = new System.Drawing.Size(45, 12);
            this.TargetAmount.TabIndex = 2;
            this.TargetAmount.Text = "목표액:";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(16, 29);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(33, 12);
            this.year.TabIndex = 1;
            this.year.Text = "연도:";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(67, 20);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(64, 21);
            this.tbxYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "가계부 관리 시스템";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(449, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재 상태";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(162, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "상태: 흑자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "잔액: 0원";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "총 지출: 0원";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "총 수입: 0원";
            // 
            // grpIncome
            // 
            this.grpIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpIncome.Controls.Add(this.btnIncomes);
            this.grpIncome.Controls.Add(this.label12);
            this.grpIncome.Controls.Add(this.tbxIncomesMoney);
            this.grpIncome.Controls.Add(this.tbxIncomesContent);
            this.grpIncome.Controls.Add(this.label11);
            this.grpIncome.Controls.Add(this.tbxIncomesDay);
            this.grpIncome.Controls.Add(this.label10);
            this.grpIncome.Controls.Add(this.tbxIncomesMonth);
            this.grpIncome.Controls.Add(this.label9);
            this.grpIncome.Controls.Add(this.tbxIncomesYear);
            this.grpIncome.Controls.Add(this.label8);
            this.grpIncome.Controls.Add(this.label7);
            this.grpIncome.Controls.Add(this.label6);
            this.grpIncome.Location = new System.Drawing.Point(21, 177);
            this.grpIncome.Name = "grpIncome";
            this.grpIncome.Size = new System.Drawing.Size(250, 133);
            this.grpIncome.TabIndex = 5;
            this.grpIncome.TabStop = false;
            this.grpIncome.Text = "수입 등록";
            // 
            // btnIncomes
            // 
            this.btnIncomes.BackColor = System.Drawing.Color.Green;
            this.btnIncomes.ForeColor = System.Drawing.Color.White;
            this.btnIncomes.Location = new System.Drawing.Point(55, 101);
            this.btnIncomes.Name = "btnIncomes";
            this.btnIncomes.Size = new System.Drawing.Size(125, 26);
            this.btnIncomes.TabIndex = 12;
            this.btnIncomes.Text = "+ 수입 등록";
            this.btnIncomes.UseVisualStyleBackColor = false;
            this.btnIncomes.Click += new System.EventHandler(this.btnIncomes_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "원";
            // 
            // tbxIncomesMoney
            // 
            this.tbxIncomesMoney.Location = new System.Drawing.Point(55, 74);
            this.tbxIncomesMoney.Name = "tbxIncomesMoney";
            this.tbxIncomesMoney.Size = new System.Drawing.Size(118, 21);
            this.tbxIncomesMoney.TabIndex = 10;
            // 
            // tbxIncomesContent
            // 
            this.tbxIncomesContent.Location = new System.Drawing.Point(55, 47);
            this.tbxIncomesContent.Name = "tbxIncomesContent";
            this.tbxIncomesContent.Size = new System.Drawing.Size(174, 21);
            this.tbxIncomesContent.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "일";
            // 
            // tbxIncomesDay
            // 
            this.tbxIncomesDay.Location = new System.Drawing.Point(163, 20);
            this.tbxIncomesDay.Name = "tbxIncomesDay";
            this.tbxIncomesDay.Size = new System.Drawing.Size(30, 21);
            this.tbxIncomesDay.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "월";
            // 
            // tbxIncomesMonth
            // 
            this.tbxIncomesMonth.Location = new System.Drawing.Point(113, 20);
            this.tbxIncomesMonth.Name = "tbxIncomesMonth";
            this.tbxIncomesMonth.Size = new System.Drawing.Size(30, 21);
            this.tbxIncomesMonth.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "년";
            // 
            // tbxIncomesYear
            // 
            this.tbxIncomesYear.Location = new System.Drawing.Point(55, 20);
            this.tbxIncomesYear.Name = "tbxIncomesYear";
            this.tbxIncomesYear.Size = new System.Drawing.Size(41, 21);
            this.tbxIncomesYear.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "금액:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "내역:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "날짜:";
            // 
            // grpExpenditure
            // 
            this.grpExpenditure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpExpenditure.Controls.Add(this.btnExpenditures);
            this.grpExpenditure.Controls.Add(this.label13);
            this.grpExpenditure.Controls.Add(this.tbxExpendituresMoney);
            this.grpExpenditure.Controls.Add(this.tbxExpendituresContent);
            this.grpExpenditure.Controls.Add(this.label14);
            this.grpExpenditure.Controls.Add(this.tbxExpendituresDay);
            this.grpExpenditure.Controls.Add(this.label15);
            this.grpExpenditure.Controls.Add(this.tbxExpendituresMonth);
            this.grpExpenditure.Controls.Add(this.label16);
            this.grpExpenditure.Controls.Add(this.tbxExpendituresYear);
            this.grpExpenditure.Controls.Add(this.label17);
            this.grpExpenditure.Controls.Add(this.label18);
            this.grpExpenditure.Controls.Add(this.label19);
            this.grpExpenditure.Location = new System.Drawing.Point(286, 177);
            this.grpExpenditure.Name = "grpExpenditure";
            this.grpExpenditure.Size = new System.Drawing.Size(250, 133);
            this.grpExpenditure.TabIndex = 13;
            this.grpExpenditure.TabStop = false;
            this.grpExpenditure.Text = "지출 등록";
            // 
            // btnExpenditures
            // 
            this.btnExpenditures.BackColor = System.Drawing.Color.Red;
            this.btnExpenditures.ForeColor = System.Drawing.Color.White;
            this.btnExpenditures.Location = new System.Drawing.Point(56, 101);
            this.btnExpenditures.Name = "btnExpenditures";
            this.btnExpenditures.Size = new System.Drawing.Size(125, 26);
            this.btnExpenditures.TabIndex = 12;
            this.btnExpenditures.Text = "- 지출 등록";
            this.btnExpenditures.UseVisualStyleBackColor = false;
            this.btnExpenditures.Click += new System.EventHandler(this.btnExpenditures_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(179, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "원";
            // 
            // tbxExpendituresMoney
            // 
            this.tbxExpendituresMoney.Location = new System.Drawing.Point(55, 74);
            this.tbxExpendituresMoney.Name = "tbxExpendituresMoney";
            this.tbxExpendituresMoney.Size = new System.Drawing.Size(118, 21);
            this.tbxExpendituresMoney.TabIndex = 10;
            // 
            // tbxExpendituresContent
            // 
            this.tbxExpendituresContent.Location = new System.Drawing.Point(55, 47);
            this.tbxExpendituresContent.Name = "tbxExpendituresContent";
            this.tbxExpendituresContent.Size = new System.Drawing.Size(174, 21);
            this.tbxExpendituresContent.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(199, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "일";
            // 
            // tbxExpendituresDay
            // 
            this.tbxExpendituresDay.Location = new System.Drawing.Point(163, 20);
            this.tbxExpendituresDay.Name = "tbxExpendituresDay";
            this.tbxExpendituresDay.Size = new System.Drawing.Size(30, 21);
            this.tbxExpendituresDay.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(149, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 6;
            this.label15.Text = "월";
            // 
            // tbxExpendituresMonth
            // 
            this.tbxExpendituresMonth.Location = new System.Drawing.Point(113, 20);
            this.tbxExpendituresMonth.Name = "tbxExpendituresMonth";
            this.tbxExpendituresMonth.Size = new System.Drawing.Size(30, 21);
            this.tbxExpendituresMonth.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(99, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "년";
            // 
            // tbxExpendituresYear
            // 
            this.tbxExpendituresYear.Location = new System.Drawing.Point(55, 20);
            this.tbxExpendituresYear.Name = "tbxExpendituresYear";
            this.tbxExpendituresYear.Size = new System.Drawing.Size(41, 21);
            this.tbxExpendituresYear.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "금액:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "내역:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "날짜:";
            // 
            // grpQuick
            // 
            this.grpQuick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpQuick.Controls.Add(this.btnQuickExpenditures);
            this.grpQuick.Controls.Add(this.btnQuickIncomes);
            this.grpQuick.Controls.Add(this.label20);
            this.grpQuick.Controls.Add(this.tbxQuickMoney);
            this.grpQuick.Controls.Add(this.tbxQuickContent);
            this.grpQuick.Controls.Add(this.label24);
            this.grpQuick.Controls.Add(this.label25);
            this.grpQuick.Location = new System.Drawing.Point(552, 177);
            this.grpQuick.Name = "grpQuick";
            this.grpQuick.Size = new System.Drawing.Size(250, 133);
            this.grpQuick.TabIndex = 14;
            this.grpQuick.TabStop = false;
            this.grpQuick.Text = "빠른 입력 (오늘 날짜)";
            // 
            // btnQuickExpenditures
            // 
            this.btnQuickExpenditures.BackColor = System.Drawing.Color.Red;
            this.btnQuickExpenditures.ForeColor = System.Drawing.Color.White;
            this.btnQuickExpenditures.Location = new System.Drawing.Point(123, 77);
            this.btnQuickExpenditures.Name = "btnQuickExpenditures";
            this.btnQuickExpenditures.Size = new System.Drawing.Size(69, 26);
            this.btnQuickExpenditures.TabIndex = 13;
            this.btnQuickExpenditures.Text = "- 지출";
            this.btnQuickExpenditures.UseVisualStyleBackColor = false;
            this.btnQuickExpenditures.Click += new System.EventHandler(this.btnQuickExpenditures_Click_1);
            // 
            // btnQuickIncomes
            // 
            this.btnQuickIncomes.BackColor = System.Drawing.Color.Green;
            this.btnQuickIncomes.ForeColor = System.Drawing.Color.White;
            this.btnQuickIncomes.Location = new System.Drawing.Point(51, 77);
            this.btnQuickIncomes.Name = "btnQuickIncomes";
            this.btnQuickIncomes.Size = new System.Drawing.Size(69, 26);
            this.btnQuickIncomes.TabIndex = 12;
            this.btnQuickIncomes.Text = "+ 수입";
            this.btnQuickIncomes.UseVisualStyleBackColor = false;
            this.btnQuickIncomes.Click += new System.EventHandler(this.btnQuickIncomes_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(175, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 11;
            this.label20.Text = "원";
            // 
            // tbxQuickMoney
            // 
            this.tbxQuickMoney.Location = new System.Drawing.Point(51, 50);
            this.tbxQuickMoney.Name = "tbxQuickMoney";
            this.tbxQuickMoney.Size = new System.Drawing.Size(118, 21);
            this.tbxQuickMoney.TabIndex = 10;
            // 
            // tbxQuickContent
            // 
            this.tbxQuickContent.Location = new System.Drawing.Point(51, 23);
            this.tbxQuickContent.Name = "tbxQuickContent";
            this.tbxQuickContent.Size = new System.Drawing.Size(174, 21);
            this.tbxQuickContent.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "금액:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 12);
            this.label25.TabIndex = 1;
            this.label25.Text = "내역:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(21, 328);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(781, 207);
            this.TabControl.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbIncomes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "수입 내역";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbIncomes
            // 
            this.lbIncomes.FormattingEnabled = true;
            this.lbIncomes.ItemHeight = 12;
            this.lbIncomes.Location = new System.Drawing.Point(7, 7);
            this.lbIncomes.Name = "lbIncomes";
            this.lbIncomes.Size = new System.Drawing.Size(760, 160);
            this.lbIncomes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbExpenditures);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "지출 내역";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbExpenditures
            // 
            this.lbExpenditures.FormattingEnabled = true;
            this.lbExpenditures.ItemHeight = 12;
            this.lbExpenditures.Location = new System.Drawing.Point(6, 6);
            this.lbExpenditures.Name = "lbExpenditures";
            this.lbExpenditures.Size = new System.Drawing.Size(760, 160);
            this.lbExpenditures.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbAll);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(773, 181);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "전체 내역";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbAll
            // 
            this.lbAll.FormattingEnabled = true;
            this.lbAll.ItemHeight = 12;
            this.lbAll.Location = new System.Drawing.Point(6, 6);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(760, 160);
            this.lbAll.TabIndex = 2;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Gray;
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(707, 537);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(91, 27);
            this.btnEnd.TabIndex = 16;
            this.btnEnd.Text = "종료";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 577);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.grpQuick);
            this.Controls.Add(this.grpExpenditure);
            this.Controls.Add(this.grpIncome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearControl);
            this.Name = "Form1";
            this.Text = "가계부 관리 시스템";
            this.YearControl.ResumeLayout(false);
            this.YearControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpIncome.ResumeLayout(false);
            this.grpIncome.PerformLayout();
            this.grpExpenditure.ResumeLayout(false);
            this.grpExpenditure.PerformLayout();
            this.grpQuick.ResumeLayout(false);
            this.grpQuick.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox YearControl;
        private System.Windows.Forms.Label TargetAmount;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox tbxTargetAmount;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpIncome;
        private System.Windows.Forms.TextBox tbxIncomesMonth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxIncomesYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIncomes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxIncomesMoney;
        private System.Windows.Forms.TextBox tbxIncomesContent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxIncomesDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpExpenditure;
        private System.Windows.Forms.Button btnExpenditures;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxExpendituresMoney;
        private System.Windows.Forms.TextBox tbxExpendituresContent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxExpendituresDay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxExpendituresMonth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxExpendituresYear;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox grpQuick;
        private System.Windows.Forms.Button btnQuickIncomes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbxQuickMoney;
        private System.Windows.Forms.TextBox tbxQuickContent;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnQuickExpenditures;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbIncomes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ListBox lbExpenditures;
        private System.Windows.Forms.ListBox lbAll;
    }
}


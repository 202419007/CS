using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Proj_FinacialLedger_202419007
{
    public partial class Form1 : Form
    {
        Dictionary<int, FinancialLedger> ledgers = new Dictionary<int, FinancialLedger>();

        public string PATH
        {
            get
            {
                var path = "C:\\amount";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                return path;
            }
        }

        public Form1()
        {
            InitializeComponent();

            grpIncome.Enabled = false;
            grpExpenditure.Enabled = false;
            grpQuick.Enabled = false;

            SetInputs();
            tbxYear.Text = DateTime.Now.Year.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbxYear.Enabled = true;
            tbxTargetAmount.Enabled = true;

            btnSave.Enabled = true;
            btnLoad.Enabled = true;

            grpIncome.Enabled = false;
            grpExpenditure.Enabled = false;
            grpQuick.Enabled = false;

            ClearLists();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxYear.Text, out int year))
            {
                MessageBox.Show("연도를 입력하세요.");
                return;
            }

            if (!int.TryParse(tbxTargetAmount.Text, out int targetAmount))
            {
                MessageBox.Show("목표 금액을 입력하세요.");
                return;
            }

            var ledger = new FinancialLedger(year, targetAmount);
            ledgers[year] = ledger;

            SaveLedgerToFile(ledger);

            grpIncome.Enabled = true;
            grpExpenditure.Enabled = true;
            grpQuick.Enabled = true;

            ShowLedger(ledger);

            MessageBox.Show("저장 완료");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxYear.Text, out int year))
            {
                MessageBox.Show("연도를 입력하세요.");
                return;
            }

            string file = Path.Combine(PATH, $"{year}.txt");
            if (!File.Exists(file))
            {
                MessageBox.Show("파일이 없습니다.");
                return;
            }

            FinancialLedger ledger = LoadLedgerFromFile(file);
            ledgers[year] = ledger;
            tbxTargetAmount.Text = ledger.TargetAmount.ToString();

            grpIncome.Enabled = true;
            grpExpenditure.Enabled = true;
            grpQuick.Enabled = true;

            ShowLedger(ledger);
        }

        private void btnIncomes_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxYear.Text, out int year)) return;

            DateTime date = GetDateFromInputs(tbxIncomesYear, tbxIncomesMonth, tbxIncomesDay);
            string content = tbxIncomesContent.Text;
            if (!int.TryParse(tbxIncomesMoney.Text, out int amount)) return;

            if (ledgers[year].RegIncome(date, content, amount))
            {
                SaveLedgerToFile(ledgers[year]);
                ShowLedger(ledgers[year]);
            }
        }

        private void btnExpenditures_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxYear.Text, out int year)) return;

            DateTime date = GetDateFromInputs(tbxExpendituresYear, tbxExpendituresMonth, tbxExpendituresDay);
            string content = tbxExpendituresContent.Text;
            if (!int.TryParse(tbxExpendituresMoney.Text, out int amount)) return;

            if (ledgers[year].RegExpenditure(date, content, amount))
            {
                SaveLedgerToFile(ledgers[year]);
                ShowLedger(ledgers[year]);
            }
        }

        private void btnQuickIncomes_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxYear.Text, out int year)) return;
            string content = tbxQuickContent.Text;
            if (!int.TryParse(tbxQuickMoney.Text, out int amount)) return;

            if (ledgers[year].RegIncome(content, amount))
            {
                SaveLedgerToFile(ledgers[year]);
                ShowLedger(ledgers[year]);
            }
        }

        private void btnQuickExpenditures_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxYear.Text, out int year)) return;
            string content = tbxQuickContent.Text;
            if (!int.TryParse(tbxQuickMoney.Text, out int amount)) return;

            if (ledgers[year].RegExpenditure(content, amount))
            {
                SaveLedgerToFile(ledgers[year]);
                ShowLedger(ledgers[year]);
            }
        }

        private void SaveLedgerToFile(FinancialLedger ledger)
        {
            string file = Path.Combine(PATH, $"{ledger.Year}.txt");
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(ledger.TargetAmount);

                foreach (var income in ledger.Incomes)
                {
                    string line = income.Key.ToString("yyyyMMdd HHmmssfff") + "," +
                                  income.Value.Content + "," + income.Value.Money;
                    writer.WriteLine(line);
                }

                foreach (var expend in ledger.Expenditures)
                {
                    string line = expend.Key.ToString("yyyyMMdd HHmmssfff") + "," +
                                  expend.Value.Content + "," + expend.Value.Money;
                    writer.WriteLine(line);
                }
            }

        }

        private FinancialLedger LoadLedgerFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int year = int.Parse(Path.GetFileNameWithoutExtension(path));
            int target = int.Parse(lines[0]);
            FinancialLedger ledger = new FinancialLedger(year, target);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                DateTime dt = DateTime.ParseExact(parts[0], "yyyyMMdd HHmmssfff", null);
                bool isIncome = parts[1] == "0";
                string content = parts[2];
                int money = int.Parse(parts[3]);

                if (isIncome)
                    ledger.RegIncome(dt, content, money);
                else
                    ledger.RegExpenditure(dt, content, money);
            }
            return ledger;
        }

        private DateTime GetDateFromInputs(TextBox yearBox, TextBox monthBox, TextBox dayBox)
        {
            int y = int.Parse(yearBox.Text);
            int m = int.Parse(monthBox.Text);
            int d = int.Parse(dayBox.Text);
            return new DateTime(y, m, d);
        }

        private void ShowLedger(FinancialLedger ledger)
        {
            lbIncomes.Items.Clear();
            lbExpenditures.Items.Clear();
            lbAll.Items.Clear();

            foreach (var kv in ledger.Incomes)
            {
                string line = $"[수입] {kv.Key:yyyy-MM-dd} {kv.Value}";
                lbIncomes.Items.Add(line);
                lbAll.Items.Add(line);
            }

            foreach (var kv in ledger.Expenditures)
            {
                string line = $"[지출] {kv.Key:yyyy-MM-dd} {kv.Value}";
                lbExpenditures.Items.Add(line);
                lbAll.Items.Add(line);
            }
        }

        private void ClearLists()
        {
            tbxYear.Clear();
            tbxTargetAmount.Clear();
            tbxIncomesYear.Clear();
            tbxIncomesMonth.Clear();
            tbxIncomesDay.Clear();
            tbxIncomesContent.Clear();
            tbxIncomesMoney.Clear();
            tbxExpendituresYear.Clear();
            tbxExpendituresMonth.Clear();
            tbxExpendituresDay.Clear();
            tbxExpendituresContent.Clear();
            tbxExpendituresMoney.Clear();
            tbxQuickContent.Clear();
            tbxQuickMoney.Clear();
            lbIncomes.Items.Clear();
            lbExpenditures.Items.Clear();
            lbAll.Items.Clear();
        }

        private void SetInputs()
        {
            DateTime now = DateTime.Now;

            tbxIncomesYear.Text = now.Year.ToString();
            tbxIncomesMonth.Text = now.Month.ToString("D2");
            tbxIncomesDay.Text = now.Day.ToString("D2");

            tbxExpendituresYear.Text = now.Year.ToString();
            tbxExpendituresMonth.Text = now.Month.ToString("D2");
            tbxExpendituresDay.Text = now.Day.ToString("D2");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

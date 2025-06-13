using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202419007
{
    class FinancialLedger : Financial
    {
        private int _year;
        private int _targetAmount;

        public int Year
        {
            get { return _year; }
        }
        public int TargetAmount => _targetAmount;
        
        public bool IsBlack
        {
            get
            {
                if (_targetAmount == 0)
                {
                    if (TotalIncome > TotalExpenditure)
                    {
                        return true;
                    }
                }
                if (_targetAmount > 0)
                {
                    if ((TotalIncome - TotalExpenditure) >= _targetAmount)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public FinancialLedger(int year)
        {
            _year = year;
        }
        public FinancialLedger(int year, int targetAmount)
        {
            _year = year;
            _targetAmount = targetAmount;
        }

        public override bool RegIncome(DateTime date, string content, int money)
        {
            if (date.Year != _year)
            {
                return false;
            }
            return base.RegIncome(date, content, money);
        }
        public override bool RegExpenditure(DateTime date, string content, int money)
        {
            if (date.Year != _year)
            {
                return false;
            }
            return base.RegExpenditure(date, content, money);
        }
        public override bool RegIncome(string content, int money)
        {
            return RegIncome(DateTime.Now, content, money);
        }
        public override bool RegExpenditure(string content, int money)
        {
            return RegExpenditure(DateTime.Now, content, money);
        }
    }
}

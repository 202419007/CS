using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202419007
{
    abstract class Financial
    {
        protected Dictionary<DateTime, Info> _incomes = new Dictionary<DateTime, Info>();
        protected Dictionary<DateTime, Info> _expenditures = new Dictionary<DateTime, Info>();

        public Dictionary<DateTime, Info> Incomes
        {
            get { return _incomes; }
        }

        public Dictionary<DateTime, Info> Expenditures
        {
            get { return _expenditures; }
        }

        public int TotalIncome
        {
            get
            {
                int totalInc = 0;
                foreach (var item in _incomes.Values)
                    totalInc += item.Money;
                return totalInc;
            }
        }
        public int TotalExpenditure
        {
            get
            {
                int totalExp = 0;
                foreach (var item in _expenditures.Values)
                    totalExp += item.Money;
                return totalExp;
            }
        }
        public virtual bool RegIncome(DateTime date, string content, int money)
        {
            if (money < 0)
            {
                return false;
            }
            _incomes[date] = new Info(content, money);
            return true;
        }
        public virtual bool RegExpenditure(DateTime date, string content, int money)
        {
            if (money < 0)
            {
                return false;
            }
            _expenditures[date] = new Info(content, money);
            return true;
        }
        public virtual bool RegIncome(string content, int money)
        {
            if (money < 0)
            {
                return false;
            }
            DateTime now = DateTime.Now;
            while (_incomes.ContainsKey(now))
            {
                now = now.AddMilliseconds(1);
            }

            return RegIncome(now, content, money);
        }
        public virtual bool RegExpenditure(string content, int money)
        {
            if (money < 0)
            {
                return false;
            }
            
            DateTime now = DateTime.Now;
            while (_expenditures.ContainsKey(now))
            {
                now = now.AddMilliseconds(1); // 밀리초 충돌 방지
            }

            return RegExpenditure(now, content, money);
        }
    }
}

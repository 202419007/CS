using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07Homework
{
    class Product
    {
        public string lblSearchProductCode;
        public string lblSearchProductName;
        public int lblSearchProductPrice;
        public int lblSearchProductStock;
        public DateTime lblSearchProductRegDate;

        public override string ToString()
        {
            return $"[{lblSearchProductCode}] {lblSearchProductName}";
        }

        public int SalePrice()
        {
            if ((DateTime.Now - lblSearchProductRegDate).TotalDays > 30)
            {
                return (int)(lblSearchProductPrice * 0.8);
            }
            else
            {
                return lblSearchProductPrice;
            }
        }

        public int CalPrice(int count)
        {
            return count * SalePrice();
        }
    }
}

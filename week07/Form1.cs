using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week07Homework
{
    public partial class Form1: Form
    {
        private List<Product> productList = new List<Product>();
        private Product selectedProduct = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string name = tbxInputProductName.Text.Trim();
            string productPrice = tbxInputProductPrice.Text.Trim();
            string productStock = tbxInputProductStock.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("상품을 올바르게 입력하세요");
                return;
            }
            if (!int.TryParse(productPrice, out int price) || price < 0)
            {
                MessageBox.Show("가격을 올바르게 입력하세요");
                return;
            }
            if (!int.TryParse(productStock, out int stock) || stock < 0)
            {
                MessageBox.Show("재고를 올바르게 입력하세요");
                return;
            }

            DateTime regDate = DateTime.Now.AddDays(-(new Random()).Next(20, 100));

            var random = new Random();
            string code;
            do
            {
                code = DateTime.Now.ToString("yyyyMMdd") + random.Next(1000).ToString("D3");
            } while (productList.Any(p => p.lblSearchProductCode == code));

            Product newProduct = new Product
            {
                lblSearchProductName = name,
                lblSearchProductCode = code,
                lblSearchProductPrice = price,
                lblSearchProductStock = stock,
                lblSearchProductRegDate = regDate
            };
            productList.Add(newProduct);

            MessageBox.Show("등록완료");

            tbxInputProductName.Clear();
            tbxInputProductPrice.Clear();
            tbxInputProductStock.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbxSearchProduct.Items.Clear();
            string keyword = tbxSearchNameCode.Text.Trim();

            var searchProduct = productList.Where(p => p.lblSearchProductName.Contains(keyword) || p.lblSearchProductCode.Contains(keyword)).ToList();
            if (searchProduct.Any())
            {
                foreach (var product in searchProduct)
                {
                    lbxSearchProduct.Items.Add(product);
                }
            }
            else
            {
                MessageBox.Show("해당 상품이 없습니다.");
            }

            lblSearchProductName.Text = "";
            lblSearchProductCode.Text = "";
            lblSearchProductPrice.Text = "";
            lblSearchProductSalePrice.Text = "";
            lblSearchProductStock.Text = "";
            lblSearchProductRegDate.Text = "";
            tbxSearchProductCount.Text = "";
            lblSearchProductTotalPrice.Text = "";
        }

        private void lbxSearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSearchProduct.SelectedItem is Product product)
            {
                selectedProduct = product;

                lblSearchProductName.Text = product.lblSearchProductName;
                lblSearchProductCode.Text = product.lblSearchProductCode;
                lblSearchProductPrice.Text = product.lblSearchProductPrice.ToString();
                lblSearchProductSalePrice.Text = product.SalePrice().ToString();
                lblSearchProductStock.Text = product.lblSearchProductStock.ToString();
                lblSearchProductRegDate.Text = product.lblSearchProductRegDate.ToString("yyyy-MM-dd");
                tbxSearchProductCount.Text = "";
                lblSearchProductTotalPrice.Text = "";
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            lblSearchProductTotalPrice.Text = "";

            if (!int.TryParse(tbxSearchProductCount.Text.Trim(), out int count) || count <= 0)
            {
                MessageBox.Show("수량을 올바르게 입력하세요");
                return;
            }
            if (count > selectedProduct.lblSearchProductStock)
            {
                MessageBox.Show("재고 수량 초과");
                return;
            }

            lblSearchProductTotalPrice.Text = selectedProduct.CalPrice(count).ToString();
        }
    }
}

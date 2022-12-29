using Baitap1.Service;
using Baitap1.entity;
using Baitap1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1.Dal;
internal class DalProduct : IProduct
{
    public List<Product> list { get; set; } = new();
    public void Add()
    {
        var n = Validate<int>.Input("Please enter number of list");
        for(int i = 0; i < n; i++)
        {
            Product pro = new();
            pro.Id = Validate<string>.Input("Please enter id");
            pro.Name = Validate<string>.Input("Please enter name");
            pro.Price = Validate<double>.Input("Please enter price");
            pro.Quantity = Validate<int>.Input("Please enter quantity");
            pro.Mfg = Validate<DateTime>.Input("Please enter datetime");
            list.Add(pro);
        }
    }
    public void Show()
    {
        list.ForEach(Console.WriteLine);
    }
}

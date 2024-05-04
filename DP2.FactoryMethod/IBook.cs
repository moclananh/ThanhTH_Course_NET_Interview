using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.FactoryMethod
{
    // Giao diện cho sách
    public interface IBook
    {
        string Title { get; }
        string Author { get; }
        decimal Price { get; }
        string GetBookDetails();
    }

}

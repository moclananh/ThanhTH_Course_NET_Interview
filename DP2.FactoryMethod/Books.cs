using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.FactoryMethod
{
    // Lớp sách Tiểu thuyết
    public class Novel : IBook
    {
        public string Title => "Novel";

        public string Author => "John Doe";

        public decimal Price => 20.0m;

        public string GetBookDetails()
        {
            return $"Title: {Title}, Author: {Author}, Price: {Price}";
        }
    }

    // Lớp sách Kỹ thuật
    public class TechnicalBook : IBook
    {
        public string Title => "Technical Book";

        public string Author => "Jane Smith";

        public decimal Price => 30.0m;

        public string GetBookDetails()
        {
            return $"Title: {Title}, Author: {Author}, Price: {Price}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP2.FactoryMethod
{
    // Lớp factory sách
    public class BookFactory
    {
        public enum BookType
        {
            Novel,
            Technical
        }

        // Phương thức tạo sách
        public static IBook CreateBook(BookType type)
        {
            switch (type)
            {
                case BookType.Novel:
                    return new Novel();
                case BookType.Technical:
                    return new TechnicalBook();
                default:
                    throw new NotSupportedException("This book type is not supported.");
            }
        }
    }

}

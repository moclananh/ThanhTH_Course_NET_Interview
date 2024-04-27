
class StringFunc
{
    public StringFunc() {
        string str = "Hello";
        int length = str.Length; // length sẽ là 5

        string str2 = "Hello";
        string upperCaseStr = str2.ToUpper(); // upperCaseStr sẽ là "HELLO"
        string lowerCaseStr = str2.ToLower(); // lowerCaseStr sẽ là "hello"

        string str3 = "  Hello   ";
        string trimmedStr = str3.Trim(); // trimmedStr sẽ là "Hello"

        /*
         * Substring(int startIndex) và Substring(int startIndex, int length): 
         * Trích xuất một phần của chuỗi, bắt đầu từ startIndex và có thể chỉ định độ dài của phần được trích xuất. */
        string str4 = "Hello World";
        string sub1 = str4.Substring(6); // sub1 sẽ là "World"
        string sub2 = str4.Substring(0, 5); // sub2 sẽ là "Hello"


        string str5 = "Hello World";
        bool containsWorld = str5.Contains("World"); // containsWorld sẽ là true

        string str6 = "Hello World";
        string replacedStr = str6.Replace("World", "Universe"); // replacedStr sẽ là "Hello Universe"

        /*Split(char[] separator):
        Tách chuỗi thành một mảng các chuỗi con, sử dụng ký tự phân cách chỉ định.*/
        string str7 = "apple,banana,orange";
        string[] fruits = str7.Split(','); // fruits sẽ là một mảng ["apple", "banana", "orange"]


        /*IndexOf(string value) và LastIndexOf(string value): 
        Tìm vị trí đầu tiên hoặc cuối cùng của một chuỗi con trong chuỗi.*/
        string str8 = "Hello World";
        int firstIndex = str8.IndexOf("o"); // firstIndex sẽ là 4
        int lastIndex = str8.LastIndexOf("o"); // lastIndex sẽ là 7


        /* sort */
        // Dùng Arrray
        string[] strings = { "banana", "apple", "orange", "grape", "kiwi" };
        // Sắp xếp mảng
        Array.Sort(strings);
        Array.Reverse(strings);

        // Hàm để sắp xếp chuỗi
        static string SortString(string str)
        {
            // Tách các từ trong chuỗi thành một mảng chuỗi
            string[] words = str.Split(' ');

            // Sắp xếp mảng chuỗi theo thứ tự tăng dần theo bảng chữ cái
            var sortedWords = words.OrderBy(w => w);

            // Kết hợp các từ đã sắp xếp thành một chuỗi mới
            string sortedString = string.Join(" ", sortedWords);

            return sortedString;
        }

    }
}
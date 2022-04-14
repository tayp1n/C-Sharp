using System;

namespace ConsoleApplication2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Client[] clients =
            {
                new Client(2343, "Andrey K.", "st.12", 772342),
                new Client(2344, "Petya A.", "st.13", 772343),
                new Client(2345, "Nastya P.", "st.14", 772344),
                new Client(2346, "Vasya Q.", "st.15", 772345)
            };
            
            Article[] articles =
            {
                new Article(999, "Pizza", 200),
                new Article(998, "Water", 100),
                new Article(997, "Meat", 150)
            };
            
            var ri1 = new RequestItem(articles[0], 1);
            var ri2 = new RequestItem(articles[1], 2);
            var ri3 = new RequestItem(articles[2], 3);

            clients[0].DoRequest(ri1, ri2);
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApplication2
{
   
   
    public struct Request
    {

        private int _code;
        private Client _client;
        private DateTime _day;
        private RequestItem[] _itemList;
      
        public Request(RequestItem[] requestItem, Client client)
        {
            /*_code = requestItem._product.Code;
            _client = client;
            i = client._numberOfOrders;
            _day = DateTime.Now;*/

            _code = 0;
            _client = client;
            _day = DateTime.Now;
            _itemList = requestItem;
            
        }
        
        public float Sum
        {
            get
            {
                float Sum = 0;
                foreach (RequestItem item in _itemList)
                {
                    Sum += item._product.ProductPrice * item.NumberOfProducts;
                }
                return Sum;
            }
        }  
        
        public void PrintRequest()
        {
            
            int i = 0;
            foreach (RequestItem item in _itemList)
            {
                Console.WriteLine($"#{_code}, {_day.ToString("yyyy/MM/dd")}");
                Console.WriteLine("{0}.{1}", i, item);
                i++;
            }
            Console.WriteLine(Sum.ToString(CultureInfo.InvariantCulture));
            
        }
        

    }
}
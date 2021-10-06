using System;
using System.Text.RegularExpressions;

namespace models
{
    public class BarebonesEverythingStore
    {
        private string _item;
        
            public string Items
            {
                get { return _item;}
                set
                {
                    if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                    {
                        throw new Exception ("City can only hold letters");
                    }
                    _item = value;
                }
            }
            public string brandName {get; set;}
            public string productName {get;set;}
            
        }
    }


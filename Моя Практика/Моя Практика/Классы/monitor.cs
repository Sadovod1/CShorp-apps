using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моя_Практика.Классы
{
    class Monitor
    {
        string brand, resolution, size;
        int price;

        public Monitor()
        {
            brand = resolution = size = "";
            price = 0;
        }

        public Monitor(string brand, string resolution, string size, int price)
        {
            this.brand = brand;
            this.resolution = resolution;
            this.size = size;
            this.price = price;
        }

        // Getters:
        public string Get_Brand() { return brand; }
        public string Get_Resolution() { return resolution; }
        public string Get_Size() { return size; }
        public int Get_Price() { return price; }

        // Setters:
        public void Set_Brand(string b) { brand = b; }
        public void Set_Resolution(string b) { resolution = b; }
        public void Set_Size(string b) { size = b; }
        public void Set_Price(int b) { price = b; }

        public void Print()
        {
            Console.WriteLine($"\n\nBrand: {brand}\nResolution: {resolution}\nSize: {size}\nPrice: {price}UAH\n");
        }
    }
}

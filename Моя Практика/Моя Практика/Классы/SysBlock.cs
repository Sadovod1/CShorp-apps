using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моя_Практика.Классы
{
    class SysBlock
    {
        private string cpy, mother_card, brend;
        private int hdd, ram, price;
        
        public SysBlock()
        {
            cpy = "";
            mother_card = "";
            brend = "";
            hdd = 0;
            ram = 0;
            price = 0;
        }

        public SysBlock(string cpy, string mother_card, string brend, int hdd, int ram, int price)
        {
            this.cpy = cpy;
            this.brend = brend;
            this.mother_card = mother_card;
            this.ram = ram;
            this.price = price;
            this.hdd = hdd;
        }

        // Getters:
        public string Cpy() { return cpy; }
        public string Brend() { return brend; }
        public string Mother_card() { return mother_card; }
        public int Hdd() { return hdd; }
        public int Price() { return price; }
        public int Ram() { return ram; }

        // Setters:
        public void Set_Cpy(string c) { cpy = c; }
        public void Set_Brend(string b) {brend = b; }
        public void Set_Mother_card(string a) {  mother_card = a; }
        public void Set_Hdd(int a) { hdd = a; }
        public void Set_Price(int a) { price = a; }
        public void Set_Ram(int a) {  ram = a; }

        public void Print()
        {
            Console.WriteLine($"\nBrand: {brend}\nCpy: {cpy}\nMother_card: {mother_card}\nRam: {ram}Gb\nHdd: {hdd}Gb\nPrice: {price}UAH\n");
        }
    }
}

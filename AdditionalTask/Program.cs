using System;
using con = System.Console;

namespace AdditionalTask
{
    struct Notebook
    {
        private string model;
        private string manufacturer;
        private decimal price;

        public Notebook(string model, string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;

        }
        public void PrintNotebookInfo()
        {
            con.WriteLine(this.model);
            con.WriteLine(this.manufacturer);
            con.WriteLine(this.price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook note = new Notebook("ASUS","NJ751K",800);
            note.PrintNotebookInfo();
        }
    }
}

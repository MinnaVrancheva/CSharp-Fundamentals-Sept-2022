namespace _12.FancyBarcodes
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            int numberOfBarcodes = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                string barcode = Console.ReadLine();
                Match validBarcode = Regex.Match(barcode, pattern);

                if (validBarcode.Success)
                {
                    var productGroup = "";
                    foreach (char ch in barcode)
                    {
                        if (char.IsDigit(ch))
                        {
                            productGroup = string.Concat(productGroup, ch);
                        }
                    }
                    
                    if (productGroup != "")
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    else 
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid barcode");
                }
            }
        }
    }
}

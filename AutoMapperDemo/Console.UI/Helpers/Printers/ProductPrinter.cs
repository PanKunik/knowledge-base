using Console.UI.DTO;

namespace Console.UI.Helpers.Printers
{
    public static class ProductPrinter
    {
        public static void PrintProduct(ProductDTO productDto)
        {
            System.Console.WriteLine("=========================================");
            System.Console.WriteLine($"Name: { productDto.Name }");
            System.Console.WriteLine($"Descritpion: { productDto.Description }");
            CategoryPrinter.PrintCateogry(productDto.Category);
            System.Console.WriteLine($"Type: { productDto.Type }");
            System.Console.WriteLine($"Code: { productDto.Code }");
            System.Console.WriteLine("=========================================");
            System.Console.WriteLine();
        }
    }
}

using Console.UI.DTO;

namespace Console.UI.Helpers.Printers
{
    public static class CategoryPrinter
    {
        public static void PrintCateogry(CategoryDTO categoryDto)
        {
            System.Console.WriteLine("===============Category==================");
            System.Console.WriteLine($"Name: { categoryDto.Name }");
            System.Console.WriteLine($"Main category: { categoryDto.MainCategory }");
            System.Console.WriteLine($"Order: { categoryDto.Order }");
            System.Console.WriteLine("===============Category==================");
        }
    }
}

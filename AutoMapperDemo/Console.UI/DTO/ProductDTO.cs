namespace Console.UI.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public CategoryDTO Category { get; set; }
        public string Code { get; set; }
    }
}

public partial class Product
{
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public int Stock { get; set; }
    public bool IsAvailable { get; set; }
    public string? Category { get; set; }
    public string[]? Tags { get; set; }
    public Dimensions? ProductDimensions { get; set; }
}

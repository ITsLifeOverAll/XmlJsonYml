
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

var product = new Product
{
    Name = "Smartphone",
    Price = 699.99m,
    Stock = 150,
    IsAvailable = true,
    Category = "Electronics",
    Tags = new[] { "Mobile", "Gadget", "New" },
    ProductDimensions = new Dimensions
    {
        Length = 5.5f,
        Width = 2.75f,
        Height = 0.3f
    }
};

// 將物件 product 序列化成 json 字串
var json = JsonSerializer.Serialize(product);

// 將物件 product 序列化成 xml 字串, 使用 XmlSerializer()
var xmlSerializer = new XmlSerializer(typeof(Product));
using var xmlWriter = new StringWriter();
xmlSerializer.Serialize(xmlWriter, product);
var xml = xmlWriter.ToString();

// 將物件 product 序列化成 yaml 字串, 使用 YamlDotNet 库
var yaml = new SerializerBuilder().Build().Serialize(product);

Console.WriteLine(json);
Console.WriteLine();

Console.WriteLine(xml);
Console.WriteLine();

Console.WriteLine(yaml);
Console.WriteLine();








using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main(string[]args)
        {
            // Product Serialization 
            try
            {
                Product product = new Product { Id = "p01", Name =
                    "Product Name 1", CategoryName = " Category 1", price = new Price { Value = 100, Unit = "USD" }
                , description = new Description { Color = " red ", Size = "Size 1", Weight = "100 gr" }
                };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                StreamWriter sw = new StreamWriter("product.xml");
                xmlSerializer.Serialize(sw, product);
                sw.Close();
                Console.WriteLine("Serialize");
            }    
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}

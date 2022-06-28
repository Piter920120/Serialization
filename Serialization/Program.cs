using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Piotr";
            person1.Surname = "Rynkowski";
            person1.Age = 30;
            person1.Save("PersonData.xml");
            Person wczytaj = Person.Load("PersonData.xml");
        }
    }
}

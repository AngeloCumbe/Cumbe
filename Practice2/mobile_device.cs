using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class mobile_device
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string os { get; set; }
        public override string ToString()
        {
            return $"Brand: {brand} Model: {model} OS: {os}";
        }
    }
}

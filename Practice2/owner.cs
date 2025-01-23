using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class owner
    {
        public string name { get; set; }
        public string username { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return $"Name: {name}  USERNAME: {username} Age: {age}";
        }
    }
}
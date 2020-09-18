using System.Linq;
namespace FongPizzaPlace.Shared
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();
        public Basket Basket { get; set; } = new Basket();
        public UI UI { get; set; } = new UI();
    }
}
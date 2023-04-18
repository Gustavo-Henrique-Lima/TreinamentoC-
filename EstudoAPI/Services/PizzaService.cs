using EstudoAPI.Models;

namespace EstudoAPI.Services
{
    public class PizzaService
    {
        static List<Pizza> pizzas{get;}
        static int nextId=3;

        static PizzaService()
        {
            pizzas=new List<Pizza>
            {
                new Pizza
                {
                    id=1,
                    name="Classic Italian",
                    isGlutenFree=false
                },
                new Pizza
                {
                    id=2,
                    name="Veggie",
                    isGlutenFree=true
                }
            };
        }

        public static List<Pizza> getAll() => pizzas;
        public static Pizza? get(int id)
        {
            return pizzas.FirstOrDefault(p => p.id == id);
        }
        public static void add(Pizza pizza)
        {
            pizza.id = nextId++;
            pizzas.Add(pizza);
        }
        public static void remove (int id)
        {
            var pizza = get(id);
            if (pizza is null)
                return;
            pizzas.Remove(pizza);
        }
           public static void update(Pizza pizza)
        {
            var index = pizzas.FindIndex(p => p.id == pizza.id);
            if(index == -1)
            return;
            pizzas[index] = pizza;
        }
    }
}
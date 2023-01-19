using NetCore_01.Models;

namespace La_mia_pizzeria_Model.Utils {

    public static class PizzaData {
        
        private static List<Pizza> Pizze;

        public static List<Pizza> GetPizze() {

            if (Pizze != null) {
                return Pizze;
            }

            Pizze = new List<Pizza>();
            
            for (int i = 0; i < 10; i++) {
                Pizza postGenerato = new Pizza(i, "Pizza " + i, "Lorem Ipsum of Lorem Ipsum.", "https://picsum.photos/id/" + i + "/150");
                Pizze.Add(postGenerato);
            }
            
            return Pizze;
        }
    }
}


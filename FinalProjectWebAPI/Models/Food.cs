namespace FinalProjectWebAPI.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }

        public Food() { }

        public Food(int id, string foodName, int calories, double protein, double carbohydrates, double fats)
        {
            Id = id;
            FoodName = foodName;
            Calories = calories;
            Protein = protein;
            Carbohydrates = carbohydrates;
            Fats = fats;
        }
    }
}

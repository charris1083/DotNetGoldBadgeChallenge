namespace Challenge_1
{
    class MenuItem
    {

        public MenuItem()
        {

        }

        public MenuItem(int foodNumber, string foodName, string description, string ingredients, decimal price)
        {
            FoodNumber = foodNumber;
            FoodName = foodName;
            Description = description;
            Ingredients = ingredients;
            Price = price;

        }
        public int FoodNumber { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set; }
    }


}

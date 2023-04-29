using System;
using System.Linq;

class Program
{
    private static List<Food> _foods = new List<Food>();
    private static Boolean _foodInList = false;
    
    static void Main(string[] args)
    {
        string menuNumber;
        //File file = new File();
        Console.Clear();

        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Total Price"); 
            Console.WriteLine("2. Total Space"); 
            Console.WriteLine("3. Determine how much per person");
            Console.WriteLine("4. Add a food");
            Console.WriteLine("5. Change food info"); 
            Console.WriteLine("6. Quit");
            Console.Write("Please enter the number of the one you want to do: ");
            menuNumber = Console.ReadLine();
            Console.WriteLine("");

            switch(menuNumber)
            {
                default: 
                    Console.WriteLine("Please enter a integer between 1 and 6 (ex. 2)");  
                    Thread.Sleep(1000); 
                    break;
                case "1": 
                    if (_foodInList)
                    {
                        Price price = new Price(_foods);
                        // https://www.c-sharpcorner.com/UploadFile/9b86d4/how-to-round-a-decimal-value-to-2-decimal-places-in-C-Sharp/
                        string foodPrice = String.Format("{0:0.00}", price.GetTotal());
                        Console.WriteLine($"Your total amount would be ${foodPrice}"); 
                    } 
                    else
                    {
                        Console.WriteLine("No food input yet");
                    }                 
                    break; 
                case "2": // 
                    if(_foodInList)
                    {
                        Space space = new Space(_foods);
                        Console.WriteLine($"Your total space would be {space.GetTotalSpace()} inches cubed.");
                    }
                    else
                    {
                        Console.WriteLine("No food input yet");
                    }
                    break;
                case "3": // How  much to store for a person based off age
                   if(_foodInList)
                   {
                        int count = 1;
                        foreach(Food food in _foods)
                        {
                            Console.WriteLine($"{count}. {food.GetFoodType()}");
                            count += 1;
                        }
                        
                        Console.Write("Which item do you want to know how much food to store? (ex. 3) ");
                        int itemNum = (int.Parse(Console.ReadLine()) - 1);
                        Console.Write("What is the age of the person? (ex. 21) ");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine($"You will need {_foods[itemNum].GetHowMuchNeeded(age)} of {_foods[itemNum].GetFoodType()} for a years supply");
                    }
                    else
                    {
                        Console.WriteLine("No food input yet");
                    }
                    break;
                case "4": // 
                    _foodInList = true;
                    Console.WriteLine("1. Grain"); // 1 Grain
                    Console.WriteLine("2. Protein"); // 2 Protein
                    Console.WriteLine("3. Water");// 3 Water
                    Console.WriteLine("4. Fruit");// 3 Water
                    Console.WriteLine("5. Vegetable");// 3 Water
                    Console.WriteLine("6. Dairy");// 3 Water
                    Console.WriteLine("7. Other");

                    Console.Write("Please enter the category of the one you want to add: ");
                    string foodCategory = Console.ReadLine();

                    Console.Write("What is the Food (ex. rice)? ");
                    string foodType = Console.ReadLine();

                    Console.Write("What is the weight (lbs.) of the food (ex. 11.267)? ");
                    double foodWeight = double.Parse(Console.ReadLine());

                    Console.Write("How much are you looking at (ex. 2)?: ");
                    float amount = float.Parse(Console.ReadLine());

                    switch (foodCategory)
                    {
                        case "1": // grain
                            Grain grain = new Grain(foodType, amount, foodWeight, 10);
                            _foods.Add(grain);
                            break; 
                        case "2":// protein
                            Protein protein = new Protein(foodType, amount, foodWeight, 10);
                            _foods.Add(protein);
                            break;
                        case "3":  // water
                            Water water = new Water(foodType, amount, foodWeight, 10);
                            _foods.Add(water);
                            break;
                        case "4": // fruit
                            Fruit fruit = new Fruit(foodType, amount, foodWeight, 10);
                            _foods.Add(fruit);
                            break;
                        case "5": // vegetable
                            Veg veg = new Veg(foodType, amount, foodWeight, 10);
                            _foods.Add(veg);
                            break;
                        case "6": // dairy
                            Dairy dairy = new Dairy(foodType, amount, foodWeight, 10);
                            _foods.Add(dairy);
                            break;
                        case "7": //other
                            OtherFood other = new OtherFood(foodType, amount, foodWeight, 10);
                            _foods.Add(other);
                            break;
                    }

                    Console.Write("Would you like to add a price? ");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        Console.WriteLine("Please input the price: ");
                        _foods.Last().SetPrice(double.Parse(Console.ReadLine()));
                    }

                    break;
                case "5": // 
                    if(_foodInList)
                   {
                        int count = 1;
                        foreach(Food food in _foods)
                        {
                            Console.WriteLine($"{count}. {food.GetFoodInfo()}");
                            count += 1;
                        }
                        
                        Console.Write("Which item do you want to change info for (ex. 3)? ");
                        int itemNum = (int.Parse(Console.ReadLine()) - 1);

                        Console.WriteLine();
                        Console.WriteLine("1. Quantity");
                        Console.WriteLine("2. Weight");
                        Console.WriteLine("3. Name of food");
                        Console.Write("Which thing would you like to change? ");
                        switch (Console.ReadLine())
                        {
                            case "1": // quantity
                                Console.Write("What is the new amount? ");
                                _foods[itemNum].SetAmount(float.Parse(Console.ReadLine()));
                                break;
                            case "2": // weight
                            Console.Write("What is the new weight? ");
                                _foods[itemNum].SetWeight(double.Parse(Console.ReadLine()));
                                break;
                            case "3": //
                                Console.Write("What is the new name? ");
                                _foods[itemNum].SetFoodType(Console.ReadLine());
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No food input yet");
                    }

                    break;
                case "6": // Quit
                    Console.WriteLine("Thanks for thinking of your furture today!");
                    break;
            }
        } while (menuNumber != "6");
       // Console.WriteLine("Hello FinalProject World!");
    }
}
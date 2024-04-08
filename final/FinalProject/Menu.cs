public class Menu
{
    private int tier;
    public Menu(int tier)
    {
        this.tier = tier;
    }

    public string display(int tier)
    {
        string chosenString = "";
        if (tier == 0)
        {
             chosenString = "Choose the following: \n" +
            "   1. Body Composition(not available) \n" +
            "   2. Repetition Calculator(not available) \n" +
            "   3. Workout Planner(not available) \n" +
            "   4. Change Client\n" +
            "   5. Choose Trainer \n" +
            "   6. Display Clients\n" +
            "   7. Quit";
        }
        else if (tier == 1)
        {
             chosenString = "Choose the following: \n" +
            "   1. Body Composition \n" +
            "   2. Repetition Calculator(not available) \n" +
            "   3. Workout Planner(not available) \n" +
            "   4. Change Client\n" +
            "   5. Choose Trainer \n" +
            "   6. Display Clients\n" +
            "   7. Quit";
        }
        else if (tier == 2)
        {
             chosenString = "Choose the following: \n" +
            "   1. Body Composition \n" +
            "   2. Repetition Calculator \n" +
            "   3. Workout Planner(not available) \n" +
            "   4. Change Client\n" +
            "   5. Choose Trainer \n" +
            "   6. Display Clients\n" +
            "   7. Quit";
        }
        else if (tier == 3)
        {
            chosenString = "Choose the following: \n" +
            "   1. Body Composition \n" +
            "   2. Repetition Calculator \n" +
            "   3. Workout Planner \n" +
            "   4. Change Client\n" +
            "   5. Choose Trainer \n" +
            "   6. Display Clients\n" +
            "   7. Quit";
        }
        return chosenString;
    }
}
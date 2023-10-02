// initalize string array with 8 elements
string[] fraudulentOrderIDs = { "B123", "C234", "A345" , "C15", "B177", "G3003", "C235", "B179" };

//Create a foreach statement to iterate through each element of your array.
foreach (string orderID in fraudulentOrderIDs)
{
    //If the Order ID starts with the letter "B", print it to the console.
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}




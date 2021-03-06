using System;

namespace SkinwalkerRanchLibrary
{
  public static class UserMessages
  {
    public static void ApplicationStartMessage()
    {
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine("Welcome to Skinwalker Ranch Investigator Edition");
      Console.WriteLine("------------------------------------------------");
      Console.WriteLine();
      Console.WriteLine("How would you like to start your investigation?");
    }
    public static void OptionsMessage()
    {
      Console.WriteLine();
      Console.WriteLine("1 - View Map");
      Console.WriteLine("2 - Choose a Location on the Map to Investigate");
      Console.WriteLine("3 - In Progress...");
      Console.WriteLine("4 - Exit");
      Console.WriteLine();
      Console.Write("Please enter a number: ");
    }
    public static void InProgressMessage()
    {
      Console.WriteLine();
      Console.WriteLine("***Feature In Progress.***");
      Console.WriteLine();
      Console.WriteLine("Please select another Feature.");
    }
    public static void LocationsMessage()
    {
      Console.WriteLine("\t\t\tloc1 - Homestead 2");
      Console.WriteLine("\t\t\tloc2 - Sinkhole");
      Console.WriteLine("\t\t\tloc3 - Western Grazing Field");
      Console.WriteLine("\t\t\tloc4 - Eastern Grazing Field");
      Console.WriteLine("\t\t\tloc5 - Ridgeline (Mesa)");
      Console.WriteLine();
    }
  }
}

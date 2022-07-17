﻿namespace SkinwalkerRanchLibrary
{
  public static class RequestData
  {
    public static int GetAnIntResponse()
    {
      string userResponseText = Console.ReadLine();
      bool isValidNumber = int.TryParse(userResponseText, out int output);
      return output;
    }
    public static void CorrespondingData(int responseNum)
    {
      switch (responseNum)
      {
        case 1:
          DisplayMap();
          break;
        case 2:
          UserMessages.LocationsMessage();
          UserMessages.InProgressMessage();
          break;
        case 3:
          UserMessages.InProgressMessage();
          break;
        default:
          Console.WriteLine();
          Console.WriteLine("Thank you for investigating Skinwalker Ranch!");
          break;
      }  
    }
    public static void DisplayMap()
    {
      Console.Clear();
      Console.WriteLine("                                                                  |||||||||||||||||");
      Console.WriteLine("                                                                  |               |");
      Console.WriteLine("                                                                  |               |");
      Console.WriteLine("                                                                  |               |");
      Console.WriteLine("                                                                  |               |");
      Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
      Console.WriteLine("|         \\ loc2                                      /          |");
      Console.WriteLine("|    loc3  \\ loc1              loc5                  /           |");
      Console.WriteLine("|           \\////////////////////////////////////////   loc4     |");
      Console.WriteLine("|                                                                 |");
      Console.WriteLine("|                                                                 |");
      Console.WriteLine("|                                                                 |");
      Console.WriteLine("|||||||||||||||                                                   |");
      Console.WriteLine("              |                                                   |");
      Console.WriteLine("              |                                                   |");
      Console.WriteLine("              |                                                   |");
      Console.WriteLine("              |                                                   |");
      Console.WriteLine("              |                                                   |");
      Console.WriteLine("              ||||||||||||||||||||||||||||||||||||||              ||||||||||");
      Console.WriteLine("                                                   |                       |");
      Console.WriteLine("                                                   |                       |");
      Console.WriteLine("                                                   |                       |");
      Console.WriteLine("                                                   |                       |");
      Console.WriteLine("                                                   |              ||||||||||");
      Console.WriteLine("                                                   |              |");
      Console.WriteLine("                                                   |              |");
      Console.WriteLine("                                                   |              |");
      Console.WriteLine("                                                   |              |");
      Console.WriteLine("                                                   |              |");
      Console.WriteLine("                                                   ||||||||||||||||");
      Console.WriteLine();

    }
    public static void AskUserOptions()
    {
      int userIntResponse = 0;
      do
      {
        UserMessages.OptionsMessage();
        userIntResponse = RequestData.GetAnIntResponse();
        RequestData.CorrespondingData(userIntResponse); 
      } while (userIntResponse == 1 || userIntResponse == 2 || userIntResponse == 3);
    }
  }
}
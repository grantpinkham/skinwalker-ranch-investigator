using System;

namespace SkinwalkerRanchLibrary
{
  public static class RequestData
  {
    public static int GetAnIntResponse()
    {
      string userResponseText = Console.ReadLine();
      bool isValidNumber = int.TryParse(userResponseText, out int output);
      return output;
    }
    public static string GetAStringResponse(string message)
    {
      Console.Write(message);
      string userResponseText = Console.ReadLine();
      return userResponseText;
    }
    public static void CorrespondingData(int responseNum)
    {
      switch (responseNum)
      {
        case 1:
          DisplayMap();
          break;
        case 2:
          DisplayMap();
          UserMessages.LocationsMessage();
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
        if (userIntResponse == 2)
        {
          GetAStringResponse("Type 'loc1' to investigate Homestead 2: ");
          UserMessages.InProgressMessage();
        }
      } while (userIntResponse == 1 || userIntResponse == 2 || userIntResponse == 3);
    }
  }
}

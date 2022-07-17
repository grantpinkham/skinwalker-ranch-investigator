using SkinwalkerRanchLibrary;
using System;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      UserMessages.ApplicationStartMessage();
      RequestData.AskUserOptions();
    }
  }
}

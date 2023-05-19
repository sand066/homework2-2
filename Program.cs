using System;
class Program
{

  static void Main(string[] args)
  {
    string option1 = "Y";

    while (option1 == "Y")
    {
      string text = Console.ReadLine();
      if (IsValidSequence(text))
      {
        Console.WriteLine("Current half DNA sequence : {0}", text);
        do
        {
          Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
          string option2 = Console.ReadLine();
          if (option2 == "Y")
          {
            string text2 = ReplicateSeqeunce(text);
            Console.WriteLine("Replicated half DNA sequence : {0}", text2);
            break;
          }
          else if (option2 == "N")
          {
            break;
          }
          else
          {
            Console.WriteLine("Please input Y or N.");
          }
        } while (true);
      }
      else
      {
        Console.WriteLine("That half DNA sequence is invalid.");
      }

      do
      {
        Console.WriteLine("Do you want to process another sequence ? (Y/N) :");
        option1 = Console.ReadLine();
        if (option1 != "Y" && option1 != "N")
        {
          Console.WriteLine("Please input Y or N.");
        }
      } while (option1 != "Y" && option1 != "N");
    }
  }

  static bool IsValidSequence(string halfDNASequence)
  {
    foreach (char nucleotide in halfDNASequence)
    {
      if (!"ATCG".Contains(nucleotide))
      {
        return false;
      }
    }
    return true;
  }

  static string ReplicateSeqeunce(string halfDNASequence)
  {
    string result = "";
    foreach (char nucleotide in halfDNASequence)
    {
      result += "TAGC"["ATCG".IndexOf(nucleotide)];
    }
    return result;
  }
}
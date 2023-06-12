using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL
{
  class Program
  {
    public static void Main(string[] args)
    {
      if(args.length < 2) 
      {
        Console.WriteLine("Usage: <connectionstring> <query>");
        return;
      }
      
      SqlConnection con = new SqlConnection(args[0]);
      try {
        con.Open()
        Console.WriteLine("Auth success!");
      } catch {
        Console.WriteLine("Auth failed.");
        return;
      }
      
      SqlCommand cmd = new SqlCommand(args[1], con);
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read() == true) {
        Console.WriteLine("Results: " + reader[0]);
      }
      reader.Close();
      con.Close();
    }
  }
}

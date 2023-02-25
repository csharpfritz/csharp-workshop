using System;

namespace sample {

  public class ValueTypes {

    public static void Defaults() {

      int? i = null;

      Console.WriteLine($"Default {i?.GetType().Name}: {i?.ToString() ?? "NULL"}");

    }

    public static void Arrays() {

      var values = new string[3];
      string firstValue = values[0];
      Console.WriteLine("-->" + firstValue.ToLower() + "<--");

    }

  }

}
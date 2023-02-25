using System;

namespace sample
{

#nullable enable 

  public static class ReferenceTypes {

    public static void SimpleNull() {

      Hat myHat = new("Foo");

      Console.WriteLine($"MyHat is a: {myHat.GetType().Name} and {myHat}");

    }

    public static void Property() {

      var myHat = new Hat("DEVintersection") {
				AcquiredYear=2019,
				Theme="Tech"
			};

      Console.WriteLine($"MyHat's year is {myHat.Name}: {myHat.Name.ToString()}");


    }

    public static void NullForgiving() {

      var myHat = Find();

      Console.WriteLine($"myHat is named {myHat!.Name}");

    }

    private static Hat Find() {
      return new("Found hat");
    }

  }

#nullable restore

}
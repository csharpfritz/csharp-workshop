using System.ComponentModel.DataAnnotations;

namespace sample
{

#nullable disable

  public class Hat {

		public Hat(string name)
		{
				this.Name = name;
		}

    [Required]
    public string Name { get; set; }

    public int AcquiredYear { get; set; }

    public string Theme { get; set; } = string.Empty;

  }


   public class Foo
    {

        public static void Bar()
        {

            Hat hat = new("Bar Hat");
            // Hat? hat = new();
            //hat.Name = null;

        }

    }
 #nullable restore


    public class Customer
    {


        public string TaxClassification { get; set; } = "Exempt";

    }

}
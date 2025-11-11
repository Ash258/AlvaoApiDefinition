
using System.Text.RegularExpressions;

public class Settings
{
  /*
  * The action to check the format of the new Phone Number property value.
  */

  public static readonly string propName = "Phone number"; // Specify the property name you want to check.
  public static readonly Regex rx = new Regex(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", RegexOptions.Compiled | RegexOptions.IgnoreCase); // Phone number format in regex.
  public static readonly string errorMessage = "The value you entered is not a phone number. Enter the phone number in the correct format, etc. +(039) 123 456 789."; // Error message if the new value is not in correct format.

  // Do not change this value.
  public static bool isPhoneNumber = false;
}
          

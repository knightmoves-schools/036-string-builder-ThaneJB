namespace knightmoves;

using System.Text;
public class Person {
   private string firstName;
   private string lastName;

   public Person(string firstName, string lastName){
      this.firstName = firstName;
      this.lastName = lastName;
   }

   // Add your code here
   public string BuildFullName(){
      StringBuilder fullname = new StringBuilder($"{firstName}");
      fullname.Append($" {lastName}");

      return fullname.ToString();
   }
}
using System;
using System.Text;  
using System.Security.Cryptography;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("H-Hewwo???");
    Console.WriteLine("Who r u? OwO \nR u fren?");

    Console.Write("Gib passwrd pls \n>> ");
    string password = Console.ReadLine();                   //ask for + get the password

    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Fren gave: " + password);
    string Hashed_Input = (ComputeSha256Hash(password));
    string Hashed_Password = "e933876a0f95ca27d75982ecf3a440526194911677ba4495829917b83db2466d";
    //Console.WriteLine(Hashed_Password);                   //current password is 'furries_unite'

    //Console.WriteLine("Hash of {0} iz {1}", password, Hashed_Input);  //this gives hash of input
    Console.WriteLine("-------------------------------------------------");

    if (Hashed_Input == Hashed_Password){
      Console.WriteLine("U r fren!!!\nWelcom bak!!");       //'sensitive' info
                                                            //this mess looks ok when printed trust me
      Console.WriteLine(@"
      +-----------------------+
      |			      |thw Hackew ethics; fwom stevwen levys book,
      |   +--------------+    |			Hackews: heroes ow thw computew owo.
      |   |.------------.|    |
      |   ||            ||    |(0) Access to computews shouwd be unwimited and totaw. Awways
      |   ||            ||    |	gib in to thw Hands-On Impewative ^w^.
      |   ||            ||    |
      |   ||            ||    |(1) Aww infowmation shouwd be fwee.
      |   |+------------+|    |
      |   +-..--------..-+    |(2) Mistwust authowity, pwomote decentwawization.
      |   .--------------.    |
      |  / /============\ \   |(3) Hackews shouwd be judged by theiw skill, nyot theiw wace,
      | / /==============\ \  |	age, gendew, position ow degwess.
      |/____________________\ |
      |\____________________/ |(4) one can cweate awt and beauty on a computew.
      |			      |
      |			      |(5) Computews can change one's wife fow thw bettew.
      +-----------------------+");

    } else {
      Console.WriteLine("U r not fren!!!\nPasswrd wrong!!");//not 'sensitive' info
    }
    Console.ReadLine();                                     //read line so program doesnt close as soon as it ends
  }
  static string ComputeSha256Hash(string rawData){          //hash building thing
    // Create a SHA256   
    using (SHA256 sha256Hash = SHA256.Create()){  
    // ComputeHash - returns byte array  
    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
    // Convert byte array to a string   
    StringBuilder builder = new StringBuilder();  
    for (int i = 0; i < bytes.Length; i++){  
      builder.Append(bytes[i].ToString("x2"));  
    }  
    return builder.ToString();  
    }  
  }  
}
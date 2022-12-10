using System;
System.Console.Write("Hurmatli abanent ismingizni kiriting >>> ");
string? fullName=Console.ReadLine();
string password ="";
do
{
    System.Console.WriteLine("Saytga kirish kodingizni kiriting >>> ");
    password = Console.ReadLine();
}while (password!="AC1929891");
System.Console.Write($"Assalomu alaykum {fullName} yoshingizni kiriting >>> ");
int age =Convert.ToInt32(Console.ReadLine());
string ageChek=
      age >= 18 && age < 55
        ?  $"{fullName} siz saytga kirishingiz mumkin!"
        
        :  $"{fullName} siz saytga kira olmesiz ";
     System.Console.WriteLine(ageChek);   
if (age>=18 && age<=55)
{
    string check = fullName switch
{
    
    "Nusratulloh" =>$"Hurmatli {fullName} siz kompaniya ho'jayinisiz.\nHush kelibsiz kuninggiz xayrli o'tsin",
    "Shahboz" => $"Hurmatli {fullName} siz kompaniya admenisiz\nHush kelibsiz kuninggiz xayrli o'tsin",
    _ => $"Hurmatli {fullName} siz bu saytda foydalanuvchisiz"
};
System.Console.WriteLine(check);
}







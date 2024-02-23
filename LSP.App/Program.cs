using bad=LSP.App.Bad;
using LSP.App.Good;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bad.BasePhone phone = new bad.IPhone();

phone.Call();
phone.TakePhoto();

Console.WriteLine("---------------------");

phone=new bad.Nokia3310();
phone.Call();
phone.TakePhoto(); // Nokia3310 doesn't have this function,when we run it, it throw exception. 
// The advantage that LSP gives us is to avoid and prevent such mistakes.
// When we create an instance from Nokia 3310, we mustn't use Take Photo. For that, We will apply the LSP to our codes.


BasePhone phoneGood = new IPhone();

phoneGood.Call();
((ITakePhoto)phoneGood).TakePhoto(); // if you want to call TakePhoto function. You need to cast it ITakePhoto

Console.WriteLine("---------------------");

phoneGood = new Nokia3310();
phoneGood.Call();
//phoneGood.TakePhoto(); // Nokia3310 doesn't have this function, So I don't call this function. 

Console.ReadLine();
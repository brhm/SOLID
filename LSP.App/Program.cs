using LSP.App.Bad;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

BasePhone phone = new IPhone();

phone.Call();
phone.TakePhoto();

Console.WriteLine("---------------------");

phone=new Nokia3310();
phone.Call();
phone.TakePhoto(); // Nokia3310 doesn't have this method,when we run it, it throw exception. 
// The advantage that LSP gives us is to avoid and prevent such mistakes.
// When we create an instance from Nokia 3310, we mustn't use Take Photo. For that, We will apply the LSP to our codes.
Console.ReadLine();
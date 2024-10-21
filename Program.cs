/*
using DesignPattern.SOLID.LiskovSubstitution;

var rect = new Square();
rect.Width = 10;
rect.Height = 4;
Console.WriteLine("Expecting area 40");
Console.WriteLine(rect.Area);*/


/*
using DesignPattern.SOLID.InterfaceSegeration;

var circle = new Circle();
var sphere = new Sphere();

circle.Radius = 10;
Console.WriteLine(circle.Area());*/
//Console.WriteLine(circle.Volume());

/*using DesignPattern.DesignPatterns.Behavioral.Memento;

var editor = new Editor();
var history = new History(editor);
history.Backup();

editor.Title = "Test";
history.Backup();
editor.Content = " i HATE LINUX";   
history.Backup();
editor.Title = "alaa";
history.Backup();

Console.WriteLine(editor.Content);
Console.WriteLine(editor.Title);
history.Undo();
Console.WriteLine("----------------------------------------");
Console.WriteLine(editor.Content);
Console.WriteLine(editor.Title);
Console.WriteLine("-----------------HISTORY-------------------");


history.ShowHistory();*/
/*


using DesignPattern.DesignPatterns.Behavioral._ٍState;
using DesignPattern.DesignPatterns.Behavioral._ٍState.Good;

var doc = new Document(UserRoles.Admin);

Console.WriteLine(doc.State);

doc.Publish();
Console.WriteLine(doc.State);


doc.Publish();
Console.WriteLine(doc.State);

*/

/*using DesignPattern.DesignPatterns.Behavioral.Strategy.Good;

var vs = new GoodVideoStorage(new CopressorMov(), new OverlayBlur());
vs.Store("blablabla");

vs.SetCompresser(new CompressorMp4());
vs.Store("blablabla");
*/

using DesignPattern.DesignPatterns.Behavioral.Iterator.good;

ShoppingList list = new ShoppingList();
list.Push("alaa");
list.Push("alaa2");

list.Push("alaa1");

list.Push("alaaa");

var it = list.CreateIterator();

while(it.HasNext())
{
    Console.WriteLine(it.Current());
    it.Next();
}


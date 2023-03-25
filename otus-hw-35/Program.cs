using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");



var newdictionary = new OtusDictionary<DictionaryItem>();

newdictionary.Add(1, "test1");
newdictionary.Add(3, "test3");
newdictionary.Add(5, "test3");


var itemfirst = newdictionary[0]; 
Console.WriteLine("  " + itemfirst.Key + "   " + itemfirst.Value);

Console.WriteLine("----" + newdictionary.Get(3));


Console.ReadKey();
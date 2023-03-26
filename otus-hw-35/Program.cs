using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");



var newdictionary = new OtusDictionary<DictionaryItem>();

newdictionary.Add(1, "test1");
newdictionary.Add(3, "test3");

//newdictionary.Resize();

newdictionary.Add(5, "test5");
newdictionary.Add(4, "test4");
newdictionary.Add(33, "test33");


for (int i = 0; i < 8; i++)
{
    if (newdictionary[i] != null )
    Console.WriteLine(i + "   " + newdictionary[i].Key + "----" + newdictionary[i].Value);
}


//Console.WriteLine ( newdictionary.Get(3) );



//var itemfirst = newdictionary[0]; 
//Console.WriteLine("  " + itemfirst.Key + "   " + itemfirst.Value);

//Console.WriteLine("----" + newdictionary.Get(3));


Console.ReadKey();
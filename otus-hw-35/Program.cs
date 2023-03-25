Console.WriteLine("Hello, World!");

OtusDictionary test = new OtusDictionary();

test.Add(1, "test1");
test.Add(9, "test3");
test.Add(5, null);
test.Add(2, "test9");




Console.WriteLine("====" + test.Get(9));
Console.WriteLine("----" + test.Get(5));
Console.WriteLine("----" + test.Get(4));



Console.ReadKey();
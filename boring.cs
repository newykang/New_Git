Console.WriteLine("나는 할 것이 없다")

try
{
    int input = Console.ReadLine("아무 값이나 입력해주세요!")
}
catch (System.Exception)
{
    Console.WriteLine("string값을 왜 int으로 받아 이 바보야")
}

using System;
using System.Collections.Generic;

List<int> list = new List<int>();
list.add    (1);
list.add (2);  
list.add (3);
list.add (4);

foreach (int i in list)
{
    Console.WriteLine(i);
}
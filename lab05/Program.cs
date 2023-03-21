using System.Text;
//task1
//string str = Console.ReadLine();
//string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//string masha = "Маша";
//int Masha = str.IndexOf(masha);
//if (Masha != -1)
//{
//    string str1= "";
//    for(int i = 0; i < words.Length; i++)
//    {
//        if (string.Compare(words[i], masha)<0){
//            Console.WriteLine(words[i]);
//        }
//    }
//}

//task2
//string str = Console.ReadLine();
//string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//for(int i=0;i<words.Length;i++)
//{
//    if (words[i].Length == 4)
//    {
//        words[i] = words[i].Replace(words[i], "love_is");
//    }
//}
//string str1 = "";
//for (int i = 0; i < words.Length; i++) { str1 += " " + words[i]; }
//Console.WriteLine(str1);

//task3
//string str = Console.ReadLine();
//Console.WriteLine("Через сколько знаков печатать смайл? ");
//int n = Convert.ToInt32(Console.ReadLine());
//string str1 = "";
//for (int i = 0; i < str.Length; i++)
//{
//    if (i % n == 0) { str1 += "\u263A"; }
//    str1 += str[i];
//}
//Console.WriteLine(str1);

//task4
//string str=Console.ReadLine();
//string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//int max= words[0].Length;
//string maxi = words[0], mini = words[0];
//for(int i=0; i<words.Length; i++)
//{
//    if (max < words[i].Length) { max = words[i].Length; maxi = words[i]; }
//}
//int min = words[0].Length;
//for(int i=0;i<words.Length; i++)
//{
//    if (min > words[i].Length) { min = words[i].Length;  mini = words[i]; }
//}
//string str1 = maxi + " " + mini + ", ";
//Console.WriteLine("Введите количство повторений: ");
//int n = Convert.ToInt32(Console.ReadLine());
//string str2 = "";
//for(int i = 0; i < n; i++)
//{
//    str2 += str1;
//}
//str2 = str2.Substring(0, str2.Length - 2);
//Console.WriteLine(str2);

//task5
//string str = Console.ReadLine();
//string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//for(int i=0;i < words.Length-1; i++)
//{
//    for(int j = i+1; j < words.Length; j++)
//    {
//        if (words[i] == words[j]) { words[j] = ""; }
//    }
//}
//for (int i = 0; i < words.Length; i++) { Console.Write(words[i]+ " "); }

//task6
StringBuilder sb = new StringBuilder();
Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();
while (str != "")
{
    string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    words[words.Length - 1].Replace(Convert.ToChar("."), '\0');
    for (int i = 1; i < words.Length + 1; i++)
    {
        if (i % 2 == 0)
        {
            sb.Append(Reverse(words[i - 1])+" ");
            
        }
        else if (i % 3 == 1) { sb.Append(words[i - 1]+ " ");}
        Console.WriteLine("Введите строку: ");
        str = Console.ReadLine();
    }
    sb.Append(".");
}
Console.WriteLine(sb);



string Reverse(string text)
{
    char[] cArray = text.ToCharArray();
    string reverse = String.Empty;
    for (int i = cArray.Length - 1; i > -1; i--)
    {
        reverse += cArray[i];
    }
    return reverse;
}



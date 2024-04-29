/*string[] words = Console.ReadLine().Split(" ");
string answer = "";
char[] support;
char firstElement;
if (words is not null)
{
    Array.Reverse(words);
    for(int i = 0; i < words.Length; i++)
    {
        support = words[i].ToCharArray();
        for (int j = 0; j < support.Length/2; j++)
        {
            firstElement = support[j];
            support[j] = support[support.Length-1-j];
            support[support.Length - 1 - j] = firstElement;
        }
        answer += new string(support) + " ";
    }
}
Console.WriteLine(answer);*/
string letter = Console.ReadLine();
bool isCorrect = true;
for (int i = 1; i < letter.Length; i++)
{
  if (Char.IsUpper(letter, i))
  {
    isCorrect = false;
    break;
  }
}
if (number == 0)
{
  Console.WriteLine("True");
  return isCorrect;
}
else
{
  Console.WriteLine("False");
  return isCorrect;
}

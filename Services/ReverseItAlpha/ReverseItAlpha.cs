namespace FiveToSevenEndpoints.Services.ReverseItAlpha;

public class ReverseItAlpha : IReverseItAlpha
{
    public string ReverseIt(string userInput)
    {
        string reversedStr = "";

        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reversedStr += userInput[i];
        }

        return $"You entered: {userInput}\nYour reversed string is: {reversedStr}";
    }
}

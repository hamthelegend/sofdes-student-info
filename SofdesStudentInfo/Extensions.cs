namespace SofdesStudentInfo;

public static class Extensions{
    public static int ToInt(this string receiver) {
        return int.Parse(receiver);
    }

    public static bool IsNullOrWhitespace(this string? receiver) {
        return string.IsNullOrWhiteSpace(receiver);
    }

    public static string ForceReadLine(string label, int tabs) {
        string? input;
        
        while (true) {
            Console.Write($"{label}: {new string('\t', tabs)}");
            input = Console.ReadLine();
            if (input.IsNullOrWhitespace()) {
                Console.WriteLine($"{label} cannot be blank.");
            }
            else {
                break;
            }
        }

        return input!;
    } 
    
    public static int ForceReadNaturalNumberLine(string label, int tabs) {
        var naturalNumber = 0;
        
        while (true) {
            Console.Write($"{label}: {new string('\t', tabs)}");

            try {
                naturalNumber = Console.ReadLine()?.ToInt() ?? 0;
            }
            catch (FormatException) {
                naturalNumber = 0;
            }

            if (naturalNumber <= 0) {
                Console.WriteLine($"{label} must be an integer greater than zero.");
            }
            else {
                break;
            }
        }

        return naturalNumber;
    }

}
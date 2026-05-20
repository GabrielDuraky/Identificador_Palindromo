using System;

namespace Identidicador_Palindromo
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra ou frase (ou sair para encerrar):");
            while (true)
            {
                Console.Write("> ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) ||
                    input.Trim().Equals("sair", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Encerrando o programa.");
                    break;
                }
                try
                {
                    bool isPalindrome = PalindromeIdentifier.IsPalindrome(input);
                    if (isPalindrome)
                        Console.WriteLine("A frase ou palavra é um palíndromo.");
                    else
                        Console.WriteLine("A frase ou palavra não é um palíndromo.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }

                Console.WriteLine("Digite outra palavra ou frase (ou sair para encerrar):");
            }
        }
    }
    public static class PalindromeIdentifier
    {
        public static bool IsPalindrome(string? input, bool ignoreCase = true,
                                    bool ignoreNonAlphanumeric = true)
        {
            if (string.IsNullOrWhiteSpace(input))
                return true;

            ReadOnlySpan<char> span = input.AsSpan();

            int left = 0;
            int right = span.Length - 1;

            while (left < right)
            {
                char leftChar = span[left];
                char rightChar = span[right];
                if (ignoreNonAlphanumeric)
                {
                    if (!char.IsLetterOrDigit(leftChar))
                    {
                        left++;
                        continue;
                    }
                    if (!char.IsLetterOrDigit(rightChar))
                    {
                        right--;
                        continue;
                    }
                }
                if (ignoreCase)
                {
                    leftChar = char.ToLowerInvariant(leftChar);
                    rightChar = char.ToLowerInvariant(rightChar);
                }
                if (leftChar != rightChar)
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}


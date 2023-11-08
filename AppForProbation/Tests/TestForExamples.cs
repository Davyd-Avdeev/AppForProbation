using AppForProbation.Rules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProbation.Tests
{
    /// <summary>
    /// Класс для модульных тестов
    /// </summary>
    public class TestForExamples
    {
        /// <summary>
        /// Метод тестирования для первого задания
        /// </summary>
        public static void TestForFirstExample()
        {
            string[] numbersArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };

            var rules = new List<IReplaceRule>();

            rules.Add(new ReplaceRule(3, "fizz"));
            rules.Add(new ReplaceRule(5, "-buzz"));

            Test(rules, numbersArray);

        }

        /// <summary>
        /// Метод тестирования для второго задания
        /// </summary>
        public static void TestForSecondExample()
        {
            string[] numbersArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "60", "105", "420" };

            var rules = new List<IReplaceRule>();

            rules.Add(new ReplaceRule(3, "fizz"));
            rules.Add(new ReplaceRule(5, "-buzz"));
            rules.Add(new ReplaceRule(4, "-muzz"));
            rules.Add(new ReplaceRule(7, "-guzz"));

            Test(rules, numbersArray);

        }

        /// <summary>
        /// Метод тестирования для третьего задания
        /// </summary>
        public static void TestForThirdExample()
        {
            string[] numbersArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "60", "105", "420" };

            var rules = new List<IReplaceRule>();

            rules.Add(new ReplaceRelatedRule(3, 5, "dog", "-cat", "good-boy"));
            rules.Add(new ReplaceRule(4, "-muzz"));
            rules.Add(new ReplaceRule(7, "-guzz"));

            Test(rules, numbersArray);

        }

        /// <summary>
        /// Метод, который выполняет правила и выводит числа с заменами в консоль для последующей проверки
        /// </summary>
        /// <param name="rules">Коллекция правил</param>
        /// <param name="numbersArray">Массив входных данных</param>
        private static void Test(List<IReplaceRule> rules, string[] numbersArray)
        {  
            string result = string.Empty;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                foreach (var rule in rules)
                {
                    result += rule.Apply(Int32.Parse(numbersArray[i]));
                }
                if (result == string.Empty)
                {

                }
                else
                {
                    if (result[0] == '-')
                    {
                        result = result.Remove(0, 1);
                    }
                    numbersArray[i] = result;
                }
                result = string.Empty;
            }

            for (int i = 0; i < numbersArray.Length; i++)
            {
                result += numbersArray[i];
                if (i + 1 < numbersArray.Length)
                {
                    result += ", ";
                }
            }

            Console.WriteLine(result);
        }
    }
}

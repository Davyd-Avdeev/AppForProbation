using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProbation.Rules
{
    /// <summary>
    /// Класс наследующий интерфейс IReplaceRule, реализующий проверку кратности на одновременно два числа
    /// </summary>
    public class ReplaceRelatedRule : IReplaceRule
    {
        private readonly string FirstReplaceValue;
        private readonly string SecondReplaceValue;
        private readonly string RelatedReplaceValue;
        private readonly int FirstNumber;
        private readonly int SecondNumber;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstNumber">Первое число для проверки</param>
        /// <param name="secondNumber">второе число для проверки</param>
        /// <param name="firstReplaceValue">Заменяющее значение при кратности на первое число</param>
        /// <param name="secondReplaceValue">Заменяющее значение при кратности на второе число</param>
        /// <param name="relatedReplaceValue">Заменяющее значение при кратности на оба числа одновременно</param>
        public ReplaceRelatedRule(int firstNumber, int secondNumber, string firstReplaceValue, string secondReplaceValue, string relatedReplaceValue)
        {
            FirstReplaceValue = firstReplaceValue;
            SecondReplaceValue = secondReplaceValue;
            RelatedReplaceValue = relatedReplaceValue;
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        /// <summary>
        /// Применить правило
        /// </summary>
        /// <param name="number">Число для проверки</param>
        /// <returns></returns>
        public string Apply(int number)
        {            
            if (number % FirstNumber == 0 && number % SecondNumber == 0)
            {
                return RelatedReplaceValue;
            }
            if (number % FirstNumber == 0)
            {
                return FirstReplaceValue;
            }
            if (number % SecondNumber == 0)
            {
                return SecondReplaceValue;
            }

            return string.Empty;
        }
    }
}

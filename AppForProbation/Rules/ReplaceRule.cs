using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProbation.Rules
{
    /// <summary>
    /// Класс наследующий интерфейс IReplaceRule, реализующий проверку кратности на одно число
    /// </summary>
    public class ReplaceRule : IReplaceRule
    {
        private readonly string ReplaceValue;
        private readonly int Number;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="number">Число для проверки</param>
        /// <param name="replaceValue">Заменяющее значение при кратности на число</param>
        public ReplaceRule(int number, string replaceValue)
        {
            ReplaceValue = replaceValue;
            Number = number;
        }

        /// <summary>
        /// Применить правило
        /// </summary>
        /// <param name="number">Число для проверки</param>
        /// <returns></returns>
        public string Apply(int number)
        {
            if (number % Number == 0)
            {
                return ReplaceValue;
            }

            return string.Empty;
        }
    }
}

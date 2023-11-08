using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForProbation.Rules
{
    /// <summary>
    /// Интерфейс правила для элементов последовательности
    /// </summary>
    public interface IReplaceRule
    {
        
        /// <summary>
        /// Применить правило
        /// </summary>
        /// <param name="number">Элемент последовательности</param>
        /// <returns></returns>
        string Apply(int number);
    }
}

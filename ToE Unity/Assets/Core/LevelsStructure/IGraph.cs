using Assets.Core.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Core.Ages
{
    /// <summary>
    /// Интерфейс Графа
    /// </summary>
    interface IGraph
    {
        /// <summary>
        /// Список вершин графа
        /// </summary>
        List <ILevel> levels { get; }
        /// <summary>
        /// Количество открытых уровней графа
        /// </summary>
        int countOpenLevels { get; }
        
        /// <summary>
        /// Список ребёр графа
        /// </summary>
        List <Edge> edges { get; }


    }
}

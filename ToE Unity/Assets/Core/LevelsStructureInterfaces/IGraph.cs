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

        /// <summary>
        /// Добавление уровня
        /// </summary>
        /// <param name="_level"></param>
        void AddLevel(ILevel _level);
        /// <summary>
        /// Удаление уровня
        /// </summary>
        /// <param name="levelID"></param>
        void RemoveLevel(int levelID);


    }
}

using Assets.Core.Volutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Core.Ages
{
    /// <summary>
    /// Интерфейс Эры
    /// </summary>
    interface IAges
    {
        /// <summary>
        /// Имя Эры
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Номер Эры
        /// </summary>      
        int ID { get; }

        /// <summary>
        /// Цена перехода в Эру
        /// </summary>
        Money Price { get; }

        /// <summary>
        /// Доступность Эры
        /// </summary>
        bool Availability { get; }
        
        /// <summary>
        /// Граф Эры
        /// </summary>
        IGraph Graph { get; }

        /// <summary>
        /// Добавление графа
        /// </summary>
        /// <param name="_graph"></param>
        void AddGraph(IGraph _graph);
        /// <summary>
        /// Удаление графа
        /// </summary>
        void RemoveGraph();
    }
}

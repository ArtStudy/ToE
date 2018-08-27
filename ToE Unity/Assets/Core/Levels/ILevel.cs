using Assets.Core.Volutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Core.Levels
{
    interface ILevel
    {
        /// <summary>
        /// Номер уровня
        /// </summary>
        int IDLevel { get; }
        /// <summary>
        /// Имя уровня
        /// </summary>
        string NameLavel { get; }


        /// <summary>
        /// Цена
        /// </summary>
        Money Price { get;  }
        /// <summary>
        /// Вознагрождение
        /// </summary>
        Money Remuneration { get; }
        /// <summary>
        /// Динамический тест
        /// </summary>
        IDynamicTest Test { get; }
        /// <summary>
        /// Основное прохождение (Текст / Интерактив)
        /// </summary>
        IPassageLevel PassageLevel { get; }
        /// <summary>
        /// Борьба с боссом
        /// </summary>
        IBossFight BossFight { get; }

    }
}

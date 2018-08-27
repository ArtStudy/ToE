﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Core.Levels
{
    /// <summary>
    /// Интерфейс прохождения уровня
    /// </summary>
    interface IPassageLevel
    {
        PassageLevelTypeEnum PassageLevelType { get; }
    }

    /// <summary>
    /// Тип прохождения уровня
    /// </summary>
   enum PassageLevelTypeEnum
    {
        /// <summary>
        /// Статья
        /// </summary>
        Article = 2,
        /// <summary>
        /// Интератив
        /// </summary>
       Interactive = 4
    }
}

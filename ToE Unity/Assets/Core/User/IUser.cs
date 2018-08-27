using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Core.User
{
    // Интерфейс пользователя
    public interface IUser
    {
        /// <summary>
        /// Номер пользователя
        /// </summary>
        int ID { get; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        string name { get; }
    }
}

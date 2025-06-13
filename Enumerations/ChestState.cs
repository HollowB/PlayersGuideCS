using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    enum ChestCommand
    {
        Заблокировать,
        Разблокировать,
        Открыть,
        Закрыть
    }

    enum ChestState
    {
        Открыт,
        Разблокирован,
        Заблокирован
    }
}

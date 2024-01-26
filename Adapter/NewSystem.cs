using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter;

internal class NewSystem
{
    private INewSystem _newSystem;

    public NewSystem(INewSystem newSystem)
    {
        _newSystem= newSystem;
    }

    public void PerformNewRequest()
    {
        _newSystem.NewRequest();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    public interface ITreinReis
    {
        public void AddObserver(ITreinDisplay observerToAdd);
        public void RemoveObserver(ITreinDisplay observerToRemove);
        public void VolgendStation();
        public void TurnAround();
    }
}

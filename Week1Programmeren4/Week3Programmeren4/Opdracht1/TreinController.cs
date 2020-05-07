using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    class TreinController : ITreinController
    {
        public ITreinReis Reis { get; set; }

        public TreinController(ITreinReis reis)
        {
            Reis = reis;
        }

        public void VolgendStation()
        {
            Reis.VolgendStation();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicGate.OCR;


namespace LogicGate.ICR
{
    public interface UserOperator
    {
        int Access { get; set; }
        Person Person { get; set; }
        KeyRing KeyRing { get; }
    }
}

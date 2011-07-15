using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicGate.ICR
{
    public interface KeyHole
    {
        /// <summary>
        /// Por lo general es el nombre del Form, por lo que para implementarlo
        /// simplemente se pone:  return this.Text;
        /// </summary>
        /// <returns></returns>
        int ModuleId { get; set; }
        void modeDeny();        // [ -1]
        void modeNone();        // [  0]
        void modeRead();        // [  1]
        void modeCreate();      // [  3]
        void modeUpdate();      // [  7]
        void modeDelete();      // [ 15]
        void modePrint();       // [ 31]
        void modeBlock();       // [ 63]
        void modeNull();        // [127]
        void modeReverse();     // [255]
        void modeSpecial1();    // [511]
        void modeSpecial2();    //[1023]
        void modeSpecial3();    //[2045]
        void modeSpecial4();    //[4095]
        void modeSpecial5();    //[8191]
    }
}

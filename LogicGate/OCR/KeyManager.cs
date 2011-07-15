using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicGate.ICR;

namespace LogicGate.OCR
{
    public class KeyManager
    {
        private KeyRing _KeyRing;
        public KeyManager(KeyRing kr)
        {
            _KeyRing = kr;
            
        }
        public void open(KeyHole keyHole)
        {
            useKey(keyHole);
        }
        private void useKey(KeyHole keyHole)
        {
            int keyValue = _KeyRing.getKeyValue(keyHole.ModuleId);
            applyKeyValue(keyValue, keyHole);
        }
        private void applyKeyValue(int keyValue, KeyHole keyHole)
        {
            // void modeDeny();        // [ -1]
            // void modeNone();        // [  0]
            // void modeRead();        // [  1]
            // void modeCreate();      // [  3]
            // void modeUpdate();      // [  7]
            // void modeDelete();      // [ 15]
            // void modePrint();       // [ 31]
            // void modeBlock();       // [ 63]
            // void modeNull();        // [127]
            // void modeReverse();     // [255]
            // void modeSpecial1();    // [511]
            // void modeSpecial2();    //[1023]
            // void modeSpecial3();    //[2045]
            // void modeSpecial4();    //[4095]
            // void modeSpecial5();    //[8191]

            switch (keyValue)
            {
                case -1:
                    keyHole.modeDeny();
                    break;
                case 0:
                    keyHole.modeNone();
                    break;
                case 1:
                    keyHole.modeRead();
                    break;
                case 3:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    break;
                case 7:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    break;
                case 15:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    break;
                case 31:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    keyHole.modePrint();
                    break;
                case 63:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    keyHole.modePrint();
                    keyHole.modeBlock();
                    break;
                case 127:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    keyHole.modePrint();
                    keyHole.modeBlock();
                    keyHole.modeNull();
                    break;
                case 255:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    keyHole.modePrint();
                    keyHole.modeBlock();
                    keyHole.modeNull();
                    keyHole.modeReverse();
                    break;
                case 511:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    keyHole.modePrint();
                    keyHole.modeBlock();
                    keyHole.modeNull();
                    keyHole.modeReverse();
                    keyHole.modeSpecial1();
                    break;
                case 1023:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    keyHole.modePrint();
                    keyHole.modeBlock();
                    keyHole.modeNull();
                    keyHole.modeReverse();
                    keyHole.modeSpecial1();
                    keyHole.modeSpecial2();
                    break;
                case 2045:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    keyHole.modePrint();
                    keyHole.modeBlock();
                    keyHole.modeNull();
                    keyHole.modeReverse();
                    keyHole.modeSpecial1();
                    keyHole.modeSpecial2();
                    keyHole.modeSpecial3();
                    break;
                case 4095:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    keyHole.modePrint();
                    keyHole.modeBlock();
                    keyHole.modeNull();
                    keyHole.modeReverse();
                    keyHole.modeSpecial1();
                    keyHole.modeSpecial2();
                    keyHole.modeSpecial3();
                    keyHole.modeSpecial4();
                    break;
                case 8191:
                    keyHole.modeRead();
                    keyHole.modeCreate();
                    keyHole.modeUpdate();
                    keyHole.modeDelete();
                    keyHole.modePrint();
                    keyHole.modeBlock();
                    keyHole.modeNull();
                    keyHole.modeReverse();
                    keyHole.modeSpecial1();
                    keyHole.modeSpecial2();
                    keyHole.modeSpecial3();
                    keyHole.modeSpecial4();
                    keyHole.modeSpecial5();
                    break;

                default:
                    keyHole.modeDeny();
                    break;
            }
        }
    }
}

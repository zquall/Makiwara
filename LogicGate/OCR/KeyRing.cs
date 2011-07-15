using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using LogicGate.ICR;
using WillyWonka;

namespace LogicGate.OCR
{
    /// <summary>
    /// Llavero que contiene todas los accesos para
    /// el Usuario
    /// </summary>
    public class KeyRing
    {
        private Hashtable Keys;
        
        public KeyRing()
        {
            Keys = new Hashtable();
        }

        private KeyAccess searchKey(int moduleID)
        {
            KeyAccess tmpKey = new KeyAccess();
            // Esto garantiza que si no tiene permisos no le aparesca nada
            tmpKey.keyValue = -1;
            if (Keys.ContainsKey(moduleID))
            {
                return (KeyAccess)Keys[moduleID];
            }
            return tmpKey;
        }
        /// <summary>
        /// Devuelve el valor de la llave solocitada
        /// de acuerdo con la siguiente notacion:
        ///     8   4   2   1
        ///     =============    -1 =>Acceso Denegado (Valor Default en todo Form) 
        ///     D   U   C   R   
        ///     0   0   0   0   = 0 = Acceso Bloqueado (Puede ver pero esta todo Disable)
        ///     0   0   0   1   = 1 = Solo Lectura
        ///     0   0   1   1   = 3 = Lectura y Creacion
        ///     0   1   1   1   = 7 = Lectura, Creacion y Modificacion
        ///     1   1   1   1   =15 = Lectura, Creacion, Modificacion y Eliminacion   
        /// </summary>
        /// <param name="Nombre del Modulo"> Es el Nombre exacto del Form al que refiere el Acceso</param>
        /// <returns> El valor de la Llave para ese Form especifico</returns>
        public int getKeyValue(int moduleID)
        {
            KeyAccess tmpKey = searchKey(moduleID);
            return tmpKey.keyValue;
        }

        public void addKeyAccessList(List<KeyAccess> ListKeyAccess)
        {
            foreach (KeyAccess tmpKeyAccess in ListKeyAccess)
            {
                Keys[tmpKeyAccess.IdModule] = tmpKeyAccess;
            }            
        }      
    }    
}

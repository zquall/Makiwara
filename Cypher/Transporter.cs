using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cypher
{    
    public static class Transporter
    {
        #region Métodos Privados

        /// <summary>
        /// Se encarga de encriptar un flujo de datos mediante la clase EncDec
        /// </summary>
        /// <remarks>
        /// De momento se utiliza el algoritmo DESCryptoServiceProvider, se espera mas adelante modificar
        /// la clase para que pueda usar cualquiera de los tres metodos conocidos o uno propio, tal como 
        /// permite la clase EncDec
        /// </remarks>
        /// <param name="theMemory">Flujo de datos que se desea encriptar</param>
        /// <returns>Una cadena de texto encriptada mediante el algoritmo DESCryptoServiceProvider</returns>
        private static string encryption(MemoryStream theMemory)
        {
            string base64String = "";

            // Se crea un Encriptador
            Cryptos Koder = new Cryptos(Cryptos.algorithmType.DES);

            // Se extraen los Binario del Memorystream
            byte[] binaryData = theMemory.GetBuffer();

            // Se convierte de Binario a String
            base64String = Convert.ToBase64String(binaryData, 0, binaryData.Length);

            // Se encrypta el objeto serializado
            base64String = Koder.Encrypt(base64String);

            return base64String;
        }

        /// <summary>
        /// Método pendiente de implementacion
        /// </summary>
        /// <param name="Daffy_Dust"></param>
        private static void desencryption(string Daffy_Dust)
        {

        }

        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Metodo que se encarga de serializar un archivo de datos encriptandolo o no dependiendo de la
        /// decicion del implementador.
        /// </summary>
        /// <param name="Daffy_Duck">Objeto que va a ser serializado (desintegrado)</param>
        /// <param name="path">Ruta del archivo en el cual se escribiran los datos</param>
        /// <param name="secured">Indica si se encripta o no la serializacion del objeto</param>
        public static void desintegrate(Object Daffy_Duck, string path, bool secured)
        {

            FileStream theFile = new FileStream(path, FileMode.Create);
            MemoryStream theMemory = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            // Serializa el objeto y lo escribe en el stream de memoria
            bf.Serialize(theMemory, Daffy_Duck);

            // Graba los datos escritos en memoria
            theMemory.Flush();

            // Si es verdadero encrypta la serializacion
            if (secured)
            {
                // Se encrypta y pasa a texto el MemoryStream
                string Daffy_Dust = encryption(theMemory);

                // Se escriben los datos en el archivo
                StreamWriter theWriter = new StreamWriter(theFile);
                theWriter.Write(Daffy_Dust);
                theWriter.Close();
            }
            else
            {
                // Se escriben los Binarios en el archivo
                theMemory.WriteTo(theFile);
            }
            // Cerrando todo
            theMemory.Close();
            theFile.Close();
        }

        /// <summary>
        /// Metodo que se encarga de deserializar un archivo de datos desencriptandolo o no dependiendo de la
        /// decición del implementador.
        /// </summary>
        /// <param name="path">Ruta del archivo del cual se leen los datos</param>
        /// <param name="secured">Indica si se desencripta o no la deserializacion del objeto</param>
        /// <returns>El objeto deserializado (integrado)</returns>
        public static Object integrate(string path, bool secured)
        {
            FileStream theFile = null;
            Object Daffy_Duck = null;
            BinaryFormatter bf = null;
            try
            {
                theFile = new FileStream(path, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
            }
            catch (Exception)
            {
                throw;
            }

            if (secured)
            {
                StreamReader theReader = new StreamReader(theFile);
                string Daffy_Dust = theReader.ReadToEnd();
                Cryptos Koder = new Cryptos(Cryptos.algorithmType.DES);
                Daffy_Dust = Koder.Decrypting(Daffy_Dust);
                byte[] binaryData = System.Convert.FromBase64String(Daffy_Dust);
                MemoryStream theMemory = new MemoryStream(binaryData);
                Daffy_Duck = bf.Deserialize(theMemory);
            }
            else
            {
                Daffy_Duck = bf.Deserialize(theFile);
            }
            theFile.Close();
            return Daffy_Duck;
        }

        #endregion
        
    }
}

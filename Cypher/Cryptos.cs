using System.Security.Cryptography;
using System.IO;
using System.Text;
using System;

namespace Cypher
{
    ///Class Documentation
    ///
    ///Solution: Cypher
    ///Project : Cypher
    ///Class   : Cryptos.EncDec
    ///
    /// <summary>
    /// Se encarga del cifrado y desifrado de textos
    /// </summary>
    /// <remarks>
    /// <para>
    ///     Recuerde que esta clase le permite seleccionar uno de tres metodos de encriptacion o definir el
    ///     suyo propio, siempre y cuando este sea una clase derivada de SymmetricAlgorithm.
    /// </para>
    /// <para>
    ///     Los tres algoritmos de encriptacion disponibles son:
    ///     <list type="table">
    ///         <listheader>
    ///             <term>ALGORITMO</term>
    ///             <description>LONGITUD DE CLAVE PERMITIDA</description>
    ///         </listheader>
    ///         <item>
    ///             <term>RijndaelManaged</term>
    ///             <description>Este algoritmo admite longitudes de clave de 128, 192 o 256 bits</description>
    ///         </item>
    ///         <item>
    ///             <term>DESCryptoServiceProvider</term>
    ///             <description>Este algoritmo admite una longitud de clave de 64 bits</description>
    ///         </item>
    ///         <item>
    ///             <term>RC2CryptoServiceProvider</term>
    ///             <description>Este algoritmo admite longitudes de clave entre 40 y 128 bits en incrementos de 8 bits </description>
    ///         </item>
    ///     </list>
    /// </para>
    /// <para>
    ///     <b>Caracteristicas de la clase:</b>
    ///     <list type="bullet">
    ///         <item>Lenguaje...: C#</item>
    ///         <item>Tipo.......: (CLASE)</item>
    ///         <item>Herencia...: (Ninguna)</item>
    ///         <item>Autor......: Jaime Torner Meza</item>
    ///     </list>
    /// </para>
    /// <para>
    ///     <b>Historia de Revisiones</b>
    ///     <list type="bullet">
    ///         <item>xx/xx/xxxx - Creación</item>
    ///         <item>20/05/2010 - Modificacion de la documentacion</item>
    ///     </list>
    /// </para>
    /// </remarks>
    public class Cryptos
    {
        #region Declaracion de Variables

        ///<sumary>
        /// Lista de los tipos de algoritmos simetricos soportados
        ///</sumary>
        ///<remarks>
        /// <para>
        ///     Los tres algoritmos de encriptacion disponibles son:
        ///     <list type="table">
        ///         <listheader>
        ///             <term>VALOR</term>
        ///             <description>NOMBRE ALGORITMO</description>
        ///         </listheader>
        ///         <item>
        ///             <term>DES</term>
        ///             <description>DESCryptoServiceProvider</description>
        ///         </item>
        ///         <item>
        ///             <term>RC2</term>
        ///             <description>RC2CryptoServiceProvider</description>
        ///         </item>
        ///         <item>
        ///             <term>Rijndael</term>
        ///             <description>RijndaelManaged</description>
        ///         </item>
        ///     </list>
        /// </para>
        /// <para>
        ///     Estos se deben utilizar conjuntamente con la instanciacion de la clase EncDec, por ejemplo:
        ///     <example>
        ///         <code>
        ///             EncDec Coder = new EncDec(EncDec.algorithmType.DES);
        ///             EncDec Coder = new EncDec(EncDec.algorithmType.RC2);
        ///             EncDec Coder = new EncDec(EncDec.algorithmType.Rijndael);
        ///         </code>
        ///     </example>
        /// </para>
        ///</remarks>
        public enum algorithmType : int 
        {
            /// <summary> DES : DESCryptoServiceProvider </summary>
            DES,
            /// <summary> RC2 : RC2CryptoServiceProvider </summary>
            RC2,
            /// <summary> Rijndael : RijndaelManaged</summary>
            Rijndael 
        }

        ///<sumary>
        ///Arreglo de bytes que contiene la llave de Encryptacion
        ///</sumary>
        /// <remarks>
        ///     <para>
        ///         Es una variable de tipo
        ///         <see cref="byte">(System.Byte)</see>
        ///         que guarda la llave de encriptacion que utilizara el algoritmo seleccionado
        ///     </para>
        /// </remarks>
        private byte[] byteKey = new byte[8];

        ///<sumary>
        ///Variable donde se almacena el algoritmo de cifrado seleccionado
        ///</sumary>
        /// <remarks>
        ///     <para>
        ///         Es una variable de tipo
        ///         <see cref="algorithmType">EnDec.algorithmType</see>
        ///         que almacena el algoritmo de cifrado (encriptacion) que se desea utilizar
        ///     </para>
        /// </remarks>
        /// <remarks>
        /// 
        /// </remarks>
        private SymmetricAlgorithm cipherService;

        #endregion

        #region Declaracion de Propiedades

        /// <summary>
        /// Llave que utiliza el algoritmo de cifrado para cumplir su función
        /// </summary>
        /// <value>
        ///     <para>
        ///         Permite setear el valor del campo miembro que contiene la llave que utiliza
        ///         el algoritmo de cifrado que se escogio
        ///     </para>
        /// </value>
        public string Key
        {
            set { this.byteKey = getLegalKey(value); }
        }

        #endregion

        #region Constructores
  
        /// <summary>
        /// Constructor que carga uno de los tres algoritmos de cifrado (DESCryptoServiceProvider,
        /// RC2CryptoServiceProvider, RijndaelManaged)
        /// </summary>
        /// <param name="cipher">Metodo de cifrado (encriptacion) que se desea utilizar</param>
        /// <remarks>
        ///     <para>
        ///         <example>
        ///             En este ejemplo se ve como instanciar la clase Endec con cada uno de los algoritmos
        ///             permitidos
        ///             <code>
        ///                 EncDec Coder = new EncDec(EncDec.algorithmType.DES);
        ///                 EncDec Coder = new EncDec(EncDec.algorithmType.RC2);
        ///                 EncDec Coder = new EncDec(EncDec.algorithmType.Rijndael);
        ///             </code>
        ///         </example>
        ///     </para>
        /// </remarks>
        public Cryptos(algorithmType cipher)
        {
            switch (cipher)
            {
                case algorithmType.DES:
                    cipherService = new DESCryptoServiceProvider();
                    break;
                case algorithmType.RC2:
                    cipherService = new RC2CryptoServiceProvider();
                    break;
                case algorithmType.Rijndael:
                    cipherService = new RijndaelManaged();
                    break;
            }
            this.Key = "X0wq3p01";
        }

        /// <summary>
        /// Constructor para utilizar un Algoritmo de cifrado persinalizado
        /// </summary>
        /// 
        /// <param name="customCipherService">Metodo personalizado de cifrado que se desea utilizar</param>
        /// 
        /// <remarks>
        ///     <para>
        ///     Para que el algoritmo de cifrado personalizado sea valido debe ser una clase derivada
        ///     de SymmetricAlgorithm
        ///     </para>
        /// 
        ///     <para>
        ///         <example>
        ///             En este ejemplo se ve como instanciar la clase Endec con un metodo de cifrado 
        ///             personalizado
        ///             <code>
        ///                 EncDec Coder = new EncDec(miMetodoDeCifrado);
        ///             </code>
        ///         </example>
        ///     </para>
        /// </remarks>
        public Cryptos(SymmetricAlgorithm customCipherService)
        {
            cipherService = customCipherService;
        }

        #endregion

        #region Metodos Privados

        /// <summary>
        /// Dependiendo de las limitaciones del tamaño de la llave especificas para cada tipo de 
        /// Algoritmo, el largo de la llave se llena con espacios en blanco para completar el tamaño
        /// legal de la llave necesario de cada Algoritmo.
        /// </summary>
        /// <param name="tempKey">La llave tentativa a ser empleada por el algoritmo</param>
        /// <returns>La llave definitiva que sera utilizada por el algoritmo</returns>
        private byte[] getLegalKey(string tempKey)
        {
            string sTemp;
            if (cipherService.LegalKeySizes.Length > 0)
            {
                // Los tamaños de Llaves estan en bits
                int maxSize = cipherService.LegalKeySizes[0].MaxSize;
                int minSize = cipherService.LegalKeySizes[0].MinSize;

                // Si la llave dada es menor que el minimo permitido
                // la rellena con espacios en blanco.
                sTemp = tempKey;
                while (sTemp.Length * 8 < minSize)
                {
                    sTemp = sTemp + " ";
                }

                // Si es mayor que el maximo permitido
                // la recorta al tamaño maximo
                if (tempKey.Length * 8 > maxSize)
                    sTemp = tempKey.Substring(0, maxSize / 8);
            }
            else
                sTemp = tempKey;
            // Convierte el tempKey en un arreglo de Bytes
            return ASCIIEncoding.ASCII.GetBytes(sTemp);
        }

        #endregion

        #region Metodos Publicos
       
        /// <summary>
        /// Permite la encryptacion de un texto dado por parametros, este primero descompone el String
        /// a codificacion ASCII y la almacena en un arreglo de bytes 
        /// </summary>
        /// <param name="Source">El texto que se desea encriptar</param>
        /// <returns>El texto encriptado</returns>
        /// <remarks>
        /// <para>
        ///     <b>Historia de Revisiones</b>
        ///     <list type="bullet">
        ///         <item>xx/xx/xxxx - Creación</item>
        ///         <item>21/05/2010 - Modificacion de la documentacion</item>
        ///     </list>
        /// </para>
        /// </remarks>
        public string Encrypt(string Source)
        {
            // Codifica el texto a un arreglo binario
            byte[] bytIn = System.Text.ASCIIEncoding.ASCII.GetBytes(Source);

            // Crea un stream de memoria para relizar el proceso
            //de encryptacion sin necesidad de utilizar un Archivo I/O
            MemoryStream ms = new MemoryStream();

            // Se crea un encryptador por medio del servicio de encryptacion
            // Se introduce la llave en el servicio de encryptacion
            // especificado en la construccion
            //--ICryptoTransform encryptor = cipherService.CreateEncryptor();
            ICryptoTransform encryptor = cipherService.CreateEncryptor(this.byteKey, this.byteKey);

            // Crea un Crypto Stream que tarnsforma el memory stream
            // utilizando el encryptador
            CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);

            // Se le inscribe el Crypto Stream a un Writer para poder meterle
            // lo que se desea encrytar
            StreamWriter writer = new StreamWriter(cs);

            // Introduce el texto al Crypto Stream por medio del
            // StreamWriter
            writer.Write(Source);
            writer.Flush();
            cs.FlushFinalBlock();
            writer.Flush();

            // Convierte en Base64 asi el resultado puede ser utilizado en un XML
            string result = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
            return result;
        }

        /// <summary>
        /// Este método se encarga de desencriptar un texto haciendo uso del método Decrypt que
        /// devuelve un flujo de datos y este método los convierte en un string
        /// </summary>
        /// <param name="Source">El texto que se va a desencriptar</param>
        /// <returns>El texto que desencriptado</returns>
        /// <remarks>
        /// <para>
        ///     <b>Historia de Revisiones</b>
        ///     <list type="bullet">
        ///         <item>xx/xx/xxxx - Creación</item>
        ///         <item>21/05/2010 - Modificacion de la documentacion</item>
        ///     </list>
        /// </para>
        /// </remarks>
        public string Decrypting(string Source)
        {
            String result = "";
            try
            {
                StreamReader sr = Decrypt(Source);
                result = sr.ReadToEnd();
            }
            catch (Exception e)
            {
                result = "ERROR - " + e.Message + "\r\n\r\n" +
                         "El origen a desencryptar es incorrecto.\r\n" +
                         "Revise que se haya encryptado con la misma llave\r\n" +
                         "con la que se esta tratando de desencryptar.";
            }
            return result;
        }

        /// <summary>
        /// Este método se encarga de desencriptar un texto mediante los métodos que ya trae con
        /// sigo la libreria System.Security.Cryptography
        /// </summary>
        /// <param name="Source">El texto que se desea desencriptar</param>
        /// <returns>Flujo de datos desencriptado</returns>
        /// <remarks>
        /// <para>
        ///     <b>Historia de Revisiones</b>
        ///     <list type="bullet">
        ///         <item>xx/xx/xxxx - Creación</item>
        ///         <item>21/05/2010 - Modificacion de la documentacion</item>
        ///     </list>
        /// </para>
        /// </remarks>
        public StreamReader Decrypt(string Source)
        {
            // Convierte de Base64 a binario
            byte[] bytIn = System.Convert.FromBase64String(Source);

            // Crea un MemoryStream con el binario de entrada
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);

            // Establece la llave en el servicio de encyptacion para luego crear
            // crear un desencryptador de cifrados hechos con esa llave
            cipherService.Key = this.byteKey;
            cipherService.IV = this.byteKey;

            // Se crea por medio del metodo Fabrica un desencryptador
            // el cual lo fabrica el servicio de encryptacion seleccionado
            ICryptoTransform decryptor = cipherService.CreateDecryptor();

            // Crea un Crypto Stream que tarnsforma el memory stream
            // utilizando el desencryptador
            CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);

            // Se crea un StreamReader el cual extraeel resultado del Crypto Stream
            // y lo retorne como texto.
            StreamReader sr = new StreamReader(cs);
            return sr;
        } 

        #endregion
    }    
}

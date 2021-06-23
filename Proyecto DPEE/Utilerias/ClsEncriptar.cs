using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Proyecto_DPEE.Utilerias
{
    public class ClsEncriptar
    {

        public static string Encriptar(string strTextoAEncriptar)
        {
            byte[] key = UTF8Encoding.UTF8.GetBytes("r4d1c4l");
            byte[] iv = UTF8Encoding.UTF8.GetBytes("1B2c3D4e5F6g7H82");
            int keySize = 32;
            int ivSize = 16;
            Array.Resize(ref key, keySize);
            Array.Resize(ref iv, ivSize);

            // SE CREA LA INSTANCIA DEL OBJETO RIJNDAEL
            Rijndael objRijndael = Rijndael.Create();

            // SE ESTABLECE UN FLUJO DE MEMORIA
            MemoryStream memoryStream = new MemoryStream();

            // SE CREA UN FLUJO DE CIFRADO PARA LOS DATOS
            CryptoStream cryptoStream = new CryptoStream(memoryStream, objRijndael.CreateEncryptor(key, iv), CryptoStreamMode.Write);

            // SE OBTIENE LA REPRESENTACION EN BYTES DE LA INFORMACION A CIFRAR
            byte[] plainMessageBytes = UTF8Encoding.UTF8.GetBytes(strTextoAEncriptar);

            // Cifrar los datos enviándolos al flujo de cifrado  
            cryptoStream.Write(plainMessageBytes, 0, plainMessageBytes.Length);
            cryptoStream.FlushFinalBlock();

            // Obtener los datos datos cifrados como un arreglo de bytes  
            byte[] cipherMessageBytes = memoryStream.ToArray();

            // Cerrar los flujos utilizados  
            memoryStream.Close();
            cryptoStream.Close();

            // Retornar la representación de texto de los datos cifrados  
            return Convert.ToBase64String(cipherMessageBytes);
        }


        public static string Desencriptar(String strTextoEncriptado)
        {
            byte[] plainTextBytes = null;
            int decryptedByteCount = 0;
            try
            {
                byte[] key = UTF8Encoding.UTF8.GetBytes("r4d1c4l");
                byte[] iv = UTF8Encoding.UTF8.GetBytes("1B2c3D4e5F6g7H82");
                int keySize = 32;
                int ivSize = 16;
                Array.Resize(ref key, keySize);
                Array.Resize(ref iv, ivSize);
                // Obtener la representación en bytes del texto cifrado  
                byte[] cipherTextBytes = Convert.FromBase64String(strTextoEncriptado);

                // Crear un arreglo de bytes para almacenar los datos descifrados  
                plainTextBytes = new byte[cipherTextBytes.Length];

                // Crear una instancia del algoritmo de Rijndael  
                Rijndael RijndaelAlg = Rijndael.Create();

                // Crear un flujo en memoria con la representación de bytes de la información cifrada  
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

                // Crear un flujo de descifrado basado en el flujo de los datos  
                CryptoStream cryptoStream = new CryptoStream(memoryStream, RijndaelAlg.CreateDecryptor(key, iv), CryptoStreamMode.Read);

                // Obtener los datos descifrados obteniéndolos del flujo de descifrado  
                decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

                // Cerrar los flujos utilizados  
                memoryStream.Close();
                cryptoStream.Close();

                // Retornar la representación de texto de los datos descifrados  
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
            catch
            {
                return "";
            }

        }

    }
}

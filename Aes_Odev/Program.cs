using System;

namespace Aes_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            AESEncoder ac = new AESEncoder();
            string key = "wEgDCNvhccofPTkFt9zUdDgZDIVdGC9L";
            byte[] iv = AESEncoder.PlainIvToByteArray("crGTopEfBGXE1k1x");
            string text = "40YLp07vJIuR0TfMaNByWwXdtsp5YFy56MU37H8=";
            Console.WriteLine(AESEncoder.DecryptString(key, iv, text));
        }
    }
}

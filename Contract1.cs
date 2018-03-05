using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;

namespace MessageOnBlock
{
    public class Contract1 : SmartContract
    {
        public static object Main(string operation, params object[] args)
        {
            if (operation == "getheight")
                return GetHeight();

            if (args.Length > 0)
            {
                if (operation == "write")
                    return Write((byte[])args[0]);

                if (operation == "getmessage")
                {
                    return GetMessage((BigInteger)args[0]);
                }

                return false;
            }

            return false;
        }

  
        private static string Key(string prefix, byte[] account)
        {
            return string.Concat(prefix, account.AsString());
        }

        private static BigInteger GetHeight()
        {
            BigInteger height = Storage.Get(Storage.CurrentContext, "height").AsBigInteger();
            return height;
        }

        private static string Write(byte[] message)
        {
            BigInteger height = Storage.Get(Storage.CurrentContext, "height").AsBigInteger();
            BigInteger newHeight = height + 1;

            Storage.Put(Storage.CurrentContext, Key("M", newHeight.AsByteArray()), message);
            Storage.Put(Storage.CurrentContext, "height", newHeight);

            return "ok";
        }

        private static byte[] GetMessage(BigInteger height)
        {
            byte[] message = Storage.Get(Storage.CurrentContext, Key("M", height.ToByteArray()));

            if (message == null)
            {
                return "invalid".AsByteArray();
            }
            else
            {
                return message;
            }
        }

    }
}
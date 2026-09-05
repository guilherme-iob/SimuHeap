using SimuHeap.Enums;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Utils
{
    public static class ConversorValorBytes
    {
        public static byte[] ConverterValorParaBytes(object valor, TiposDeVariaveis tipo)
        {
            switch (tipo)
            {
                case TiposDeVariaveis.Char:
                    {
                        byte valorByte;
                        if (valor is char caractere)
                        {
                            valorByte = (byte)caractere;
                        }
                        else
                        {
                            valorByte = Convert.ToByte(valor);
                        }

                        return new[] { valorByte };
                    }
                case TiposDeVariaveis.Short:
                    {
                        byte[] bytes = new byte[sizeof(short)];
                        BinaryPrimitives.WriteInt16LittleEndian(bytes, Convert.ToInt16(valor));
                        return bytes;
                    }
                case TiposDeVariaveis.Int:
                    {
                        byte[] bytes = new byte[sizeof(int)];
                        BinaryPrimitives.WriteInt32LittleEndian(bytes, Convert.ToInt32(valor));
                        return bytes;
                    }
                case TiposDeVariaveis.Long:
                    {
                        byte[] bytes = new byte[sizeof(long)];
                        BinaryPrimitives.WriteInt64LittleEndian(bytes, Convert.ToInt64(valor));
                        return bytes;
                    }
                case TiposDeVariaveis.Float:
                    {
                        float valorFloat = Convert.ToSingle(valor);
                        int bits = BitConverter.SingleToInt32Bits(valorFloat);
                        byte[] bytes = new byte[sizeof(float)];
                        BinaryPrimitives.WriteInt32LittleEndian(bytes, bits);
                        return bytes;
                    }
                case TiposDeVariaveis.Double:
                    {
                        double valorDouble = Convert.ToDouble(valor);
                        long bits = BitConverter.DoubleToInt64Bits(valorDouble);
                        byte[] bytes = new byte[sizeof(double)];
                        BinaryPrimitives.WriteInt64LittleEndian(bytes, bits);
                        return bytes;
                    }
                default:
                    throw new NotSupportedException($"Tipo {tipo} não suportado.");
            }
        }
    }
}

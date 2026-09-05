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

        public static object ConverterBytesParaValor(
            ReadOnlySpan<byte> bytes,
            TiposDeVariaveis tipo)
        {
            switch (tipo)
            {
                case TiposDeVariaveis.Char:
                    return (char)bytes[0];

                case TiposDeVariaveis.Short:
                    return BinaryPrimitives.ReadInt16LittleEndian(bytes);

                case TiposDeVariaveis.Int:
                    return BinaryPrimitives.ReadInt32LittleEndian(bytes);

                case TiposDeVariaveis.Long:
                    return BinaryPrimitives.ReadInt64LittleEndian(bytes);

                case TiposDeVariaveis.Float:
                    {
                        int bits =
                            BinaryPrimitives.ReadInt32LittleEndian(bytes);

                        return BitConverter.Int32BitsToSingle(bits);
                    }

                case TiposDeVariaveis.Double:
                    {
                        long bits =
                            BinaryPrimitives.ReadInt64LittleEndian(bytes);

                        return BitConverter.Int64BitsToDouble(bits);
                    }

                default:
                    throw new NotSupportedException(
                        $"Tipo {tipo} não suportado.");
            }
        }


        public static string FormatarValor(
    object valor,
    TiposDeVariaveis tipo)
        {
            switch (tipo)
            {
                case TiposDeVariaveis.Char:
                    {
                        char caractere = (char)valor;

                        if (char.IsControl(caractere))
                        {
                            return $"0x{(byte)caractere:X2}";
                        }

                        return $"'{caractere}' (0x{(byte)caractere:X2} - ASCII)";
                    }

                case TiposDeVariaveis.Float:
                    {
                        float numero = (float)valor;

                        if (float.IsNaN(numero))
                            return "NaN";

                        if (float.IsPositiveInfinity(numero))
                            return "+Infinito";

                        if (float.IsNegativeInfinity(numero))
                            return "-Infinito";

                        return numero.ToString("G9");
                    }

                case TiposDeVariaveis.Double:
                    {
                        double numero = (double)valor;

                        if (double.IsNaN(numero))
                            return "NaN";

                        if (double.IsPositiveInfinity(numero))
                            return "+Infinito";

                        if (double.IsNegativeInfinity(numero))
                            return "-Infinito";

                        return numero.ToString("G17");
                    }

                default:
                    return valor.ToString() ?? string.Empty;
            }
        }


        public static string FormatarBytes(ReadOnlySpan<byte> bytes)
        {
            return BitConverter
                .ToString(bytes.ToArray())
                .Replace("-", " ");
        }
    }
}

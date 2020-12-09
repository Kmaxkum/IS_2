using System;
using System.Linq;

namespace IS_2
{
    public class MD5
    {
        /*
         * Задан массив значений сдвига для всех 4 циклов по 16 шагов
         */
        static int[] s = new int[64] {
            7, 12, 17, 22,  7, 12, 17, 22,  7, 12, 17, 22,  7, 12, 17, 22,
            5,  9, 14, 20,  5,  9, 14, 20,  5,  9, 14, 20,  5,  9, 14, 20,
            4, 11, 16, 23,  4, 11, 16, 23,  4, 11, 16, 23,  4, 11, 16, 23,
            6, 10, 15, 21,  6, 10, 15, 21,  6, 10, 15, 21,  6, 10, 15, 21
        };

        /*
         * Задем массив значений T с помощью предпросчета целевой функции uint(2^32 * abs(sin(i))
         */
        static uint[] T = new uint[64] {
            0xd76aa478, 0xe8c7b756, 0x242070db, 0xc1bdceee,
            0xf57c0faf, 0x4787c62a, 0xa8304613, 0xfd469501,
            0x698098d8, 0x8b44f7af, 0xffff5bb1, 0x895cd7be,
            0x6b901122, 0xfd987193, 0xa679438e, 0x49b40821,
            0xf61e2562, 0xc040b340, 0x265e5a51, 0xe9b6c7aa,
            0xd62f105d, 0x02441453, 0xd8a1e681, 0xe7d3fbc8,
            0x21e1cde6, 0xc33707d6, 0xf4d50d87, 0x455a14ed,
            0xa9e3e905, 0xfcefa3f8, 0x676f02d9, 0x8d2a4c8a,
            0xfffa3942, 0x8771f681, 0x6d9d6122, 0xfde5380c,
            0xa4beea44, 0x4bdecfa9, 0xf6bb4b60, 0xbebfbc70,
            0x289b7ec6, 0xeaa127fa, 0xd4ef3085, 0x04881d05,
            0xd9d4d039, 0xe6db99e5, 0x1fa27cf8, 0xc4ac5665,
            0xf4292244, 0x432aff97, 0xab9423a7, 0xfc93a039,
            0x655b59c3, 0x8f0ccc92, 0xffeff47d, 0x85845dd1,
            0x6fa87e4f, 0xfe2ce6e0, 0xa3014314, 0x4e0811a1,
            0xf7537e82, 0xbd3af235, 0x2ad7d2bb, 0xeb86d391
        };

        // Функция циклического битового сдвига на s бит
        public static uint CLS(uint x, int s)
        {
            return (x << s) | (x >> (32 - s));
        }

        // Вычисляем Хэш от заданной последовательности байтов
        public static string Calculate(byte[] input)
        {
            // 128 битные буфер разделенный на 4 значнеия (uint -> 32 бита без знака)
            uint A = 0x67452301;   // A 01234567
            uint B = 0xefcdab89;   // B 89ABCDEF
            uint C = 0x98badcfe;   // C FEDCBA98
            uint D = 0x10325476;   // D 76543210

            // Определяем кол-во недостающих байтов, c учетом того, что бы добавили 1 байт
            var addLength = (56 - ((input.Length + 1) % 64)) % 64;
            var processedInput = new byte[input.Length + 1 + addLength + 8];
            Array.Copy(input, processedInput, input.Length);

            // Добавляем первым байтом значение 10000000 в двоичном представлении
            processedInput[input.Length] = 0x80;

            // Добавлем 8 байтное представление исходной длинны к модифицированному массиву
            byte[] length = BitConverter.GetBytes(input.Length * 8);
            Array.Copy(length, 0, processedInput, processedInput.Length - 8, 4);

            for (int blockInd = 0; blockInd < processedInput.Length / 64; ++blockInd)
            {
                // Создаем массив слов X
                uint[] X = new uint[16];

                // Заполняем массив слов от текущего блока сообщения
                for (int j = 0; j < 16; ++j)
                {
                    X[j] = BitConverter.ToUInt32(processedInput, (blockInd * 64) + (j * 4));
                }

                // Инициализируем локальные значения буфера
                uint AA = A;
                uint BB = B;
                uint CC = C;
                uint DD = D;

                uint F = 0;
                uint k = 0;

                // Процесс прогона по циклам и шагам, задаюся функции цикла и индекс текущего слова из блока сообщения
                for (uint i = 0; i < 64; ++i)
                {
                    if (i <= 15)
                    {
                        F = (BB & CC) | (~BB & DD);
                        k = i;
                    }
                    else if (i >= 16 && i <= 31)
                    {
                        F = (DD & BB) | (~DD & CC);
                        k = ((5 * i) + 1) % 16;
                    }
                    else if (i >= 32 && i <= 47)
                    {
                        F = BB ^ CC ^ DD;
                        k = ((3 * i) + 5) % 16;
                    }
                    else if (i >= 48)
                    {
                        F = CC ^ (BB | ~DD);
                        k = (7 * i) % 16;
                    }

                    var dtemp = DD;
                    DD = CC;
                    CC = BB;
                    BB += CLS(AA + F + X[k] + T[i], s[i]);
                    AA = dtemp;
                }

                // Прибавляем результат текущего "куска" к общему результату
                A += AA;
                B += BB;
                C += CC;
                D += DD;
            }

            // Возвращаем значение хэша в виде строки
            return GetByteString(A) + GetByteString(B) + GetByteString(C) + GetByteString(D);
        }

        private static string GetByteString(uint x)
        {
            return String.Join("", BitConverter.GetBytes(x).Select(y => y.ToString("x2")));
        }
    }
}

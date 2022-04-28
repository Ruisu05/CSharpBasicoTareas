using System;

namespace T1TiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usar: byte | sbyte | decimal | nint | nuint | ulong | short | ushort | object | dynamic

            byte vbyte = 255; /* Rango: 0 a 255 Espacio en memoria: Entero de 8 bits con signo
            Byte es un tipo de valor inmutable que representa enteros sin signo con valores
            que van desde 0 (representado por la constante Byte.MinValue) hasta 255 
            (representado por la constante Byte.MaxValue). .NET también incluye un 
            tipo de valor entero de 8 bits con signo, SByte, que representa valores 
            que van desde -128 a 127. */
            sbyte vsbyte = -128; /* Rango: -128 a 255 Espacio en memoria: Entero de 8 bits sin signo
            El tipo de valor SByte representa números enteros con valores que van desde 128 negativo a 127 positivo. */
            decimal vdecimal = 3.14M; /* Rango: ±1.0 x 10-28 to ±7.9228 x 1028 Espacio en memoria: 16 bytes
            El tipo de valor Decimal representa números decimales que van desde el positivo 79.228.162.514.264.337.593.543.950.335 hasta el negativo 79.228.162.514.264.337.593.543.950.335.*/
            ulong vulong = 18446744073709551615; /* Rango: 0 a 18446744073709551615 Espacio en memoria: Entero de 64 bits sin signo 
            El tipo de valor UInt64 representa enteros sin signo con valores que van de 0 a 18 446 744 073 709 551 615. */
            short vshort = 32767; /* Rango: -32768 a 32767 Espacio en memoria: Entero de 16 bits con signo 
            El tipo de valor Int16 representa enteros con signo con valores que van desde 32768 negativo hasta 32767 positivo. */
            ushort vushort = 65535; /* Rango: 0 a 65535 Espacio en memoria: Entero de 16 bits sin signo 
            El tipo de valor UInt16 representa enteros sin signo con valores que van de 0 a 65535. */
            object vobject = "Hola"; /* Espacio en memoria: 16 bytes 
            El tipo de objeto es la clase base definitiva para todos los tipos de datos en C# Common Type System (CTS).
            Object es un alias para la clase System.Object. A los tipos de objetos se les pueden asignar valores de
            cualquier otro tipo, tipos de valor, tipos de referencia, tipos predefinidos o definidos por el usuario.
            Sin embargo, antes de asignar valores, necesita conversión de tipo. */
            dynamic vdynamic = "Hola"; /* Espacio en memoria: 16 bytes 
            Se utiliza para evitar la verificación de tipos en tiempo de compilación. El compilador no verifica el tipo de la variable
            de tipo dinámico en el momento de la compilación; en lugar de eso, el compilador obtiene el tipo en el momento de la ejecución.
            La variable de tipo dinámico se crea usando una palabra clave dinámica. */
        }
    }
}

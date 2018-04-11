using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Texto;
            Texto = Console.ReadLine();
            bool Accept = false;

            int size = Texto.Length;
            int index = 0;

            try
            {

                if (index < size && Texto[index] == '0')
                {


                    while (index - 1 < size && Texto[index] == '0')
                    {
                        index = GetIndex(index, size);
                        if (index < size & Texto[index] == '1')
                        {
                            Accept = true;
                            index = GetIndex(index, size);

                            while (index < size && Texto[index] == '0')
                            {
                                index = GetIndex(index, size);
                            }

                            if (index < size && Texto[index] == '1')
                                index = GetIndex(index, size);
                            else
                            {
                                Accept = false;

                            }

                            while (index < size && Texto[index] == '1')
                                index = GetIndex(index, size);

                            if (index < size && Texto[index] == '0')
                                index = GetIndex(index, size);

                        }
                        else
                        {
                            Accept = true;
                            break;
                        }
                    }

                }
                else Accept = true;


                if (Accept == false)
                {
                    Console.WriteLine("la cadena es valida");
                    Console.ReadLine();
                }
                else if( Accept == true)
                    Console.WriteLine("la cadena no es valida");
                Console.ReadLine();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static int GetIndex(int index,int size)
        {
            if (index < size-1)
                return index++;
            else
                return index;
        }
    }
}

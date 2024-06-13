using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Lista1
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            //para adicionar nomes na lista

            list.Insert(0, "Marco");
            //Para inserir um nome na Lista e colocando a posição dele

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count: "+ list.Count);
            //Contar os itens da Lista

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            //Expresso Lambida


            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);
            //Expressao Lambida para encontrar a pessoa que a ultima letra termine com 'A'





            int pos1 = list.FindIndex(x1 => x1[0] == 'A');
            Console.WriteLine("First Position: " + pos1);
            //A primeira posição de quem começa com a letra A


            int pos2 = list.FindLastIndex(x1 => x1[0] == 'A');
            Console.WriteLine("Last Position: " + pos2);
            //A ultima posição de quem começa com a letra A


            //Para encontrar pessoas que tem mais de 5 caracteres na Lista
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Para retirar uma "Pessoa" ou seja um objeto da lista
            list.Remove("Alex");
            Console.WriteLine("---------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Para remover todas as pessoas que começam com a letra M da Lista
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover por posição da Lista
            list.RemoveAt(3);
            Console.WriteLine("---------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Para remover de uma area
            list.RemoveRange(2, 2);
            Console.WriteLine("---------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
        /**static bool Test(string s)
        {
            return s[0] == 'A';
            //Função para procurar o primeiro nome da lista que começa com A
        }
        **/
    }
}

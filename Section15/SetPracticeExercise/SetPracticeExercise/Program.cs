using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

namespace SetPracticeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Em um portal de cursos online, cada usuário possui um código único, representado porum número inteiro.
            //Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode sematricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor não é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haveralunos repetidos em mais de um curso.
            //O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
            //Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar aquantidade total e alunos dele, conforme exemplo.

            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int studentId = int.Parse(Console.ReadLine());
                courseA.Add(studentId);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int studentId = int.Parse(Console.ReadLine());
                courseB.Add(studentId);
            }

            Console.Write("How many students for course A? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int studentId = int.Parse(Console.ReadLine());
                courseC.Add(studentId);
            }

            HashSet<int> allStudents = new HashSet<int>(courseA);
            allStudents.UnionWith(courseB);
            allStudents.UnionWith(courseC);

            Console.WriteLine("Total students: " + allStudents.Count);
        }
    }
}

using System;
using System.Collections.Generic;

namespace EnumsAndSwitches
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> todos = new List<ToDo>()//Loaded list
            {
                new ToDo {Description = "Task 1", Estimate = 6, Status = Status.Complete},
                new ToDo {Description = "Task 2", Estimate = 2, Status = Status.InProgress},
                new ToDo {Description = "Task 3", Estimate = 8, Status = Status.NotStarted},
                new ToDo {Description = "Task 4", Estimate = 3, Status = Status.InProgress},
                new ToDo {Description = "Task 5", Estimate = 12, Status = Status.Deleted},
                new ToDo {Description = "Task 6", Estimate = 6, Status = Status.InProgress},
                new ToDo {Description = "Task 7", Estimate = 1, Status = Status.Complete},
                new ToDo {Description = "Task 8", Estimate = 9, Status = Status.NotStarted},
                new ToDo {Description = "Task 9", Estimate = 4, Status = Status.InProgress},
                new ToDo {Description = "Task 10", Estimate = 1, Status = Status.Deleted}
            };

            Console.WriteLine("Hello");

            PrintAssessment(todos);//call PrintAssessment method

            Console.ReadLine();
        }

        private static void PrintAssessment(List<ToDo> ToDos)
        {
            foreach(var todo in ToDos)
            {
                switch (todo.Status)//Create the switch and add something to be evaluted
                {
                    case Status.Complete://a colon needs to follow the case evaluation
                        Console.WriteLine(todo.Description +  " has been completed.");
                        Console.ForegroundColor = ConsoleColor.Yellow;//Change the foreground colour
                        break;//Semi colon to end the case
                    case Status.NotStarted:
                        Console.WriteLine(todo.Description + " is yet to be started.");
                        Console.ForegroundColor = ConsoleColor.Red;//Change the foreground colour
                        break;
                    case Status.OnHold:
                        Console.WriteLine(todo.Description + " are on hold for now.");
                        Console.ForegroundColor = ConsoleColor.Blue;//Change the foreground colour
                        break;
                    case Status.InProgress:
                        Console.WriteLine(todo.Description + " is in progress");
                        Console.ForegroundColor = ConsoleColor.Green;//Change the foreground colour
                        break;
                    case Status.Deleted:
                        Console.WriteLine(todo.Description + " has been deleted.");
                        Console.ForegroundColor = ConsoleColor.Cyan;//Change the foreground colour
                        break;
                    default:
                        break;

                }
            }        
        }
    }

    class ToDo
    {
        public string Description { get; set; }
        public int Estimate { get; set; }
        public Status Status { get; set; }
    }

    enum Status// each status is given a numerical value.
    {
        NotStarted,
        InProgress,
        OnHold,
        Complete,
        Deleted
    }
}
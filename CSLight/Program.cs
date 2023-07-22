using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PerFormat worker1 = new PerFormat("Сергей");
            PerFormat worker2 = new PerFormat("Антон");

            Task[] tasks = { new Task(worker1, "Создать дискорд бота."), new Task(worker2, "Нарисовать дизайн.") };

            Board shedule = new Board(tasks);

            shedule.ShowAllTasks();
        }
    }

    class PerFormat
    {
        public string Name;

        public PerFormat(string name)
        {
            Name = name;
        }
    }

    class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks()
        {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }

    class Task
    {
        public PerFormat Worker;
        public string Description;

        public Task(PerFormat worker, string description)
        {
            Worker = worker;
            Description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}.\n");
        }
    }
}
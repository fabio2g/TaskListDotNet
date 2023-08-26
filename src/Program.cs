using src.Util;
using System;

namespace src
{
    class Program
    {
        public static void Main()
        {
            List<Task> taskList = new List<Task>(); // Cria uma lista para armazenar as tarefas

            while (true)
            {
                Console.WriteLine("#### Menu To Do List ####");
                Console.WriteLine("1 - Adicionar tarefa.");
                Console.WriteLine("2 - Atualizar Tarefa.");
                Console.WriteLine("3 - Listar tarefas.");
                Console.WriteLine("4 - Deletar Tarefa.");
                Console.WriteLine("5 - Finalizar Programa.");

                if (taskList.Count > 0)
                {
                }

                Console.WriteLine();

                Console.Write("Opção: ");
                int option = 0;
                try
                {
                    option = Convert.ToInt32(Console.ReadLine()); // Lê a opção escolhida
                }
                catch (Exception)
                {
                    Console.WriteLine("\nOpção inválida.\n");
                }

                if (option == 1)
                {
                    try
                    {
                        Task newTask = new Task();

                        Console.Write("Nova tarefa: ");
                        string description = Console.ReadLine(); // Lê a descrição da tarefa

                        if(description == null)
                        {
                            Console.WriteLine("A tarefa é obrigatória.\n");
                            return;
                        }

                        newTask.setId(TaskListUtil.CreateNextId(taskList));
                        newTask.setDescription(description);

                        taskList.Add(newTask);

                        Console.Write("\nLista de tarefas:");
                        TaskListUtil.InfoList(taskList);

                        Console.WriteLine("\n");

                    } catch(Exception)
                    {
                        Console.WriteLine("\nErro ao adiciona tarefa.\n");
                    }
                }
                else if (option == 2)
                {
                    try
                    {
                        Console.Write("\nInforme o ID da tarefa a ser atualizada: ");
                        int idToUpdate = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nova tarefa: ");
                        string description = Console.ReadLine();

                        TaskListUtil.UpdateTaskDescription(taskList, idToUpdate, description);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nOpção inválida.\n");
                    }
                }
                else if(option == 3)
                {

                }
                else if (option == 4)
                {
                    try
                    {
                        Console.Write("\nInforme o ID a ser removido: ");

                        int idToRemove = Convert.ToInt32(Console.ReadLine());

                        TaskListUtil.RemoveTaskById(taskList, idToRemove);
                        TaskListUtil.ReindexTasks(taskList);

                        Console.Write("\nLista de tarefas:");
                        TaskListUtil.InfoList(taskList);

                    } catch (Exception)
                    {
                        Console.WriteLine("\nOpção inválida.\n");
                    }
                    Console.WriteLine("\n");
                }
                else if (option == 5)
                {
                    break; // Sai do loop e finaliza o programa
                }
            }
        }

        
    }
}
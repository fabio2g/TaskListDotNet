﻿using src.Util;
using System.Globalization;

namespace src
{
    class Program
    {
        public static void Main()
        {
            List<Task> taskList = new List<Task>(); // Cria uma lista para armazenar as tarefas

            while (true)
            {
                Console.WriteLine("#### MENU TO DO LIST ####");
                Console.WriteLine("1 - Adicionar tarefa.");
                Console.WriteLine("2 - Atualizar Tarefa.");
                Console.WriteLine("3 - Listar tarefas.");
                Console.WriteLine("4 - Deletar Tarefa.");
                Console.WriteLine("5 - Finalizar Programa.\n");

                Console.Write("Opção: ");

                int option = 0;
    
                try
                {
                    option = Convert.ToInt32(Console.ReadLine()); // Lê a opção escolhida

                    if(option < 1 || option > 5)
                    {
                        throw new Exception();
                    }
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
                else if (option == 2) // Atualizar Tarefa
                {
                    try
                    {
                        Console.Write("\nInforme o ID da tarefa a ser atualizada: ");
                        int idToUpdate = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Tarefa: ");
                        string description = Console.ReadLine();

                        TaskListUtil.UpdateTaskDescription(taskList, idToUpdate, description);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nOpção inválida.\n");
                    }
                }
                else if (option == 3) // Listar tarefas
                {
                    Console.Write("Deseja listar todas as tarefas? [S/N]: ");
                    string response = Console.ReadLine();

                    if(response == "S" || response == "s")
                    {
                        TaskListUtil.InfoList(taskList);
                    } else if (response == "N" || response == "n") 
                    { 
                        Console.Write("Informe o ID da tarefa: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        TaskListUtil.InfoList(taskList, id);
                    }
                }
                else if (option == 4) // Deletar Tarefa
                {
                    try
                    {
                        Console.Write("Informe o ID a ser removido: ");

                        int idToRemove = Convert.ToInt32(Console.ReadLine());

                        TaskListUtil.RemoveTaskById(taskList, idToRemove);
                        Console.Write("aqui");
                    } catch (Exception)
                    {
                        Console.WriteLine("\nOpção inválida.\n");
                    }
                }
                else if (option == 5)
                {
                    break; // Sai do loop e finaliza o programa
                }
            }
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.util
{
    static class TaskListUtil
    {
        public static void InfoList(List<Task> taskList, int id = 0)
        {
            try
            {
                if (taskList == null) throw new Exception("Ouve um erro ao exibir a lista.");

                if(id > 0)
                {
                    Task item = taskList.Find(task => task.getId() == id);

                    if (item == null) throw new Exception("Id inválido.");

                    Console.WriteLine(item);
                } else
                {
                    foreach (var task in taskList)
                    {
                        Console.Write(task);
                    }
                }  
            }
            catch(Exception error) 
            {
                Console.WriteLine(error.Message);
            } 
        }

        // Função para gerar o próximo ID
        public static int CreateNextId(List<Task> taskList)
        {
            return taskList.Count + 1; // Obtém o próximo ID disponível
        }

        // Função para remover uma tarefa da lista de tarefas
        public static void RemoveTaskById(List<Task> taskList, int id)
        {
            try
            {
                if (taskList == null)
                {
                    throw new Exception("\nA lista de tarefas está nula.\n");
                    return;
                }
                else if (taskList.Count == 0)
                {
                    throw new Exception("\nA lista de tarefas está vazia.\n");
                    return;
                }
                Task taskToRemove = taskList.Find(task => task.getId() == id);

                taskList.Remove(taskToRemove);
                ReindexTasks(taskList);

                Console.Write("\nLista de tarefas:");
                InfoList(taskList);

            } catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public static void ReindexTasks(List<Task> taskList)
        {
           
            int newId = 1;
            foreach(var task in taskList)
            {
                task.setId(newId++);
            }
        }

        public static void UpdateTaskDescription(List<Task> taskList, int id, string description)
        {
            try
            {
                if (taskList == null || id <= 0 || description == null) throw new Exception();

                Task taskUpdate = taskList.Find(task => task.getId() == id);

                if (taskUpdate != null)
                {
                    taskUpdate.setDescription(description);

                    Console.WriteLine("\nTarefa atualizada com sucesso.\n");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Failed to update task description: {description}");
            }
        }
    }
}

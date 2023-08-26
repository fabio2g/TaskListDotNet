using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Util
{
    static class TaskListUtil
    {
        public static void InfoList(List<Task> listTask)
        {
            foreach (var task in listTask)
            {
                Console.Write(task);
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
                if (taskList == null || id <= 0) throw new Exception();

                Task taskToRemove = taskList.Find(task => task.getId() == id);

                taskList.Remove(taskToRemove);
            } catch(Exception)
            {
                Console.WriteLine("\nHouve um erro ao remover tarefa.\n");
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
                if (taskList == null || id <= 0 || description == null) return;

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

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
                Console.WriteLine("1 - Adicionar Tarefa.");
                Console.WriteLine("2 - Finalizar Programa.");

                if (taskList.Count > 0)
                {
                    Console.WriteLine("3 - Deletar Tarefa.");
                }

                Console.WriteLine();

                Console.Write("Opção: ");
                int option = 0;
                try
                {
                    option = Convert.ToInt32(Console.ReadLine()); // Lê a opção escolhida
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nOpção inválida.\n");
                }

                if (option == 1)
                {
                    int id = NextId(taskList); // Obtém o próximo ID disponível

                    Console.Write("Descrição: ");
                    string description = Console.ReadLine(); // Lê a descrição da tarefa

                    Task newTask = new Task(id, description); // Cria uma nova tarefa

                    taskList.Add(newTask); // Adiciona a tarefa à lista

                    Console.Write("\nLista de tarefas:");
                    foreach (var task in taskList)
                    {
                        Console.Write(task); // Mostra a lista de tarefas
                    }

                    Console.WriteLine("\n");
                }
                else if (option == 2)
                {
                    break; // Sai do loop e finaliza o programa
                }
                else if (option == 3)
                {
                    Console.Write("\nInforme o ID a ser removido: ");
                    int idToRemove = Convert.ToInt32(Console.ReadLine());

                    RemoveTaskById(taskList, idToRemove);
                    ReindexTasks(taskList);

                    Console.Write("\nLista de tarefas:");
                    foreach (var task in taskList)
                    {
                        Console.Write(task); // Mostra a lista de tarefas
                    }
                    Console.WriteLine("\n");
                }
            }
        }
        // Função para gerar o próximo ID
        private static int NextId(List<Task> list)
        {
            return list.Count + 1; // Retorna o próximo ID sequencial
        }

        // Função para remover uma tarefa da lista de tarefas
        static void RemoveTaskById(List<Task> tasks, int taskId)
        {
            Task taskToRemove = tasks.Find(task => task.getId() == taskId);
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
            }
        }

        static void ReindexTasks(List<Task> taskList)
        {
            int newId = 1;
            foreach (var task in taskList)
            {
                task.setId(newId++); // Atualiza os IDs sequencialmente
            }
        }
    }
}
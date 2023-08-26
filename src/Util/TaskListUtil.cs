using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Util
{
    static class TaskListUtil
    {
        // Função para gerar o próximo ID
        public static int AddNextId(List<Task> taskList)
        {
            return taskList.Count + 1; // Obtém o próximo ID disponível
        }
    }
}

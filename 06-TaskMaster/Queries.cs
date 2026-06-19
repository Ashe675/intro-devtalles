using BetterConsoles.Tables;
using BetterConsoles.Tables.Configuration;

namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("---------------Lista de tareas---------------");

            Table table = new Table("Id", "Descripcion", "Completado");
            foreach (var task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed ? "✅" : "[]");
            }

            table.Config = TableConfig.Unicode();

            Write(table.ToString());
        }

        public List<Task> AddTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---------Agregar Tarea--------");
                WriteLine("Ingrese la descripcion de la tarea: ");
                var descripcion = ReadLine();
                Task newTask = new Task(Utils.GenerateId(), descripcion ?? "");
                Tasks.Add(newTask);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea agregada con exito");
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return [];
            }
        }

        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---------Marcar tarea como completada--------");
                ListTasks();
                WriteLine("---------------------------------");
                Write("Ingrese el id de la tarea que desea marcar como completada: ");
                var id = ReadLine();
                Task task = Tasks.Find(task => task.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontro la tarea con el ID proporcionado");
                    ResetColor();
                    return Tasks;
                }
                task.Completed = true;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea marcada como completada con exito!");
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return [];
            }
        }

        public List<Task> EditTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---------Editar Tarea--------");
                ListTasks();
                WriteLine("---------------------------------");
                Write("Ingrese el id de la tarea que desea editar: ");
                var id = ReadLine();
                Task task = Tasks.Find(task => task.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontro la tarea con el ID proporcionado");
                    ResetColor();
                    return Tasks;
                }
                Write("Ingrese la nueva descripción de la tarea");
                var newDescription = ReadLine();
                task.Description = newDescription;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea marcada como modificada con exito!");
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return [];
            }
        }

        public List<Task> RemoveTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---------Eliminar Tarea--------");
                ListTasks();
                WriteLine("---------------------------------");
                Write("Ingrese el id de la tarea que desea eliminar: ");
                var id = ReadLine();
                Task task = Tasks.Find(task => task.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("No se encontro la tarea con el ID proporcionado");
                    ResetColor();
                    return Tasks;
                }
                Tasks.Remove(task);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea eliminada con exito!");
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex.Message);
                return [];
            }
        }
    }

}
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

        public void TasksByState()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---------Tareas por estado--------");
                ListTasks();
                WriteLine("---------------------------------");
                WriteLine("1. Completadas");
                WriteLine("2. Pendientes");
                Write("Ingrese la opcion por la cual desea filtrar: ");
                var state = ReadLine();
                if (state != "1" && state != "2")
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"{state} - No es una opcion valida");
                    ResetColor();
                    return;
                }

                var completed = state == "1";

                List<Task> filteredTasks = Tasks.Where(task => task.Completed == completed).ToList();
                if (filteredTasks.Count() == 0)
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("No se encontraron tareas con el estado solicitado");
                    ResetColor();
                    return;
                }
                ForegroundColor = completed ? ConsoleColor.Green : ConsoleColor.DarkYellow;

                WriteLine($"---------Tareas {(completed ? "Completadas" : "Pendientes")}---------");
                Table table = new Table("Id", "Descripcion", "Completado");
                foreach (var task in filteredTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "✅" : "[]");
                }

                table.Config = TableConfig.Unicode();

                Write(table.ToString());
                return;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Ocurrio un error al filtrar las tareas: {ex.Message}");
                return;
            }
        }


        public void TasksByDescription()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("---------Buscar tareas por descripcion--------");
                ListTasks();
                WriteLine("---------------------------------");
                Write("Ingrese la descripcion que desea filtrar: ");
                var description = ReadLine();
                if (string.IsNullOrEmpty(description))
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Descripcion invalida");
                    ResetColor();
                    return;
                }
                List<Task> filteredTasks = Tasks.FindAll(task => task.Description?.Contains(description, StringComparison.OrdinalIgnoreCase) ?? false);

                if (filteredTasks.Count() == 0)
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("No se encontraron tareas con el estado solicitado");
                    ResetColor();
                    return;
                }

                WriteLine($"---------Tareas encontradas---------");
                Table table = new Table("Id", "Descripcion", "Completado");
                foreach (var task in filteredTasks)
                {
                    table.AddRow(task.Id, task.Description, task.Completed ? "✅" : "[]");
                }

                table.Config = TableConfig.Unicode();

                Write(table.ToString());
                return;

            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Ocurrio un error al buscar tareas por descripcion: {ex.Message}");
                ResetColor();
                return;
            }
        }
    }

}
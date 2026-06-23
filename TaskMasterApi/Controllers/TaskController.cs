using Microsoft.AspNetCore.Mvc;
using TaskMasterApi.Services;

namespace TaskMasterApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Models.Task>> GetTasks()
    {
        return Ok(TaskDataStore.Current.Tasks);
    }

    [HttpGet("{id}")]
    public ActionResult<Models.Task> GetTask(int id)
    {
        var task = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return NotFound("Task not found");
        }
        return Ok(task);
    }

    [HttpPost]
    public ActionResult<Models.Task> CreateTask(Models.TaskInsert task)
    {
        var newTask = new Models.Task
        {
            Id = TaskDataStore.Current.Tasks.Max(t => t.Id) + 1,
            Title = task.Title,
            Description = task.Description,
            IsCompleted = false,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        TaskDataStore.Current.Tasks.Add(newTask);
        return CreatedAtAction(nameof(GetTask), new { id = newTask.Id }, newTask);
    }

    [HttpPut("{id}")]
    public ActionResult<Models.Task> UpdateTask(int id, Models.TaskUpdate task)
    {
        var existingTask = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);
        if (existingTask == null)
        {
            return NotFound("Task not found");
        }
        existingTask.Title = task.Title;
        existingTask.Description = task.Description;
        existingTask.UpdatedAt = DateTime.Now;
        return Ok(existingTask);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteTask(int id)
    {
        var existingTask = TaskDataStore.Current.Tasks.FirstOrDefault(t => t.Id == id);
        if (existingTask == null)
        {
            return NotFound("Task not found");
        }
        TaskDataStore.Current.Tasks.Remove(existingTask);
        return NoContent();
    }
    
}
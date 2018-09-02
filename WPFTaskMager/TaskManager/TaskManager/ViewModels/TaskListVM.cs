using System.Linq;
using TaskDAL.DAL;
using TaskDAL.Models;

namespace TaskManager.ViewModels
{
    public sealed class TaskListVM : ViewModelBase
    {
        public Task[] Tasks { get; set; }
        public Task SelectedTask { get; set; }

        public TaskListVM()
        {
            TaskContext context = new TaskContext();
            Tasks = context.Tasks.ToArray();
            OnPropertyChanged(nameof(Tasks));
        }
    }
}
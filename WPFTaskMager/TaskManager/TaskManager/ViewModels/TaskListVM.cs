using TaskDAL.Models;

namespace TaskManager.ViewModels
{
    public class TaskListVM : ViewModelBase
    {
        public Task[] Tasks { get; set; }
        public Task SelectedTask { get; set; }
    }
}
using TaskDAL.Models;

namespace TaskManager.ViewModels
{
    public class TaskDetailVM : ViewModelBase
    {
        public string TaskName => _task.Name;
        public string DueDate => _task.DueDate.ToString("d");

        private Task _task;

        public TaskDetailVM()
        {
            
        }

        public TaskDetailVM(Task task)
        {
            _task = task;
            OnPropertyChanged(nameof(TaskName));
        }
    }
}
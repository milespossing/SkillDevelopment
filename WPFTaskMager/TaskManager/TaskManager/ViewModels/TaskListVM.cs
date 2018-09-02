using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TaskDAL.DAL;
using TaskDAL.Models;

namespace TaskManager.ViewModels
{
    public sealed class TaskListVM : ViewModelBase
    {
        public Task[] Tasks { get; set; }
        public Task SelectedTask { get; set; }
        public ICommand EndingCellEdit => new SimpleCommand(Save);

        private TaskContext context;

        public TaskListVM()
        {
            context = new TaskContext();
            Tasks = context.Tasks.ToArray();
            OnPropertyChanged(nameof(Tasks));
        }

        private void Save()
        {
            context.SaveChanges();
        }
    }
}
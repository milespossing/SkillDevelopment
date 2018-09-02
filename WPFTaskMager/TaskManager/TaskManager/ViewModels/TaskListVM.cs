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
        public ICommand TestCommand => new SimpleCommand(Test);

        public TaskListVM()
        {
            TaskContext context = new TaskContext();
            Tasks = context.Tasks.ToArray();
            OnPropertyChanged(nameof(Tasks));
        }

        private void Test()
        {
            MessageBox.Show("Test!");
        }
    }
}
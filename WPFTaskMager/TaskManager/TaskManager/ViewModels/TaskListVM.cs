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

        private TaskContext _context;

        public TaskListVM()
        {
            _context = new TaskContext();
            Tasks = _context.Tasks.ToArray();
            OnPropertyChanged(nameof(Tasks));
        }

        public void Update()
        {
            Tasks = _context.Tasks.ToArray();
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
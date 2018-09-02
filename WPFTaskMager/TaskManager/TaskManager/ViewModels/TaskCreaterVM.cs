using System;
using System.Windows;
using System.Windows.Input;
using TaskDAL.DAL;
using TaskDAL.Models;

namespace TaskManager.ViewModels
{
    public class TaskCreaterVM : ViewModelBase
    {
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Today;
        public ICommand OnSubmit => new SimpleCommand(SubmitTask);

        public event EventHandler Submitted;

        private void SubmitTask()
        {
            TaskContext context = new TaskContext();
            Task t = new Task();
            t.Name = TaskName;
            t.DueDate = DueDate;
            t.Description = "test";
            context.Tasks.Add(t);
            context.SaveChanges();
            Submitted?.Invoke(this, new EventArgs());
        }
    }
}
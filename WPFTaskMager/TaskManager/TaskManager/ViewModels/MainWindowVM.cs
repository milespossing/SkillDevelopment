using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Input;
using TaskDAL.Models;
using TaskManager.Views;

namespace TaskManager.ViewModels
{
    public class MainWindowVM : ViewModelBase
    {
        public ICommand TaskViewButtonClick => new SimpleCommand(taskViewButtonCallBack);

        public TaskListVM taskListVm { get; set; }
        public TaskCreaterVM vm;

        public MainWindowVM()
        {
            taskListVm = new TaskListVM();
        }

        private void taskViewButtonCallBack()
        {
            vm = new TaskCreaterVM();
            vm.Submitted += VmOnSubmitted;
            TaskCreationDialog dialog = new TaskCreationDialog();
            dialog.DataContext = vm;
            dialog.Show();
        }

        private void VmOnSubmitted(object sender, EventArgs e)
        {
            taskListVm.Update();
        }
    }
}
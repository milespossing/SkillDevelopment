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

        private void taskViewButtonCallBack()
        {
            TaskCreationDialog dialog = new TaskCreationDialog();
            dialog.Show();
        }
    }
}
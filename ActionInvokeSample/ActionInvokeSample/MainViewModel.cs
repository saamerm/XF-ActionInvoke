using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ActionInvokeSample
{
    public class MainViewModel
    {
        public Action<bool> OnLoginFailed { get; set; }
        public ICommand CheckCommand { get; set; }
        public MainViewModel()
        {
            CheckCommand = new Command(CheckPassword);
        }

        private void CheckPassword(object obj)
        {
            OnLoginFailed?.Invoke(true);
        }
    }
}

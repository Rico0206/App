using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class WindowViewModel : BaseViewModel
    {
        public WindowViewModel(Window window)
        {
            mWindow = window;
        }

        private Window mWindow;

        public double WindowMinimumWidth { get; set; } = 400;
        public double WindowMinimumHeight { get; set; } = 400;
        public Thickness InnerContentPadding { get; set; } = new Thickness(0);
        public int TitleHeight { get; set; } = 42;
        public AppPage CurrentPage { get; set; } = AppPage.Login;
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand MenuCommand { get; set; }

    }
}

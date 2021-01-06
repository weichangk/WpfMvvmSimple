using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmSimple.Common
{
    /// <summary>
    /// 命令属性绑定基类
    /// </summary>
    public class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action<object> DoExecute { get; set; }
        public Func<object, bool> DoCanExecute { get; set; }

        /// <summary>
        /// 定义确定此命令是否可在其当前状态下执行的方法。
        /// </summary>
        public bool CanExecute(object parameter)
        {
            return DoCanExecute?.Invoke(parameter) == true;
        }
        /// <summary>
        /// 定义在调用此命令时要调用的方法。
        /// </summary>
        public void Execute(object parameter)
        {
            DoExecute?.Invoke(parameter);
        }
        /// <summary>
        /// 当出现影响是否应执行该命令的更改时发生
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}

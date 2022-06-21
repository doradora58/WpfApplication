using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTaskApplication.Commands
{
    using System;
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// ICommand を実装することで 
    /// ICommandSource を実装した オブジェクト(Button等) の
    /// Commandイベント に関連付けて呼び出せるようになる
    /// </summary>
    public class OpenMessageDialogCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        /// <summary>
        /// MainView で ボタン を押下されたとき実行される処理
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            var name = parameter as string;

            var message = "こんにちは、" + name + "さん";

            MessageBox.Show(message);
        }
    }
}

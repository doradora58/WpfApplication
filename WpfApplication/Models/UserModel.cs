using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication.Models
{
    /// <summary>
    /// テキスト入力に対応するユーザー情報
    /// </summary>
    public class UserModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }
    }
}

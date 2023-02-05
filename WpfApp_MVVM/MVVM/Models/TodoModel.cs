using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_MVVM.MVVM.Models;

class TodoModel
{
    public string Text { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.Now;
}

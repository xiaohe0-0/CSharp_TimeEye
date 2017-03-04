using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeEye
{
    public class NumberTextbox : System.Windows.Forms.TextBox
    {
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            } 

        }
    }
}

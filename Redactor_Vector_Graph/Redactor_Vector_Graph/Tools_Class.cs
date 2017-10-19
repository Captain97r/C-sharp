using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    class Tool
    {
       public static Tool ActiveTool { get; set; }
       private Button tool_button;
        public Type typeFigure;
        public Tool(Button button,Type type)
        {
            typeFigure = type;
            tool_button = button;
            tool_button.Click += new EventHandler(tool_buttonClick);
        }
        public void tool_buttonClick(object sender, EventArgs e)
        {
            ActiveTool = this;
        }
    }
}

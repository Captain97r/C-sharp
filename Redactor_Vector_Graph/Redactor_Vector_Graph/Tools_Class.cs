using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Redactor_Vector_Graph
{
    class Tools
    {
        static int number_of_tools = 0;
        Button tool_button;

        public Tools(Form form, Image button_image, ToolTip toolTip, String toolTipText)
        {
            number_of_tools++;
            tool_button = new Button();
            if (number_of_tools % 2 == 1)
               tool_button.Location = new Point(5, 55+(58* number_of_tools));
            else
               tool_button.Location = new Point(63, 55 + (58 * number_of_tools));
            tool_button.Size = new Size(52,52);
            tool_button.Image = button_image;
            toolTip.SetToolTip(tool_button, toolTipText);
            form.Controls.Add(tool_button);
        }

    }
}

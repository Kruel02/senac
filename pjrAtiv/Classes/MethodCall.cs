using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pjrAtiv;
using pjrAtiv.Properties;
using pjrAtiv.Classes;
using System.Reflection.Metadata;

namespace pjrAtiv.Classes
{
    public class MethodCall
    {
        public Control.ControlCollection? Controls;

        

        public void MenuStrips(string menunome, string botao,bool ligar)
        {
            
            

            Control[] controls = Controls.Find(menunome, true);
            foreach (Control control in controls)
            {

                if (control.Name == menunome)
                {
                    

                    MenuStrip? strip = control as MenuStrip;
                    foreach (ToolStripMenuItem SubMenu in strip.Items)
                    {
                        

                        
                        foreach (ToolStripItem SubmenuItem in SubMenu.DropDownItems)
                        {
                            if (SubmenuItem.Name == botao)
                            {
                                
                                SubmenuItem.Enabled = ligar;

                            }

                        }

                    }


                }
            }
        }

        public void LimparTextBoxes()
        {

            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();

                    }
                    else
                    {
                        func(control.Controls);
                    }
                }


            };

            func(Controls);


        }

    }

    
}



       
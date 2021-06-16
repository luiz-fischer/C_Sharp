using System;
using System.Diagnostics;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;


namespace LocaCar
{

    public class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            // Make the Form an MDI parent.
            this.IsMdiContainer = true;

            // Create a MenuStrip control with a new window.
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem windowMenu = new ToolStripMenuItem("Cadastrar");
            ToolStripMenuItem cadastrarClienteMenuPrincipal = new ToolStripMenuItem(
                "Cliente",
                null, 
                new EventHandler(windowNewMenu_Click)
                );
            ToolStripMenuItem cadastrarLocacaoMenuPrincipal = new ToolStripMenuItem(
                "Locação",
                null, 
                new EventHandler(windowNewMenu_Click)
                );
            
            windowMenu.DropDownItems.Add(cadastrarClienteMenuPrincipal);
            windowMenu.DropDownItems.Add(cadastrarLocacaoMenuPrincipal);
            

            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;

            // Assign the ToolStripMenuItem that displays 
            // the list of child forms.
            ms.MdiWindowListItem = windowMenu;

            // Add the window ToolStripMenuItem to the MenuStrip.
            ms.Items.Add(windowMenu);

            // Dock the MenuStrip to the top of the form.
            ms.Dock = DockStyle.Top;

            // The Form.MainMenuStrip property determines the merge target.
            this.MainMenuStrip = ms;

            // Add the ToolStripPanels to the form in reverse order.

            // Add the MenuStrip last.
            // This is important for correct placement in the z-order.
            this.Controls.Add(ms);
        }

        // This event handler is invoked when 
        // the "New" ToolStripMenuItem is clicked.
        // It creates a new Form and sets its MdiParent 
        // property to the main form.
        void windowNewMenu_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.MdiParent = this;
            f.Text = "Form - " + this.MdiChildren.Length.ToString();
            f.Show();
        }
        private void clienteCadastrarMenuPrincipal_Click(object sender, EventArgs e)
        {
            CriarCliente criarCliente = new CriarCliente();
            criarCliente.Show();
        }
    }
}
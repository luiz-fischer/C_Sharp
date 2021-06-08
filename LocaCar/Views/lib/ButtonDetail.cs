using System;
using System.Drawing;

namespace Library
{
    public enum ButtonType
    {
        Sair,
        Update,
        Delete
    }
    public class ButtonDetail : System.Windows.Forms.Button
    {
        public ButtonDetail(ButtonType type)
        {
            this.Size = new Size(150, 50);
            switch (type)
            {
                case ButtonType.Sair:
                this.MouseEnter += new EventHandler(this.btn_SairDetalheEnter);
                this.MouseLeave += new EventHandler(this.btn_SairDetalheLeave);
                    break; 
                case ButtonType.Update:
                this.MouseEnter += new EventHandler(this.btn_UpdateDetalheEnter);
                this.MouseLeave += new EventHandler(this.btn_UpdateDetalheLeave);
                    break;                
                case ButtonType.Delete:
                this.MouseEnter += new EventHandler(this.btn_DeleteDetalheEnter);  
                this.MouseLeave += new EventHandler(this.btn_DeleteDetalheLeave);
                    break;
                default:
                break;
            }              
        }
        
        
        private void btn_SairDetalheEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }
        private void btn_SairDetalheLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }
       
        private void btn_UpdateDetalheEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }
        private void btn_UpdateDetalheLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }
        private void btn_DeleteDetalheEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }
        private void btn_DeleteDetalheLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }
    }
}
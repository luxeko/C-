using System.Collections.Generic;
namespace Assignment
{
    public class VegesDAO
    {
        List<Vegestable> listVG;

        public VegesDAO()
        {
            listVG = new List<Vegestable>();
        }

        public VegesDAO(List<Vegestable> listVG)
        {
            this.listVG = listVG;
        }

        public List<Vegestable> ListVG { get => listVG; set => listVG = value; }
    }
}
using ProductionLogic.Core.Domain;
using ProductionUI.Classes;

namespace ProductionUI
{
    internal class ClassAdd
    {
        public void Add()
        {
            GlobalData.UnitOfWork.Orders.Add(new Order());
        }
    }
}
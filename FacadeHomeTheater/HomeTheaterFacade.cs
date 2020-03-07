using FacadeHomeTheater.SybSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeHomeTheater
{
    class HomeTheaterFacade
    {
        Tuner tuner = new Tuner();
        Screen screen = new Screen();
        Subwoofer subwoofer = new Subwoofer();

        public void WatchMovie()
        {
            tuner.OperationA();
            screen.OperationA();
            subwoofer.OperationA();
        }

        public void EndMovie()
        {
            subwoofer.OperationB();
            tuner.OperationB();
            screen.OperationB();            
        }
    }
}

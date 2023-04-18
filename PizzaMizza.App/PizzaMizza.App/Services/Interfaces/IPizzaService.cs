using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.App.Services.Interfaces
{
    public interface IPizzaService
    {
        public void Create();
        public void Update();
        public void Delete();
        public void ShowAll();
        public void ShowById();
    }
}

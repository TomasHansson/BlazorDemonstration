using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary.Services
{
    public class CounterStateService
    {
        private int currentCount;
        public int CurrentCount
        {
            get { return currentCount; }
            set { currentCount = value; CurrentCountChanged?.Invoke(); }
        }
        public Action CurrentCountChanged { get; set; }
    }
}

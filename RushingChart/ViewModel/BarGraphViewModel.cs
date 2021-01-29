using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace RushingChart.ViewModel
{
    public class BarGraphViewModel : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion


        #region Properties

        public string HelloWorld
        {
            get => m_helloWorld;
            private set
            {
                m_helloWorld = value;
                
            }
        }

        #endregion


        #region Private Variables

        private string m_helloWorld;

        #endregion




        #region Constructor

        public BarGraphViewModel()
        {
            m_helloWorld = "Hy bro";
        }

        #endregion

    }
}

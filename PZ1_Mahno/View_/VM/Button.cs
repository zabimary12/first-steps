using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;
using System.Collections.ObjectModel;
using PZ1_Mahno_;
using System.Runtime.CompilerServices;

namespace View_ {

    public class Button : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        private RelayCommand _Open_Add_Window;

        RelayCommand relayCommand;
        public ICommand Open_Add_Window => new RelayCommand(() =>
                                                            {

                                                                Add_Window taskWindow = new Add_Window();
                                                                taskWindow.Show();
                                                            },
    );

       
    }

     
}
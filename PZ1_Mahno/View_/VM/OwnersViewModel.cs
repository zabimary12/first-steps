﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using PZ1_Mahno_.Сlass_library;

namespace ViewModel
{
    public class OwnersViewModel : DependencyObject 
    {


        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(OwnersViewModel), new PropertyMetadata(null));

        public OwnersViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Owner.GetOwner());
        }

    }
}

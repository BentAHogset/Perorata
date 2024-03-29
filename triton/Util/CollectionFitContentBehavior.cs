﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace triton.Util
{
    public class CollectionFitContentBehavior : Behavior<CollectionView>
    {
        List<View> _itemsView;
        public CollectionView _control { get; set; }
        protected override void OnAttachedTo(CollectionView bindable)
        {
            base.OnAttachedTo(bindable);
            _control = bindable;
            _control.ChildAdded += ChildsAdded;
            _control.BindingContextChanged += ControlOnBindingContextChanged;
            _itemsView = new List<View>();
        }

        private void ControlOnBindingContextChanged(object sender, EventArgs e)
        {
            
        }

        protected override void OnDetachingFrom(CollectionView bindable)
        {
            base.OnDetachingFrom(bindable);
            _control.ChildAdded -= ChildsAdded;

            foreach (var item in _itemsView)
                item.SizeChanged -= ChildSize;
        }

        private void ChildsAdded(object sender, ElementEventArgs e)
        {
            var cell = (e.Element as View);
            cell.SizeChanged += ChildSize;
            _itemsView.Add(cell);
        }

        private void ChildSize(object sender, EventArgs e)
        {
            var cell = (sender as View);
            _control.HeightRequest = _control.HeightRequest + cell.Height;
        }
    }

}

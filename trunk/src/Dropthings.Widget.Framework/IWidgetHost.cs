﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dropthings.DataAccess;

namespace Dropthings.Widget.Framework
{
    public interface IWidgetHost
    {
        int ID { get; }
        void SaveState(string state);
        string GetState();
        void Expand();
        void Collaspe();
        void Maximize();
        void Restore();
        void Close();
        WidgetInstance WidgetInstance { get; set; }
        event Action<WidgetInstance,IWidgetHost> Deleted;
        void ShowSettings();
        void HideSettings();
        void Refresh(IWidget widget);

        EventBrokerService EventBroker { get; set; }        
    }
}

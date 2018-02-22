﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Workflow.Common.Enums;
using Workflow.Common.Interface;
using WorkFlow.Extensions;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace WorkFlow.Controls.Workflow
{
    public sealed partial class WorkFlowItemContentBase : UserControl, IWorkFlowItemContent
    {
        public WorkFlowItemContentBase()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        public IWorkFlowItemContentContext ItemContentContext { get; set; }

        public void AddConnector(IConnector connector)
        {
            if (connector.Type == ConnectorType.In) inputConnectors.Children.Add(connector.Element.ToFrameworkElement());
            else outputConnectors.Children.Add(connector.Element.ToFrameworkElement());
            
            
        }
    }
}
﻿#pragma checksum "D:\Git\Web\GMS\Src\GMS.Web.OrgChart\OrgChart.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F60636B58ED760B7D0047CE9E58B39E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.0
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using GMS.Web.OrgChart.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace GMS.Web.OrgChart {
    
    
    public partial class OrgChart : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal GMS.Web.OrgChart.Controls.BranchNode mainBranchNode;
        
        internal System.Windows.Controls.Button save;
        
        internal GMS.Web.OrgChart.Controls.BranchNode unAllocateStaffNode;
        
        internal GMS.Web.OrgChart.Controls.BranchNode unAllocateBranchNode;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/GMS.Web.OrgChart;component/OrgChart.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.mainBranchNode = ((GMS.Web.OrgChart.Controls.BranchNode)(this.FindName("mainBranchNode")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.unAllocateStaffNode = ((GMS.Web.OrgChart.Controls.BranchNode)(this.FindName("unAllocateStaffNode")));
            this.unAllocateBranchNode = ((GMS.Web.OrgChart.Controls.BranchNode)(this.FindName("unAllocateBranchNode")));
        }
    }
}


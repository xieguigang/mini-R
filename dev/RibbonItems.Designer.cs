//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using RibbonLib;
using RibbonLib.Controls;
using RibbonLib.Interop;

    partial class RibbonItems
    {
        private static class Cmd
        {
            public const uint cmdApplicationMenu = 1000;
            public const uint cmdButtonNew = 1001;
            public const uint cmdButtonOpen = 1002;
            public const uint cmdButtonSave = 1003;
            public const uint cmdButtonExit = 1004;
        }

        // ContextPopup CommandName

        public Ribbon Ribbon { get; private set; }
        public RibbonApplicationMenu ApplicationMenu { get; private set; }
        public RibbonButton ButtonNew { get; private set; }
        public RibbonButton ButtonOpen { get; private set; }
        public RibbonButton ButtonSave { get; private set; }
        public RibbonButton ButtonExit { get; private set; }

        public RibbonItems(Ribbon ribbon)
        {
            if (ribbon == null)
                throw new ArgumentNullException(nameof(ribbon), "Parameter is null");
            this.Ribbon = ribbon;
            ApplicationMenu = new RibbonApplicationMenu(ribbon, Cmd.cmdApplicationMenu);
            ButtonNew = new RibbonButton(ribbon, Cmd.cmdButtonNew);
            ButtonOpen = new RibbonButton(ribbon, Cmd.cmdButtonOpen);
            ButtonSave = new RibbonButton(ribbon, Cmd.cmdButtonSave);
            ButtonExit = new RibbonButton(ribbon, Cmd.cmdButtonExit);
        }

    }

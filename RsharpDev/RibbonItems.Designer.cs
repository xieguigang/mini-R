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
            public const uint cmdButtonNew = 1005;
            public const uint cmdButtonOpen = 1006;
            public const uint cmdButtonSave = 1007;
            public const uint cmdAbout = 16;
            public const uint cmdLicense = 25;
            public const uint cmdConfig = 26;
            public const uint cmdClose = 24;
            public const uint cmdHelp = 14;
            public const uint cmdSoluationTabGroup = 20;
            public const uint cmdSolutionTab = 22;
            public const uint cmdViewProperty = 21;
            public const uint cmdTabMain = 1001;
            public const uint cmdGroupCommon = 1002;
            public const uint cmdStartPage = 28;
            public const uint cmdGroupSimple = 1003;
            public const uint cmdConfigServer = 23;
            public const uint cmdRunScript = 18;
            public const uint cmdRunRemote = 19;
            public const uint cmdConsole = 27;
            public const uint cmdGroupAdvanced = 1004;
            public const uint cmdButtonSwitchToSimple = 1012;
            public const uint cmdButtonDropA = 1008;
            public const uint cmdButtonDropB = 1009;
            public const uint cmdButtonDropC = 1010;
        }

        // ContextPopup CommandName

        public Ribbon Ribbon { get; private set; }
        public RibbonButton ButtonNew { get; private set; }
        public RibbonButton ButtonOpen { get; private set; }
        public RibbonButton ButtonSave { get; private set; }
        public RibbonButton About { get; private set; }
        public RibbonButton License { get; private set; }
        public RibbonButton Config { get; private set; }
        public RibbonButton Close { get; private set; }
        public RibbonHelpButton Help { get; private set; }
        public RibbonTabGroup SoluationTabGroup { get; private set; }
        public RibbonTab SolutionTab { get; private set; }
        public RibbonButton ViewProperty { get; private set; }
        public RibbonTab TabMain { get; private set; }
        public RibbonGroup GroupCommon { get; private set; }
        public RibbonButton StartPage { get; private set; }
        public RibbonGroup GroupSimple { get; private set; }
        public RibbonButton ConfigServer { get; private set; }
        public RibbonButton RunScript { get; private set; }
        public RibbonButton RunRemote { get; private set; }
        public RibbonButton Console { get; private set; }
        public RibbonGroup GroupAdvanced { get; private set; }
        public RibbonButton ButtonSwitchToSimple { get; private set; }
        public RibbonButton ButtonDropA { get; private set; }
        public RibbonButton ButtonDropB { get; private set; }
        public RibbonButton ButtonDropC { get; private set; }

        public RibbonItems(Ribbon ribbon)
        {
            if (ribbon == null)
                throw new ArgumentNullException(nameof(ribbon), "Parameter is null");
            this.Ribbon = ribbon;
            ButtonNew = new RibbonButton(ribbon, Cmd.cmdButtonNew);
            ButtonOpen = new RibbonButton(ribbon, Cmd.cmdButtonOpen);
            ButtonSave = new RibbonButton(ribbon, Cmd.cmdButtonSave);
            About = new RibbonButton(ribbon, Cmd.cmdAbout);
            License = new RibbonButton(ribbon, Cmd.cmdLicense);
            Config = new RibbonButton(ribbon, Cmd.cmdConfig);
            Close = new RibbonButton(ribbon, Cmd.cmdClose);
            Help = new RibbonHelpButton(ribbon, Cmd.cmdHelp);
            SoluationTabGroup = new RibbonTabGroup(ribbon, Cmd.cmdSoluationTabGroup);
            SolutionTab = new RibbonTab(ribbon, Cmd.cmdSolutionTab);
            ViewProperty = new RibbonButton(ribbon, Cmd.cmdViewProperty);
            TabMain = new RibbonTab(ribbon, Cmd.cmdTabMain);
            GroupCommon = new RibbonGroup(ribbon, Cmd.cmdGroupCommon);
            StartPage = new RibbonButton(ribbon, Cmd.cmdStartPage);
            GroupSimple = new RibbonGroup(ribbon, Cmd.cmdGroupSimple);
            ConfigServer = new RibbonButton(ribbon, Cmd.cmdConfigServer);
            RunScript = new RibbonButton(ribbon, Cmd.cmdRunScript);
            RunRemote = new RibbonButton(ribbon, Cmd.cmdRunRemote);
            Console = new RibbonButton(ribbon, Cmd.cmdConsole);
            GroupAdvanced = new RibbonGroup(ribbon, Cmd.cmdGroupAdvanced);
            ButtonSwitchToSimple = new RibbonButton(ribbon, Cmd.cmdButtonSwitchToSimple);
            ButtonDropA = new RibbonButton(ribbon, Cmd.cmdButtonDropA);
            ButtonDropB = new RibbonButton(ribbon, Cmd.cmdButtonDropB);
            ButtonDropC = new RibbonButton(ribbon, Cmd.cmdButtonDropC);
        }

    }

﻿using System.Collections.Generic;

namespace ET.Client.EUI
{
    public interface IUILogic
    {
        
    }

    public interface IUIScrollItem
    {
        
    }
    
    [ComponentOf(typeof(Scene))]
    public class UIComponent : Entity,IAwake,IDestroy
    {
        public Dictionary<int, UIBaseWindow> AllWindowsDic     = new Dictionary<int, UIBaseWindow>();
        public List<WindowID> UIBaseWindowlistCached           = new List<WindowID>();
        public Dictionary<int, UIBaseWindow> VisibleWindowsDic = new Dictionary<int, UIBaseWindow>();
        public Queue<WindowID> StackWindowsQueue               = new Queue<WindowID>();
        public bool IsPopStackWndStatus                        = false;

    }
}
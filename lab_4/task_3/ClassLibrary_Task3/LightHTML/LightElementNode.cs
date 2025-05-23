﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ClassLibrary_Task3.LightHTML
{
    public class LightElementNode : LightNode
    {
        private Dictionary<string, List<Action>> _eventListeners = new Dictionary<string, List<Action>>();
        public string TagName { get; }
        public DisplayType Display { get; }
        public bool SelfClosing { get; }
        public List<string> CssClasses { get; } = new List<string>();
        public List<LightNode> Children { get; } = new List<LightNode>();

        public LightElementNode(string tagName, DisplayType DisplayType = DisplayType.Block, bool selfClosing = false)
        {
            TagName = tagName;
            Display = DisplayType;
            SelfClosing = selfClosing;
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public void AddEventListener(string eventName, Action callback)
        {
            if (!_eventListeners.ContainsKey(eventName))
            {
                _eventListeners[eventName] = new List<Action>();
            }
            _eventListeners[eventName].Add(callback);
        }

        public void DispatchEvent(string eventName)
        {
            if (_eventListeners.TryGetValue(eventName, out var listeners))
            {
                foreach (var listener in listeners)
                {
                    listener.Invoke();
                }
            }
            else
            {
                Console.WriteLine($"No listeners for event: {eventName}");
            }
        }

        public override string InnerHTML
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }

        public override string OuterHTML
        {
            get
            {
                string classAttr = CssClasses.Count > 0 ? " class=\"" + string.Join(" ", CssClasses) + "\"" : " ";
                if (SelfClosing)
                {
                    return "<" + TagName + classAttr + "/>";
                }
                else
                {
                    return "<" + TagName + classAttr + ">" + InnerHTML + "</" + TagName + ">";
                }
            }
        }
    }
}
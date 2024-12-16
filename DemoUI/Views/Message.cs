using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUI.Views
{
    internal class Message1
    {
        internal HorizontalAlignment MsgAlignment { get; set; } = HorizontalAlignment.Right;
        internal string MsgText { get; set; } = "Default Text";
        internal string MsgDateTime { get; set; } = "1/1/1200";
        internal Brush MsgColor { get; private set; } = new SolidColorBrush(Colors.DodgerBlue);
        internal Message1() { }
        internal Message1(string text, string dateTime, HorizontalAlignment alignment = HorizontalAlignment.Right)
        { 
            MsgText = text;
            MsgDateTime = dateTime;
            MsgAlignment = alignment;

            if(alignment == HorizontalAlignment.Left)
            {
                MsgColor = new SolidColorBrush(Colors.DarkGray);
            }
            
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panuon.UI.Silver.Core
{
    public class DragAreaEventArgs : RoutedEventArgs
    {
        public DragAreaEventArgs(Point startPosition, Point endPosition, TimeSpan duration, RoutedEvent routedEvent) : base(routedEvent)
        {
            StartPosition = startPosition;
            EndPosition = endPosition;
            Duration = duration;
        }

        public Point StartPosition { get; set; }

        public Point EndPosition { get; set; }

        public TimeSpan Duration { get; set; }

        public Size Size
        {
            get
            {
                return new Size()
                {
                    Height = Math.Abs(StartPosition.Y - EndPosition.Y),
                    Width = Math.Abs(StartPosition.X - EndPosition.X),
                };
            }
        }
    }

    public delegate void DragAreaEventHandler(object sender, DragAreaEventArgs e);
}

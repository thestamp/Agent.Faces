﻿using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Input;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;

namespace SimpleFace
{
    public class Program : Microsoft.SPOT.Application
    {
        /// <summary>
        /// 1000 = 1 second
        /// </summary>
        private static int updateSpeed = 1000*5;

        public static void Main()
        {
            //setup our watch face, and wait until we can paint, etc.
            var face = new WatchFace();
            face.OnSetupCompleted += watchFace_OnSetupCompleted;
            face.OnPaint += watchFace_OnPaint;
            face.OnComplete += face_OnComplete;
            face.Start(updateSpeed);

        }

        static void face_OnComplete(WatchFace face, Device device)
        {
            Debug.Print("Face paint complete");
        }

        static void watchFace_OnPaint(WatchFace face, Device device)
        {
            
            Debug.Print("Face paint starting");

            device.Painter.PaintCentered(device.HourMinute, device.DefaultFont, Color.White);

            //print full date along the bottom
            device.Painter.PaintCentered(device.ShortDate, device.NinaBFont, Color.White, Device.AgentSize - device.Border.FooterHeight + 1);
            
            //print the day of the week in the footer
            //device.Painter.PaintCentered(device.DayOfWeek, device.NinaBFont, Color.White, Device.AgentSize - device.Border.FooterHeight + 1);
        }

        static void watchFace_OnSetupCompleted(WatchFace face, Device device)
        {
            device.Border = new Border() { Thickness = 1, FooterHeight = device.NinaBFont.Height + 2, HeaderHeight = 10 };     
        }



    }
}
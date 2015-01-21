﻿using System;

namespace WoWEditor6.Utils
{
    class TimeManager
    {
        public static TimeManager Instance { get; } = new TimeManager();

        private DateTime mStartTime = DateTime.Now;

        public TimeSpan GetTime()
        {
            return DateTime.Now - mStartTime;
        }

        public void Reset()
        {
            mStartTime = DateTime.Now;
        }
    }
}

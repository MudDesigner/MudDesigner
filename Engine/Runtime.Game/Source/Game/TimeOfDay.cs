﻿namespace MudDesigner.Runtime.Game
{
    public struct TimeOfDay : ITimeOfDay
    {
        public TimeOfDay(int hour) : this(hour, 0, 0, 0)
        {
        }

        public TimeOfDay(int hour, int minute) : this(hour, minute, 0, 0)
        {
        }

        public TimeOfDay(int hour, int minute, int second) : this(hour, minute, second, 0)
        {
        }

        public TimeOfDay(int hour, int minute, int second, int millisecond)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
            this.Millisecond = millisecond;
        }

        public TimeOfDay(IUniverseClock universeClock, ITimeOfDay timezoneOffset)
        {
            ITimeOfDay universeTime = universeClock.GetCurrentUniverseTime();
            this.Hour = universeTime.Hour - timezoneOffset.Hour;
            this.Minute = universeTime.Hour - timezoneOffset.Minute;
            this.Second = universeTime.Hour - timezoneOffset.Second;
            this.Millisecond = universeTime.Hour - timezoneOffset.Millisecond;
        }

        public int Hour { get; }

        public int Minute { get; }

        public int Second { get; }

        public int Millisecond { get; }
    }
}

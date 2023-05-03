using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramming
{
    class StopWatch
    {
		public long startTimer = 0;
		public long stopTimer = 0;
		public long elapsed;

		//to start timer
		public void Start()
		{
			startTimer = DateTime.Now.Ticks;
			Console.WriteLine("Start Time is: " + startTimer);
		}

		// to stop timer
		public void Stop()
		{
			stopTimer = DateTime.Now.Ticks;
			Console.WriteLine("Stop Time is: " + stopTimer);
		}

		public  long GetElapsedTime()
		{
			elapsed = stopTimer - startTimer;
			return elapsed;
		}

	}
}

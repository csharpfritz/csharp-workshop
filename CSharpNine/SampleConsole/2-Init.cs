using System;
using static System.Console;

namespace SampleConsole {

	public class Init {

		public static void Demo() {

			Demo1();

		}

#region Demo1		

		public static void Demo1() {

			var l = new LogEntry {
				Severity = LogSeverity.Error,
				LogTimestampUtc = DateTime.UtcNow,
				Description = "Bad dates..."
			};

			//l.Severity = LogSeverity.Warning;

			WriteLine(l);

		}

		public struct LogEntry {

			// public LogEntry()
			// {
			// 		Console.WriteLine("Parameterless Constructor called");
			// }

			public LogEntry(LogSeverity severity, DateTime timestamp, string desc) {
				Severity = severity;
				LogTimestampUtc = timestamp;
				Description = desc;
			}

			public LogSeverity Severity {get; init;}

			public DateTime LogTimestampUtc {get; init;}

			public string Description {get; init;}

			public override string ToString()
			{
				return $"{LogTimestampUtc} - {Severity} - {Description}";
			}

		}

		public enum LogSeverity {
			Error,
			Warning,
			Debug,
			Info
		}

#endregion

	}

}
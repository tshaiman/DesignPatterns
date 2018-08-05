using System;

namespace Immutable
{
	public struct CalendarDay : ICloneable
	{
		public  CalendarDay(int day,int month, string data)
		{
			this.day=day;
			this.month=month;
			this.data=data;
		}
		public int day ;//public - just to simplify code
		public int month;
		public string data;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
	public class Calendar:ICloneable
	{
		private CalendarDay[] calendarDays;
        private int CalanderId;
        private string Name;
		public Calendar()
		{
			calendarDays =  new CalendarDay[7];//in real ->365}
		}
		public Calendar(CalendarDay[] calendarDays)
		{
			
			this.calendarDays=calendarDays;
		}
		public object Clone()
	{
            Calendar copy = (Calendar)MemberwiseClone();
            copy.calendarDays = new CalendarDay[7];

            for (int i = 0; i < 7; i++)
                copy.calendarDays[i] = (CalendarDay)this.calendarDays[i].Clone();
			return copy;
	}
		
		
		public Calendar UpdateCalendar(CalendarDay cDay)
		{
			Calendar tmpCal = (Calendar)this.Clone();
			tmpCal.calendarDays[cDay.day-1]=cDay;
			return tmpCal;
		}
		public CalendarDay[] CalendarDays
		{
			get{return calendarDays;}
		}
		public void Print()
		{
			for(int i=0;i<7;i++)
				System.Console.WriteLine(i+1+" " + this.calendarDays[i].day.ToString()+" "+
					this.calendarDays[i].month.ToString()+" "+this.calendarDays[i].data);
			
		}


			

	}
	

}

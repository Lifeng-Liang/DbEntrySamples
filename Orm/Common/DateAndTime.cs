using System;
using Leafing.Data.Definition;

namespace OrmCommon
{
    public class DateAndTime : DbObjectModel<DateAndTime>
    {
        public Date StartDate { get; set; }
        public Time StartTime { get; set; }
    }
}

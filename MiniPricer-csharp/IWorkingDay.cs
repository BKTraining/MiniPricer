using System;

namespace MiniPricer_csharp
{
    public interface IWorkingDay
    {
        int GetWorkingDay(DateTime start, DateTime end);
    }
}
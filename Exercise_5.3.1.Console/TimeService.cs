namespace Exercise_5._3._1.API
{
    public class TimeService : ITimeService
    {
        private ITimePrintingService _printingService;
        public TimeService(ITimePrintingService printingService)
        {
            _printingService = printingService;
        }

        public DateTime GetTime()
        {
            var time = DateTime.Now;
            _printingService.PrintTime(time);
            return time;
        }
    }
}

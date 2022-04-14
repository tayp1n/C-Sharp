using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Runtime.Serialization;
namespace ConsoleApplication1
{
    [Serializable]
    public class Payment
    {
        public static bool Flag { get; set; } = true;
        
        public double _DayPayment; // оплата за день
        public double _DayCount; // кол-во дней
        public double _DayFine; // штраф за 1 день задержки зарп.
        public double _DayDelay; // кол-во дней задержки зарплаты

        public double _daysum;
        public double _fine;
        public double _sum;
        public double DaySum //- сумам к оплате без штрафа
        {
            get => _daysum;
            set => _daysum = value;
        }

        public double Fine//- штраф
        {
            get => _fine;
            set => _fine = value;
        }

        public double Sum //- общая сумма к оплате
        {
            get => _sum;
            set => _sum = value;
        }

        //--------------------------------------------------------//
        
        public Payment()
        {
            _daysum = _DayPayment * _DayCount;
            _fine = _DayPayment * _DayCount;
            _sum = DaySum + Fine;
        }

        public Payment(double dayPayment, double dayCount, double dayFine, double dayDelay, bool flag)
        {
            _DayPayment = dayPayment;
            _DayCount = dayCount;
            _DayFine = dayFine;
            _DayDelay = dayDelay;
            Flag = flag;
            _daysum = _DayPayment * _DayCount;
            _fine = _DayPayment * _DayCount;
            _sum = DaySum + Fine;
        }
        

        public override string ToString()
        {
            return $"DayPayment: {_DayPayment}, DayCount: {_DayCount}, " +
                   $"DayFine: {_DayFine}, DayDelay: {_DayDelay} " +
                   $"DaySum: {DaySum}, Fine: {Fine}, Sum: {Sum}";
        }
        
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("DayPayment", _DayPayment);
            info.AddValue("DayCount", _DayCount);
            info.AddValue("DayFine", _DayFine);
            info.AddValue("DayDelay", _DayDelay);

            if (Flag)
            {
                info.AddValue("DaySum", DaySum);
                info.AddValue("Fine", Fine);
                info.AddValue("Sum", Sum);
            }
                
        }
        private Payment(SerializationInfo info, StreamingContext context)
        {
            _DayPayment = info.GetInt32("DayPayment");
            _DayCount = info.GetInt32("DayCount");
            _DayFine = info.GetInt32("DayCount");
            _DayDelay = info.GetInt32("DayCount");
            Flag = info.GetBoolean("Flag");

            if (Flag)
            {
                DaySum = info.GetInt32("DaySum");
                Fine = info.GetInt32("Fine");
                Sum = info.GetInt32("Sum");
            }
                
        }

    }
}
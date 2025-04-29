using CleanCode;

namespace DirtyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSheetEntries = getTimeSheetEntriesFromUser();
            var companies = new CompanyService().GetCompanies();
            foreach (var company in companies)
            {
                var total = getTotalBill(timeSheetEntries, company);
                sendSimulatingMail(company, total);
            }
            ExtraPaymentOptions options = new ExtraPaymentOptions()
            {
                MaxHourInAWeek = 40,
                MaxPrice = 15,
                StandardPrice = 10

            }
                ;
            var extraBill = getExtraPaymentForWork(timeSheetEntries, options);
            Console.WriteLine($"You will get paid ${extraBill} for your work.");            
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }



        static List<TimeSheetEntry> getTimeSheetEntriesFromUser()
        {
            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();

            string answer = string.Empty;
            do
            {
                TimeSheetEntry timeSheetEntry = getWorkInfo();
                timeSheetEntries.Add(timeSheetEntry);
                Console.Write($"Do you want to enter more time ({UserAnswers.YES}/{UserAnswers.NO}): ");

                answer = Console.ReadLine();
            }
            while (answer.ToLower() == UserAnswers.YES);



            return timeSheetEntries;
        }

        private static TimeSheetEntry getWorkInfo()
        {
            Console.Write("Enter what you did: ");
            string workDescription = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            string rawTimeWorked = Console.ReadLine();

            double timeForWork = parseTimeValue(rawTimeWorked);

            TimeSheetEntry timeSheetEntry = new TimeSheetEntry
            {
                HoursWorked = timeForWork,
                WorkDone = workDescription
            };
            return timeSheetEntry;
        }

        private static double parseTimeValue(string rawTimeWorked)
        {
            double timeForWork;
            while (!double.TryParse(rawTimeWorked, out timeForWork))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given");
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
            }

            return timeForWork;
        }

        static double getTotalBill(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            double totalTime = 0;           

            string lowerCompanyName = company.Name.ToLower();         
            totalTime = timeSheetEntries.Where(entry=>entry.WorkDone.ToLower().Contains(lowerCompanyName))
                                        .Sum(entry=> entry.HoursWorked);

            double totalBill = totalTime * company.HourlyRate;
            return totalBill;
            //Console.WriteLine($"Simulating Sending email to {companyName}");
            //Console.WriteLine("Your bill is $" + (totalTime * hourlyRate) + " for the hours worked.");

        }

        private static void sendSimulatingMail(Company company, double total)
        {
            Console.WriteLine($"Simulating mail to {company.Name}");
            Console.WriteLine($"Total bill is: ${total} ");
        }

        static double getExtraPaymentForWork(List<TimeSheetEntry> timeSheetEntries, ExtraPaymentOptions extraPaymentOptions)
        {
            double totalTime = 0;
            var extraPayment = 0.0;
            totalTime = timeSheetEntries.Sum(entry => entry.HoursWorked);
            if (totalTime > extraPaymentOptions.MaxHourInAWeek)
            {
                var moreThenWeek = (totalTime - extraPaymentOptions.MaxHourInAWeek) * extraPaymentOptions.MaxPrice;
                var standardInWeek = extraPaymentOptions.MaxHourInAWeek * extraPaymentOptions.StandardPrice;
                extraPayment = moreThenWeek + standardInWeek;

            }
            else
            {
                extraPayment = totalTime * extraPaymentOptions.StandardPrice;

            }
            return extraPayment;
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }
}


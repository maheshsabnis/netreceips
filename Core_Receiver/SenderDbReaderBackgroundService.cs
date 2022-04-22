using Core_Receiver.Models;

using Microsoft.EntityFrameworkCore;

namespace Core_Receiver
{
    public class SenderDbReaderBackgroundService : BackgroundService
    {
        private readonly SenderContext senderContext;
        private readonly ReceiverContext receiverContext;
        private List<Employee> empsSender;
        private List<MyEmployee> empsReceiver;

        /// <summary>
        /// Inject the IServiceProvider to Read the Services Hosted into the
        /// Dependency COntainer
        /// </summary>
        public SenderDbReaderBackgroundService(IServiceProvider provider)
        {
            // CreateScope(): Read the Cotainer in the current score 
            // so that service form it can be read
            var scope = provider.CreateScope();
            // Read the Instance of the SenderCOntext
            senderContext = scope.ServiceProvider.GetService<SenderContext>();
           receiverContext = scope.ServiceProvider.GetService<ReceiverContext>();
            empsReceiver = new List<MyEmployee>();
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Logic for Backgrud App

            // Reader Sender Database
            empsSender = await senderContext.Employees.ToListAsync();
            foreach (var emp in empsSender)
            {
                empsReceiver.Add(new Models.MyEmployee()
                {
                    EmpNo = emp.EmpNo,
                    EmpName = emp.EmpName
                });
            }
            // Add this data into the Receiver Database
            await receiverContext.MyEmployees.AddRangeAsync(empsReceiver);
            await receiverContext.SaveChangesAsync();
        }
    }
}

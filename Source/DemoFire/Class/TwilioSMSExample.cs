using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace DemoFire.Class
{
    public class TwilioSMSExample
    {
        public void SendSMS(string to, string from, string message)
        {
            // Thông tin từ Twilio
            string accountSid = "ACc4138e8ab112636d76e0df1b657a2768";  // Thay thế bằng Account SID của bạn
            string authToken = "cffe8b037a34b43cbe219bbed8688c8c";    // Thay thế bằng Auth Token của bạn

            // Khởi tạo Twilio client
            TwilioClient.Init(accountSid, authToken);

            // Gửi tin nhắn
            var sentMessage = MessageResource.Create(
                to: new PhoneNumber(to),       // Số điện thoại người nhận
                from: new PhoneNumber(from),   // Số điện thoại Twilio của bạn
                body: message                  // Tin nhắn bạn muốn gửi
            );

            // In ra thông tin tin nhắn đã gửi
            Console.WriteLine($"Message sent: {sentMessage.Sid}");
        }

        public void ListMessages()
        {
            // Lấy danh sách tin nhắn đã gửi và nhận
            string accountSid = "ACc4138e8ab112636d76e0df1b657a2768"; // Thay bằng Account SID của bạn
            string authToken = "cffe8b037a34b43cbe219bbed8688c8c";   // Thay bằng Auth Token của bạn

            // Khởi tạo Twilio client
            TwilioClient.Init(accountSid, authToken);

            // Lấy các tin nhắn
            var messages = MessageResource.Read();

            Console.WriteLine("Listing all messages...");
            foreach (var message in messages)
            {
                Console.WriteLine($"SID: {message.Sid}, To: {message.To}, From: {message.From}, Body: {message.Body}");
            }
        }

        // Phương thức giả lập nhận tin nhắn (Chỉ in ra console)
        public void ReceiveSMS(string from, string message)
        {
            // Đây chỉ là ví dụ, Twilio không tự động gọi phương thức này
            // Nếu bạn muốn thực sự nhận tin nhắn, bạn phải cấu hình webhook trong Twilio console
            Console.WriteLine($"Received SMS from {from}: {message}");
        }
    }
}

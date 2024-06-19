using FastCarServer.Application.Common.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;

namespace FastCarServer.Infrastructure.Services
{
    public class VerificationService : IVerificationService
    {
        public IConfiguration Configuration { get; }
        public VerificationService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<string> VerifyPhoneNumber(string number)
        {
            Random random = new Random();
            int verificationCode = random.Next(1000, 10000);
            TwilioClient.SetLogLevel("debug");
            TwilioClient.Init(Configuration["Twilio:Username"], Configuration["Twilio:Password"]);
            var message = MessageResource.Create(
                new PhoneNumber(number),
                from: new PhoneNumber("+12292673194"),
                body: $"Код верификации: {verificationCode}. Никому не говорите код верификации!"
            );

            Console.WriteLine(message.ErrorMessage);

            return verificationCode;
        }
    }
}

using Grpc.Core;
using GRPCServiceProviderSample.Protos;

namespace GRPCServiceProviderSample.Services;

public class SMSService : SMS.SMSBase
{
    public async override Task<SendSMSResponse> Send(SendSMSRequest request, ServerCallContext context)
    {
        //send sms
        var smsResponse = new SendSMSResponse { IsSent = true };
        return await Task.FromResult(smsResponse);
    }
}
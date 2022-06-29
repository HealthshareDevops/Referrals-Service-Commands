using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MessageLambda;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public void FunctionHandler(SQSEvent evnt, ILambdaContext context)
    {
        context.Logger.LogInformation($"INFO: Function.FunctionHandler start...");
        foreach (var message in evnt.Records)
        {
            context.Logger.LogInformation($"INFO: Function.FunctionHandler - MessageId ({message.MessageId}) processing.");
        }
        context.Logger.LogInformation($"INFO: Function.FunctionHandler end...");
    }
}

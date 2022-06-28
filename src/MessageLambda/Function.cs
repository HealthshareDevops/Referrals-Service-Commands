using Amazon.Lambda.Core;

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
    public void FunctionHandler(ILambdaContext context)
    {
        context.Logger.LogInformation($"INFO: Function.FunctionHandler start...");
        context.Logger.LogInformation($"INFO: Function.FunctionHandler - Yeah, yeah !!!");
        context.Logger.LogInformation($"INFO: Function.FunctionHandler end...");
    }
}

namespace CoreAdmin.Infrastructure.Util;

/// <inheritdoc cref="CoreAdmin.Infrastructure.Util.ISmsSender" />
public class SmsSender : ISmsSender, IScoped
{
    /// <inheritdoc />
    public void Send(long mobile, string content)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public void SendCode(long mobile, string code) { }
}
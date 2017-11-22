using SmtpServer;
using SmtpServer.Authentication;

public class UserAuthenticatorFact : IUserAuthenticatorFactory
{
    private IUserAuthenticator _authenticator;

    public UserAuthenticatorFact(IUserAuthenticator authenticator)
    {
        _authenticator = authenticator;
    }

    #region Implementation of IUserAuthenticatorFactory

    public IUserAuthenticator CreateInstance(ISessionContext context)
    {
        return _authenticator;
    }

    #endregion
}
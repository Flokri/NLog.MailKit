using System;
using System.Threading;
using System.Threading.Tasks;
using SmtpServer;
using SmtpServer.Authentication;

namespace NLog.MailKit.Tests
{
    public class UserAuthenticator : IUserAuthenticator
    {
        private string _username;
        private string _pasword;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public UserAuthenticator(string username, string pasword)
        {
            _username = username;
            _pasword = pasword;
        }



        public Task<bool> AuthenticateAsync(ISessionContext context, string user, string password, CancellationToken cancellationToken)
        {
            return Task.FromResult(_username == user && _pasword == password);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDevice
{
    /// <summary>
    /// Interface used to pass a message parser to <see cref="InterfaceDevice"/>.
    /// </summary>
    public interface IIncomingMessageParser
    {
        /// <summary>
        /// Parse the message parameter into a class of type <see cref="IMessage" />.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        IMessage Parse(string message);
    }
}

using System;

namespace HypeProxy.Constants;

[Flags]
public enum StatusTypes
{
    /// <summary>
    /// 
    /// </summary>
    HqChannel,
    
    /// <summary>
    /// Notify the user by throwing a `Notification`.
    /// </summary>
    Notify,
    
    /// <summary>
    /// Pin the message in the telegram channel.
    /// </summary>
    Pinned
}
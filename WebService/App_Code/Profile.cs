using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Profile information.
/// </summary>
[Serializable]
public class Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Profile"/> class.
    /// </summary>
    public Profile()
    {
            
    }

    /// <summary>
    /// Gets the name.
    /// </summary>
    public string Name { get;  set; }

    /// <summary>
    /// Gets the email.
    /// </summary>
    public string Email { get;  set; }

    /// <summary>
    /// Gets the phone no.
    /// </summary>
    public string PhoneNo { get;  set; }

    /// <summary>
    /// Gets the message.
    /// </summary>
    public string Message { get;  set; }
}
﻿//-----------------------------------------------------------------------
// <copyright file="CslaActionEventArgs.cs" company="Marimer LLC">
//     Copyright (c) Marimer LLC. All rights reserved.
//     Website: https://cslanet.com
// </copyright>
// <summary>Event args for an action.</summary>
//-----------------------------------------------------------------------

namespace Csla.Windows
{
  /// <summary>
  /// Event args for an action.
  /// </summary>
  public class CslaActionEventArgs : EventArgs
  {
    /// <summary>
    /// Creates an instance of the object.
    /// </summary>
    /// <param name="commandName">
    /// Name of the command.
    /// </param>
    public CslaActionEventArgs(string commandName)
    {
      CommandName = commandName;
    }

    /// <summary>
    /// Gets the name of the command.
    /// </summary>
    public string CommandName { get; }
  }
}
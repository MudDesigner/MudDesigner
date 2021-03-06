﻿//-----------------------------------------------------------------------
// <copyright file="GameMessage.cs" company="Sully">
//     Copyright (c) Johnathon Sullinger. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace MudDesigner.Engine.Game
{
    /// <summary>
    /// A standard information message generated by the game
    /// </summary>
    //[MessageVerbosity(MessageScope.Low)]
    public class GameMessage : MessageBase<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameMessage"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public GameMessage(string message)
        {
            this.Content = message;
        }
    }
}

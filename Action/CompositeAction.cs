﻿//     File:  ScoreAI/ScoreAI/CompositeAction.cs
//     Copyright (C) 2016 Rethought and SupportExTraGoZ
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
//     Created: 20.11.2016 7:30 PM
//     Last Edited: 20.11.2016 8:29 PM

namespace ScoreAI.Action
{
    #region Using Directives

    using System.Collections.Generic;

    using ScoreAI.Context;

    #endregion

    /// <summary>
    ///     The composite action.
    /// </summary>
    public class CompositeAction<T> : ActionBase<T> where T : IContext
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the actions.
        /// </summary>
        /// <value>
        ///     The actions.
        /// </value>
        public List<IAction<T>> Actions { get; set; } = new List<IAction<T>>();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Executes the action
        /// </summary>
        /// <param name="context">The context.</param>
        public override void Execute(T context)
        {
            foreach (var action in this.Actions)
            {
                action.Execute(context);
            }
        }

        #endregion
    }
}
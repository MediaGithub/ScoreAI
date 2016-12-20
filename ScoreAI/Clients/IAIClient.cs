﻿//     File:  ScoreAI/ScoreAI/IAIClient.cs
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

namespace ScoreAI
{
    #region Using Directives

    using ScoreAI.Selector;

    #endregion

    /// <summary>
    ///     The AiClient interface.
    /// </summary>
    public interface IAIClient
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the selector.
        /// </summary>
        SelectorBase RootSelector { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Ticks this instance.
        /// </summary>
        void Tick();

        #endregion
    }
}
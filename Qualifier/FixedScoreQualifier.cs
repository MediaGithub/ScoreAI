﻿//     File:  ScoreAI/ScoreAI/FixedScoreQualifier.cs
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

namespace ScoreAI.Qualifier
{
    #region Using Directives

    using ScoreAI.Context;

    #endregion

    /// <summary>
    ///     The fixed fixedScore qualifier.
    /// </summary>
    public class FixedScoreQualifier<T> : QualifierBase<T> where T : IContext
    {
        #region Fields

        /// <summary>
        ///     The fixed fixedScore.
        /// </summary>
        private readonly float fixedScore;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="FixedScoreQualifier" /> class.
        /// </summary>
        /// <param name="fixedScore">
        ///     The fixedScore.
        /// </param>
        public FixedScoreQualifier(float fixedScore = 0f)
        {
            this.fixedScore = fixedScore;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The fixedScore.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        ///     The <see cref="float" />.
        /// </returns>
        public override float Score(T context)
        {
            return this.fixedScore;
        }

        #endregion
    }
}
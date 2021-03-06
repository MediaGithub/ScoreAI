﻿//     File:  ScoreAI/ScoreAI/QualifierWithScorersBase.cs
//     Copyright (C) 2016 Rethought
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
//     Created: 20.11.2016 7:30 PM
//     Last Edited: 31.01.2017 6:14 AM
namespace ScoreAI.Qualifier
{
    #region Using Directives

    using System.Collections.Generic;

    using ScoreAI.Scorer;

    #endregion

    /// <summary>
    ///     The qualifier base.
    /// </summary>
    public abstract class QualifierWithScorersBase<T> : IQualifier<T>
    {
        protected QualifierWithScorersBase(T qualifiedItem, IList<IScorer> scorerList)
        {
            this.QualifiedItem = qualifiedItem;
            this.ScorerList = scorerList;
        }

        protected QualifierWithScorersBase()
        {
        }

        public T QualifiedItem { get; set; }

        /// <summary>
        ///     Gets or sets the scorers.
        /// </summary>
        public IList<IScorer> ScorerList { get; set; } = new List<IScorer>();

        /// <summary>
        ///     Adds a scorer.
        /// </summary>
        /// <param name="scorer">The scorer.</param>
        public virtual void AddScorer(IScorer scorer)
        {
            this.ScorerList.Add(scorer);
        }

        public abstract float Score();
    }
}
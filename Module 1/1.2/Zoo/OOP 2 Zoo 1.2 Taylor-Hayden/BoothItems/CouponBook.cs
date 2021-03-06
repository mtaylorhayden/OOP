﻿using System;
using System.Collections.Generic;

namespace BoothItems
{
    /// <summary>
    /// The class that represents the toy coupon book.
    /// </summary>
    public class CouponBook : Item
    {
        /// <summary>
        /// The exact time and date something was made.
        /// </summary>
        private DateTime dateMade;

        /// <summary>
        /// The exact time and date something was expired.
        /// </summary>
        private DateTime dateExpired;

        /// <summary>
        /// Initializes a new instance of the CouponBook class.
        /// </summary>
        /// <param name="dateMade"> The time the book was made.</param>
        /// <param name="dateExpired"> The time the book is expired.</param>
        /// <param name="weight"> The weight of the coupon book.</param>
        public CouponBook(DateTime dateMade, DateTime dateExpired, double weight)
            : base(0, weight)
        {
            this.dateMade = dateMade;
            this.dateExpired = dateExpired;
        }

        /// <summary>
        /// Gets the date the coupon book was made.
        /// </summary>
        public DateTime DateMade
        {
            get
            {
                return this.dateMade;
            }
        }

        /// <summary>
        /// Gets the date the coupon book was expired.
        /// </summary>
        public DateTime DateExpired
        {
            get
            {
                return this.dateExpired;
            }
        }
    }
}

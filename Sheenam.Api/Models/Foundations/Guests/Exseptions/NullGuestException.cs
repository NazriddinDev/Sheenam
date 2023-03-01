//================================================
//Copyright (c) Calition of Good-Hearted Engineers
//Free To Use To Find Comfort and Peace
//================================================

using System;
using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exseptions
{
    public class NullGuestException: Xeption
    {
        
        public NullGuestException()
            :base(message: "Guest is null")
        { }
    }
}

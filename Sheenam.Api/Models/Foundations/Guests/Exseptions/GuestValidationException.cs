//================================================
//Copyright (c) Calition of Good-Hearted Engineers
//Free To Use To Find Comfort and Peace
//================================================


using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exseptions
{
    public class GuestValidationException : Xeption
    {
        public GuestValidationException(Xeption innerException)
            :base(message: "Guest validation occured, fix the errors and try again",
                innerException )
        { }
    }
}

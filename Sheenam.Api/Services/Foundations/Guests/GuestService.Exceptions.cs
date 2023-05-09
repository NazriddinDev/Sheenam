//================================================
//Copyright (c) Calition of Good-Hearted Engineers
//Free To Use To Find Comfort and Peace
//================================================

using Sheenam.Api.Models.Foundations.Guests;
using Sheenam.Api.Models.Foundations.Guests.Exseptions;
using System.Threading.Tasks;
using Xeptions;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public partial class GuestService
    {
        private delegate ValueTask<Guest> ReturningGuestFunction();

        private async ValueTask<Guest> TryCatch(ReturningGuestFunction returningGuestFunction)
        {
            try
            {
                return await returningGuestFunction();
            }
            catch (NullGuestException nullGuestException)
            {
                throw CreateAndLogvalidationException(nullGuestException);
            }
        }
        private GuestValidationException CreateAndLogvalidationException(Xeption exception)
        {
                var guestValidationException =
                    new GuestValidationException(exception);

                this.loggingBroker.LogError(guestValidationException);

            return guestValidationException;
        }

    }
}

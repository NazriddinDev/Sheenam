//================================================
//Copyright (c) Calition of Good-Hearted Engineers
//Free To Use To Find Comfort and Peace
//================================================

using Sheenam.Api.Models.Foundations.Guests;
using Sheenam.Api.Models.Foundations.Guests.Exseptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sheenam.API.Tests.Unit.Services.Foundations.Guests
{
    public partial class GuestServiceTests
    {
        [Fact]
        public async Task ShouldThrovValodationExceptionOnAddIfGuestIsNullAndLogItAsync()
        { 
            //given
            Guest nullGuest = null;
            var nullGuestException = new NullGuestException();

            var expectedGuestValidationRxception =
                new GuestValidationException(nullGuestException);

            //when
            ValueTask<Guest> addGuestTask=
                this.guestService.AddGuestAsync(nullGuest);

            //than
            await Assert.ThrowsAsync<GuestValidationException>(() =>
            addGuestTask.AsTask());
        }
    }
}

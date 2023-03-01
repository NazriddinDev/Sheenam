//================================================
//Copyright (c) Calition of Good-Hearted Engineers
//Free To Use To Find Comfort and Peace
//================================================

using FluentAssertions;
using Moq;
using Sheenam.Api.Models.Foundations.Guests;
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
            public async Task ShouldGuestAddAsync()
            {
            //given 
            Guest randomGuest = CreateRandomGuest();
            Guest inputGuest = randomGuest;
            Guest returningGuest = inputGuest;
            Guest expectedGuest= returningGuest; 

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(inputGuest))
                .ReturnsAsync(returningGuest);

            //when
            Guest actualGuest =
                await this.guestService.AddGuestAsync(inputGuest);

            //than 
            actualGuest.Should().BeEquivalentTo(expectedGuest);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertGuestAsync(inputGuest),
                    Times.Once());

            this.storageBrokerMock.VerifyNoOtherCalls();
            }
    }
}

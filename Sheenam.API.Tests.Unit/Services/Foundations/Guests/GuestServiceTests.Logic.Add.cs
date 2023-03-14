﻿//================================================
//Copyright (c) Calition of Good-Hearted Engineers
//Free To Use To Find Comfort and Peace
//================================================

using FluentAssertions;
using Force.DeepCloner;
using Moq;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.API.Tests.Unit.Services.Foundations.Guests
{
    public partial class GuestServiceTests 
    {
            [Fact]
            public async Task ShouldAddGuestAsync()
            {
            //given  
            Guest randomGuest = CreateRandomGuest();
            Guest inputGuest = randomGuest;
            Guest storageBroker = inputGuest;
            Guest expectedGuest = storageBroker.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(inputGuest))
                .ReturnsAsync(storageBroker);

            //when
            Guest actualGuest =
                await this.guestService.AddGuestAsync(inputGuest);

            //than 
            actualGuest.Should().BeEquivalentTo(expectedGuest);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertGuestAsync(inputGuest),
                    Times.Once());

            this.storageBrokerMock.VerifyNoOtherCalls();
            this.loggingBrokerMock.VerifyNoOtherCalls();
            }
    }
}

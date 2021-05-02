using System;
using System.Collections.Generic;
using Xunit;

namespace ATMWithdrawal.UnitTests
{
    public class TestWithdrawal
    {

        [Fact]
        public void WithdrawalTest()
        {
            //AAA pattern

            //Arrange 
            List<int> bills = new()
            {
                1000,
                1000,
                500,
                500,
                500,
                100,
                100,
                100,
                100,
                100
            };

            WithdrawalATM ATM = new(bills);

            //Act
            var act1 = ATM.Withdraw(1500);
            var act2 = ATM.Withdraw(700);
            var act3 = ATM.Withdraw(400);
            var act4 = ATM.Withdraw(1100);
            var act5 = ATM.Withdraw(1000);
            var act6 = ATM.Withdraw(700);
            var act7 = ATM.Withdraw(300);


            //Assert
            Assert.Equal(1500, act1);
            Assert.Equal(700, act2);
            Assert.Equal(-1, act3);
            Assert.Equal(1100, act4);
            Assert.Equal(-1, act5);
            Assert.Equal(700, act6);
            Assert.Equal(-1, act7);
        }
    }
}

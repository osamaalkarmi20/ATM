using ATM;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void withDrawBiggerNumberThanBalance()
        {
            decimal a = 2000;
            decimal result = Program.Withdraw(a);
            Assert.Equal(0, result);
        }
        [Fact]
        public void withDrawSmallerNumberThanBalance()
        {
            decimal a = 200;
            decimal result = Program.Withdraw(a);
            Assert.Equal(1, result);
        }
        [Fact]
        public void depositPositiveNumber()
        {
            decimal a = 1200;
            decimal result = Program.Deposit(a);
            Assert.Equal(1, result);
        }
        [Fact]
        public void depositNigativeNumber()
        {
            decimal a = -120;
            decimal result = Program.Deposit(a);
            Assert.Equal(0, result);
        }
    }
}
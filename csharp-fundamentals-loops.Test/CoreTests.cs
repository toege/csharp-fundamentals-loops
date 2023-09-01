using csharp_fundamentals_loops.Main;
using NUnit.Framework;

namespace csharp_fundamentals_loops.Test
{
    public class CoreTests
    {        
        
         [Test]
        public void numsZeroToThreeShouldContainNumsZeroToThree()
        {
            Core exercise = new Core();
            int[] shouldBe = { 0, 1, 2, 3 };
            try
            {
                exercise.stepOne();                                
                Assert.IsTrue(Enumerable.SequenceEqual(exercise.numsZeroToThree, shouldBe));
            }
            catch
            {
                Assert.Fail();
            }

            //this.exercise.stepOne();
            //Assertions.assertArrayEquals(shouldBe, this.exercise.numsZeroToThree);
        }

        [Test]
        public void numsFiveToTenShouldContainNumsFiveToTen()
        {
            Core exercise = new Core();
            int[] shouldBe = { 5, 6, 7, 8, 9, 10 };
            try
            {
                exercise.stepTwo();
                Assert.IsTrue(Enumerable.SequenceEqual(exercise.numsFiveToTen, shouldBe));
            }
            catch
            {
                Assert.Fail();
            }
                        
        }

        [Test]
        public void countdownShouldBeThreeToZero()
        {
            Core exercise = new Core();
            int[] shouldBe = { 3, 2, 1, 0 };
            try
            {
                exercise.stepThree();
                Assert.IsTrue(Enumerable.SequenceEqual(exercise.countdown, shouldBe));
            }
            catch
            {
                Assert.Fail();
            }          
        }

        [Test]
        public void isMyNumberAFavourite()
        {
            Core exercise = new Core();
            Assert.AreEqual(true, exercise.stepFour(1));
            Assert.AreEqual(true, exercise.stepFour(2));
            Assert.AreEqual(true, exercise.stepFour(4));
            Assert.AreEqual(true, exercise.stepFour(5));
            Assert.AreEqual(true, exercise.stepFour(7));
            Assert.AreEqual(true, exercise.stepFour(8));
            Assert.AreEqual(true, exercise.stepFour(10));

            Assert.AreEqual(false, exercise.stepFour(6));
            Assert.AreEqual(false, exercise.stepFour(3));
            Assert.AreEqual(false, exercise.stepFour(11));
        }

        [Test]
        public void isAHobby()
        {
            Core exercise = new Core();
            Assert.AreEqual(true, exercise.stepFive("Fishing"));
            Assert.AreEqual(true, exercise.stepFive("Language learning"));
            Assert.AreEqual(true, exercise.stepFive("Skydiving"));
            Assert.AreEqual(true, exercise.stepFive("Procrastinating"));

            Assert.AreEqual(false, exercise.stepFive("Singing"));
            Assert.AreEqual(false, exercise.stepFive("Dancing"));
            Assert.AreEqual(false, exercise.stepFive("Horse riding"));
        }
    }
}

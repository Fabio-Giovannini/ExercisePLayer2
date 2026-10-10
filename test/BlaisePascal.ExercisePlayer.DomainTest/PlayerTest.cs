using BlaisePascal.ExercisePlayer.Domain;   
namespace BlaisePascal.ExercisePlayer.DomainTest
{
    public class PlayerTest
    {

        //Test to verify the correct functioning of the constructor
        [Fact]
        public void Player_ShouldStartWithName()
        {
            Player player = new Player("Fabio");
            Assert.Equal("Fabio", player.Name);
        }

        [Fact]
        public void Player_ShouldStartZeroExerience()
        {
            Player player = new Player("Fabio");
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void Player_ShouldStartAtLEvelOne()
        {
            Player player = new Player("Fabio");

            Assert.Equal(1, player.Level);

        }

        [Fact]
        public void Player_MaxHealthShouldBe100()
        {
            Player player = new Player("Fabio");
            Assert.Equal(100, player.MaxHealth);
        }

        [Fact]
        public void Player_ShouldStartAtMaxHealth()
        {
            Player player = new Player("Fabio");
            Assert.Equal(player.MaxHealth, player.Health);
        }

        [Fact]
        public void Player_ShouldStartAlive()
        {
            Player player = new Player("Fabio");
            Assert.Equal(true, player.IsAlive);
        }

        [Fact]
        public void Player_ShouldStartWithZeroGold()
        {
            Player player = new Player("Fabio");
            Assert.Equal(0, player.Gold);
        }

        //Test to verify the correct functioning of the AddExperience function.
        [Fact]
        public void AddExperience_ShouldIncreaseExperience()
        {
            Player player = new Player("Fabio");
            player.AddExperience(50);
            Assert.Equal(50, player.Experience);
        }
        [Fact]
        public void AddExperience_AmountMustNotBeNegative()
        {
            Player player = new Player("Fabio");
            Assert.Throws<ArgumentException>(() => player.AddExperience(-10));
        }

        //Test to verify the correct functioning of the ResetExperience function
        [Fact]
        public void ResetExperience_ShouldResetExperienceToZero()
        {
            Player player = new Player("Fabio");
            player.AddExperience(50);
            player.ResetExperience();
            Assert.Equal(0, player.Experience);
        }

        //Test to verify the correct functioning of the TakeDamage function.
        [Fact]
        public void TakeDamage_ShouldDecreaseHealth()
        {
            Player player = new Player("Fabio");
            player.TakeDamage(30);
            Assert.Equal(70, player.Health);
        }

        [Fact]
        public void TakeDamage_AmountMustNotBeNegative()
        {
            Player player = new Player("Fabio");
            Assert.Throws<ArgumentException>(() => player.TakeDamage(-10));
        }


    }
}

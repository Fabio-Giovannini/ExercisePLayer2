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
        public void Player_ShouldStartAtLevelOne()
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

        [Fact]
        public void AddExperience_ShouldLevelUpWhenExperienceReaches100()
        {
            Player player = new Player("Fabio");
            player.AddExperience(230);
            Assert.Equal(3, player.Level);
        }

        [Fact]
        public void AddExperience_ShoulRemove100ExperienceWhenLevelUp()
        {
            Player player = new Player("Fabio");
            player.AddExperience(150);
            Assert.Equal(50, player.Experience);
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

        [Fact]
        public void TakeDamage_ShouldSetISALiveToFalseIfHealthBecameZero()
        {
            Player player = new Player("Fabio");
            player.TakeDamage(100);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void TakeDamage_ShouldHealthBeZeroEvenIfTheDamageIsGreaterThanActuallyHealth()
        {
            Player player = new Player("Fabio");
            player.TakeDamage(120);
            Assert.Equal(0, player.Health);
        }


        //Test to verify the correct operation of the Heal function.
        [Fact]
        public void Heal_AmountMustNotBeNegative()
        {
            Player player = new Player("Fabio");
            Assert.Throws<ArgumentException>(() => player.Heal(-10));
        }

        [Fact]
        public void Heal_ShouldIncreaseHealth()
        {
            Player player = new Player("Fabio");
            player.TakeDamage(30);
            player.Heal(20);
            Assert.Equal(90, player.Health);
        }

        [Fact]
        public void Heal_ShouldNotHealMoreThanMaxHealth()
        {
            Player player = new Player("Fabio");
            player.TakeDamage(30);
            player.Heal(60);
            Assert.Equal(100, player.Health);

        }


        //Test to verify the correct functioning of the AddGold function.
        [Fact]
        public void AddGold_AmountMustNotBeNegative()
        {
            Player player = new Player("Fabio");
            Assert.Throws<ArgumentException>(() => player.AddGold(-10));
        }

        [Fact]
        public void AddGold_ShouldIncreaseGold()
        {
            Player player = new Player("Fabio");
            player.AddGold(50);
            Assert.Equal(50, player.Gold);
        }

        //Test to verify the correct functioning of the ResetHealth function.
        [Fact]
        public void ResetHealth_ShouldResetHealthToMaxHealth()
        {
            Player player = new Player("Fabio");
            player.TakeDamage(30);
            player.ResetHealth();
            Assert.Equal(player.MaxHealth, player.Health);
        }

    }
}

using BlaisePascal.ExercisePlayer.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.ExercisePlayer.DomainTest
{
    public class EnemyTest
    {

        //Test to verify the correct functioning of the Health property set
        [Fact]
        public void Enemy_HealthLessThanZero()
        {
            Enemy enemy = new Enemy("Zombie", -15, 42);

            Assert.Equal(0, enemy.Health);
        }

        [Fact]
        public void Enemy_HealthMoreThanAHundred()
        {
            Enemy enemy = new Enemy("Zombie", 101, 42);

            Assert.Equal(100, enemy.Health);
        }

        [Fact]
        public void Enemy_HealthIsCorrect()
        {
            Enemy enemy = new Enemy("Zombie", 64, 42);

            Assert.Equal(64, enemy.Health);
        }

        //Test to verify the correct functioning of the IsAlive function
        [Fact]
        public void IsAlive_EnemyIsAlive()
        {
            Enemy enemy = new Enemy("Zombie", 64, 42);

            Assert.True(enemy.IsAlive());
        }

        [Fact]
        public void IsAlive_EnemyIsDead()
        {
            Enemy enemy = new Enemy("Zombie", 64, 42);
            enemy.TakeDamage(80);

            Assert.Equal(false, enemy.IsAlive());
        }

        //Test to verify the correct functioning of the TakeDamage function
        [Fact]
        public void TakeDamage_HealthDecreases()
        {
            Enemy enemy = new Enemy("Zombie", 64, 42);
            enemy.TakeDamage(20);

            Assert.Equal(44, enemy.Health);
        }

        //Test to verify the correct functioning of the constructor
        [Fact]
        public void Enemy_ShouldStartWithName()
        {
            Enemy enemy = new Enemy("Zombie", 64, 42);
            Assert.Equal("Zombie", enemy.Name);
        }
        [Fact]
        public void Enemy_ShouldStartHealth()
        {
            Enemy enemy = new Enemy("Zombie", 64, 42);
            Assert.Equal(64, enemy.Health);
        }
        [Fact]
        public void Enemy_ShouldStartDamage()
        {
            Enemy enemy = new Enemy("Zombie", 64, 42);
            Assert.Equal(42, enemy.Damage);
        }

    }
}

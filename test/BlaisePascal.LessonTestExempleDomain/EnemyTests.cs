using BlaisePascal.LessonExempleDomain;

namespace BlaisePascal.LessonTestExempleDomain
{
    public class EnemyTests
    {
        [Fact]
        public void Player_PlayerShouldStartAtLevelOne()
        {
            Player player = new Player("Luigi");

            Assert.Equal(1, player.Level);
        }
    }
}

using ClassLibrary_Task5;

namespace ConsoleApp_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterDirector director = new CharacterDirector();

            var hero = director.CreateHero(new HeroBuilder());
            var enemy = director.CreateEnemy(new EnemyBuilder());

            hero.Show();
            enemy.Show();

        }
    }
}

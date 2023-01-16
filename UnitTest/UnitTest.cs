using Library;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPlayers()
        {
            // TODO U.1
            Team team = new Team("Squadra 1"); //creazione situazione di partenza

            team.AddPlayer(new Player("Cognome 1", "Nome 1", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 2", "Nome 2", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 3", "Nome 3", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 4", "Nome 4", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 5", "Nome 5", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 6", "Nome 6", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 7", "Nome 7", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 8", "Nome 8", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 9", "Nome 9", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 10", "Nome 10", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 11", "Nome 11", Player.ERole.Rosa));
            team.AddPlayer(new Player("Cognome 12", "Nome 12", Player.ERole.Riserva));
            team.AddPlayer(new Player("Cognome 13", "Nome 13", Player.ERole.Riserva));
            team.AddPlayer(new Player("Cognome 14", "Nome 14", Player.ERole.Riserva));
            team.AddPlayer(new Player("Cognome 15", "Nome 15", Player.ERole.Riserva));
            Assert.IsTrue(team.AddPlayer("Cognome 15", "Nome 15", Player.ERole.Riserva) == false); 
        }

        [Test]
        public void AddCaptain()
        {
            // TODO U.2
        }
    }
}
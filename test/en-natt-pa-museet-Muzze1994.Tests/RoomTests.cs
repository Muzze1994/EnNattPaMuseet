using Xunit;

namespace en_natt_pa_museet_Muzze1994.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddArtworkToSpecificRoom()
        {
            // arrange
            Room room1 = new Room("Room1", 1);
            Room room2 = new Room("Room2", 2);
            Room room3 = new Room("Room3", 3);
            var ArtworkRoom1 = new Artwork();
            ArtworkRoom1.Title = "Mona lisa";
            var ArtworkRoom2 = new Artwork();
            ArtworkRoom2.Title = "Mona lisa";

            // act
            room1.AddArtworkToList(ArtworkRoom1);
            room1.AddArtworkToList(ArtworkRoom2);

            // arrange
            Assert.Equal(2, room1.GetNumberOfArtworksInRoom());

        }
        [Fact]
        public void SeeIfRoomConnects()
        {
            // arrange
            Room room1 = new Room("Room1", 1);
            Room room2 = new Room("Room2", 2);
            Room room3 = new Room("Room3", 3);

            // act
            room1.ConnectToRoom(room2);
            room2.ConnectToRoom(room3);
            room1.ConnectToRoom(room2);

            // arrange
            Assert.Equal(1, room1.GetNumbersOfConnectedRooms());
            Assert.Equal(2, room2.GetNumbersOfConnectedRooms());

        }
        [Fact]
        public void TestThatYouCantTeleport()
        {
            // arrange
            Room room1 = new Room("Room1", 1);
            Room room2 = new Room("Room2", 2);
            Room room3 = new Room("Room3", 3);

            // act
            room1.ConnectToRoom(room2);
            room2.ConnectToRoom(room3);
            room1.ConnectToRoom(room2);

            // arrange
            Assert.True(room1.CanWalkToRoom(room2));
            Assert.False(room1.CanWalkToRoom(room3));

        }
    }
}

using System;

namespace en_natt_pa_museet_Muzze1994
{
    class Program
    {
        static void Main(string[] args)
        {
            var Entrance = new Room("Entrance", 1);
            var Corridor = new Room("Corridor", 2);
            var GreenRoom = new Room("Green Room", 3);
            var BlueRoom = new Room("Blue Room", 4);
            var RedRoom = new Room("Red Room", 5);
            var PurpleRoom = new Room("Purple Room", 6);
            var BlackRoom = new Room("Black Room", 7);
            var WhiteRoom = new Room("White Room", 8);

            Entrance.ConnectToRoom(Corridor);
            Corridor.ConnectToRoom(GreenRoom);
            GreenRoom.ConnectToRoom(BlueRoom);
            GreenRoom.ConnectToRoom(RedRoom);
            PurpleRoom.ConnectToRoom(BlueRoom);
            PurpleRoom.ConnectToRoom(RedRoom);
            BlackRoom.ConnectToRoom(BlueRoom);
            WhiteRoom.ConnectToRoom(BlueRoom);

            var artworkGreenRoom_1 = new Artwork();
            artworkGreenRoom_1.Title = "Mona lisa";
            artworkGreenRoom_1.Description = "Tavla";
            artworkGreenRoom_1.Author = "Leonardo Da Vinci";
            var artworkGreenRoom_2 = new Artwork();
            artworkGreenRoom_2.Title = " Studio Idyll";
            artworkGreenRoom_2.Description = "Skulptur";
            artworkGreenRoom_2.Author = "Anders Zorn";
            var artworkRedRoom_1 = new Artwork();
            artworkRedRoom_1.Title = "Borawski";
            artworkRedRoom_1.Description = "Klocka";
            artworkRedRoom_1.Author = "Gunnar Ivartsson";
            var artworkRedRoom_2 = new Artwork();
            artworkRedRoom_2.Title = "Eiffeltornet";
            artworkRedRoom_2.Description = "Byggnad";
            artworkRedRoom_2.Author = "Gustave Eiffel";
            var artworkRedRoom_3 = new Artwork();
            artworkRedRoom_3.Title = "Frihetsgudinnan";
            artworkRedRoom_3.Description = "Enorm staty";
            artworkRedRoom_3.Author = "Auguste Bartholdi";

            GreenRoom.AddArtworkToList(artworkGreenRoom_1);
            GreenRoom.AddArtworkToList(artworkGreenRoom_2);
            RedRoom.AddArtworkToList(artworkRedRoom_1);
            RedRoom.AddArtworkToList(artworkRedRoom_2);
            RedRoom.AddArtworkToList(artworkRedRoom_3);

            Room currentRoom = Entrance;

            Console.WriteLine($"Du är {currentRoom.roomName}");
            Console.WriteLine($"Du kan gå till {currentRoom.PrintOutConnectedRoomNames()}");

            while (true)
            {
                int input;
                Int32.TryParse(Console.ReadLine(), out input);
                switch (input)
                {

                    case 1:
                        Console.Clear();
                        if (currentRoom.CanWalkToRoom(Entrance))
                        {
                            currentRoom = Entrance;
                        }
                        else
                        {
                            throw new Exception("Det gick inte att gå till" + Entrance.roomName);
                        }
                        Console.WriteLine($"Du är i \n {currentRoom.roomName}");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        break;

                    case 2:
                        Console.Clear();
                        if (currentRoom.CanWalkToRoom(Corridor))
                        {
                            currentRoom = Corridor;
                        }
                        else
                        {
                            throw new Exception("Det gick inte att gå till" + Corridor.roomName);
                        }
                        Console.WriteLine($"Du är i {currentRoom.roomName}");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        break;

                    case 3:
                        Console.Clear();
                        if (currentRoom.CanWalkToRoom(GreenRoom))
                        {
                            currentRoom = GreenRoom;
                        }
                        else
                        {
                            throw new Exception("Det gick inte att gå till" + GreenRoom.roomName);
                        }
                        Console.WriteLine($"Du är i {currentRoom.roomName} \n");
                        Console.WriteLine($"Dessa konstverk finns här \n {currentRoom.PrintOutArtworkForThisRoom()}");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        break;

                    case 4:
                    Console.Clear();
                        if (currentRoom.CanWalkToRoom(BlueRoom))
                        {
                            currentRoom = BlueRoom;
                        }
                        else
                        {
                            throw new Exception("Det gick inte att gå till" + BlueRoom.roomName);
                        }
                        Console.WriteLine($"Du är i {currentRoom.roomName}");
                        Console.WriteLine($"Dessa konstverk finns här \n {currentRoom.PrintOutArtworkForThisRoom()}");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        break;

                    case 5:
                    Console.Clear();
                        if (currentRoom.CanWalkToRoom(RedRoom))
                        {
                            currentRoom = RedRoom;
                        }
                        else
                        {
                            throw new Exception("Det gick inte att gå till" + RedRoom.roomName);
                        }
                        Console.WriteLine($"Du är i {currentRoom.roomName}");
                        Console.WriteLine($"Dessa konstverk finns här \n {currentRoom.PrintOutArtworkForThisRoom()}");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        break;

                    case 6:
                    Console.Clear();
                        if (currentRoom.CanWalkToRoom(PurpleRoom))
                        {
                            currentRoom = PurpleRoom;
                        }
                        else
                        {
                            throw new Exception("Det gick inte att gå till" + PurpleRoom.roomName);
                        }
                        Console.WriteLine($"Du är i {currentRoom.roomName}");
                        Console.WriteLine($"Dessa konstverk finns här \n {currentRoom.PrintOutArtworkForThisRoom()}");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        break;

                    case 7:
                    Console.Clear();
                        if (currentRoom.CanWalkToRoom(BlackRoom))
                        {
                            currentRoom = BlackRoom;
                        }
                        else
                        {
                            throw new Exception("Det gick inte att gå till" + BlackRoom.roomName);
                        }
                        Console.WriteLine($"Du är i {currentRoom.roomName}");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        break;
                    case 8:
                    Console.Clear();
                        if (currentRoom.CanWalkToRoom(WhiteRoom))
                        {
                            currentRoom = WhiteRoom;
                        }
                        else
                        {
                            throw new Exception("Det gick inte att gå till" + WhiteRoom.roomName);
                        }
                        Console.WriteLine($"Du är i {currentRoom.roomName}");
                        Console.WriteLine($"Dessa konstverk finns här \n {currentRoom.PrintOutArtworkForThisRoom()}");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        break;
                }
            }
        }
    }
}

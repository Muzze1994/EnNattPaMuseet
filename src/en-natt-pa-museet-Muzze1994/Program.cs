using System;

namespace en_natt_pa_museet_Muzze1994
{
    class Program
    {
        static void Main(string[] args)
        {
            //Map over the museeum
            string map = "\t(7) BlackR        \n " +
                 "(8) WR (4) BlueR  (6) PR \n" +
                        " \t(3) GR     (5) RR \n" +
                        " \t(2) C   \n" +
                        " \t(1) E   \n";

            //All room objects that is in the museeum
            var Entrance = new Room("Entrance", 1);
            var Corridor = new Room("Corridor", 2);
            var GreenRoom = new Room("Green Room", 3);
            var BlueRoom = new Room("Blue Room", 4);
            var RedRoom = new Room("Red Room", 5);
            var PurpleRoom = new Room("Purple Room", 6);
            var BlackRoom = new Room("Black Room", 7);
            var WhiteRoom = new Room("White Room", 8);

            //Connects all the rooms to the correct room
            Entrance.ConnectToRoom(Corridor);
            Corridor.ConnectToRoom(GreenRoom);
            GreenRoom.ConnectToRoom(BlueRoom);
            GreenRoom.ConnectToRoom(RedRoom);
            PurpleRoom.ConnectToRoom(BlueRoom);
            PurpleRoom.ConnectToRoom(RedRoom);
            BlackRoom.ConnectToRoom(BlueRoom);
            WhiteRoom.ConnectToRoom(BlueRoom);

            //Creates all the objects for the art in the rooms with a title, description and author
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
            var artworkBlueRoom_1 = new Artwork();
            artworkBlueRoom_1.Title = "Pieta";
            artworkBlueRoom_1.Description = "Tavla";
            artworkBlueRoom_1.Author = "Michelangelo";
            var artworkPurpleRoom_1 = new Artwork();
            artworkPurpleRoom_1.Title = "The broken";
            artworkPurpleRoom_1.Description = "Tavla";
            artworkPurpleRoom_1.Author = "Van googoh";
            var artworkPurpleRoom_2 = new Artwork();
            artworkPurpleRoom_2.Title = "Skriet";
            artworkPurpleRoom_2.Description = "Tavla";
            artworkPurpleRoom_2.Author = "Edvard Munch";
            var artworkPurpleRoom_3 = new Artwork();
            artworkPurpleRoom_3.Title = "Guernica";
            artworkPurpleRoom_3.Description = "Tavla";
            artworkPurpleRoom_3.Author = "Picasso";
            var artworkPurpleRoom_4 = new Artwork();
            artworkPurpleRoom_4.Title = "The weeping woman";
            artworkPurpleRoom_4.Description = "Tavla";
            artworkPurpleRoom_4.Author = "Picasso";
            var artworkWhiteRoom_1 = new Artwork();
            artworkWhiteRoom_1.Title = "Lutande tornet i Pisa";
            artworkWhiteRoom_1.Description = "Torn";
            artworkWhiteRoom_1.Author = "Guglielmo";

            //Adds all the art to the correct room
            GreenRoom.AddArtworkToList(artworkGreenRoom_1);
            GreenRoom.AddArtworkToList(artworkGreenRoom_2);
            RedRoom.AddArtworkToList(artworkRedRoom_1);
            RedRoom.AddArtworkToList(artworkRedRoom_2);
            RedRoom.AddArtworkToList(artworkRedRoom_3);
            BlueRoom.AddArtworkToList(artworkBlueRoom_1);
            PurpleRoom.AddArtworkToList(artworkPurpleRoom_1);
            PurpleRoom.AddArtworkToList(artworkPurpleRoom_2);
            PurpleRoom.AddArtworkToList(artworkPurpleRoom_3);
            PurpleRoom.AddArtworkToList(artworkPurpleRoom_4);
            WhiteRoom.AddArtworkToList(artworkWhiteRoom_1);

            //Creates a pointer for the current room the user is in, starts at the entrance
            Room currentRoom = Entrance;

            //A small text of how the program works
            Console.WriteLine("Välkommen till mitt museeum!");
            Console.WriteLine("Här finns många spännande rum och konstverk.");
            Console.WriteLine("Du rör dig genom rummen genom att skriva in siffran som står bredvid rummen. Du kan enbart gå in i rum som ligger bredvid varandra.");
            Console.WriteLine($"Här får du en karta på hur museet ser ut \n{map}");

            Console.WriteLine($"Du börjar i {currentRoom.roomName}");
            Console.WriteLine($"Och du kan gå till dessa rum: {currentRoom.PrintOutConnectedRoomNames()}");

            //Makes the program running until you try to input the wrong room or simply close the program
            while (true)
            {
                int input;
                Int32.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    //Depending on what number you press between 1-8 you'll enter a different room, 1 for entrance etc
                    //If you try to enter a room that is not connected to that room you're in you'll get thrown an exception telling you that you cant enter that room
                    case 1:
                        Console.Clear();
                        if (currentRoom.CanWalkToRoom(Entrance))
                        {
                            //Changes current room to the room you want to enter, for this instance the entrance
                            currentRoom = Entrance;
                        }
                        else
                        {
                            throw new Exception("Det gick inte att gå till" + Entrance.roomName);
                        }

                        Console.WriteLine($"Du är i {currentRoom.roomName}");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        Console.WriteLine(map);
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
                        Console.WriteLine($"Du är i {currentRoom.roomName} \n");
                        Console.WriteLine($"Du kan gå till \n {currentRoom.PrintOutConnectedRoomNames()}");
                        Console.WriteLine(map);
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
                        Console.WriteLine(map);
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
                        Console.WriteLine(map);
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
                        Console.WriteLine(map);
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
                        Console.WriteLine(map);
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
                        Console.WriteLine(map);
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
                        Console.WriteLine(map);
                        break;
                }
            }
        }
    }
}

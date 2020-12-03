
using System.Collections.Generic;

namespace en_natt_pa_museet_Muzze1994
{
    class Room : Artwork
    {
        public string roomName;
        public int roomNumber;
        public List<Artwork> artworks = new List<Artwork>();
        public List<Room> ConnectedRooms = new List<Room>();

        public Room(string roomName, int roomNumber)
        {
            this.roomName = roomName;
            this.roomNumber = roomNumber;
            this.ConnectedRooms = new List<Room>();
        }

        public void ConnectToRoom(Room RoomToConnectTo)
        {
            if (this.ConnectedRooms.Contains(RoomToConnectTo) == false)
            {
                this.ConnectedRooms.Add(RoomToConnectTo);
                RoomToConnectTo.ConnectToRoom(this);
            }
        }
        public int chooseRoom()
        {
            int nr = 0;
            for (int i = 0; i < ConnectedRooms.Count; i++)
            {
                nr += ConnectedRooms[i].roomNumber;
            }
            return nr;
        }

        public List<Room> GetRoomsThatCanBeReached()
        {
            return ConnectedRooms;
        }
        public bool CanWalkToRoom(Room to)
        {
            List<Room> roomsThatCanBeReached = this.GetRoomsThatCanBeReached();
            return roomsThatCanBeReached.Contains(to);
        }
        public void AddArtworkToList(Artwork ArtworkToList)
        {
            this.artworks.Add(ArtworkToList);
        }

        public string PrintOutArtworkForThisRoom()
        {
            string art = "";
            for (int i = 0; i < artworks.Count; i++)
            {
                art += "\n";
                art += artworks[i].Title;
                art += "\n";
                art += artworks[i].Description;
                art += "\n";
                art += "Skapad av " + artworks[i].Author;
                art += "\n";
            }
            return art;
        }
        public string PrintOutConnectedRoomNames()
        {
            string roomTitle = "";

            for (int i = 0; i < ConnectedRooms.Count; i++)
            {
                roomTitle += ConnectedRooms[i].roomNumber;
                roomTitle += " ";
                roomTitle += ConnectedRooms[i].roomName;
                roomTitle += "\n";
            }
            return roomTitle;
        }
    }
}
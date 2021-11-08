
using System.Collections.Generic;

namespace en_natt_pa_museet_Muzze1994
{
    public class Room : Artwork
    {
        public string roomName;
        public int roomNumber;
        private List<Artwork> artworks = new List<Artwork>();
        private List<Room> ConnectedRooms = new List<Room>();

        public Room(string roomName, int roomNumber)
        {
            this.roomName = roomName;
            this.roomNumber = roomNumber;
            this.ConnectedRooms = new List<Room>();
        }

        //Adds objects to the ConnectedRooms-list 
        //If none of the objects are added then Object 1 gets added to the list of Object 2 and Object 2 gets added to list of Object 1
        public void ConnectToRoom(Room RoomToConnectTo)
        {
            if (this.ConnectedRooms.Contains(RoomToConnectTo) == false)
            {
                this.ConnectedRooms.Add(RoomToConnectTo);
                RoomToConnectTo.ConnectToRoom(this);
            }
        }
        public List<Room> GetRoomsThatCanBeReached()
        {
            return ConnectedRooms;
        }

        //Fetches the list of the room that you want to walk to and check if the room exsists
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

        public int GetNumbersOfConnectedRooms()
        {
            return ConnectedRooms.Count;
        }
        public int GetNumberOfArtworksInRoom()
        {
            return artworks.Count;
        }
    }
}
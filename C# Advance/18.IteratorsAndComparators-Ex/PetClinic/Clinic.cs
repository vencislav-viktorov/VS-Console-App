namespace PetClinic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Clinic
    {
        private Dictionary<int, Pet> roomPet;
        private int roomsCount;

        public Clinic(string name, int roomsCount)
        {
            this.Name = name;
            this.RoomsCount = roomsCount;
            roomPet = new Dictionary<int, Pet>();
        }

        public string Name { get; set; }

        public int RoomsCount
        {
            get
            {
                return this.roomsCount;
            }

            set
            {
                if (value % 2 == 0)
                {
                    throw new InvalidOperationException("Invalid Operation!");
                }

                this.roomsCount = value;
            }
        }

        public bool AddPet(Pet pet)
        {
            var middle = RoomsCount / 2 + 1;

            for (int i = 1; i < middle; i++)
            {
                if (roomPet.ContainsKey(middle) == false)
                {
                    roomPet.Add(middle, pet);
                    return true;
                }

                if (roomPet.ContainsKey(middle - i) == false)
                {
                    roomPet.Add(middle - i, pet);
                    return true;
                }

                if (roomPet.ContainsKey(middle + i) == false)
                {
                    roomPet.Add(middle + i, pet);
                    return true;
                }
            }

            return false;
        }

        public bool Release()
        {
            var middle = RoomsCount / 2 + 1;

            for (int i = middle; i <= RoomsCount; i++)
            {
                if (this.roomPet.ContainsKey(i))
                {
                    this.roomPet.Remove(i);
                    return true;
                }
            }

            for (int i = 1; i < middle; i++)
            {
                if(this.roomPet.ContainsKey(i))
                {
                    this.roomPet.Remove(i);
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            for (int i = 1; i <= RoomsCount; i++)
            {
                if (this.roomPet.ContainsKey(i) == false)
                {
                    return true;
                }
            }

            return false;
        }

        public string GetPet(int room)
        {
            if (this.roomPet.ContainsKey(room))
            {
                return roomPet[room].ToString();
            }

            else
            {
                return "Room empty";
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            for (int i = 1; i <= roomsCount; i++)
            {
                if (this.roomPet.ContainsKey(i))
                {
                    stringBuilder.AppendLine(roomPet[i].ToString());
                }

                else
                {
                    stringBuilder.AppendLine("Room empty");

                }
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
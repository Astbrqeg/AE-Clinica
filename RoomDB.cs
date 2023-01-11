using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace AE_Clinica
{
    class RoomDB
    {
        public static Room select(string roomNumber)
        {
            Room R = null;
            string sql = "select RoomNumber, FloorOfTheRoom, SpaceOfTheRoom " +
               "from Room " +
               "where (RoomNumber= '" + roomNumber + "')";
            Connector c = new Connector();
            OleDbDataReader result = c.RunSelect(sql);
            if (result.Read())
            {
                DataSet ds = c.returnOledbDataSet(sql);
                string floorOfTheRoom, spaceOfTheRoom;
                floorOfTheRoom = ds.Tables[0].Rows[0][1].ToString();
                spaceOfTheRoom = ds.Tables[0].Rows[0][2].ToString();
                R = new Room(roomNumber, floorOfTheRoom, spaceOfTheRoom);
            }
            return R;
        }
        public static List<Room> SelectAllRoom()
        {
            List<Room> lst = new List<Room>();
            string sql = "select [Room Number], [Floor of the room], [Space of the room] " +
               "from Room ";
            Connector c = new Connector();
            OleDbDataReader result = c.RunSelect(sql);
            if (result.Read())
            {
                DataSet ds = c.returnOledbDataSet(sql);
                string RoomNumber, Flooroftheroom, Spaceoftheroom;


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    RoomNumber = ds.Tables[0].Rows[i][0].ToString();
                    Flooroftheroom = ds.Tables[0].Rows[i][1].ToString();
                    Spaceoftheroom = ds.Tables[0].Rows[i][2].ToString();
                    Room R = new Room(RoomNumber, Flooroftheroom, Spaceoftheroom);
                    lst.Add(R);
                }
            }
            return lst;
        }
    }
}

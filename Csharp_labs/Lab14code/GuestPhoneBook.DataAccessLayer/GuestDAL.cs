using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using GuestPhoneBook.Entities;
using GuestPhoneBook.Exceptions;

namespace GuestPhoneBook.DataAccessLayer
{
    public class GuestDAL
    {
        public static List<Guest> guestList = new List<Guest>();

        public bool AddGuest(Guest newGuest)
        {
            bool guestAdded = false;
            try
            {
                guestList.Add(newGuest);
                guestAdded = true;
            }
            catch (SystemException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return guestAdded;

        }

        public List<Guest> ListAllGuests()
        {
            return guestList;
        }

        public Guest SearchGuestByID(int searchGuestID)
        {
            Guest searchGuest = null;
            try
            {
                searchGuest = guestList.Find(guest => guest.GuestID == searchGuestID);
            }
            catch (SystemException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return searchGuest;
        }

        public List<Guest> SearchGuestByRelationShip(Relation relationShip)
        {
            List<Guest> List = new List<Guest>();

            foreach (var x in guestList)
            {
                Guest SearchGuest = null;
                try
                {
                    SearchGuest = guestList.Find(guest => guest.RelationShip == relationShip);
                    List.Add(SearchGuest);
                }
                catch (SystemException ex)
                {
                    throw new GuestPhoneBookException(ex.Message);
                }


            }
            return List;
        }
        public bool UpdateGuest(Guest updateGuest)
        {
            bool guestUpdated = false;
            try
            {
                for (int i = 0; i < guestList.Count; i++)
                {
                    if (guestList[i].GuestID == updateGuest.GuestID)
                    {
                        updateGuest.GuestName = guestList[i].GuestName;
                        updateGuest.GuestContactNumber = guestList[i].GuestContactNumber;
                        guestUpdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return guestUpdated;

        }

        public bool DeleteGuest(int deleteGuestID)
        {
            bool guestDeleted = false;
            try
            {
                Guest deleteGuest = guestList.Find(guest => guest.GuestID == deleteGuestID);

                if (deleteGuest != null)
                {
                    guestList.Remove(deleteGuest);
                    guestDeleted = true;
                }
            }
            catch (DbException ex)
            {
                throw new GuestPhoneBookException(ex.Message);
            }
            return guestDeleted;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestPhoneBook.Entities
{

    public enum Relation
    {
        FATHER,
        MOTHER,
        BROTHER,
        SISTER,
        COUSIN,
        UNCLE,
        AUNT,
        SON,
        DAUGHTER,
        FRIEND

    }

    public class Guest
    {
        private int guestID;

        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        private string guestName;

        public string GuestName
        {
            get { return guestName; }
            set { guestName = value; }
        }
        private Relation relationShip;

        public Relation RelationShip { get => relationShip; set => relationShip = value; }

        private string guestContactNumber;

        public string GuestContactNumber
        {
            get { return guestContactNumber; }
            set { guestContactNumber = value; }
        }



        public Guest()
        {
            guestID = 0;
            guestName = string.Empty;
            guestContactNumber = string.Empty;
        }
    }
}
